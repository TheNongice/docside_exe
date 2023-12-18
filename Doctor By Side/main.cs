using Doctor_By_Side.Resources.nurse_screen;
using Doctor_By_Side.Resources.screen.nurse_screen;
using System;
using System.Windows.Forms;

namespace Doctor_By_Side
{
    public partial class main : Form
    {
        string[] data_login;
        string host_ip;
        bool ask_sign_out = true;
        bool activities = true;
        public main(string[] session_data, string ip)
        {
            InitializeComponent();
            data_login = session_data;
            host_ip = ip;
            this.Text = "Doctor By Side - "+ data_login[1] +" ("+ data_login[2] +")";
        }

        private void main_Load(object sender, EventArgs e)
        {
            host_tip.Text = "เชื่อมต่อไปที่: "+host_ip;
            user_logintip.Text = " ผู้ใช้งาน: " + data_login[0];
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("ต้องการออกจากระบบหรือไม่?", "Doctor By Side", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (ask == DialogResult.Yes)
            {
                Login_Screen authen = new Login_Screen();
                authen.Show();
                notifyIcon2.BalloonTipTitle = "Doctor By Side";
                notifyIcon2.BalloonTipText = "ออกจากระบบเสร็จสิ้น";
                notifyIcon2.ShowBalloonTip(1000);
                ask_sign_out = false;
                this.Close();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            check_treatment mdi = new check_treatment();
            mdi.MdiParent = this;
            mdi.Show();
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && ask_sign_out == true)
            {
                DialogResult ask = MessageBox.Show("ต้องการออกจากโปรแกรมใช่หรือไม่?","Doctor By Side",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
                if (ask != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void closeall_mdi_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("ต้องการปิดหน้าต่างทั้งหมดหรือไม่?","Doctor By Side", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (ask == DialogResult.Yes)
            {
                foreach (Form c in this.MdiChildren)
                {
                    c.Close();
                }
            }
        }

        private void reg_patient_Click(object sender, EventArgs e)
        {
            add_tretment add_Tretment = new add_tretment();
            add_Tretment.MdiParent = this;
            add_Tretment.Show();
        }

    }
}
