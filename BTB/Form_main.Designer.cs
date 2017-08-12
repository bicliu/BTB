namespace BTB
{
    partial class Form_main
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
            this.btn_searchUSB = new System.Windows.Forms.Button();
            this.gb_prepare = new System.Windows.Forms.GroupBox();
            this.btn_power = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_usblist = new System.Windows.Forms.ComboBox();
            this.tb_show = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_get_LD = new System.Windows.Forms.Button();
            this.btn_get_PD = new System.Windows.Forms.Button();
            this.btn_get_ROPD = new System.Windows.Forms.Button();
            this.tb_LD = new System.Windows.Forms.TextBox();
            this.tb_PD = new System.Windows.Forms.TextBox();
            this.tb_ROPD = new System.Windows.Forms.TextBox();
            this.tb_ROPD_S = new System.Windows.Forms.TextBox();
            this.gb_prepare.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_searchUSB
            // 
            this.btn_searchUSB.Location = new System.Drawing.Point(17, 20);
            this.btn_searchUSB.Name = "btn_searchUSB";
            this.btn_searchUSB.Size = new System.Drawing.Size(75, 23);
            this.btn_searchUSB.TabIndex = 0;
            this.btn_searchUSB.Text = "搜索USB";
            this.btn_searchUSB.UseVisualStyleBackColor = true;
            this.btn_searchUSB.Click += new System.EventHandler(this.btn_searchUSB_Click);
            // 
            // gb_prepare
            // 
            this.gb_prepare.Controls.Add(this.btn_power);
            this.gb_prepare.Controls.Add(this.label2);
            this.gb_prepare.Controls.Add(this.label1);
            this.gb_prepare.Controls.Add(this.cbb_usblist);
            this.gb_prepare.Controls.Add(this.btn_searchUSB);
            this.gb_prepare.Location = new System.Drawing.Point(31, 8);
            this.gb_prepare.Name = "gb_prepare";
            this.gb_prepare.Size = new System.Drawing.Size(427, 60);
            this.gb_prepare.TabIndex = 1;
            this.gb_prepare.TabStop = false;
            this.gb_prepare.Text = "准备";
            // 
            // btn_power
            // 
            this.btn_power.Location = new System.Drawing.Point(359, 19);
            this.btn_power.Name = "btn_power";
            this.btn_power.Size = new System.Drawing.Size(46, 23);
            this.btn_power.TabIndex = 4;
            this.btn_power.Text = "OFF";
            this.btn_power.UseVisualStyleBackColor = true;
            this.btn_power.Click += new System.EventHandler(this.btn_power_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "电源";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "选择USB设备";
            // 
            // cbb_usblist
            // 
            this.cbb_usblist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_usblist.FormattingEnabled = true;
            this.cbb_usblist.Location = new System.Drawing.Point(180, 22);
            this.cbb_usblist.Name = "cbb_usblist";
            this.cbb_usblist.Size = new System.Drawing.Size(111, 20);
            this.cbb_usblist.TabIndex = 1;
            this.cbb_usblist.SelectedIndexChanged += new System.EventHandler(this.cbb_usblist_SelectedIndexChanged);
            // 
            // tb_show
            // 
            this.tb_show.Location = new System.Drawing.Point(524, 25);
            this.tb_show.Multiline = true;
            this.tb_show.Name = "tb_show";
            this.tb_show.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_show.Size = new System.Drawing.Size(481, 138);
            this.tb_show.TabIndex = 2;
            this.tb_show.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(31, 214);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(974, 371);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(966, 345);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_ROPD_S);
            this.groupBox1.Controls.Add(this.tb_ROPD);
            this.groupBox1.Controls.Add(this.tb_PD);
            this.groupBox1.Controls.Add(this.tb_LD);
            this.groupBox1.Controls.Add(this.btn_get_ROPD);
            this.groupBox1.Controls.Add(this.btn_get_PD);
            this.groupBox1.Controls.Add(this.btn_get_LD);
            this.groupBox1.Location = new System.Drawing.Point(31, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 134);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "测试";
            // 
            // btn_get_LD
            // 
            this.btn_get_LD.Location = new System.Drawing.Point(17, 20);
            this.btn_get_LD.Name = "btn_get_LD";
            this.btn_get_LD.Size = new System.Drawing.Size(75, 23);
            this.btn_get_LD.TabIndex = 0;
            this.btn_get_LD.Text = "LD";
            this.btn_get_LD.UseVisualStyleBackColor = true;
            this.btn_get_LD.Click += new System.EventHandler(this.btn_get_LD_Click);
            // 
            // btn_get_PD
            // 
            this.btn_get_PD.Location = new System.Drawing.Point(17, 57);
            this.btn_get_PD.Name = "btn_get_PD";
            this.btn_get_PD.Size = new System.Drawing.Size(75, 23);
            this.btn_get_PD.TabIndex = 1;
            this.btn_get_PD.Text = "PD";
            this.btn_get_PD.UseVisualStyleBackColor = true;
            this.btn_get_PD.Click += new System.EventHandler(this.btn_get_PD_Click);
            // 
            // btn_get_ROPD
            // 
            this.btn_get_ROPD.Location = new System.Drawing.Point(17, 94);
            this.btn_get_ROPD.Name = "btn_get_ROPD";
            this.btn_get_ROPD.Size = new System.Drawing.Size(75, 23);
            this.btn_get_ROPD.TabIndex = 2;
            this.btn_get_ROPD.Text = "RO_PD";
            this.btn_get_ROPD.UseVisualStyleBackColor = true;
            this.btn_get_ROPD.Click += new System.EventHandler(this.btn_get_ROPD_Click);
            // 
            // tb_LD
            // 
            this.tb_LD.Location = new System.Drawing.Point(123, 20);
            this.tb_LD.Name = "tb_LD";
            this.tb_LD.Size = new System.Drawing.Size(100, 21);
            this.tb_LD.TabIndex = 3;
            // 
            // tb_PD
            // 
            this.tb_PD.Location = new System.Drawing.Point(123, 57);
            this.tb_PD.Name = "tb_PD";
            this.tb_PD.Size = new System.Drawing.Size(100, 21);
            this.tb_PD.TabIndex = 4;
            // 
            // tb_ROPD
            // 
            this.tb_ROPD.Location = new System.Drawing.Point(123, 96);
            this.tb_ROPD.Name = "tb_ROPD";
            this.tb_ROPD.Size = new System.Drawing.Size(100, 21);
            this.tb_ROPD.TabIndex = 5;
            // 
            // tb_ROPD_S
            // 
            this.tb_ROPD_S.Location = new System.Drawing.Point(229, 96);
            this.tb_ROPD_S.Name = "tb_ROPD_S";
            this.tb_ROPD_S.Size = new System.Drawing.Size(100, 21);
            this.tb_ROPD_S.TabIndex = 6;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 616);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tb_show);
            this.Controls.Add(this.gb_prepare);
            this.Name = "Form_main";
            this.Text = "Bosa Testing";
            this.gb_prepare.ResumeLayout(false);
            this.gb_prepare.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_searchUSB;
        private System.Windows.Forms.GroupBox gb_prepare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_usblist;
        private System.Windows.Forms.TextBox tb_show;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_power;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_ROPD;
        private System.Windows.Forms.TextBox tb_PD;
        private System.Windows.Forms.TextBox tb_LD;
        private System.Windows.Forms.Button btn_get_ROPD;
        private System.Windows.Forms.Button btn_get_PD;
        private System.Windows.Forms.Button btn_get_LD;
        private System.Windows.Forms.TextBox tb_ROPD_S;
    }
}

