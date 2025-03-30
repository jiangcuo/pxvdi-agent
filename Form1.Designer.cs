namespace pxvdi_agent
{
    partial class Start
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabComputer = new System.Windows.Forms.TabPage();
            this.pcnamebox = new System.Windows.Forms.TextBox();
            this.pcname = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.leavedomainbut = new System.Windows.Forms.Button();
            this.joindomainbut = new System.Windows.Forms.Button();
            this.passbox = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.userbox = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.domainbox = new System.Windows.Forms.TextBox();
            this.domainname = new System.Windows.Forms.Label();
            this.tabSysprep = new System.Windows.Forms.TabPage();
            this.btnSysprep = new System.Windows.Forms.Button();
            this.chkSkipOOBE = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDomainPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDomainUser = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDomainName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkDomainSysprep = new System.Windows.Forms.CheckBox();
            this.txtPCNamePrefix = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabOptimize = new System.Windows.Forms.TabPage();
            this.btnExternalOptimizer = new System.Windows.Forms.Button();
            this.btnDisableDefender = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBestPerformance = new System.Windows.Forms.Button();
            this.btnDisableHibernate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoPerformance = new System.Windows.Forms.RadioButton();
            this.rdoAppearance = new System.Windows.Forms.RadioButton();
            this.btnApplyVisual = new System.Windows.Forms.Button();
            this.tabService = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblPxvdiMonitor = new System.Windows.Forms.Label();
            this.btnRefreshPxvdiMonitor = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblQemuAgent = new System.Windows.Forms.Label();
            this.btnRefreshQemuAgent = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblSpiceService = new System.Windows.Forms.Label();
            this.btnRefreshSpice = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnUpdateFirewall = new System.Windows.Forms.Button();
            this.txtRdpPort = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnChangeRdpPort = new System.Windows.Forms.Button();
            this.btnToggleRDP = new System.Windows.Forms.Button();
            this.lblRdpStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.vmid = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabComputer.SuspendLayout();
            this.tabSysprep.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabOptimize.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabService.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabComputer);
            this.tabControl1.Controls.Add(this.tabSysprep);
            this.tabControl1.Controls.Add(this.tabOptimize);
            this.tabControl1.Controls.Add(this.tabService);
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(6, 60);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(572, 289);
            this.tabControl1.TabIndex = 17;
            // 
            // tabComputer
            // 
            this.tabComputer.BackColor = System.Drawing.Color.White;
            this.tabComputer.Controls.Add(this.pcnamebox);
            this.tabComputer.Controls.Add(this.pcname);
            this.tabComputer.Controls.Add(this.btnChangePassword);
            this.tabComputer.Controls.Add(this.leavedomainbut);
            this.tabComputer.Controls.Add(this.joindomainbut);
            this.tabComputer.Controls.Add(this.passbox);
            this.tabComputer.Controls.Add(this.password);
            this.tabComputer.Controls.Add(this.userbox);
            this.tabComputer.Controls.Add(this.username);
            this.tabComputer.Controls.Add(this.domainbox);
            this.tabComputer.Controls.Add(this.domainname);
            this.tabComputer.Location = new System.Drawing.Point(4, 26);
            this.tabComputer.Margin = new System.Windows.Forms.Padding(2);
            this.tabComputer.Name = "tabComputer";
            this.tabComputer.Padding = new System.Windows.Forms.Padding(2);
            this.tabComputer.Size = new System.Drawing.Size(564, 259);
            this.tabComputer.TabIndex = 0;
            this.tabComputer.Text = "计算机管理";
            // 
            // pcnamebox
            // 
            this.pcnamebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcnamebox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pcnamebox.Location = new System.Drawing.Point(119, 25);
            this.pcnamebox.Margin = new System.Windows.Forms.Padding(2);
            this.pcnamebox.Name = "pcnamebox";
            this.pcnamebox.Size = new System.Drawing.Size(161, 23);
            this.pcnamebox.TabIndex = 13;
            this.pcnamebox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pcname
            // 
            this.pcname.AutoSize = true;
            this.pcname.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pcname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pcname.Location = new System.Drawing.Point(53, 27);
            this.pcname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pcname.Name = "pcname";
            this.pcname.Size = new System.Drawing.Size(68, 17);
            this.pcname.TabIndex = 14;
            this.pcname.Text = "计算机名：";
            this.pcname.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(213, 156);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(75, 25);
            this.btnChangePassword.TabIndex = 12;
            this.btnChangePassword.Text = "修改密码";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // leavedomainbut
            // 
            this.leavedomainbut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.leavedomainbut.FlatAppearance.BorderSize = 0;
            this.leavedomainbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leavedomainbut.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.leavedomainbut.ForeColor = System.Drawing.Color.White;
            this.leavedomainbut.Location = new System.Drawing.Point(123, 156);
            this.leavedomainbut.Margin = new System.Windows.Forms.Padding(2);
            this.leavedomainbut.Name = "leavedomainbut";
            this.leavedomainbut.Size = new System.Drawing.Size(75, 25);
            this.leavedomainbut.TabIndex = 11;
            this.leavedomainbut.Text = "退出域";
            this.leavedomainbut.UseVisualStyleBackColor = false;
            this.leavedomainbut.Click += new System.EventHandler(this.leavedomainbut_Click);
            // 
            // joindomainbut
            // 
            this.joindomainbut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.joindomainbut.FlatAppearance.BorderSize = 0;
            this.joindomainbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.joindomainbut.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.joindomainbut.ForeColor = System.Drawing.Color.White;
            this.joindomainbut.Location = new System.Drawing.Point(33, 156);
            this.joindomainbut.Margin = new System.Windows.Forms.Padding(2);
            this.joindomainbut.Name = "joindomainbut";
            this.joindomainbut.Size = new System.Drawing.Size(75, 25);
            this.joindomainbut.TabIndex = 3;
            this.joindomainbut.Text = "加域";
            this.joindomainbut.UseVisualStyleBackColor = false;
            this.joindomainbut.Click += new System.EventHandler(this.joindomainbut_Click);
            // 
            // passbox
            // 
            this.passbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passbox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passbox.Location = new System.Drawing.Point(119, 112);
            this.passbox.Margin = new System.Windows.Forms.Padding(2);
            this.passbox.Name = "passbox";
            this.passbox.PasswordChar = '●';
            this.passbox.Size = new System.Drawing.Size(161, 23);
            this.passbox.TabIndex = 8;
            this.passbox.TextChanged += new System.EventHandler(this.passbox_TextChanged);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password.Location = new System.Drawing.Point(53, 114);
            this.password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(44, 17);
            this.password.TabIndex = 9;
            this.password.Text = "密码：";
            // 
            // userbox
            // 
            this.userbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userbox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userbox.Location = new System.Drawing.Point(119, 82);
            this.userbox.Margin = new System.Windows.Forms.Padding(2);
            this.userbox.Name = "userbox";
            this.userbox.Size = new System.Drawing.Size(161, 23);
            this.userbox.TabIndex = 6;
            this.userbox.TextChanged += new System.EventHandler(this.userbox_TextChanged);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.username.Location = new System.Drawing.Point(53, 84);
            this.username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(44, 17);
            this.username.TabIndex = 7;
            this.username.Text = "用户：";
            // 
            // domainbox
            // 
            this.domainbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.domainbox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.domainbox.Location = new System.Drawing.Point(119, 52);
            this.domainbox.Margin = new System.Windows.Forms.Padding(2);
            this.domainbox.Name = "domainbox";
            this.domainbox.Size = new System.Drawing.Size(161, 23);
            this.domainbox.TabIndex = 4;
            this.domainbox.TextChanged += new System.EventHandler(this.domainbox_TextChanged);
            // 
            // domainname
            // 
            this.domainname.AutoSize = true;
            this.domainname.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.domainname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.domainname.Location = new System.Drawing.Point(53, 54);
            this.domainname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.domainname.Name = "domainname";
            this.domainname.Size = new System.Drawing.Size(44, 17);
            this.domainname.TabIndex = 5;
            this.domainname.Text = "域名：";
            // 
            // tabSysprep
            // 
            this.tabSysprep.BackColor = System.Drawing.Color.White;
            this.tabSysprep.Controls.Add(this.btnSysprep);
            this.tabSysprep.Controls.Add(this.chkSkipOOBE);
            this.tabSysprep.Controls.Add(this.groupBox1);
            this.tabSysprep.Controls.Add(this.chkDomainSysprep);
            this.tabSysprep.Controls.Add(this.txtPCNamePrefix);
            this.tabSysprep.Controls.Add(this.label6);
            this.tabSysprep.Location = new System.Drawing.Point(4, 26);
            this.tabSysprep.Margin = new System.Windows.Forms.Padding(2);
            this.tabSysprep.Name = "tabSysprep";
            this.tabSysprep.Padding = new System.Windows.Forms.Padding(2);
            this.tabSysprep.Size = new System.Drawing.Size(564, 259);
            this.tabSysprep.TabIndex = 1;
            this.tabSysprep.Text = "系统封装";
            // 
            // btnSysprep
            // 
            this.btnSysprep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSysprep.FlatAppearance.BorderSize = 0;
            this.btnSysprep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSysprep.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSysprep.ForeColor = System.Drawing.Color.White;
            this.btnSysprep.Location = new System.Drawing.Point(34, 214);
            this.btnSysprep.Margin = new System.Windows.Forms.Padding(2);
            this.btnSysprep.Name = "btnSysprep";
            this.btnSysprep.Size = new System.Drawing.Size(75, 25);
            this.btnSysprep.TabIndex = 13;
            this.btnSysprep.Text = "封装系统";
            this.btnSysprep.UseVisualStyleBackColor = false;
            this.btnSysprep.Click += new System.EventHandler(this.btnSysprep_Click);
            // 
            // chkSkipOOBE
            // 
            this.chkSkipOOBE.AutoSize = true;
            this.chkSkipOOBE.Checked = true;
            this.chkSkipOOBE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSkipOOBE.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkSkipOOBE.Location = new System.Drawing.Point(222, 58);
            this.chkSkipOOBE.Margin = new System.Windows.Forms.Padding(2);
            this.chkSkipOOBE.Name = "chkSkipOOBE";
            this.chkSkipOOBE.Size = new System.Drawing.Size(86, 21);
            this.chkSkipOOBE.TabIndex = 4;
            this.chkSkipOOBE.Text = "跳过OOBE";
            this.chkSkipOOBE.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDomainPassword);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDomainUser);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDomainName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(34, 96);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(274, 105);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "域信息";
            // 
            // txtDomainPassword
            // 
            this.txtDomainPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDomainPassword.Enabled = false;
            this.txtDomainPassword.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDomainPassword.Location = new System.Drawing.Point(95, 76);
            this.txtDomainPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtDomainPassword.Name = "txtDomainPassword";
            this.txtDomainPassword.PasswordChar = '●';
            this.txtDomainPassword.Size = new System.Drawing.Size(150, 23);
            this.txtDomainPassword.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(9, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "域管理员密码：";
            // 
            // txtDomainUser
            // 
            this.txtDomainUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDomainUser.Enabled = false;
            this.txtDomainUser.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDomainUser.Location = new System.Drawing.Point(95, 49);
            this.txtDomainUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtDomainUser.Name = "txtDomainUser";
            this.txtDomainUser.Size = new System.Drawing.Size(150, 23);
            this.txtDomainUser.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(9, 47);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "域管理员用户：";
            // 
            // txtDomainName
            // 
            this.txtDomainName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDomainName.Enabled = false;
            this.txtDomainName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDomainName.Location = new System.Drawing.Point(95, 22);
            this.txtDomainName.Margin = new System.Windows.Forms.Padding(2);
            this.txtDomainName.Name = "txtDomainName";
            this.txtDomainName.Size = new System.Drawing.Size(150, 23);
            this.txtDomainName.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(9, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "域名：";
            // 
            // chkDomainSysprep
            // 
            this.chkDomainSysprep.AutoSize = true;
            this.chkDomainSysprep.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkDomainSysprep.Location = new System.Drawing.Point(34, 58);
            this.chkDomainSysprep.Margin = new System.Windows.Forms.Padding(2);
            this.chkDomainSysprep.Name = "chkDomainSysprep";
            this.chkDomainSysprep.Size = new System.Drawing.Size(63, 21);
            this.chkDomainSysprep.TabIndex = 2;
            this.chkDomainSysprep.Text = "域封装";
            this.chkDomainSysprep.UseVisualStyleBackColor = true;
            this.chkDomainSysprep.CheckedChanged += new System.EventHandler(this.chkDomainSysprep_CheckedChanged);
            // 
            // txtPCNamePrefix
            // 
            this.txtPCNamePrefix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPCNamePrefix.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPCNamePrefix.Location = new System.Drawing.Point(129, 19);
            this.txtPCNamePrefix.Margin = new System.Windows.Forms.Padding(2);
            this.txtPCNamePrefix.Name = "txtPCNamePrefix";
            this.txtPCNamePrefix.Size = new System.Drawing.Size(179, 23);
            this.txtPCNamePrefix.TabIndex = 0;
            this.txtPCNamePrefix.Text = "PXVDI-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(31, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "计算机名前缀：";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tabOptimize
            // 
            this.tabOptimize.BackColor = System.Drawing.Color.White;
            this.tabOptimize.Controls.Add(this.btnExternalOptimizer);
            this.tabOptimize.Controls.Add(this.btnDisableDefender);
            this.tabOptimize.Controls.Add(this.groupBox3);
            this.tabOptimize.Controls.Add(this.groupBox2);
            this.tabOptimize.Location = new System.Drawing.Point(4, 26);
            this.tabOptimize.Margin = new System.Windows.Forms.Padding(2);
            this.tabOptimize.Name = "tabOptimize";
            this.tabOptimize.Size = new System.Drawing.Size(564, 259);
            this.tabOptimize.TabIndex = 2;
            this.tabOptimize.Text = "系统优化";
            // 
            // btnExternalOptimizer
            // 
            this.btnExternalOptimizer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnExternalOptimizer.FlatAppearance.BorderSize = 0;
            this.btnExternalOptimizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExternalOptimizer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExternalOptimizer.ForeColor = System.Drawing.Color.White;
            this.btnExternalOptimizer.Location = new System.Drawing.Point(11, 211);
            this.btnExternalOptimizer.Margin = new System.Windows.Forms.Padding(2);
            this.btnExternalOptimizer.Name = "btnExternalOptimizer";
            this.btnExternalOptimizer.Size = new System.Drawing.Size(255, 25);
            this.btnExternalOptimizer.TabIndex = 3;
            this.btnExternalOptimizer.Text = "打开外部优化工具 (Optimizer)";
            this.btnExternalOptimizer.UseVisualStyleBackColor = false;
            this.btnExternalOptimizer.Click += new System.EventHandler(this.optimizerbut_Click);
            // 
            // btnDisableDefender
            // 
            this.btnDisableDefender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDisableDefender.FlatAppearance.BorderSize = 0;
            this.btnDisableDefender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisableDefender.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDisableDefender.ForeColor = System.Drawing.Color.White;
            this.btnDisableDefender.Location = new System.Drawing.Point(11, 167);
            this.btnDisableDefender.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisableDefender.Name = "btnDisableDefender";
            this.btnDisableDefender.Size = new System.Drawing.Size(255, 25);
            this.btnDisableDefender.TabIndex = 2;
            this.btnDisableDefender.Text = "关闭 Microsoft Defender";
            this.btnDisableDefender.UseVisualStyleBackColor = false;
            this.btnDisableDefender.Click += new System.EventHandler(this.btnDisableDefender_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBestPerformance);
            this.groupBox3.Controls.Add(this.btnDisableHibernate);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(187, 18);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(126, 95);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "电源优化";
            // 
            // btnBestPerformance
            // 
            this.btnBestPerformance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBestPerformance.FlatAppearance.BorderSize = 0;
            this.btnBestPerformance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBestPerformance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBestPerformance.ForeColor = System.Drawing.Color.White;
            this.btnBestPerformance.Location = new System.Drawing.Point(12, 57);
            this.btnBestPerformance.Margin = new System.Windows.Forms.Padding(2);
            this.btnBestPerformance.Name = "btnBestPerformance";
            this.btnBestPerformance.Size = new System.Drawing.Size(102, 25);
            this.btnBestPerformance.TabIndex = 1;
            this.btnBestPerformance.Text = "开启最佳性能";
            this.btnBestPerformance.UseVisualStyleBackColor = false;
            this.btnBestPerformance.Click += new System.EventHandler(this.btnBestPerformance_Click);
            // 
            // btnDisableHibernate
            // 
            this.btnDisableHibernate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDisableHibernate.FlatAppearance.BorderSize = 0;
            this.btnDisableHibernate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisableHibernate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDisableHibernate.ForeColor = System.Drawing.Color.White;
            this.btnDisableHibernate.Location = new System.Drawing.Point(12, 22);
            this.btnDisableHibernate.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisableHibernate.Name = "btnDisableHibernate";
            this.btnDisableHibernate.Size = new System.Drawing.Size(102, 25);
            this.btnDisableHibernate.TabIndex = 0;
            this.btnDisableHibernate.Text = "关闭休眠";
            this.btnDisableHibernate.UseVisualStyleBackColor = false;
            this.btnDisableHibernate.Click += new System.EventHandler(this.btnDisableHibernate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoPerformance);
            this.groupBox2.Controls.Add(this.rdoAppearance);
            this.groupBox2.Controls.Add(this.btnApplyVisual);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(11, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(126, 95);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "系统视觉效果";
            // 
            // rdoPerformance
            // 
            this.rdoPerformance.AutoSize = true;
            this.rdoPerformance.Checked = true;
            this.rdoPerformance.Location = new System.Drawing.Point(12, 34);
            this.rdoPerformance.Margin = new System.Windows.Forms.Padding(2);
            this.rdoPerformance.Name = "rdoPerformance";
            this.rdoPerformance.Size = new System.Drawing.Size(74, 21);
            this.rdoPerformance.TabIndex = 1;
            this.rdoPerformance.TabStop = true;
            this.rdoPerformance.Text = "最佳性能";
            this.rdoPerformance.UseVisualStyleBackColor = true;
            // 
            // rdoAppearance
            // 
            this.rdoAppearance.AutoSize = true;
            this.rdoAppearance.Location = new System.Drawing.Point(12, 17);
            this.rdoAppearance.Margin = new System.Windows.Forms.Padding(2);
            this.rdoAppearance.Name = "rdoAppearance";
            this.rdoAppearance.Size = new System.Drawing.Size(74, 21);
            this.rdoAppearance.TabIndex = 0;
            this.rdoAppearance.Text = "最佳外观";
            this.rdoAppearance.UseVisualStyleBackColor = true;
            // 
            // btnApplyVisual
            // 
            this.btnApplyVisual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnApplyVisual.FlatAppearance.BorderSize = 0;
            this.btnApplyVisual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyVisual.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnApplyVisual.ForeColor = System.Drawing.Color.White;
            this.btnApplyVisual.Location = new System.Drawing.Point(12, 57);
            this.btnApplyVisual.Margin = new System.Windows.Forms.Padding(2);
            this.btnApplyVisual.Name = "btnApplyVisual";
            this.btnApplyVisual.Size = new System.Drawing.Size(102, 25);
            this.btnApplyVisual.TabIndex = 2;
            this.btnApplyVisual.Text = "应用设置";
            this.btnApplyVisual.UseVisualStyleBackColor = false;
            this.btnApplyVisual.Click += new System.EventHandler(this.btnApplyVisual_Click);
            // 
            // tabService
            // 
            this.tabService.BackColor = System.Drawing.Color.White;
            this.tabService.Controls.Add(this.groupBox7);
            this.tabService.Controls.Add(this.groupBox6);
            this.tabService.Controls.Add(this.groupBox5);
            this.tabService.Controls.Add(this.groupBox4);
            this.tabService.Location = new System.Drawing.Point(4, 26);
            this.tabService.Margin = new System.Windows.Forms.Padding(2);
            this.tabService.Name = "tabService";
            this.tabService.Size = new System.Drawing.Size(564, 259);
            this.tabService.TabIndex = 3;
            this.tabService.Text = "PXVDI服务";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblPxvdiMonitor);
            this.groupBox7.Controls.Add(this.btnRefreshPxvdiMonitor);
            this.groupBox7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox7.Location = new System.Drawing.Point(313, 140);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(238, 99);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Pxvdimonitor服务";
            // 
            // lblPxvdiMonitor
            // 
            this.lblPxvdiMonitor.AutoSize = true;
            this.lblPxvdiMonitor.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPxvdiMonitor.Location = new System.Drawing.Point(10, 22);
            this.lblPxvdiMonitor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPxvdiMonitor.Name = "lblPxvdiMonitor";
            this.lblPxvdiMonitor.Size = new System.Drawing.Size(80, 17);
            this.lblPxvdiMonitor.TabIndex = 1;
            this.lblPxvdiMonitor.Text = "状态：获取中";
            // 
            // btnRefreshPxvdiMonitor
            // 
            this.btnRefreshPxvdiMonitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRefreshPxvdiMonitor.FlatAppearance.BorderSize = 0;
            this.btnRefreshPxvdiMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshPxvdiMonitor.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRefreshPxvdiMonitor.ForeColor = System.Drawing.Color.White;
            this.btnRefreshPxvdiMonitor.Location = new System.Drawing.Point(12, 52);
            this.btnRefreshPxvdiMonitor.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshPxvdiMonitor.Name = "btnRefreshPxvdiMonitor";
            this.btnRefreshPxvdiMonitor.Size = new System.Drawing.Size(75, 25);
            this.btnRefreshPxvdiMonitor.TabIndex = 0;
            this.btnRefreshPxvdiMonitor.Text = "刷新状态";
            this.btnRefreshPxvdiMonitor.UseVisualStyleBackColor = false;
            this.btnRefreshPxvdiMonitor.Click += new System.EventHandler(this.btnRefreshPxvdiMonitor_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblQemuAgent);
            this.groupBox6.Controls.Add(this.btnRefreshQemuAgent);
            this.groupBox6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox6.Location = new System.Drawing.Point(12, 131);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(223, 108);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "qemu-guest-agent服务";
            // 
            // lblQemuAgent
            // 
            this.lblQemuAgent.AutoSize = true;
            this.lblQemuAgent.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQemuAgent.Location = new System.Drawing.Point(4, 34);
            this.lblQemuAgent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQemuAgent.Name = "lblQemuAgent";
            this.lblQemuAgent.Size = new System.Drawing.Size(80, 17);
            this.lblQemuAgent.TabIndex = 1;
            this.lblQemuAgent.Text = "状态：获取中";
            this.lblQemuAgent.Click += new System.EventHandler(this.lblQemuAgent_Click);
            // 
            // btnRefreshQemuAgent
            // 
            this.btnRefreshQemuAgent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRefreshQemuAgent.FlatAppearance.BorderSize = 0;
            this.btnRefreshQemuAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshQemuAgent.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRefreshQemuAgent.ForeColor = System.Drawing.Color.White;
            this.btnRefreshQemuAgent.Location = new System.Drawing.Point(7, 63);
            this.btnRefreshQemuAgent.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshQemuAgent.Name = "btnRefreshQemuAgent";
            this.btnRefreshQemuAgent.Size = new System.Drawing.Size(75, 25);
            this.btnRefreshQemuAgent.TabIndex = 0;
            this.btnRefreshQemuAgent.Text = "刷新状态";
            this.btnRefreshQemuAgent.UseVisualStyleBackColor = false;
            this.btnRefreshQemuAgent.Click += new System.EventHandler(this.btnRefreshQemuAgent_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblSpiceService);
            this.groupBox5.Controls.Add(this.btnRefreshSpice);
            this.groupBox5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.Location = new System.Drawing.Point(313, 17);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(238, 110);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "spice-vda spice服务";
            // 
            // lblSpiceService
            // 
            this.lblSpiceService.AutoSize = true;
            this.lblSpiceService.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSpiceService.Location = new System.Drawing.Point(10, 22);
            this.lblSpiceService.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpiceService.Name = "lblSpiceService";
            this.lblSpiceService.Size = new System.Drawing.Size(80, 17);
            this.lblSpiceService.TabIndex = 1;
            this.lblSpiceService.Text = "状态：获取中";
            // 
            // btnRefreshSpice
            // 
            this.btnRefreshSpice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRefreshSpice.FlatAppearance.BorderSize = 0;
            this.btnRefreshSpice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshSpice.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRefreshSpice.ForeColor = System.Drawing.Color.White;
            this.btnRefreshSpice.Location = new System.Drawing.Point(12, 46);
            this.btnRefreshSpice.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshSpice.Name = "btnRefreshSpice";
            this.btnRefreshSpice.Size = new System.Drawing.Size(75, 25);
            this.btnRefreshSpice.TabIndex = 0;
            this.btnRefreshSpice.Text = "刷新状态";
            this.btnRefreshSpice.UseVisualStyleBackColor = false;
            this.btnRefreshSpice.Click += new System.EventHandler(this.btnRefreshSpice_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnUpdateFirewall);
            this.groupBox4.Controls.Add(this.txtRdpPort);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.btnChangeRdpPort);
            this.groupBox4.Controls.Add(this.btnToggleRDP);
            this.groupBox4.Controls.Add(this.lblRdpStatus);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(12, 17);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(223, 110);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "RDP服务";
            // 
            // btnUpdateFirewall
            // 
            this.btnUpdateFirewall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnUpdateFirewall.FlatAppearance.BorderSize = 0;
            this.btnUpdateFirewall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateFirewall.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdateFirewall.ForeColor = System.Drawing.Color.White;
            this.btnUpdateFirewall.Location = new System.Drawing.Point(121, 71);
            this.btnUpdateFirewall.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateFirewall.Name = "btnUpdateFirewall";
            this.btnUpdateFirewall.Size = new System.Drawing.Size(91, 25);
            this.btnUpdateFirewall.TabIndex = 5;
            this.btnUpdateFirewall.Text = "更新防火墙";
            this.btnUpdateFirewall.UseVisualStyleBackColor = false;
            this.btnUpdateFirewall.Click += new System.EventHandler(this.btnUpdateFirewall_Click);
            // 
            // txtRdpPort
            // 
            this.txtRdpPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRdpPort.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRdpPort.Location = new System.Drawing.Point(64, 44);
            this.txtRdpPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtRdpPort.Name = "txtRdpPort";
            this.txtRdpPort.Size = new System.Drawing.Size(53, 23);
            this.txtRdpPort.TabIndex = 1;
            this.txtRdpPort.Text = "3389";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(4, 46);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "RDP端口：";
            // 
            // btnChangeRdpPort
            // 
            this.btnChangeRdpPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnChangeRdpPort.FlatAppearance.BorderSize = 0;
            this.btnChangeRdpPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeRdpPort.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChangeRdpPort.ForeColor = System.Drawing.Color.White;
            this.btnChangeRdpPort.Location = new System.Drawing.Point(121, 41);
            this.btnChangeRdpPort.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeRdpPort.Name = "btnChangeRdpPort";
            this.btnChangeRdpPort.Size = new System.Drawing.Size(91, 26);
            this.btnChangeRdpPort.TabIndex = 3;
            this.btnChangeRdpPort.Text = "修改端口";
            this.btnChangeRdpPort.UseVisualStyleBackColor = false;
            this.btnChangeRdpPort.Click += new System.EventHandler(this.btnChangeRdpPort_Click);
            // 
            // btnToggleRDP
            // 
            this.btnToggleRDP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnToggleRDP.FlatAppearance.BorderSize = 0;
            this.btnToggleRDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleRDP.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnToggleRDP.ForeColor = System.Drawing.Color.White;
            this.btnToggleRDP.Location = new System.Drawing.Point(7, 71);
            this.btnToggleRDP.Margin = new System.Windows.Forms.Padding(2);
            this.btnToggleRDP.Name = "btnToggleRDP";
            this.btnToggleRDP.Size = new System.Drawing.Size(91, 25);
            this.btnToggleRDP.TabIndex = 0;
            this.btnToggleRDP.Text = "开启/关闭";
            this.btnToggleRDP.UseVisualStyleBackColor = false;
            this.btnToggleRDP.Click += new System.EventHandler(this.btnToggleRDP_Click);
            // 
            // lblRdpStatus
            // 
            this.lblRdpStatus.AutoSize = true;
            this.lblRdpStatus.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRdpStatus.Location = new System.Drawing.Point(4, 18);
            this.lblRdpStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRdpStatus.Name = "lblRdpStatus";
            this.lblRdpStatus.Size = new System.Drawing.Size(80, 17);
            this.lblRdpStatus.TabIndex = 1;
            this.lblRdpStatus.Text = "状态：获取中";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(11, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pxvdi Tools";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // vmid
            // 
            this.vmid.AutoSize = true;
            this.vmid.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.vmid.Location = new System.Drawing.Point(391, 31);
            this.vmid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmid.Name = "vmid";
            this.vmid.Size = new System.Drawing.Size(89, 17);
            this.vmid.TabIndex = 15;
            this.vmid.Text = "未获取到VMID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 5);
            this.panel1.TabIndex = 16;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vmid);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pxvdi Tools";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabComputer.ResumeLayout(false);
            this.tabComputer.PerformLayout();
            this.tabSysprep.ResumeLayout(false);
            this.tabSysprep.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabOptimize.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabService.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabComputer;
        private System.Windows.Forms.TabPage tabSysprep;
        private System.Windows.Forms.TabPage tabOptimize;
        private System.Windows.Forms.TabPage tabService;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label vmid;
     //  private System.Windows.Forms.TextBox pcnamebox;
        
        // 计算机管理选项卡
        private System.Windows.Forms.TextBox domainbox;
        private System.Windows.Forms.Label domainname;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox userbox;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.Button joindomainbut;
        private System.Windows.Forms.Button leavedomainbut;
        private System.Windows.Forms.Button btnChangePassword;
        
        // 系统封装选项卡
        private System.Windows.Forms.TextBox txtPCNamePrefix;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkDomainSysprep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDomainPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDomainUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDomainName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkSkipOOBE;
        private System.Windows.Forms.Button btnSysprep;
        
        // 系统优化选项卡
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoPerformance;
        private System.Windows.Forms.RadioButton rdoAppearance;
        private System.Windows.Forms.Button btnApplyVisual;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBestPerformance;
        private System.Windows.Forms.Button btnDisableHibernate;
        private System.Windows.Forms.Button btnDisableDefender;
        private System.Windows.Forms.Button btnExternalOptimizer;
        
        // PXVDI服务选项卡
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblRdpStatus;
        private System.Windows.Forms.Button btnToggleRDP;
        private System.Windows.Forms.TextBox txtRdpPort;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnChangeRdpPort;
        private System.Windows.Forms.Button btnUpdateFirewall;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblSpiceService;
        private System.Windows.Forms.Button btnRefreshSpice;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblQemuAgent;
        private System.Windows.Forms.Button btnRefreshQemuAgent;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblPxvdiMonitor;
        private System.Windows.Forms.Button btnRefreshPxvdiMonitor;
        private System.Windows.Forms.Label pcname;
        private System.Windows.Forms.TextBox pcnamebox;
        private System.Windows.Forms.Panel panel1;
    }
}

