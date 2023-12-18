using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Doctor_By_Side.Resources;
using System.Threading;
using System.Globalization;


namespace Doctor_By_Side.Resources.nurse_screen
{
    public partial class check_treatment : Form
    {
        public string server = "DB_HOST_DEFAULT";
        public string db = "DB_NAME";
        public string user = "USER_DB";
        public string pass_db = "PASS_DB";
        public check_treatment()
        {
            InitializeComponent();           
        }

        private void grid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grid1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    //grid1.CurrentRow.Selected = true;
                    string users = grid1.Rows[e.RowIndex].Cells["เลขประจำตัว"].FormattedValue.ToString();
                    string patients_mode = grid1.Rows[e.RowIndex].Cells["ประเภทบริการ"].FormattedValue.ToString();

                    string connect_string = "SERVER=" + server + ";DATABASE=" + db + ";UID=" + user + ";PASSWORD=" + pass_db + ";";

                    MySqlConnection conn = new MySqlConnection(connect_string);
                    conn.Open();

                    string query = "SELECT * FROM student_info WHERE id_std=" + users + ";";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    try
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            string name = reader.GetValue(1).ToString() + " " + reader.GetValue(2).ToString();
                            lbl_tell.Text = "ขณะนี้คุณกำลังเลือก: " + name;
                            patient_mode.Text = "อยู่ในการรักษาประเภท: " + patients_mode;
                        }
                    }
                    catch (Exception err)
                    {

                    }
                    conn.Close();
                }
            }
            catch (Exception err)
            {

            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string patient_sql = "";
            string idStd_sql = "";
            string timestamp_sql = "";
            string query;

            wait sc_wait = new wait();
            sc_wait.Show();

            string id_std = idStd_picker.Text;
         
            string patient_picker = "";
            try{
                if (patients_picker.SelectedItem != null)
                {
                    patient_picker = patients_picker.SelectedItem.ToString();
                }
            }
            catch (Exception ex) {
                // patient_picker = "";

            }

            DateTime date = date_picker.Value;
            bool search_all = searchall_date.Checked;

            if (patient_picker != ""){
                if (patient_picker != "ทั้งหมด") { 
                    patient_sql = "type_service = '" + patient_picker + "' &&";
                }
            }

            if (id_std != ""){
                idStd_sql = "id_std = " + id_std+" &&";
            }
            else
            {
                id_std = "id_std &&";
            }

            if (search_all == true){
                timestamp_sql = "timestamp";
            }else{
                timestamp_sql = "timestamp LIKE '%" + date.ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US")) + "%'";
            }

            if (patient_sql == "" && idStd_sql == "" && timestamp_sql == ""){
                query = "SELECT id_std AS 'เลขประจำตัว', type_service AS 'ประเภทบริการ', reason AS 'เหตุผล' , status AS 'สถานะ', timestamp AS 'วันเวลาที่ทำรายการ' FROM treatment WHERE 1;";
            }
            else
            {
                query = "SELECT id_std AS 'เลขประจำตัว', type_service AS 'ประเภทบริการ', reason AS 'เหตุผล' , status AS 'สถานะ', timestamp AS 'วันเวลาที่ทำรายการ' FROM treatment WHERE " + patient_sql + " " + idStd_sql + " " + timestamp_sql + ";";
            }

            string connect_string = "SERVER=" + server + ";DATABASE=" + db + ";UID=" + user + ";PASSWORD=" + pass_db + ";";
             
            MySqlConnection conn = new MySqlConnection(connect_string);
            conn.Open();


            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            
            DataTable table = new DataTable();
            table.Load(reader);
            if (table.Rows.Count < 1)
            {
                MessageBox.Show("ไม่พบข้อมูลจากตัวกรองดังกล่าว", "Doctor By Side", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            grid1.DataSource = table;

            conn.Close();
            sc_wait.Close();
        }
    }
}
