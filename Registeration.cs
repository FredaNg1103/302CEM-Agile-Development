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

namespace CnL_Scheduling
{
    public partial class Registeration : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=cnl_scheduling;User Id=root;password=''");
        string user_role = string.Empty;
        string user_name = string.Empty;
        input_info user_input = new input_info();
        DataTable cl;

        public class input_info
        {
            public string dtp { get; set; }
            public string dst { get; set; }
            public string det { get; set; }
            public int lecturer_index { get; set; }
            public int course_index { get; set; }
            public string capacity { get; set; }
        }

        public Registeration(string ur, string un)
        {
            InitializeComponent();
            user_role = ur;
            user_name = un;                      
            Init_Com();
        }

        private void Init_Com()
        {
            GreedingMsg_function(user_role, user_name);
            String[] timeArray1 = { "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00" };
            String[] timeArray2 = { "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00" };
            dateTimePicker.MinDate = DateTime.Now;
            Duration_Start_List.DataSource = timeArray1;
            Duration_End_List.DataSource = timeArray2;
            Get_Course();
            Get_Lecturer();
        }

        private void Get_Course()
        {           
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT course_id, course_name FROM course";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            Course_List.DataSource = dt;
            Course_List.ValueMember = "course_id";
            Course_List.DisplayMember = "course_name";
            con.Close();
        }

        private void Get_Lecturer()
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT user_id, user_name FROM user";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            Lecturer_List.DataSource = dt;
            Lecturer_List.ValueMember = "user_id";
            Lecturer_List.DisplayMember = "user_name";
            con.Close();
        }

        private void Get_ClassroomInfo(int index, DataTable cl)
        {
            if (cl.Rows[index]["classroom_type"].ToString() == "1")
            {
                CT_Message.Text = "Classroom";
            }
            else if (cl.Rows[index]["classroom_type"].ToString() == "2")
            {
                CT_Message.Text = "Lab";
            }

            CU_Message.Text = cl.Rows[index]["utility_name"].ToString();
            MSC_Message.Text = cl.Rows[index]["classroom_capacity"].ToString();
        }

        private bool Register_Validation()
        {
            bool validation = false;
            if (user_input.dtp != dateTimePicker.Value.ToString("yyyy-MM-dd "))
            {
                validation = true;
            }
           
            if (user_input.dst != Duration_Start_List.SelectedItem.ToString())
            {
                validation = true;
            }

            if (user_input.det != Duration_End_List.SelectedItem.ToString())
            {
                validation = true;
            }

            if (user_input.lecturer_index != Lecturer_List.SelectedIndex)
            {
                validation = true;
            }

            if (user_input.course_index != Course_List.SelectedIndex)
            {
                validation = true;
            }

            if (user_input.capacity != CapacityTextBox.Text)
            {
                validation = true;
            }

            return validation;
        }

        private void Get_UserInfo()
        {
            user_input.dtp = dateTimePicker.Value.ToString("yyyy-MM-dd ");
            user_input.dst = Duration_Start_List.SelectedItem.ToString();
            user_input.det = Duration_End_List.SelectedItem.ToString();
            user_input.lecturer_index = Lecturer_List.SelectedIndex;
            user_input.course_index = Course_List.SelectedIndex;
            user_input.capacity = CapacityTextBox.Text;
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
                this.Hide();
                Login login_Page = new Login();
                login_Page.Show();
            }
        }

        private void Search_function()
        {
            bool validation = false;
            string st = string.Empty;
            string et = string.Empty;
            if (Duration_End_List.SelectedIndex - Duration_Start_List.SelectedIndex <= 0)
            {
                TimeMessage.Text = "Invalid time input!";
                validation = true;
            }
            else
            {
                int duration = Duration_End_List.SelectedIndex - Duration_Start_List.SelectedIndex;
                st = dateTimePicker.Value.ToString("yyyy-MM-dd ") + Duration_Start_List.SelectedItem.ToString();
                et = dateTimePicker.Value.ToString("yyyy-MM-dd ") + Duration_End_List.SelectedItem.ToString();
            }

            if (CapacityTextBox.Text == string.Empty || CapacityTextBox.Text == "")
            {
                CapacityMessage.Text = "No input!";
                validation = true;
            }

            if (validation == false)
            {
                TimeMessage.Text = "";
                CapacityMessage.Text = "";
                Get_UserInfo();
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT DISTINCT classroom.classroom_id, classroom.classroom_name, classroom.classroom_capacity, classroom.classroom_type, utility.utility_name " +
                                  "FROM classroom " +
                                  "LEFT JOIN schedule ON schedule.classroom_id = classroom.classroom_id " +
                                  "INNER JOIN classroom_utility ON classroom.classroom_id = classroom_utility.classroom_id " +
                                  "INNER JOIN utility ON classroom_utility.utility_id = utility.utility_id " +
                                  "WHERE COALESCE(@start_time NOT BETWEEN schedule.schedule_datetime_start AND schedule.schedule_datetime_end, TRUE) " +
                                  "AND COALESCE(@end_time NOT BETWEEN schedule.schedule_datetime_start AND schedule.schedule_datetime_end, TRUE) " +
                                  //"AND COALESCE(schedule.user_id != @lecturer, TRUE) " +
                                  "AND classroom.classroom_capacity >= @capacity " +
                                  "AND classroom_utility.utility_id = ANY(SELECT course_utility.utility_id FROM course_utility WHERE course_utility.course_id = @course)";
                cmd.Parameters.AddWithValue("@start_time", st);
                cmd.Parameters.AddWithValue("@end_time", et);
                //cmd.Parameters.AddWithValue("@lecturer", Lecturer_List.SelectedValue);
                cmd.Parameters.AddWithValue("@capacity", CapacityTextBox.Text);
                cmd.Parameters.AddWithValue("@course", Course_List.SelectedValue);
                cmd.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                cl = new DataTable();
                da.Fill(cl);
                Classroom_List.DataSource = cl;
                Classroom_List.ValueMember = "classroom_id";
                Classroom_List.DisplayMember = "classroom_name";
                Get_ClassroomInfo(Classroom_List.SelectedIndex, cl);
                con.Close();
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Search_function();           
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if(!Register_Validation())
            {
                Classroom_ListMessage.Text = "";
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO schedule(classroom_id, course_id, user_id, schedule_datetime_start, schedule_datetime_end) " +
                    "VALUES(@classroom_id, @course_id, @user_id, @datestart, @dateend)";
                cmd.Parameters.AddWithValue("@classroom_id", Classroom_List.SelectedValue);
                cmd.Parameters.AddWithValue("@course_id", Course_List.SelectedValue);
                cmd.Parameters.AddWithValue("@user_id", Lecturer_List.SelectedValue);
                cmd.Parameters.AddWithValue("@datestart", dateTimePicker.Value.ToString("yyyy-MM-dd ") + Duration_Start_List.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@dateend", dateTimePicker.Value.ToString("yyyy-MM-dd ") + Duration_End_List.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                con.Close();
                Search_function();
                MessageBox.Show("Register Successful.");
            }
            
            else
            {
                Classroom_ListMessage.Text = "Input about had changed, press search button again.";
                MessageBox.Show("Input about had changed, press search button again.");
            }

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login_Page = new Login();
            login_Page.Show();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (user_role == "1")
            {
                HomePage homepage_Page = new HomePage(user_role, user_name);
                homepage_Page.Show();
            }
            else
            {
                this.Hide();
                Login login_Page = new Login();
                login_Page.Show();
            }
        }

        private void CapacityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Classroom_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            Get_ClassroomInfo(Classroom_List.SelectedIndex, cl);
        }
    }
}
