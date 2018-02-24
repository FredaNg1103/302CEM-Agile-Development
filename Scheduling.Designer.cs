namespace CnL_Scheduling
{
    partial class Scheduling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scheduling));
            this.WelcomeMessage = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CCL_List = new System.Windows.Forms.ComboBox();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.Classroom_rdb = new System.Windows.Forms.RadioButton();
            this.Course_rdb = new System.Windows.Forms.RadioButton();
            this.Lecturer_rdb = new System.Windows.Forms.RadioButton();
            this.Schedule_lv = new System.Windows.Forms.ListView();
            this.Line = new System.Windows.Forms.Label();
            this.RadioMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeMessage.Location = new System.Drawing.Point(146, 10);
            this.WelcomeMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(292, 20);
            this.WelcomeMessage.TabIndex = 3;
            this.WelcomeMessage.Text = "Welcome, User";
            this.WelcomeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("LogoutBtn.Image")));
            this.LogoutBtn.Location = new System.Drawing.Point(442, 10);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(60, 65);
            this.LogoutBtn.TabIndex = 2;
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(418, 568);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(85, 34);
            this.BackBtn.TabIndex = 17;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(38, 81);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(63, 24);
            this.DateLabel.TabIndex = 18;
            this.DateLabel.Text = "Date : ";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(103, 81);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(172, 26);
            this.dateTimePicker.TabIndex = 19;
            this.dateTimePicker.Value = new System.DateTime(2018, 2, 22, 2, 8, 51, 0);
            // 
            // CCL_List
            // 
            this.CCL_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCL_List.FormattingEnabled = true;
            this.CCL_List.Location = new System.Drawing.Point(41, 163);
            this.CCL_List.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CCL_List.Name = "CCL_List";
            this.CCL_List.Size = new System.Drawing.Size(234, 30);
            this.CCL_List.TabIndex = 21;
            // 
            // CheckBtn
            // 
            this.CheckBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBtn.Location = new System.Drawing.Point(304, 160);
            this.CheckBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(85, 34);
            this.CheckBtn.TabIndex = 22;
            this.CheckBtn.Text = "Check";
            this.CheckBtn.UseVisualStyleBackColor = true;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // Classroom_rdb
            // 
            this.Classroom_rdb.AutoSize = true;
            this.Classroom_rdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Classroom_rdb.Location = new System.Drawing.Point(41, 121);
            this.Classroom_rdb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Classroom_rdb.Name = "Classroom_rdb";
            this.Classroom_rdb.Size = new System.Drawing.Size(117, 28);
            this.Classroom_rdb.TabIndex = 0;
            this.Classroom_rdb.TabStop = true;
            this.Classroom_rdb.Text = "Classroom";
            this.Classroom_rdb.UseVisualStyleBackColor = true;
            this.Classroom_rdb.CheckedChanged += new System.EventHandler(this.Classroom_rdb_CheckedChanged);
            // 
            // Course_rdb
            // 
            this.Course_rdb.AutoSize = true;
            this.Course_rdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_rdb.Location = new System.Drawing.Point(158, 121);
            this.Course_rdb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Course_rdb.Name = "Course_rdb";
            this.Course_rdb.Size = new System.Drawing.Size(89, 28);
            this.Course_rdb.TabIndex = 1;
            this.Course_rdb.TabStop = true;
            this.Course_rdb.Text = "Course";
            this.Course_rdb.UseVisualStyleBackColor = true;
            this.Course_rdb.CheckedChanged += new System.EventHandler(this.Course_rdb_CheckedChanged);
            // 
            // Lecturer_rdb
            // 
            this.Lecturer_rdb.AutoSize = true;
            this.Lecturer_rdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lecturer_rdb.Location = new System.Drawing.Point(247, 121);
            this.Lecturer_rdb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Lecturer_rdb.Name = "Lecturer_rdb";
            this.Lecturer_rdb.Size = new System.Drawing.Size(97, 28);
            this.Lecturer_rdb.TabIndex = 23;
            this.Lecturer_rdb.TabStop = true;
            this.Lecturer_rdb.Text = "Lecturer";
            this.Lecturer_rdb.UseVisualStyleBackColor = true;
            this.Lecturer_rdb.CheckedChanged += new System.EventHandler(this.Lecturer_rdb_CheckedChanged);
            // 
            // Schedule_lv
            // 
            this.Schedule_lv.Location = new System.Drawing.Point(9, 264);
            this.Schedule_lv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Schedule_lv.Name = "Schedule_lv";
            this.Schedule_lv.Size = new System.Drawing.Size(494, 292);
            this.Schedule_lv.TabIndex = 24;
            this.Schedule_lv.UseCompatibleStateImageBehavior = false;
            this.Schedule_lv.View = System.Windows.Forms.View.Details;
            // 
            // Line
            // 
            this.Line.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Line.Location = new System.Drawing.Point(9, 242);
            this.Line.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(494, 2);
            this.Line.TabIndex = 25;
            // 
            // RadioMessage
            // 
            this.RadioMessage.AutoSize = true;
            this.RadioMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioMessage.ForeColor = System.Drawing.Color.Red;
            this.RadioMessage.Location = new System.Drawing.Point(38, 196);
            this.RadioMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RadioMessage.Name = "RadioMessage";
            this.RadioMessage.Size = new System.Drawing.Size(0, 20);
            this.RadioMessage.TabIndex = 29;
            // 
            // Scheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 597);
            this.Controls.Add(this.RadioMessage);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.Schedule_lv);
            this.Controls.Add(this.Lecturer_rdb);
            this.Controls.Add(this.Course_rdb);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.Classroom_rdb);
            this.Controls.Add(this.CCL_List);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.WelcomeMessage);
            this.Controls.Add(this.LogoutBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Scheduling";
            this.Text = "Scheduling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeMessage;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox CCL_List;
        private System.Windows.Forms.Button CheckBtn;
        private System.Windows.Forms.RadioButton Classroom_rdb;
        private System.Windows.Forms.RadioButton Course_rdb;
        private System.Windows.Forms.RadioButton Lecturer_rdb;
        private System.Windows.Forms.ListView Schedule_lv;
        private System.Windows.Forms.Label Line;
        private System.Windows.Forms.Label RadioMessage;
    }
}