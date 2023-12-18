namespace Doctor_By_Side.Resources.nurse_screen
{
    partial class check_treatment
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
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.lbl_tell = new System.Windows.Forms.Label();
            this.patient_mode = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchall_date = new System.Windows.Forms.CheckBox();
            this.date_picker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.patients_picker = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idStd_picker = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid1
            // 
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Location = new System.Drawing.Point(18, 161);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(1379, 545);
            this.grid1.TabIndex = 0;
            this.grid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid1_CellClick);
            // 
            // lbl_tell
            // 
            this.lbl_tell.AutoSize = true;
            this.lbl_tell.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_tell.Location = new System.Drawing.Point(12, 34);
            this.lbl_tell.Name = "lbl_tell";
            this.lbl_tell.Size = new System.Drawing.Size(239, 31);
            this.lbl_tell.TabIndex = 1;
            this.lbl_tell.Text = "ขณะนี้คุณกำลังเลือก: -";
            // 
            // patient_mode
            // 
            this.patient_mode.AutoSize = true;
            this.patient_mode.Location = new System.Drawing.Point(18, 69);
            this.patient_mode.Name = "patient_mode";
            this.patient_mode.Size = new System.Drawing.Size(118, 13);
            this.patient_mode.TabIndex = 3;
            this.patient_mode.Text = "อยู่ในการรักษาประเภท:";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.PaleGreen;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.submit.Location = new System.Drawing.Point(1252, 40);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(136, 66);
            this.submit.TabIndex = 4;
            this.submit.Text = "แสดงข้อมูล";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchall_date);
            this.groupBox1.Controls.Add(this.date_picker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.patients_picker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.idStd_picker);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(569, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "กรองการค้นหา";
            // 
            // searchall_date
            // 
            this.searchall_date.AutoSize = true;
            this.searchall_date.Location = new System.Drawing.Point(339, 60);
            this.searchall_date.Name = "searchall_date";
            this.searchall_date.Size = new System.Drawing.Size(148, 17);
            this.searchall_date.TabIndex = 6;
            this.searchall_date.Text = "ค้นหาประวัติทุกวันที่บันทึก";
            this.searchall_date.UseVisualStyleBackColor = true;
            // 
            // date_picker
            // 
            this.date_picker.Location = new System.Drawing.Point(430, 24);
            this.date_picker.Name = "date_picker";
            this.date_picker.Size = new System.Drawing.Size(200, 20);
            this.date_picker.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "วันที่บันทึกประวัติ";
            // 
            // patients_picker
            // 
            this.patients_picker.FormattingEnabled = true;
            this.patients_picker.Items.AddRange(new object[] {
            "ทั้งหมด",
            "ขอนอนพัก",
            "ขอยา"});
            this.patients_picker.Location = new System.Drawing.Point(113, 65);
            this.patients_picker.Name = "patients_picker";
            this.patients_picker.Size = new System.Drawing.Size(200, 21);
            this.patients_picker.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ประเภทการรักษา";
            // 
            // idStd_picker
            // 
            this.idStd_picker.Location = new System.Drawing.Point(113, 27);
            this.idStd_picker.Name = "idStd_picker";
            this.idStd_picker.Size = new System.Drawing.Size(200, 20);
            this.idStd_picker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "เลขประจำตัว";
            // 
            // check_treatment
            // 
            this.AcceptButton = this.submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1409, 718);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.patient_mode);
            this.Controls.Add(this.lbl_tell);
            this.Controls.Add(this.grid1);
            this.Name = "check_treatment";
            this.Text = "ตรวจสอบทะเบียนรักษา";
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid1;
        private System.Windows.Forms.Label lbl_tell;
        private System.Windows.Forms.Label patient_mode;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox patients_picker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idStd_picker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_picker;
        private System.Windows.Forms.CheckBox searchall_date;
    }
}