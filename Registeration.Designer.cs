namespace CnL_Scheduling
{
    partial class Registeration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registeration));
            this.WelcomeMessage = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.Duration_Start_List = new System.Windows.Forms.ComboBox();
            this.ToLabel = new System.Windows.Forms.Label();
            this.Duration_End_List = new System.Windows.Forms.ComboBox();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.Course_List = new System.Windows.Forms.ComboBox();
            this.CapacityLabel = new System.Windows.Forms.Label();
            this.CapacityTextBox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.Line = new System.Windows.Forms.Label();
            this.Classroom_List = new System.Windows.Forms.ComboBox();
            this.ClassroomLabel = new System.Windows.Forms.Label();
            this.Box = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MSCLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CT_Message = new System.Windows.Forms.Label();
            this.CU_Message = new System.Windows.Forms.Label();
            this.MSC_Message = new System.Windows.Forms.Label();
            this.TimeMessage = new System.Windows.Forms.Label();
            this.CapacityMessage = new System.Windows.Forms.Label();
            this.Classroom_ListMessage = new System.Windows.Forms.Label();
            this.Lecturer_List = new System.Windows.Forms.ComboBox();
            this.LecturerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeMessage.Location = new System.Drawing.Point(304, 12);
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(390, 25);
            this.WelcomeMessage.TabIndex = 3;
            this.WelcomeMessage.Text = "Welcome, User";
            this.WelcomeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("LogoutBtn.Image")));
            this.LogoutBtn.Location = new System.Drawing.Point(700, 12);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(70, 70);
            this.LogoutBtn.TabIndex = 2;
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(78, 80);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(81, 29);
            this.DateLabel.TabIndex = 4;
            this.DateLabel.Text = "Date : ";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(165, 80);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(170, 30);
            this.dateTimePicker.TabIndex = 5;
            this.dateTimePicker.Value = new System.DateTime(2018, 2, 22, 2, 8, 51, 0);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(72, 130);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(87, 29);
            this.TimeLabel.TabIndex = 6;
            this.TimeLabel.Text = "Time : ";
            // 
            // Duration_Start_List
            // 
            this.Duration_Start_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duration_Start_List.FormattingEnabled = true;
            this.Duration_Start_List.Location = new System.Drawing.Point(165, 130);
            this.Duration_Start_List.Name = "Duration_Start_List";
            this.Duration_Start_List.Size = new System.Drawing.Size(121, 33);
            this.Duration_Start_List.TabIndex = 7;
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabel.Location = new System.Drawing.Point(301, 130);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(43, 29);
            this.ToLabel.TabIndex = 8;
            this.ToLabel.Text = "To";
            // 
            // Duration_End_List
            // 
            this.Duration_End_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duration_End_List.FormattingEnabled = true;
            this.Duration_End_List.Location = new System.Drawing.Point(361, 130);
            this.Duration_End_List.Name = "Duration_End_List";
            this.Duration_End_List.Size = new System.Drawing.Size(121, 33);
            this.Duration_End_List.TabIndex = 9;
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseLabel.Location = new System.Drawing.Point(56, 230);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(103, 29);
            this.CourseLabel.TabIndex = 10;
            this.CourseLabel.Text = "Course :";
            // 
            // Course_List
            // 
            this.Course_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_List.FormattingEnabled = true;
            this.Course_List.Location = new System.Drawing.Point(165, 230);
            this.Course_List.Name = "Course_List";
            this.Course_List.Size = new System.Drawing.Size(317, 33);
            this.Course_List.TabIndex = 11;
            // 
            // CapacityLabel
            // 
            this.CapacityLabel.AutoSize = true;
            this.CapacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapacityLabel.Location = new System.Drawing.Point(42, 280);
            this.CapacityLabel.Name = "CapacityLabel";
            this.CapacityLabel.Size = new System.Drawing.Size(117, 29);
            this.CapacityLabel.TabIndex = 12;
            this.CapacityLabel.Text = "Capacity :";
            // 
            // CapacityTextBox
            // 
            this.CapacityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapacityTextBox.Location = new System.Drawing.Point(166, 280);
            this.CapacityTextBox.Name = "CapacityTextBox";
            this.CapacityTextBox.Size = new System.Drawing.Size(202, 30);
            this.CapacityTextBox.TabIndex = 13;
            this.CapacityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CapacityTextBox_KeyPress);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(374, 280);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(108, 34);
            this.SearchBtn.TabIndex = 14;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.Location = new System.Drawing.Point(520, 599);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(131, 42);
            this.RegisterBtn.TabIndex = 15;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(657, 599);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(113, 42);
            this.BackBtn.TabIndex = 16;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Line
            // 
            this.Line.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Line.Location = new System.Drawing.Point(12, 334);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(758, 2);
            this.Line.TabIndex = 17;
            // 
            // Classroom_List
            // 
            this.Classroom_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Classroom_List.FormattingEnabled = true;
            this.Classroom_List.Location = new System.Drawing.Point(166, 358);
            this.Classroom_List.Name = "Classroom_List";
            this.Classroom_List.Size = new System.Drawing.Size(297, 33);
            this.Classroom_List.TabIndex = 19;
            this.Classroom_List.SelectedIndexChanged += new System.EventHandler(this.Classroom_List_SelectedIndexChanged);
            // 
            // ClassroomLabel
            // 
            this.ClassroomLabel.AutoSize = true;
            this.ClassroomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassroomLabel.Location = new System.Drawing.Point(19, 358);
            this.ClassroomLabel.Name = "ClassroomLabel";
            this.ClassroomLabel.Size = new System.Drawing.Size(141, 29);
            this.ClassroomLabel.TabIndex = 18;
            this.ClassroomLabel.Text = "Classroom :";
            // 
            // Box
            // 
            this.Box.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Box.Location = new System.Drawing.Point(12, 452);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(758, 134);
            this.Box.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Classroom Detail :";
            // 
            // MSCLabel
            // 
            this.MSCLabel.AutoSize = true;
            this.MSCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSCLabel.Location = new System.Drawing.Point(20, 534);
            this.MSCLabel.Name = "MSCLabel";
            this.MSCLabel.Size = new System.Drawing.Size(237, 20);
            this.MSCLabel.TabIndex = 22;
            this.MSCLabel.Text = "Maximum Students Capacity : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 504);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Classroom Utility :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Classroom Type :";
            // 
            // CT_Message
            // 
            this.CT_Message.AutoSize = true;
            this.CT_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CT_Message.Location = new System.Drawing.Point(173, 474);
            this.CT_Message.Name = "CT_Message";
            this.CT_Message.Size = new System.Drawing.Size(0, 20);
            this.CT_Message.TabIndex = 25;
            // 
            // CU_Message
            // 
            this.CU_Message.AutoSize = true;
            this.CU_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CU_Message.Location = new System.Drawing.Point(173, 504);
            this.CU_Message.Name = "CU_Message";
            this.CU_Message.Size = new System.Drawing.Size(0, 20);
            this.CU_Message.TabIndex = 26;
            // 
            // MSC_Message
            // 
            this.MSC_Message.AutoSize = true;
            this.MSC_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSC_Message.Location = new System.Drawing.Point(263, 534);
            this.MSC_Message.Name = "MSC_Message";
            this.MSC_Message.Size = new System.Drawing.Size(0, 20);
            this.MSC_Message.TabIndex = 27;
            // 
            // TimeMessage
            // 
            this.TimeMessage.AutoSize = true;
            this.TimeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeMessage.ForeColor = System.Drawing.Color.Red;
            this.TimeMessage.Location = new System.Drawing.Point(503, 134);
            this.TimeMessage.Name = "TimeMessage";
            this.TimeMessage.Size = new System.Drawing.Size(0, 25);
            this.TimeMessage.TabIndex = 28;
            // 
            // CapacityMessage
            // 
            this.CapacityMessage.AutoSize = true;
            this.CapacityMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapacityMessage.ForeColor = System.Drawing.Color.Red;
            this.CapacityMessage.Location = new System.Drawing.Point(503, 285);
            this.CapacityMessage.Name = "CapacityMessage";
            this.CapacityMessage.Size = new System.Drawing.Size(0, 25);
            this.CapacityMessage.TabIndex = 29;
            // 
            // Classroom_ListMessage
            // 
            this.Classroom_ListMessage.AutoEllipsis = true;
            this.Classroom_ListMessage.AutoSize = true;
            this.Classroom_ListMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Classroom_ListMessage.ForeColor = System.Drawing.Color.Red;
            this.Classroom_ListMessage.Location = new System.Drawing.Point(161, 394);
            this.Classroom_ListMessage.Name = "Classroom_ListMessage";
            this.Classroom_ListMessage.Size = new System.Drawing.Size(0, 25);
            this.Classroom_ListMessage.TabIndex = 30;
            // 
            // Lecturer_List
            // 
            this.Lecturer_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lecturer_List.FormattingEnabled = true;
            this.Lecturer_List.Location = new System.Drawing.Point(165, 180);
            this.Lecturer_List.Name = "Lecturer_List";
            this.Lecturer_List.Size = new System.Drawing.Size(317, 33);
            this.Lecturer_List.TabIndex = 32;
            // 
            // LecturerLabel
            // 
            this.LecturerLabel.AutoSize = true;
            this.LecturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LecturerLabel.Location = new System.Drawing.Point(48, 180);
            this.LecturerLabel.Name = "LecturerLabel";
            this.LecturerLabel.Size = new System.Drawing.Size(113, 29);
            this.LecturerLabel.TabIndex = 31;
            this.LecturerLabel.Text = "Lecturer :";
            // 
            // Registeration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 653);
            this.Controls.Add(this.Lecturer_List);
            this.Controls.Add(this.LecturerLabel);
            this.Controls.Add(this.Classroom_ListMessage);
            this.Controls.Add(this.CapacityMessage);
            this.Controls.Add(this.TimeMessage);
            this.Controls.Add(this.MSC_Message);
            this.Controls.Add(this.CU_Message);
            this.Controls.Add(this.CT_Message);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MSCLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.Classroom_List);
            this.Controls.Add(this.ClassroomLabel);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.CapacityTextBox);
            this.Controls.Add(this.CapacityLabel);
            this.Controls.Add(this.Course_List);
            this.Controls.Add(this.CourseLabel);
            this.Controls.Add(this.Duration_End_List);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.Duration_Start_List);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.WelcomeMessage);
            this.Controls.Add(this.LogoutBtn);
            this.Name = "Registeration";
            this.Text = "Registeration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeMessage;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.ComboBox Duration_Start_List;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.ComboBox Duration_End_List;
        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.ComboBox Course_List;
        private System.Windows.Forms.Label CapacityLabel;
        private System.Windows.Forms.TextBox CapacityTextBox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label Line;
        private System.Windows.Forms.ComboBox Classroom_List;
        private System.Windows.Forms.Label ClassroomLabel;
        private System.Windows.Forms.Label Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MSCLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CT_Message;
        private System.Windows.Forms.Label CU_Message;
        private System.Windows.Forms.Label MSC_Message;
        private System.Windows.Forms.Label TimeMessage;
        private System.Windows.Forms.Label CapacityMessage;
        private System.Windows.Forms.Label Classroom_ListMessage;
        private System.Windows.Forms.ComboBox Lecturer_List;
        private System.Windows.Forms.Label LecturerLabel;
    }
}
