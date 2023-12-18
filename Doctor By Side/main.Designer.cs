namespace Doctor_By_Side
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.host_tip = new System.Windows.Forms.ToolStripStatusLabel();
            this.user_logintip = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.closeall_mdi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.reg_patient = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.host_tip,
            this.user_logintip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 626);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1304, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // host_tip
            // 
            this.host_tip.Image = global::Doctor_By_Side.Properties.Resources.net_globe;
            this.host_tip.Name = "host_tip";
            this.host_tip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.host_tip.RightToLeftAutoMirrorImage = true;
            this.host_tip.Size = new System.Drawing.Size(149, 17);
            this.host_tip.Text = "เชื่อมต่อไปที่: host_name";
            // 
            // user_logintip
            // 
            this.user_logintip.Image = global::Doctor_By_Side.Properties.Resources.user;
            this.user_logintip.Name = "user_logintip";
            this.user_logintip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.user_logintip.Size = new System.Drawing.Size(47, 17);
            this.user_logintip.Text = "user";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.reg_patient,
            this.toolStripButton2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1304, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolStripLabel1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeall_mdi});
            this.toolStripLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Image = global::Doctor_By_Side.Properties.Resources.logo_a;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(116, 22);
            this.toolStripLabel1.Text = "Doctor By Side";
            // 
            // closeall_mdi
            // 
            this.closeall_mdi.Name = "closeall_mdi";
            this.closeall_mdi.Size = new System.Drawing.Size(180, 22);
            this.closeall_mdi.Text = "ปิดหน้าต่างทั้งหมด";
            this.closeall_mdi.Click += new System.EventHandler(this.closeall_mdi_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // reg_patient
            // 
            this.reg_patient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.reg_patient.Image = ((System.Drawing.Image)(resources.GetObject("reg_patient.Image")));
            this.reg_patient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reg_patient.Name = "reg_patient";
            this.reg_patient.Size = new System.Drawing.Size(106, 22);
            this.reg_patient.Text = "+ เพิ่มทะเบียนรักษา";
            this.reg_patient.ToolTipText = "เพิ่มทะเบียนรักษา";
            this.reg_patient.Click += new System.EventHandler(this.reg_patient_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton2.Text = "ทะเบียนรักษา";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.toolStripButton1.Image = global::Doctor_By_Side.Properties.Resources.shutdown;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(89, 22);
            this.toolStripButton1.Text = "ออกจากระบบ";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon2.Icon")));
            this.notifyIcon2.Text = "notifyIcon1";
            this.notifyIcon2.Visible = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1304, 648);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.Load += new System.EventHandler(this.main_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel host_tip;
        private System.Windows.Forms.ToolStripStatusLabel user_logintip;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem closeall_mdi;
        private System.Windows.Forms.ToolStripButton reg_patient;

    }
}