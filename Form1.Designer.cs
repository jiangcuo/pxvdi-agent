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
            this.sysprepbut = new System.Windows.Forms.Button();
            this.joindomainbut = new System.Windows.Forms.Button();
            this.domainbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.leavedomainbut = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pcnamebox = new System.Windows.Forms.TextBox();
            this.renamepcbut = new System.Windows.Forms.Button();
            this.vmid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sysprepbut
            // 
            this.sysprepbut.Location = new System.Drawing.Point(514, 468);
            this.sysprepbut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sysprepbut.Name = "sysprepbut";
            this.sysprepbut.Size = new System.Drawing.Size(136, 50);
            this.sysprepbut.TabIndex = 0;
            this.sysprepbut.Text = "封装系统";
            this.sysprepbut.UseVisualStyleBackColor = true;
            this.sysprepbut.Click += new System.EventHandler(this.button1_Click);
            // 
            // joindomainbut
            // 
            this.joindomainbut.Location = new System.Drawing.Point(56, 468);
            this.joindomainbut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.joindomainbut.Name = "joindomainbut";
            this.joindomainbut.Size = new System.Drawing.Size(136, 50);
            this.joindomainbut.TabIndex = 3;
            this.joindomainbut.Text = "加域";
            this.joindomainbut.UseVisualStyleBackColor = true;
            this.joindomainbut.Click += new System.EventHandler(this.joindomainbut_Click);
            // 
            // domainbox
            // 
            this.domainbox.Location = new System.Drawing.Point(224, 144);
            this.domainbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.domainbox.Name = "domainbox";
            this.domainbox.Size = new System.Drawing.Size(238, 35);
            this.domainbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "域名：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "用户：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // userbox
            // 
            this.userbox.Location = new System.Drawing.Point(224, 206);
            this.userbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userbox.Name = "userbox";
            this.userbox.Size = new System.Drawing.Size(238, 35);
            this.userbox.TabIndex = 6;
            this.userbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 266);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "密码：";
            // 
            // passbox
            // 
            this.passbox.Location = new System.Drawing.Point(226, 264);
            this.passbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(236, 35);
            this.passbox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 16F);
            this.label4.Location = new System.Drawing.Point(214, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 43);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pxvdi Agent";
            // 
            // leavedomainbut
            // 
            this.leavedomainbut.Location = new System.Drawing.Point(212, 468);
            this.leavedomainbut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leavedomainbut.Name = "leavedomainbut";
            this.leavedomainbut.Size = new System.Drawing.Size(136, 50);
            this.leavedomainbut.TabIndex = 11;
            this.leavedomainbut.Text = "脱域";
            this.leavedomainbut.UseVisualStyleBackColor = true;
            this.leavedomainbut.Click += new System.EventHandler(this.leavedomainbut_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 330);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "计算机名：";
            // 
            // pcnamebox
            // 
            this.pcnamebox.Location = new System.Drawing.Point(224, 328);
            this.pcnamebox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcnamebox.Name = "pcnamebox";
            this.pcnamebox.Size = new System.Drawing.Size(238, 35);
            this.pcnamebox.TabIndex = 13;
            this.pcnamebox.TextChanged += new System.EventHandler(this.pcnamebox_TextChanged);
            // 
            // renamepcbut
            // 
            this.renamepcbut.Location = new System.Drawing.Point(496, 328);
            this.renamepcbut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.renamepcbut.Name = "renamepcbut";
            this.renamepcbut.Size = new System.Drawing.Size(122, 46);
            this.renamepcbut.TabIndex = 14;
            this.renamepcbut.Text = "更改";
            this.renamepcbut.UseVisualStyleBackColor = true;
            this.renamepcbut.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // vmid
            // 
            this.vmid.AutoSize = true;
            this.vmid.Location = new System.Drawing.Point(222, 84);
            this.vmid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vmid.Name = "vmid";
            this.vmid.Size = new System.Drawing.Size(154, 24);
            this.vmid.TabIndex = 15;
            this.vmid.Text = "未获取到VMID";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 496);
            this.Controls.Add(this.vmid);
            this.Controls.Add(this.renamepcbut);
            this.Controls.Add(this.pcnamebox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.leavedomainbut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.domainbox);
            this.Controls.Add(this.joindomainbut);
            this.Controls.Add(this.sysprepbut);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(690, 567);
            this.MinimumSize = new System.Drawing.Size(690, 567);
            this.Name = "Start";
            this.Text = "Pxvdi-agent";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sysprepbut;
        private System.Windows.Forms.Button joindomainbut;
        private System.Windows.Forms.TextBox domainbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button leavedomainbut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pcnamebox;
        private System.Windows.Forms.Button renamepcbut;
        private System.Windows.Forms.Label vmid;
    }
}

