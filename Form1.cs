using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pxvdi_agent
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Vars.Instance.vmid != null && Vars.Instance.vmid != "")
            {
                this.vmid.ForeColor = Color.Green;
                this.vmid.Text = "已检测到vm: " + Vars.Instance.vmid;
            }
            else {
                this.vmid.ForeColor = Color.Red;
                this.vmid.Text = "未检测到vm！ ";
            }

            this.pcnamebox.Text = Vars.Instance.pcname;
            this.userbox.Text = Vars.Instance.Username;
            this.domainbox.Text = Vars.Instance.domain;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vars.Instance.Password = this.passbox.Text;
            Vars.Instance.Username = this.userbox.Text;
            Vars.Instance.domain = this.domainbox.Text;
            if (Vars.Instance.Password != null && Vars.Instance.Password != "" && Vars.Instance.pcname != null && Vars.Instance.pcname != "" && Vars.Instance.domain != "" && Vars.Instance.domain != null)
            {
                pxvdi_agent.sysprep();
            }
            else
            {
                MessageBox.Show("参数不能为空！");
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
                pxvdi_agent.Join();
            }
            else {
                MessageBox.Show("参数不能为空！");
            }
        }

        private void leavedomainbut_Click(object sender, EventArgs e)
        {
            Vars.Instance.Password = this.passbox.Text;
            Vars.Instance.Username = this.userbox.Text;
            Vars.Instance.domain = "workgroup";
            if (Vars.Instance.Password != null && Vars.Instance.Password != "" && Vars.Instance.pcname != null && Vars.Instance.pcname != "" && Vars.Instance.domain != "" && Vars.Instance.domain != null)
            {
               pxvdi_agent.Leave_domain();
            }
            else
            {
                MessageBox.Show("参数不能为空！");
            }
        }
    }
}
