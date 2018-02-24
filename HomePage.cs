using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CnL_Scheduling
{
    public partial class HomePage : Form
    {
        string user_role = string.Empty ;
        string user_name = string.Empty ;
        public HomePage(string ur, string un)
        {
            InitializeComponent();
            user_role = ur;
            user_name = un;
            GreedingMsg_function(user_role, user_name);
        }

        private void GreedingMsg_function(string user_role, string user_name)
        {
            if (user_role == string.Empty || user_role == "" || user_role == "0")
            {
                this.Hide();
                Login login_Page = new Login();
                login_Page.Show();
            }

            if (user_name != string.Empty || user_name != "")
            {
                WelcomeMessage.Text = "Welcome, " + user_name;
            }

            else
            {
                WelcomeMessage.Text = "Welcome.";
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registeration registeration_Page = new Registeration(user_role, user_name);
            registeration_Page.Show();
        }

        private void ScheduleBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Scheduling scheduling_Page = new Scheduling(user_role, user_name);
            scheduling_Page.Show();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login_Page = new Login();
            login_Page.Show();
        }
    }
}
