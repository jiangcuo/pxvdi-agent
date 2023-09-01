using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using pxvdi_agent;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Diagnostics;

namespace pxvdi_agent
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            pxvdi_agent.hwcheck();
                if (args.Length == 0 ) {
                          Application.EnableVisualStyles();
                          Application.SetCompatibleTextRenderingDefault(false);
                          Application.Run(new Start());
                 }
                else if (args.Length >0 && args[0] == "cmd") {
                Console.WriteLine(args[0]);   
            }
        }

    }
}
