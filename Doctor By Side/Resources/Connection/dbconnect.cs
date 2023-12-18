using BCrypt.Net;
using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Doctor_By_Side.Resources
{
    internal class DBConnect
    {
        private string con_host;
        private string user_db;
        private string pass_db;
        private string host_db;

        public DBConnect(string host = "DB_HOST_DEFAULT") {
            user_db = "USER_DB";
            pass_db = "PASS_DB";
            host_db = host;
            con_host = "SERVER=" + host_db + ";DATABASE=DB_NAME;UID=" + user_db + ";PASSWORD=" + pass_db + ";";
        }

        public string[] Authen_Nurse(string user_input, string pass_input)
        {
            MySqlConnection conn = new MySqlConnection(con_host);
            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ไม่สามารถเชื่อมต่อไปยังฐานข้อมูล โปรดตรวจสอบการเชื่อมต่อหรือที่อยู่โฮสต์", "Doctor By Side", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
            string query_string = "SELECT * FROM admin_nurse WHERE user='" + user_input + "';";
            MySqlCommand cmd = new MySqlCommand(query_string, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read()){
                string name = reader.GetValue(3).ToString();
                string roles = reader.GetValue(4).ToString();
                string pass = reader.GetValue(2).ToString();
                if (BCrypt.Net.BCrypt.Verify(pass_input, pass)){
                    string[] return_val = new string[3];
                    return_val[0] = user_input;
                    return_val[1] = name;
                    return_val[2] = roles;
                    return return_val;
                }
                else{
                    MessageBox.Show("รหัสผ่านไม่ถูกต้อง", "Doctor By Side", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }

            }
            else{
                MessageBox.Show("ไม่พบชื่อผู้ใช้งานดังกล่าวในฐานระบบ", "Doctor By Side", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

        }
        public bool Open()
        {
            MySqlConnection conn = new MySqlConnection(con_host);
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ไม่สามารถเชื่อมต่อไปยังฐานข้อมูล โปรดตรวจสอบการเชื่อมต่อหรือที่อยู่โฮสต์", "Doctor By Side", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
