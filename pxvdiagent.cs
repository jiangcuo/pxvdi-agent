using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Windows.Forms;
using System.Net;
using Microsoft.Win32;
using System.Net.NetworkInformation;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.IO;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace pxvdi_agent
{
    public class Vars
    {
        public static Vars _Instance = null;
        public static Vars Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new Vars();
                return _Instance;
            }
        }
        public string Username;
        public string Password;
        public string domain;
        public string pcname;
        public string vmid;
        public string Manufacturer;
        public bool cmd = false;
    }
    public class pxvdi_agent
    {
        private static readonly XNamespace UnattendNamespace = "urn:schemas-microsoft-com:unattend";
        private static readonly XNamespace WcmNamespace = "http://schemas.microsoft.com/WMIConfig/2002/State";
        private static readonly XNamespace XsiNamespace = "http://www.w3.org/2001/XMLSchema-instance";

        private static string GetSystemUuid()
        {
            try
            {
                // 读取主板序列号 (smbios type=2)
                var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "wmic",
                        Arguments = "baseboard get serialnumber",
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    }
                };

                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                // 解析输出，跳过标题行
                var lines = output.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                if (lines.Length > 1)
                {
                    string uuid = lines[1].Trim();
                    return !string.IsNullOrEmpty(uuid) ? uuid : "未能检测到UUID";
                }

                return "未能检测到UUID";
            }
            catch (Exception ex)
            {
                return "UUID检测失败";
            }
        }

        public static string hwinfo() {
            Vars.Instance.domain = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
            Vars.Instance.pcname = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().HostName;
            Vars.Instance.Username = System.Environment.UserName;
            Vars.Instance.vmid = GetSystemUuid();

            return "ok";
        }

        public static void hwcheck() {
            hwinfo();
            //if (Vars.Instance.Manufacturer != "ProxmoxVE") {

            //    MessageBox.Show("检测到不是Proxmox VE VM！");
            //}

        }

        public static void renamepc() {
            if (Vars.Instance.domain == null || Vars.Instance.domain == "")
            {
                RegistryKey key = Registry.LocalMachine;

                string activeComputerName = "SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName";
                RegistryKey activeCmpName = key.CreateSubKey(activeComputerName);
                activeCmpName.SetValue("ComputerName", Vars.Instance.pcname);
                activeCmpName.Close();
                string computerName = "SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ComputerName";
                RegistryKey cmpName = key.CreateSubKey(computerName);
                cmpName.SetValue("ComputerName", Vars.Instance.pcname);
                cmpName.Close();
                string _hostName = "SYSTEM\\CurrentControlSet\\services\\Tcpip\\Parameters\\";
                RegistryKey hostName = key.CreateSubKey(_hostName);
                hostName.SetValue("Hostname", Vars.Instance.pcname);
                hostName.SetValue("NV Hostname", Vars.Instance.pcname);
                hostName.Close();
                MessageBox.Show("计算机已重命名为：" + Vars.Instance.pcname + "\n请重启!");
            }
            else
            {
                if (Vars.Instance.Password != null && Vars.Instance.Password != "" && Vars.Instance.Username != "" && Vars.Instance.Username != null)
                {

                    object[] methodArgs = { Vars.Instance.pcname, Vars.Instance.Password, Vars.Instance.Username };

                    // Here we construct the ManagementObject and set Options
                    ManagementObject computerSystem = new ManagementObject("Win32_ComputerSystem");
                    computerSystem.Scope.Options.Authentication = System.Management.AuthenticationLevel.PacketPrivacy;
                    computerSystem.Scope.Options.Impersonation = ImpersonationLevel.Impersonate;
                    computerSystem.Scope.Options.EnablePrivileges = true;

                    // Here we invoke the method JoinDomainOrWorkgroup passing the parameters as the second parameter
                    object Oresult = computerSystem.InvokeMethod("rename", methodArgs);

                    // The result is returned as an object of type int, so we need to cast.
                    int result = (int)Convert.ToInt32(Oresult);
                    if (result == 0)
                    {
                        MessageBox.Show("重命名成功！");
                    }
                    else {

                        MessageBox.Show("重命名失败！");
                    }
                }
                else
                {
                    MessageBox.Show("参数不能为空！");
                }
            }
        }
        public static void Join()
        {
            // Define constants used in the method.
            int JOIN_DOMAIN = 1;
            int ACCT_CREATE = 2;
            int ACCT_DELETE = 4;
            int WIN9X_UPGRADE = 16;
            int DOMAIN_JOIN_IF_JOINED = 32;
            int JOIN_UNSECURE = 64;
            int MACHINE_PASSWORD_PASSED = 128;
            int DEFERRED_SPN_SET = 256;
            int INSTALL_INVOCATION = 262144;
            int parameters = JOIN_DOMAIN | DOMAIN_JOIN_IF_JOINED | ACCT_CREATE;

            // The arguments are passed as an array of string objects in a specific order
            object[] methodArgs = { Vars.Instance.domain, Vars.Instance.Password, Vars.Instance.Username, null, parameters };

            // Here we construct the ManagementObject and set Options
            ManagementObject computerSystem = new ManagementObject("Win32_ComputerSystem.Name='" + Environment.MachineName + "'");
            computerSystem.Scope.Options.Authentication = System.Management.AuthenticationLevel.PacketPrivacy;
            computerSystem.Scope.Options.Impersonation = ImpersonationLevel.Impersonate;
            computerSystem.Scope.Options.EnablePrivileges = false;

            // Here we invoke the method JoinDomainOrWorkgroup passing the parameters as the second parameter
            object Oresult = computerSystem.InvokeMethod("JoinDomainOrWorkgroup", methodArgs);

            // The result is returned as an object of type int, so we need to cast.
            int result = (int)Convert.ToInt32(Oresult);

            // If the result is 0 then the computer is joined.
            if (result == 0)
            {
                MessageBox.Show("Joined Successfully!");
            }
            else
            {
                // Here are the list of possible errors
                string strErrorDescription = " ";
                switch (result)
                {
                    case 5:
                        strErrorDescription = "Access is denied";
                        break;
                    case 87:
                        strErrorDescription = "The parameter is incorrect";
                        break;
                    case 110:
                        strErrorDescription = "The system cannot open the specified object";
                        break;
                    case 1323:
                        strErrorDescription = "Unable to update the password";
                        break;
                    case 1326:
                        strErrorDescription = "Logon failure: unknown username or bad password";
                        break;
                    case 1355:
                        strErrorDescription = "The specified domain either does not exist or could not be contacted";
                        break;
                    case 2224:
                        strErrorDescription = "The account already exists";
                        break;
                    case 2691:
                        strErrorDescription = "The machine is already joined to the domain";
                        break;
                    case 2692:
                        strErrorDescription = "The machine is not currently joined to a domain";
                        break;
                }
                MessageBox.Show(strErrorDescription.ToString());
            }

        }

        public static void Leave_domain()
        {

            // The arguments are passed as an array of string objects in a specific order
            object[] methodArgs = { Vars.Instance.Password, Vars.Instance.Username };

            // Here we construct the ManagementObject and set Options
            ManagementObject computerSystem = new ManagementObject("Win32_ComputerSystem.Name='" + Environment.MachineName + "'");
            computerSystem.Scope.Options.Authentication = System.Management.AuthenticationLevel.PacketPrivacy;
            computerSystem.Scope.Options.Impersonation = ImpersonationLevel.Impersonate;
            computerSystem.Scope.Options.EnablePrivileges = true;

            // Here we invoke the method JoinDomainOrWorkgroup passing the parameters as the second parameter
            object Oresult = computerSystem.InvokeMethod("unJoinDomainOrWorkgroup", methodArgs);

            // The result is returned as an object of type int, so we need to cast.
            int result = (int)Convert.ToInt32(Oresult);
            if (result == 0)
            {
                MessageBox.Show("离域成功！");
            }
            else
            {
                MessageBox.Show("离域失败！");
            }
        }

        private static XElement CreateComponent(string componentName, params object[] content)
        {
            return new XElement(
                UnattendNamespace + "component",
                new XAttribute("name", componentName),
                new XAttribute("processorArchitecture", "amd64"),
                new XAttribute("publicKeyToken", "31bf3856ad364e35"),
                new XAttribute("language", "neutral"),
                new XAttribute("versionScope", "nonSxS"),
                new XAttribute(XNamespace.Xmlns + "wcm", WcmNamespace),
                new XAttribute(XNamespace.Xmlns + "xsi", XsiNamespace),
                content
            );
        }

        private static string FormatDomainUsername(string username, string domain)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                return string.Empty;
            }

            if (username.Contains("@") || username.Contains("\\"))
            {
                return username;
            }

            return username + "@" + domain;
        }

        private static XDocument BuildUnattendDocument(bool useDomainSysprep, bool skipOobe)
        {
            XElement root = new XElement(UnattendNamespace + "unattend");

            if (useDomainSysprep)
            {
                root.Add(
                    new XElement(
                        UnattendNamespace + "settings",
                        new XAttribute("pass", "specialize"),
                        CreateComponent(
                            "Microsoft-Windows-UnattendedJoin",
                            new XElement(
                                UnattendNamespace + "Identification",
                                new XElement(
                                    UnattendNamespace + "Credentials",
                                    new XElement(UnattendNamespace + "Domain", Vars.Instance.domain),
                                    new XElement(UnattendNamespace + "Password", Vars.Instance.Password),
                                    new XElement(UnattendNamespace + "Username", FormatDomainUsername(Vars.Instance.Username, Vars.Instance.domain))
                                ),
                                new XElement(UnattendNamespace + "JoinDomain", Vars.Instance.domain)
                            )
                        )
                    )
                );
            }

            if (skipOobe)
            {
                root.Add(
                    new XElement(
                        UnattendNamespace + "settings",
                        new XAttribute("pass", "oobeSystem"),
                        CreateComponent(
                            "Microsoft-Windows-Shell-Setup",
                            new XElement(
                                UnattendNamespace + "OOBE",
                                new XElement(
                                    UnattendNamespace + "VMModeOptimizations",
                                    new XElement(UnattendNamespace + "SkipAdministratorProfileRemoval", true),
                                    new XElement(UnattendNamespace + "SkipWinREInitialization", true),
                                    new XElement(UnattendNamespace + "SkipNotifyUILanguageChange", true)
                                ),
                                new XElement(UnattendNamespace + "HideEULAPage", true),
                                new XElement(UnattendNamespace + "HideOEMRegistrationScreen", true),
                                new XElement(UnattendNamespace + "HideOnlineAccountScreens", true),
                                new XElement(UnattendNamespace + "HideWirelessSetupInOOBE", true),
                                new XElement(UnattendNamespace + "ProtectYourPC", 3),
                                new XElement(UnattendNamespace + "NetworkLocation", "Work"),
                                new XElement(UnattendNamespace + "UnattendEnableRetailDemo", false)
                            )
                        )
                    )
                );
            }

            return new XDocument(new XDeclaration("1.0", "utf-8", null), root);
        }

        public static void sysprep(bool useDomainSysprep, bool skipOobe) {
            string unattendpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "unattend.xml");

            if (useDomainSysprep || skipOobe)
            {
                XmlWriterSettings writerSettings = new XmlWriterSettings
                {
                    Encoding = new UTF8Encoding(false),
                    Indent = true,
                    OmitXmlDeclaration = false
                };

                using (XmlWriter writer = XmlWriter.Create(unattendpath, writerSettings))
                {
                    BuildUnattendDocument(useDomainSysprep, skipOobe).Save(writer);
                }
            }

            Process p = new Process();
            p.StartInfo.FileName = @"C:\\Windows\\sysnative\\Sysprep\\sysprep.exe";
            p.StartInfo.Arguments = @"/oobe /generalize /shutdown /mode:vm";

            if (useDomainSysprep || skipOobe)
            {
                p.StartInfo.Arguments += " /unattend:" + unattendpath;
            }

            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.Start();
        }

    }
}
