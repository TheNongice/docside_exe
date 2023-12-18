using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Doctor_By_Side.Resources;
using Org.BouncyCastle.Utilities.Encoders;

namespace Doctor_By_Side.Resources.screen.nurse_screen
{
    public partial class add_tretment : Form
    {
        public string server = "DB_HOST_DEFAULT";
        public string db = "DB_NAME";
        public string user = "USER_DB";
        public string pass_db = "PASS_DB";
        public bool drugMode = false;
        public bool sleepMode = false;
        public add_tretment()
        {
            InitializeComponent();
        }

        public void load_patientData()
        {
            submit.Enabled = false;
            roomSleep_check.SelectedIndex = -1;
            roomSleep_check.Items.Clear();
            string users = idStd.Text;
            
            if (users == ""){
                MessageBox.Show("กรุณาอย่าเว้นช่องว่าง", "Doctor By Side", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            string connect_string = "SERVER=" + server + ";DATABASE=" + db + ";UID=" + user + ";PASSWORD=" + pass_db + ";";
            MySqlConnection conn = new MySqlConnection(connect_string);

            string query = "SELECT * FROM student_info WHERE id_std='" + users + "';";
            wait wait_sc = new wait();
            try
            {
                wait_sc.Show();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string Name = reader.GetValue(1).ToString() + " " + reader.GetValue(2).ToString();
                    string Class = reader.GetValue(3).ToString();
                    DateTime Birthday = (DateTime)reader.GetValue(4);
                    string Birthdays = (string)Birthday.ToString("dd/MM/yyyy");
                    string Sex = reader.GetValue(5).ToString();
                    string Weight = reader.GetValue(6).ToString();
                    string Height = reader.GetValue(7).ToString();
                    string Allegery = reader.GetValue(8).ToString();
                    string Disease = reader.GetValue(9).ToString();
                    patient_name.Text = Name;
                    patient_class.Text = Class;
                    if (Allegery == ""){
                        allegery.Text = "-";
                    }
                    else{
                        allegery.Text = Allegery;
                    }
                    if (Disease == ""){
                        disease.Text = "-";
                    }
                    else{
                        disease.Text = Disease;
                    }
                    weight_height_zone.Text = Weight + " กก. " + Height + " ซม.";
                    birth_patient.Text = Birthdays;
                    patient_zone.Visible = true;

                    conn.Close();
                    conn.Open();
                    // Load room data
                    string query_room = "SELECT * FROM room WHERE room_sex='" + Sex + "';";
                    MySqlCommand cmd_sex = new MySqlCommand(query_room, conn);
                    MySqlDataReader reader_sex = cmd_sex.ExecuteReader();
                    while (reader_sex.Read())
                    {
                        roomSleep_check.Items.Add(reader_sex.GetValue(1).ToString());
                    }
                    conn.Close();

                    submit.Enabled = true;
                }
                else
                {
                    MessageBox.Show("ไม่พบข้อมูลของเลขประจำตัวดังกล่าว โปรดตรวจสอบอีกครั้ง!","Doctor By Side", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    patient_zone.Visible = false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("ไม่สามารถติดต่อไปยังเซิร์ฟเวอร์ได้ ณ ขณะนี้", "Doctor By Side", MessageBoxButtons.OK, MessageBoxIcon.Error);
                patient_zone.Visible = false;
            }

            wait_sc.Close();
        }

        private void drug_check_Click(object sender, EventArgs e)
        {
            drugMode = true;
            drugZone.Visible = true;
            sleepZone.Visible = false;
            pauseperiod_st.Value = 0;
            pauseperiod_nd.Value = 0;
            sleepMode = true;
        }

        private void sleep_check_Click(object sender, EventArgs e)
        {
            sleepMode = true;
            drugZone.Visible = false;
            sleepZone.Visible = true;
            drugWant.Text = "";
            drugMode = false;
        }

        private void idStd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                load_patientData();
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            int pause_st = (int) pauseperiod_nd.Value;
            int pause_nd = (int) pauseperiod_st.Value;
            
            if (sleepMode == true && pause_st < pause_nd){
                MessageBox.Show("คาบที่เข้าพักต้องมากกว่าคาบที่ออก","Doctor By Side",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }

            MessageBox.Show("เก่งมาก กล้ามาก ขอบใจ", "Docotr By Side", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
