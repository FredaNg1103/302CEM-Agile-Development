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
    public partial class Scheduling : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=cnl_scheduling;User Id=root;password=''");
        string user_role = string.Empty;
        string user_name = string.Empty;        
        public Scheduling(string ur, string un)
        {
            InitializeComponent();
            user_role = ur;
            user_name = un;
            GreedingMsg_function(user_role, user_name);
        }

        private void Init_Com()
        {
            Classroom_rdb.Checked = true;
            Get_CnCInfo();         
        }

        private void Get_CnCInfo()
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();

            if (Classroom_rdb.Checked)
            {
                cmd.CommandText = "SELECT classroom_id, classroom_name FROM classroom";
                cmd.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                CCL_List.DataSource = dt;
                CCL_List.ValueMember = "classroom_id";
                CCL_List.DisplayMember = "classroom_name";
            }
            else if (Course_rdb.Checked)
            {
                cmd.CommandText = "SELECT course_id, course_name FROM course";
                cmd.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                CCL_List.DataSource = dt;
                CCL_List.ValueMember = "course_id";
                CCL_List.DisplayMember = "course_name";
            }
            else if (Lecturer_rdb.Checked)
            {
                cmd.CommandText = "SELECT user_id, user_name FROM user";
                cmd.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                CCL_List.DataSource = dt;
                CCL_List.ValueMember = "user_id";
                CCL_List.DisplayMember = "user_name";
            }
            con.Close();
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

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login_Page = new Login();
            login_Page.Show();
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            if(!Classroom_rdb.Checked && !Course_rdb.Checked && !Lecturer_rdb.Checked)
            {
                RadioMessage.Text = "Please select one of the radio button.";
            }

            else
            {
                RadioMessage.Text = "";
                Schedule_lv.Columns.Clear();
                Schedule_lv.Items.Clear();
                ListViewItem items;
                con.Open();
                if(Classroom_rdb.Checked)
                {                    
                    MySqlCommand cmd = new MySqlCommand("SELECT user.user_name as 'Lecturer', course.course_name as 'Course', DATE_FORMAT(schedule.schedule_datetime_start, '%H:%i') AS 'Start Time', DATE_FORMAT(schedule.schedule_datetime_end, '%H:%i') as 'End Time' " +
                                                        "FROM schedule " +
                                                        "INNER JOIN user ON user.user_id = schedule.user_id " +
                                                        "INNER JOIN course ON course.course_id = schedule.course_id " +
                                                        "WHERE schedule.classroom_id = @ccl " +
                                                        "AND DATE_FORMAT(schedule.schedule_datetime_start, '%Y-%m-%d') = @date", con);
                    cmd.Parameters.AddWithValue("@ccl", CCL_List.SelectedValue);
                    cmd.Parameters.AddWithValue("@date", dateTimePicker.Value.ToString("yyyy-MM-dd"));
                    MySqlDataReader dr = cmd.ExecuteReader();

                    Schedule_lv.Columns.Add("Lecturer", 120, HorizontalAlignment.Left);
                    Schedule_lv.Columns.Add("Course", 165, HorizontalAlignment.Left);
                    Schedule_lv.Columns.Add("Start Time", 115, HorizontalAlignment.Left);
                    Schedule_lv.Columns.Add("End Time", 115, HorizontalAlignment.Left);

                    while (dr.Read())
                    {
                        items = new ListViewItem(dr["Lecturer"].ToString());
                        items.SubItems.Add(dr["Course"].ToString());
                        items.SubItems.Add(dr["Start Time"].ToString());
                        items.SubItems.Add(dr["End Time"].ToString());
                        Schedule_lv.Items.Add(items);
                    }
                }

                else if(Course_rdb.Checked)
                {                   
                    MySqlCommand cmd = new MySqlCommand("SELECT user.user_name as 'Lecturer', classroom.classroom_name as 'Classroom', DATE_FORMAT(schedule.schedule_datetime_start, '%H:%i') AS 'Start Time', DATE_FORMAT(schedule.schedule_datetime_end, '%H:%i') as 'End Time' " +
                                                        "FROM schedule " +
                                                        "INNER JOIN user ON user.user_id = schedule.user_id " +
                                                        "INNER JOIN classroom ON classroom.classroom_id = schedule.classroom_id " +
                                                        "WHERE schedule.course_id = @ccl " +
                                                        "AND DATE_FORMAT(schedule.schedule_datetime_start, '%Y-%m-%d') = @date", con);
                    cmd.Parameters.AddWithValue("@ccl", CCL_List.SelectedValue);
                    cmd.Parameters.AddWithValue("@date", dateTimePicker.Value.ToString("yyyy-MM-dd"));
                    MySqlDataReader dr = cmd.ExecuteReader();

                    Schedule_lv.Columns.Add("Lecturer", 120, HorizontalAlignment.Left);
                    Schedule_lv.Columns.Add("Classroom", 165, HorizontalAlignment.Left);
                    Schedule_lv.Columns.Add("Start Time", 115, HorizontalAlignment.Left);
                    Schedule_lv.Columns.Add("End Time", 115, HorizontalAlignment.Left);

                    while (dr.Read())
                    {
                        items = new ListViewItem(dr["Lecturer"].ToString());
                        items.SubItems.Add(dr["Classroom"].ToString());
                        items.SubItems.Add(dr["Start Time"].ToString());
                        items.SubItems.Add(dr["End Time"].ToString());
                        Schedule_lv.Items.Add(items);
                    }
                }

                else if(Lecturer_rdb.Checked)
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT course.course_name as 'Course', classroom.classroom_name as 'Classroom', DATE_FORMAT(schedule.schedule_datetime_start, '%H:%i') AS 'Start Time', DATE_FORMAT(schedule.schedule_datetime_end, '%H:%i') as 'End Time' " +
                                                        "FROM schedule " +
                                                        "INNER JOIN course ON course.course_id = schedule.course_id " +
                                                        "INNER JOIN classroom ON classroom.classroom_id = schedule.classroom_id " +
                                                        "AND schedule.user_id  = @ccl " +
                                                        "AND DATE_FORMAT(schedule.schedule_datetime_start, '%Y-%m-%d') = @date", con);
                    cmd.Parameters.AddWithValue("@ccl", CCL_List.SelectedValue);
                    cmd.Parameters.AddWithValue("@date", dateTimePicker.Value.ToString("yyyy-MM-dd"));
                    MySqlDataReader dr = cmd.ExecuteReader();

                    Schedule_lv.Columns.Add("Course", 120, HorizontalAlignment.Left);
                    Schedule_lv.Columns.Add("Classroom", 165, HorizontalAlignment.Left);
                    Schedule_lv.Columns.Add("Start Time", 115, HorizontalAlignment.Left);
                    Schedule_lv.Columns.Add("End Time", 115, HorizontalAlignment.Left);

                    while (dr.Read())
                    {
                        items = new ListViewItem(dr["Course"].ToString());
                        items.SubItems.Add(dr["Classroom"].ToString());
                        items.SubItems.Add(dr["Start Time"].ToString());
                        items.SubItems.Add(dr["End Time"].ToString());
                        Schedule_lv.Items.Add(items);
                    }
                }

                con.Close();
            }
        }

        private void Classroom_rdb_CheckedChanged(object sender, EventArgs e)
        {         
            Get_CnCInfo();
        }

        private void Course_rdb_CheckedChanged(object sender, EventArgs e)
        {           
            Get_CnCInfo();
        }

        private void Lecturer_rdb_CheckedChanged(object sender, EventArgs e)
        {
            Get_CnCInfo();
        }

        
    }
}
