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

namespace CnL_Scheduling
{
    public partial class Login : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=cnl_scheduling;User Id=root;password=''");

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Function()
        {
            if ((UserTextBox.Text != string.Empty || UserTextBox.Text != "") && (PassTextBox.Text != string.Empty || PassTextBox.Text != ""))
            {
                UserMessage.Text = "";
                PassMessage.Text = "";
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM user WHERE user_name = @user and user_password = @pass";
                cmd.Parameters.AddWithValue("@user", UserTextBox.Text);
                cmd.Parameters.AddWithValue("@pass", PassTextBox.Text);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                int user_exist = Convert.ToInt32(dt.Rows.Count.ToString());

                if (user_exist > 0)
                {
                    this.Hide();
                    if (dt.Rows[0]["user_role"].ToString() == "1")
                    {
                        HomePage homepage_Page = new HomePage(dt.Rows[0]["user_role"].ToString(), dt.Rows[0]["user_name"].ToString());
                        homepage_Page.Show();
                    }
                    else if (dt.Rows[0]["user_role"].ToString() == "2")
                    {
                        Scheduling scheduling_Page = new Scheduling(dt.Rows[0]["user_role"].ToString(), dt.Rows[0]["user_name"].ToString());
                        scheduling_Page.Show();
                    }
                }

                else
                {
                    LoginMessage.Text = "User doesn't exist!";
                }
                con.Close();
            }

            else if ((UserTextBox.Text == string.Empty || UserTextBox.Text == "") && (PassTextBox.Text == string.Empty || PassTextBox.Text == ""))
            {
                UserMessage.Text = "Please enter your username.";
                PassMessage.Text = "Please enter your password.";
            }

            if (UserTextBox.Text == string.Empty || UserTextBox.Text == "")
            {
                UserMessage.Text = "Please enter your username.";
            }

            else if (UserTextBox.Text != string.Empty || UserTextBox.Text != "")
            {
                UserMessage.Text = "";
            }

            if (PassTextBox.Text == string.Empty || PassTextBox.Text == "")
            {
                PassMessage.Text = "Please enter your password.";
            }

            else if (PassTextBox.Text != string.Empty || PassTextBox.Text != "")
            {
                PassMessage.Text = "";
            }

        }

        private void UserTextBox_Leave(object sender, EventArgs e)
        {
            if (UserTextBox.Text == string.Empty || UserTextBox.Text == "")
            {
                UserMessage.Text = "Please enter your username.";
            }
            else
            {
                UserMessage.Text = "";
            }
        }

        private void PassTextBox_Leave(object sender, EventArgs e)
        {
            if (PassTextBox.Text == string.Empty || PassTextBox.Text == "")
            {
                PassMessage.Text = "Please enter your password.";
            }
            else
            {
                PassMessage.Text = "";
            }
        }       

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Login_Function();
        }

        private void UserTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Login_Function();
            }
        }

        private void PassTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_Function();
            }
        }
    }
}
