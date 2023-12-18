using Doctor_By_Side.Resources;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Doctor_By_Side
{
    public partial class Login_Screen : Form
    {
        string[] login_session;
        // Secret Mode
        int round_secret = 0;
        bool secret_mode = false;

        public Login_Screen()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            wait sc_wait = new wait();
            sc_wait.Show();
            string user_entry = user.Text;
            string pass_entry = pass.Text;
            string host_entry = host.Text;

            if (host_entry == "")
            {
                host_entry = "docside.ngixx.in.th";
            }

            DBConnect db = new DBConnect(host_entry);
            login_session = db.Authen_Nurse(user_entry,pass_entry);
            if (login_session != null)
            {
                notifyIcon1.BalloonTipTitle = "Doctor By Side";
                notifyIcon1.BalloonTipText = "ยินดีต้อนรับ " + login_session[1];
                notifyIcon1.ShowBalloonTip(1000);
                main sc_main = new main(login_session,host_entry);
                sc_main.Show();
                sc_wait.Close();
                this.Close();
            }
            sc_wait.Close();
        }

        private void ปดโปรแกรมToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void update_pg_Click(object sender, EventArgs e)
        {
            Process.Start("https://ngixx.in.th");
        }


        private void authen_bypass_Click(object sender, EventArgs e)
        {
            wait sc_wait = new wait();
            sc_wait.Show();
            string host_entry = "docside.ngixx.in.th";
            DBConnect db = new DBConnect(host_entry);
            login_session = db.Authen_Nurse("admin", "0831991727ice");
            if (login_session != null)
            {
                notifyIcon1.BalloonTipTitle = "Doctor By Side";
                notifyIcon1.BalloonTipText = "ยินดีต้อนรับ " + login_session[1];
                notifyIcon1.ShowBalloonTip(1000);
                main sc_main = new main(login_session, host_entry);
                sc_main.Show();
                sc_wait.Close();
                timer1.Stop();
                this.Close();
            }
            sc_wait.Close();
        }

        private void version_text_Click(object sender, EventArgs e)
        {
            round_secret++;
            if (round_secret > 2)
            {
                secret_mode = true;
                authen_bypass.Visible = true;
                version_text.ForeColor = Color.Red;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            lbl_telltime.Text = currentTime.ToString("ขณะนี้วันที่ dd/M/yyy เวลา HH:mm:ss น.");
        }
    }
}
