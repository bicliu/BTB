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
            this.gb_prepare.SuspendLayout();
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
            this.gb_prepare.Location = new System.Drawing.Point(31, 25);
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
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 616);
            this.Controls.Add(this.tb_show);
            this.Controls.Add(this.gb_prepare);
            this.Name = "Form_main";
            this.Text = "Bosa Testing";
            this.gb_prepare.ResumeLayout(false);
            this.gb_prepare.PerformLayout();
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
    }
}

