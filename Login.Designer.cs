namespace CnL_Scheduling
{
    partial class Login
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
           this.UserLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.UserMessage = new System.Windows.Forms.Label();
            this.PassMessage = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.LoginMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.Location = new System.Drawing.Point(109, 155);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(160, 32);
            this.UserLabel.TabIndex = 0;
            this.UserLabel.Text = "Username :";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLabel.Location = new System.Drawing.Point(115, 260);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(154, 32);
            this.PassLabel.TabIndex = 1;
            this.PassLabel.Text = "Password :";
            // 
            // UserTextBox
            // 
            this.UserTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTextBox.Location = new System.Drawing.Point(281, 152);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(300, 38);
            this.UserTextBox.TabIndex = 2;
            this.UserTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserTextBox_KeyDown);
            this.UserTextBox.Leave += new System.EventHandler(this.UserTextBox_Leave);
            // 
            // PassTextBox
            // 
            this.PassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTextBox.Location = new System.Drawing.Point(281, 257);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.PasswordChar = '*';
            this.PassTextBox.Size = new System.Drawing.Size(300, 38);
            this.PassTextBox.TabIndex = 3;
            this.PassTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PassTextBox_KeyDown);
            this.PassTextBox.Leave += new System.EventHandler(this.PassTextBox_Leave);
            // 
            // UserMessage
            // 
            this.UserMessage.AutoSize = true;
            this.UserMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserMessage.ForeColor = System.Drawing.Color.Red;
            this.UserMessage.Location = new System.Drawing.Point(278, 193);
            this.UserMessage.Name = "UserMessage";
            this.UserMessage.Size = new System.Drawing.Size(0, 25);
            this.UserMessage.TabIndex = 4;
            // 
            // PassMessage
            // 
            this.PassMessage.AutoSize = true;
            this.PassMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassMessage.ForeColor = System.Drawing.Color.Red;
            this.PassMessage.Location = new System.Drawing.Point(278, 298);
            this.PassMessage.Name = "PassMessage";
            this.PassMessage.Size = new System.Drawing.Size(0, 25);
            this.PassMessage.TabIndex = 5;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Location = new System.Drawing.Point(320, 366);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(150, 42);
            this.LoginBtn.TabIndex = 6;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // LoginMessage
            // 
            this.LoginMessage.AutoSize = true;
            this.LoginMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginMessage.ForeColor = System.Drawing.Color.Red;
            this.LoginMessage.Location = new System.Drawing.Point(303, 421);
            this.LoginMessage.Name = "LoginMessage";
            this.LoginMessage.Size = new System.Drawing.Size(0, 25);
            this.LoginMessage.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.LoginMessage);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PassMessage);
            this.Controls.Add(this.UserMessage);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.UserLabel);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Label UserMessage;
        private System.Windows.Forms.Label PassMessage;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label LoginMessage;
    }
}

