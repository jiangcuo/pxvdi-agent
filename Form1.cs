using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.ServiceProcess;

namespace pxvdi_agent
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        private static bool IsValidGuid(string guidString)
        {
            return Guid.TryParse(guidString, out _);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.vmid.Text = "正在检测虚拟机...";
            this.vmid.ForeColor = Color.DarkOrange;
            
            // 使用异步方法加载VM信息，避免界面卡顿
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (s, args) => {
                pxvdi_agent.hwinfo();
            };
            
            worker.RunWorkerCompleted += (s, args) => {
                if (IsValidGuid(Vars.Instance.vmid))
                {
                    this.vmid.ForeColor = Color.Green;
                    this.vmid.Text = "已检测到VM: " + Vars.Instance.vmid;
                }
                else {
                    this.vmid.ForeColor = Color.Red;
                    this.vmid.Text = "本机不是VM！ ";
                }

                this.pcnamebox.Text = Vars.Instance.pcname;
                this.userbox.Text = Vars.Instance.Username;
                this.domainbox.Text = Vars.Instance.domain;
                
                // 初始化服务状态
                RefreshServiceStatuses();
            };
            
            worker.RunWorkerAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vars.Instance.Password = this.passbox.Text;
            Vars.Instance.Username = this.userbox.Text;
            Vars.Instance.domain = this.domainbox.Text;
            if (Vars.Instance.Password != null && Vars.Instance.Password != "" && Vars.Instance.pcname != null && Vars.Instance.pcname != "" && Vars.Instance.domain != "" && Vars.Instance.domain != null)
            {
                if (MessageBox.Show("系统将进行封装，此操作不可逆，确定继续吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    pxvdi_agent.sysprep();
                }
            }
            else
            {
                MessageBox.Show("参数不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //rename pc
            Vars.Instance.Password= this.passbox.Text;
            Vars.Instance.pcname= this.pcnamebox.Text;
            Vars.Instance.domain= this.domainbox.Text;
            pxvdi_agent.renamepc();
        }

        private void pcnamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void joindomainbut_Click(object sender, EventArgs e)
        {
            //joindomain
            Vars.Instance.Password = this.passbox.Text;
            Vars.Instance.Username = this.userbox.Text;
            Vars.Instance.domain = this.domainbox.Text;
            if (Vars.Instance.Password != null && Vars.Instance.Password != "" && Vars.Instance.pcname != null && Vars.Instance.pcname != "" && Vars.Instance.domain != "" && Vars.Instance.domain != null)
            {
                joindomainbut.Enabled = false;
                joindomainbut.Text = "加域中...";
                
                // 使用异步方法加入域，避免界面卡顿
                BackgroundWorker worker = new BackgroundWorker();
                worker.DoWork += (s, args) => {
                    pxvdi_agent.Join();
                };
                
                worker.RunWorkerCompleted += (s, args) => {
                    joindomainbut.Enabled = true;
                    joindomainbut.Text = "加域";
                };
                
                worker.RunWorkerAsync();
            }
            else {
                MessageBox.Show("参数不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void leavedomainbut_Click(object sender, EventArgs e)
        {
            Vars.Instance.Password = this.passbox.Text;
            Vars.Instance.Username = this.userbox.Text;
            Vars.Instance.domain = "workgroup";
            if (Vars.Instance.Password != null && Vars.Instance.Password != "" && Vars.Instance.pcname != null && Vars.Instance.pcname != "" && Vars.Instance.domain != "" && Vars.Instance.domain != null)
            {
                leavedomainbut.Enabled = false;
                leavedomainbut.Text = "脱域中...";
                
                // 使用异步方法脱离域，避免界面卡顿
                BackgroundWorker worker = new BackgroundWorker();
                worker.DoWork += (s, args) => {
                    pxvdi_agent.Leave_domain();
                };
                
                worker.RunWorkerCompleted += (s, args) => {
                    leavedomainbut.Enabled = true;
                    leavedomainbut.Text = "脱域";
                };
                
                worker.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("参数不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void optimizerbut_Click(object sender, EventArgs e)
        {
            try
            {
                string executingPath = Path.GetDirectoryName(Application.ExecutablePath);
                string optimizerPath = Path.Combine(executingPath, "Optimizer.exe");
                
                if (File.Exists(optimizerPath))
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = optimizerPath,
                        UseShellExecute = true
                    };
                    
                    Process.Start(startInfo);
                }
                else
                {
                    MessageBox.Show("找不到系统优化工具(Optimizer.exe)！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("启动系统优化工具时出错：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkDomainSysprep_CheckedChanged(object sender, EventArgs e)
        {
            // 当勾选域封装时，启用域信息输入
            bool enabled = chkDomainSysprep.Checked;
            txtDomainName.Enabled = enabled;
            txtDomainUser.Enabled = enabled;
            txtDomainPassword.Enabled = enabled;
        }
        
        private void btnSysprep_Click(object sender, EventArgs e)
        {
            // 检查是否有前缀
            if (string.IsNullOrEmpty(txtPCNamePrefix.Text))
            {
                MessageBox.Show("请输入计算机名前缀！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            // 如果勾选了域封装，检查域信息
            if (chkDomainSysprep.Checked)
            {
                if (string.IsNullOrEmpty(txtDomainName.Text) || 
                    string.IsNullOrEmpty(txtDomainUser.Text) || 
                    string.IsNullOrEmpty(txtDomainPassword.Text))
                {
                    MessageBox.Show("开启域封装时，请填写完整的域信息！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                // 设置域信息
                Vars.Instance.domain = txtDomainName.Text;
                Vars.Instance.Username = txtDomainUser.Text;
                Vars.Instance.Password = txtDomainPassword.Text;
            }
            
            // 设置计算机名前缀
            Vars.Instance.pcname = txtPCNamePrefix.Text;
            
            // 确认操作
            if (MessageBox.Show("系统将进行封装，此操作不可逆，确定继续吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                pxvdi_agent.sysprep();
            }
        }
        
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userbox.Text) || string.IsNullOrEmpty(passbox.Text))
            {
                MessageBox.Show("用户名和密码不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo("cmd.exe");
                psi.Arguments = $"/c net user {userbox.Text} {passbox.Text}";
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                psi.Verb = "runas"; // 请求管理员权限
                
                Process.Start(psi);
                MessageBox.Show($"密码已修改成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"修改密码失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnApplyVisual_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects", true);
                if (key == null)
                {
                    key = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects");
                }
                
                if (rdoAppearance.Checked)
                {
                    key.SetValue("VisualFXSetting", 1);
                }
                else // 最佳性能
                {
                    key.SetValue("VisualFXSetting", 2);
                }
                
                MessageBox.Show("系统视觉效果设置已应用，可能需要重启以生效。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"应用视觉效果设置失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnDisableHibernate_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo("cmd.exe");
                psi.Arguments = "/c powercfg /h off";
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                psi.Verb = "runas"; // 请求管理员权限
                
                Process.Start(psi);
                MessageBox.Show("休眠功能已关闭。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"关闭休眠失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnBestPerformance_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo("cmd.exe");
                psi.Arguments = "/c powercfg /s 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c";
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                psi.Verb = "runas"; // 请求管理员权限
                
                Process.Start(psi);
                MessageBox.Show("电源计划已设置为最佳性能。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"设置电源计划失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnDisableDefender_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo("cmd.exe");
                psi.Arguments = "/c reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\" /v DisableAntiSpyware /t REG_DWORD /d 1 /f";
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                psi.Verb = "runas"; // 请求管理员权限
                
                Process.Start(psi);
                MessageBox.Show("Microsoft Defender已禁用，重启后生效。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"禁用Microsoft Defender失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void RefreshServiceStatuses()
        {
            // 检查RDP服务状态
            CheckRdpStatus();
            
            // 检查其他服务状态
            CheckSpiceService();
            CheckQemuAgentService();
            CheckPxvdiMonitorService();
        }
        
        private void CheckRdpStatus()
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Terminal Server"))
                {
                    if (key != null)
                    {
                        int fDenyTSConnections = (int)key.GetValue("fDenyTSConnections", 1);
                        bool rdpEnabled = (fDenyTSConnections == 0);
                        
                        lblRdpStatus.Text = "状态：" + (rdpEnabled ? "已启用" : "已禁用");
                        lblRdpStatus.ForeColor = rdpEnabled ? Color.Green : Color.Red;
                        
                        // 获取当前RDP端口
                        using (RegistryKey portKey = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Terminal Server\WinStations\RDP-Tcp"))
                        {
                            if (portKey != null)
                            {
                                int port = (int)portKey.GetValue("PortNumber", 3389);
                                txtRdpPort.Text = port.ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblRdpStatus.Text = "状态：错误";
                lblRdpStatus.ForeColor = Color.Red;
                MessageBox.Show($"获取RDP状态失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void CheckServiceStatus(string serviceName, Label statusLabel)
        {
            try
            {
                ServiceController sc = new ServiceController(serviceName);
                string status = "未找到";
                Color statusColor = Color.Gray;
                
                try
                {
                    switch (sc.Status)
                    {
                        case ServiceControllerStatus.Running:
                            status = "运行中";
                            statusColor = Color.Green;
                            break;
                        case ServiceControllerStatus.Stopped:
                            status = "已停止";
                            statusColor = Color.Red;
                            break;
                        case ServiceControllerStatus.Paused:
                            status = "已暂停";
                            statusColor = Color.Orange;
                            break;
                        default:
                            status = sc.Status.ToString();
                            statusColor = Color.Gray;
                            break;
                    }
                }
                catch
                {
                    // 服务不存在
                }
                
                statusLabel.Text = "状态：" + status;
                statusLabel.ForeColor = statusColor;
            }
            catch
            {
                statusLabel.Text = "状态：未找到";
                statusLabel.ForeColor = Color.Gray;
            }
        }
        
        private void CheckSpiceService()
        {
            CheckServiceStatus("spice-agent", lblSpiceService);
        }
        
        private void CheckQemuAgentService()
        {
            CheckServiceStatus("QEMU-GA", lblQemuAgent);
        }
        
        private void CheckPxvdiMonitorService()
        {
            CheckServiceStatus("PxvdiMonitor", lblPxvdiMonitor);
        }
        
        private void btnToggleRDP_Click(object sender, EventArgs e)
        {
            try
            {
                bool currentState = false;
                
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Terminal Server", true))
                {
                    if (key != null)
                    {
                        int fDenyTSConnections = (int)key.GetValue("fDenyTSConnections", 1);
                        currentState = (fDenyTSConnections == 0);
                        
                        // 切换状态
                        key.SetValue("fDenyTSConnections", currentState ? 1 : 0);
                    }
                }
                
                // 更新防火墙
                ProcessStartInfo psi = new ProcessStartInfo("cmd.exe");
                psi.Arguments = currentState ? 
                    "/c netsh advfirewall firewall set rule group=\"远程桌面\" new enable=no" :
                    "/c netsh advfirewall firewall set rule group=\"远程桌面\" new enable=yes";
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                psi.Verb = "runas"; // 请求管理员权限
                Process.Start(psi);
                
                // 刷新状态
                CheckRdpStatus();
                
                MessageBox.Show($"RDP服务已{(currentState ? "禁用" : "启用")}。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"切换RDP状态失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnChangeRdpPort_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtRdpPort.Text, out int port) || port < 1 || port > 65535)
                {
                    MessageBox.Show("请输入有效的端口号(1-65535)！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Terminal Server\WinStations\RDP-Tcp", true))
                {
                    if (key != null)
                    {
                        key.SetValue("PortNumber", port);
                    }
                }
                
                MessageBox.Show($"RDP端口已修改为 {port}，需要重启系统生效。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"修改RDP端口失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnUpdateFirewall_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtRdpPort.Text, out int port) || port < 1 || port > 65535)
                {
                    MessageBox.Show("请输入有效的端口号(1-65535)！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                ProcessStartInfo psi = new ProcessStartInfo("cmd.exe");
                psi.Arguments = $"/c netsh advfirewall firewall add rule name=\"RDP Port {port}\" dir=in action=allow protocol=TCP localport={port}";
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                psi.Verb = "runas"; // 请求管理员权限
                Process.Start(psi);
                
                MessageBox.Show($"已为RDP端口 {port} 添加防火墙规则。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"更新防火墙规则失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnRefreshSpice_Click(object sender, EventArgs e)
        {
            CheckSpiceService();
        }
        
        private void btnRefreshQemuAgent_Click(object sender, EventArgs e)
        {
            CheckQemuAgentService();
        }
        
        private void btnRefreshPxvdiMonitor_Click(object sender, EventArgs e)
        {
            CheckPxvdiMonitorService();
        }

        private void domainbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void userbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblQemuAgent_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
