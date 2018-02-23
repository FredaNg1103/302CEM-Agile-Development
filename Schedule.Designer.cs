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
            this.CnC_List = new System.Windows.Forms.ComboBox();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.Classroom_rdb = new System.Windows.Forms.RadioButton();
            this.Course_rdb = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeMessage.Location = new System.Drawing.Point(704, 12);
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
            this.LogoutBtn.Location = new System.Drawing.Point(1100, 12);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(70, 70);
            this.LogoutBtn.TabIndex = 2;
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(1057, 699);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(113, 42);
            this.BackBtn.TabIndex = 17;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(50, 100);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(81, 29);
            this.DateLabel.TabIndex = 18;
            this.DateLabel.Text = "Date : ";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(137, 100);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(228, 30);
            this.dateTimePicker.TabIndex = 19;
            this.dateTimePicker.Value = new System.DateTime(2018, 2, 22, 2, 8, 51, 0);
            // 
            // CnC_List
            // 
            this.CnC_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CnC_List.FormattingEnabled = true;
            this.CnC_List.Location = new System.Drawing.Point(55, 226);
            this.CnC_List.Name = "CnC_List";
            this.CnC_List.Size = new System.Drawing.Size(310, 37);
            this.CnC_List.TabIndex = 21;
            // 
            // CheckBtn
            // 
            this.CheckBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBtn.Location = new System.Drawing.Point(406, 222);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(113, 42);
            this.CheckBtn.TabIndex = 22;
            this.CheckBtn.Text = "Check";
            this.CheckBtn.UseVisualStyleBackColor = true;
            // 
            // Classroom_rdb
            // 
            this.Classroom_rdb.AutoSize = true;
            this.Classroom_rdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Classroom_rdb.Location = new System.Drawing.Point(55, 174);
            this.Classroom_rdb.Name = "Classroom_rdb";
            this.Classroom_rdb.Size = new System.Drawing.Size(150, 33);
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
            this.Course_rdb.Location = new System.Drawing.Point(211, 174);
            this.Course_rdb.Name = "Course_rdb";
            this.Course_rdb.Size = new System.Drawing.Size(112, 33);
            this.Course_rdb.TabIndex = 1;
            this.Course_rdb.TabStop = true;
            this.Course_rdb.Text = "Course";
            this.Course_rdb.UseVisualStyleBackColor = true;
            this.Course_rdb.CheckedChanged += new System.EventHandler(this.Course_rdb_CheckedChanged);
            // 
            // Scheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.Course_rdb);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.Classroom_rdb);
            this.Controls.Add(this.CnC_List);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.WelcomeMessage);
            this.Controls.Add(this.LogoutBtn);
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
        private System.Windows.Forms.ComboBox CnC_List;
        private System.Windows.Forms.Button CheckBtn;
        private System.Windows.Forms.RadioButton Classroom_rdb;
        private System.Windows.Forms.RadioButton Course_rdb;
    }
}
