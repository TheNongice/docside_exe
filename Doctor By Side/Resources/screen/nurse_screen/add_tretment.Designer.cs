namespace Doctor_By_Side.Resources.screen.nurse_screen
{
    partial class add_tretment
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
            this.label1 = new System.Windows.Forms.Label();
            this.idStd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reason_list = new System.Windows.Forms.ComboBox();
            this.sleep_check = new System.Windows.Forms.RadioButton();
            this.drug_check = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.sleepZone = new System.Windows.Forms.GroupBox();
            this.roomSleep_check = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pauseperiod_nd = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.pauseperiod_st = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.drugZone = new System.Windows.Forms.GroupBox();
            this.drugWant = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.patient_zone = new System.Windows.Forms.GroupBox();
            this.birth_patient = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.weight_height_zone = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.disease = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.allegery = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.patient_class = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.patient_name = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.sleepZone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pauseperiod_nd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseperiod_st)).BeginInit();
            this.drugZone.SuspendLayout();
            this.patient_zone.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "เลขประจำตัว";
            // 
            // idStd
            // 
            this.idStd.Location = new System.Drawing.Point(154, 35);
            this.idStd.Name = "idStd";
            this.idStd.Size = new System.Drawing.Size(181, 20);
            this.idStd.TabIndex = 1;
            this.idStd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.idStd_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "อาการ/สาเหตุ";
            // 
            // reason_list
            // 
            this.reason_list.FormattingEnabled = true;
            this.reason_list.Items.AddRange(new object[] {
            "ป่วย/ไข้ ไม่สบายตัว",
            "ท้องเสีย",
            "เพลีย/อ่อนล้า",
            "อื่น ๆ"});
            this.reason_list.Location = new System.Drawing.Point(153, 134);
            this.reason_list.Name = "reason_list";
            this.reason_list.Size = new System.Drawing.Size(182, 21);
            this.reason_list.TabIndex = 4;
            // 
            // sleep_check
            // 
            this.sleep_check.AutoSize = true;
            this.sleep_check.Location = new System.Drawing.Point(154, 111);
            this.sleep_check.Name = "sleep_check";
            this.sleep_check.Size = new System.Drawing.Size(74, 17);
            this.sleep_check.TabIndex = 5;
            this.sleep_check.TabStop = true;
            this.sleep_check.Text = "ขอนอนพัก";
            this.sleep_check.UseVisualStyleBackColor = true;
            this.sleep_check.Click += new System.EventHandler(this.sleep_check_Click);
            // 
            // drug_check
            // 
            this.drug_check.AutoSize = true;
            this.drug_check.Location = new System.Drawing.Point(154, 88);
            this.drug_check.Name = "drug_check";
            this.drug_check.Size = new System.Drawing.Size(62, 17);
            this.drug_check.TabIndex = 6;
            this.drug_check.TabStop = true;
            this.drug_check.Text = "ขอรับยา";
            this.drug_check.UseVisualStyleBackColor = true;
            this.drug_check.Click += new System.EventHandler(this.drug_check_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ประเภทการขอรับบริการ";
            // 
            // sleepZone
            // 
            this.sleepZone.Controls.Add(this.roomSleep_check);
            this.sleepZone.Controls.Add(this.label8);
            this.sleepZone.Controls.Add(this.label7);
            this.sleepZone.Controls.Add(this.pauseperiod_nd);
            this.sleepZone.Controls.Add(this.label6);
            this.sleepZone.Controls.Add(this.pauseperiod_st);
            this.sleepZone.Controls.Add(this.label5);
            this.sleepZone.Location = new System.Drawing.Point(691, 35);
            this.sleepZone.Name = "sleepZone";
            this.sleepZone.Size = new System.Drawing.Size(284, 120);
            this.sleepZone.TabIndex = 8;
            this.sleepZone.TabStop = false;
            this.sleepZone.Text = "สำหรับขอนอนพัก";
            this.sleepZone.Visible = false;
            // 
            // roomSleep_check
            // 
            this.roomSleep_check.FormattingEnabled = true;
            this.roomSleep_check.Location = new System.Drawing.Point(57, 76);
            this.roomSleep_check.Name = "roomSleep_check";
            this.roomSleep_check.Size = new System.Drawing.Size(211, 21);
            this.roomSleep_check.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "ห้องพัก";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "คาบที่";
            // 
            // pauseperiod_nd
            // 
            this.pauseperiod_nd.Location = new System.Drawing.Point(179, 44);
            this.pauseperiod_nd.Name = "pauseperiod_nd";
            this.pauseperiod_nd.Size = new System.Drawing.Size(89, 20);
            this.pauseperiod_nd.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "ถึง";
            // 
            // pauseperiod_st
            // 
            this.pauseperiod_st.Location = new System.Drawing.Point(57, 44);
            this.pauseperiod_st.Name = "pauseperiod_st";
            this.pauseperiod_st.Size = new System.Drawing.Size(89, 20);
            this.pauseperiod_st.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "ระยะเวลาต้องการเข้าพัก";
            // 
            // drugZone
            // 
            this.drugZone.Controls.Add(this.drugWant);
            this.drugZone.Controls.Add(this.label4);
            this.drugZone.Location = new System.Drawing.Point(387, 35);
            this.drugZone.Name = "drugZone";
            this.drugZone.Size = new System.Drawing.Size(284, 120);
            this.drugZone.TabIndex = 9;
            this.drugZone.TabStop = false;
            this.drugZone.Text = "สำหรับขอรับยา";
            this.drugZone.Visible = false;
            // 
            // drugWant
            // 
            this.drugWant.Location = new System.Drawing.Point(16, 39);
            this.drugWant.Name = "drugWant";
            this.drugWant.Size = new System.Drawing.Size(262, 56);
            this.drugWant.TabIndex = 1;
            this.drugWant.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ยาที่ต้องการ/คาดหวัง";
            // 
            // patient_zone
            // 
            this.patient_zone.Controls.Add(this.birth_patient);
            this.patient_zone.Controls.Add(this.label15);
            this.patient_zone.Controls.Add(this.weight_height_zone);
            this.patient_zone.Controls.Add(this.label17);
            this.patient_zone.Controls.Add(this.disease);
            this.patient_zone.Controls.Add(this.label11);
            this.patient_zone.Controls.Add(this.allegery);
            this.patient_zone.Controls.Add(this.label13);
            this.patient_zone.Controls.Add(this.patient_class);
            this.patient_zone.Controls.Add(this.label12);
            this.patient_zone.Controls.Add(this.patient_name);
            this.patient_zone.Controls.Add(this.label10);
            this.patient_zone.Controls.Add(this.label9);
            this.patient_zone.Location = new System.Drawing.Point(33, 184);
            this.patient_zone.Name = "patient_zone";
            this.patient_zone.Size = new System.Drawing.Size(926, 352);
            this.patient_zone.TabIndex = 10;
            this.patient_zone.TabStop = false;
            this.patient_zone.Text = "ประวัติผู้เข้าใช้บริการ";
            this.patient_zone.Visible = false;
            // 
            // birth_patient
            // 
            this.birth_patient.AutoSize = true;
            this.birth_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.birth_patient.Location = new System.Drawing.Point(595, 70);
            this.birth_patient.Name = "birth_patient";
            this.birth_patient.Size = new System.Drawing.Size(116, 20);
            this.birth_patient.TabIndex = 12;
            this.birth_patient.Text = "<birth_patient>";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label15.Location = new System.Drawing.Point(493, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 20);
            this.label15.TabIndex = 11;
            this.label15.Text = "วันเกิด";
            // 
            // weight_height_zone
            // 
            this.weight_height_zone.AutoSize = true;
            this.weight_height_zone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.weight_height_zone.Location = new System.Drawing.Point(595, 35);
            this.weight_height_zone.Name = "weight_height_zone";
            this.weight_height_zone.Size = new System.Drawing.Size(327, 20);
            this.weight_height_zone.TabIndex = 10;
            this.weight_height_zone.Text = "<weight_patient> ส่วนสูง <hwight_patient> ซม.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label17.Location = new System.Drawing.Point(493, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 20);
            this.label17.TabIndex = 9;
            this.label17.Text = "น้ำหนัก";
            // 
            // disease
            // 
            this.disease.Cursor = System.Windows.Forms.Cursors.No;
            this.disease.Location = new System.Drawing.Point(599, 112);
            this.disease.Name = "disease";
            this.disease.ReadOnly = true;
            this.disease.Size = new System.Drawing.Size(271, 116);
            this.disease.TabIndex = 8;
            this.disease.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.Location = new System.Drawing.Point(493, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "โรคประจำตัว";
            // 
            // allegery
            // 
            this.allegery.Cursor = System.Windows.Forms.Cursors.No;
            this.allegery.Location = new System.Drawing.Point(160, 112);
            this.allegery.Name = "allegery";
            this.allegery.ReadOnly = true;
            this.allegery.Size = new System.Drawing.Size(271, 116);
            this.allegery.TabIndex = 6;
            this.allegery.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label13.Location = new System.Drawing.Point(26, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "การแพ้ยา/อาหาร";
            // 
            // patient_class
            // 
            this.patient_class.AutoSize = true;
            this.patient_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.patient_class.Location = new System.Drawing.Point(156, 70);
            this.patient_class.Name = "patient_class";
            this.patient_class.Size = new System.Drawing.Size(121, 20);
            this.patient_class.TabIndex = 4;
            this.patient_class.Text = "<class_patient>";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label12.Location = new System.Drawing.Point(26, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "ห้องเรียน";
            // 
            // patient_name
            // 
            this.patient_name.AutoSize = true;
            this.patient_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.patient_name.Location = new System.Drawing.Point(156, 35);
            this.patient_name.Name = "patient_name";
            this.patient_name.Size = new System.Drawing.Size(125, 20);
            this.patient_name.TabIndex = 2;
            this.patient_name.Text = "<name_patient>";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.Location = new System.Drawing.Point(26, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "ชื่อ-สกุล";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(213, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(491, 42);
            this.label9.TabIndex = 0;
            this.label9.Text = "** กรุณาอ่านข้อมูลอย่างถี่ถ้วน **";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.PaleGreen;
            this.submit.Enabled = false;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.submit.Location = new System.Drawing.Point(797, 542);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(162, 48);
            this.submit.TabIndex = 11;
            this.submit.Text = "บันทึกข้อมูล";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(154, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "(กดปุ่ม Enter เพื่อแสดงข้อมูล)";
            // 
            // add_tretment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 600);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.patient_zone);
            this.Controls.Add(this.drugZone);
            this.Controls.Add(this.sleepZone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.drug_check);
            this.Controls.Add(this.sleep_check);
            this.Controls.Add(this.reason_list);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idStd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "add_tretment";
            this.Text = "เพิ่มทะเบียนรักษา";
            this.sleepZone.ResumeLayout(false);
            this.sleepZone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pauseperiod_nd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseperiod_st)).EndInit();
            this.drugZone.ResumeLayout(false);
            this.drugZone.PerformLayout();
            this.patient_zone.ResumeLayout(false);
            this.patient_zone.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idStd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox reason_list;
        private System.Windows.Forms.RadioButton sleep_check;
        private System.Windows.Forms.RadioButton drug_check;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox sleepZone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown pauseperiod_nd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown pauseperiod_st;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox drugZone;
        private System.Windows.Forms.RichTextBox drugWant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox roomSleep_check;
        private System.Windows.Forms.GroupBox patient_zone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.RichTextBox allegery;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label patient_class;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label patient_name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox disease;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label birth_patient;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label weight_height_zone;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
    }
}