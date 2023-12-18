namespace Doctor_By_Side
{
    partial class Login_Screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Screen));
            this.label1 = new System.Windows.Forms.Label();
            this.version_text = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.host = new System.Windows.Forms.TextBox();
            this.user_text = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menu_tooldown = new System.Windows.Forms.ToolStripDropDownButton();
            this.update_pg = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_pg = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.authen_bypass = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorBySidePCSHSSTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_telltime = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "หมอเคียงคุณ";
            // 
            // version_text
            // 
            this.version_text.AutoSize = true;
            this.version_text.Location = new System.Drawing.Point(706, 499);
            this.version_text.Name = "version_text";
            this.version_text.Size = new System.Drawing.Size(71, 13);
            this.version_text.TabIndex = 2;
            this.version_text.Text = "V 0.0.1 Alpha";
            this.version_text.Click += new System.EventHandler(this.version_text_Click);
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.OliveDrab;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.submit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submit.Location = new System.Drawing.Point(154, 253);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(137, 49);
            this.submit.TabIndex = 4;
            this.submit.Text = "เข้าสู่ระบบ";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.user);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.host);
            this.groupBox1.Controls.Add(this.user_text);
            this.groupBox1.Controls.Add(this.pass);
            this.groupBox1.Controls.Add(this.submit);
            this.groupBox1.Location = new System.Drawing.Point(330, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 356);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authen Zone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(44, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Username:";
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.user.Location = new System.Drawing.Point(47, 72);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(331, 23);
            this.user.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(44, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Host:";
            // 
            // host
            // 
            this.host.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.host.Location = new System.Drawing.Point(47, 197);
            this.host.Name = "host";
            this.host.Size = new System.Drawing.Size(331, 23);
            this.host.TabIndex = 3;
            // 
            // user_text
            // 
            this.user_text.AutoSize = true;
            this.user_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.user_text.Location = new System.Drawing.Point(44, 112);
            this.user_text.Name = "user_text";
            this.user_text.Size = new System.Drawing.Size(73, 17);
            this.user_text.TabIndex = 5;
            this.user_text.Text = "Password:";
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pass.Location = new System.Drawing.Point(47, 132);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(331, 23);
            this.pass.TabIndex = 2;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Doctor By Side";
            this.notifyIcon1.Visible = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_tooldown});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(789, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menu_tooldown
            // 
            this.menu_tooldown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menu_tooldown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.update_pg,
            this.exit_pg,
            this.toolStripSeparator1,
            this.authen_bypass,
            this.doctorBySidePCSHSSTToolStripMenuItem});
            this.menu_tooldown.Image = ((System.Drawing.Image)(resources.GetObject("menu_tooldown.Image")));
            this.menu_tooldown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_tooldown.Name = "menu_tooldown";
            this.menu_tooldown.Size = new System.Drawing.Size(50, 22);
            this.menu_tooldown.Text = "จัดการ";
            // 
            // update_pg
            // 
            this.update_pg.Image = global::Doctor_By_Side.Properties.Resources.update;
            this.update_pg.Name = "update_pg";
            this.update_pg.Size = new System.Drawing.Size(210, 22);
            this.update_pg.Text = "ตรวจสอบอัพเดต";
            this.update_pg.Click += new System.EventHandler(this.update_pg_Click);
            // 
            // exit_pg
            // 
            this.exit_pg.Image = global::Doctor_By_Side.Properties.Resources.shutdown;
            this.exit_pg.Name = "exit_pg";
            this.exit_pg.Size = new System.Drawing.Size(210, 22);
            this.exit_pg.Text = "ปิดโปรแกรม";
            this.exit_pg.Click += new System.EventHandler(this.ปดโปรแกรมToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // authen_bypass
            // 
            this.authen_bypass.Name = "authen_bypass";
            this.authen_bypass.Size = new System.Drawing.Size(210, 22);
            this.authen_bypass.Text = "Bypass Login";
            this.authen_bypass.Visible = false;
            this.authen_bypass.Click += new System.EventHandler(this.authen_bypass_Click);
            // 
            // doctorBySidePCSHSSTToolStripMenuItem
            // 
            this.doctorBySidePCSHSSTToolStripMenuItem.Enabled = false;
            this.doctorBySidePCSHSSTToolStripMenuItem.Name = "doctorBySidePCSHSSTToolStripMenuItem";
            this.doctorBySidePCSHSSTToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.doctorBySidePCSHSSTToolStripMenuItem.Text = "Doctor By Side (PCSHSST)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Doctor_By_Side.Properties.Resources.logo_a;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Doctor_By_Side.Properties.Resources.logo_a;
            this.pictureBox1.Location = new System.Drawing.Point(14, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 288);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_telltime
            // 
            this.lbl_telltime.AutoSize = true;
            this.lbl_telltime.Location = new System.Drawing.Point(13, 498);
            this.lbl_telltime.Name = "lbl_telltime";
            this.lbl_telltime.Size = new System.Drawing.Size(35, 13);
            this.lbl_telltime.TabIndex = 6;
            this.lbl_telltime.Text = "label4";
            // 
            // Login_Screen
            // 
            this.AcceptButton = this.submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(789, 521);
            this.Controls.Add(this.lbl_telltime);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.version_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor By Side";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label version_text;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox host;
        private System.Windows.Forms.Label user_text;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton menu_tooldown;
        private System.Windows.Forms.ToolStripMenuItem update_pg;
        private System.Windows.Forms.ToolStripMenuItem exit_pg;
        private System.Windows.Forms.ToolStripMenuItem authen_bypass;
        private System.Windows.Forms.ToolStripMenuItem doctorBySidePCSHSSTToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_telltime;
    }
}

