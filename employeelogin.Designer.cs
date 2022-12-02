
namespace Healthcare_UI
{
    partial class employeelogin
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
            this.employeelogin_label_welcome = new System.Windows.Forms.Label();
            this.employeelogin_label_username = new System.Windows.Forms.Label();
            this.employeelogin_textbox_username = new System.Windows.Forms.TextBox();
            this.employeelogin_textbox_password = new System.Windows.Forms.TextBox();
            this.employeelogin_label_password = new System.Windows.Forms.Label();
            this.employee_button_login = new System.Windows.Forms.Button();
            this.employeelogin_button_goback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeelogin_label_welcome
            // 
            this.employeelogin_label_welcome.AutoSize = true;
            this.employeelogin_label_welcome.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employeelogin_label_welcome.Location = new System.Drawing.Point(175, 12);
            this.employeelogin_label_welcome.Name = "employeelogin_label_welcome";
            this.employeelogin_label_welcome.Size = new System.Drawing.Size(426, 54);
            this.employeelogin_label_welcome.TabIndex = 0;
            this.employeelogin_label_welcome.Text = "Welcome, Please Login";
            // 
            // employeelogin_label_username
            // 
            this.employeelogin_label_username.AutoSize = true;
            this.employeelogin_label_username.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employeelogin_label_username.Location = new System.Drawing.Point(265, 204);
            this.employeelogin_label_username.Name = "employeelogin_label_username";
            this.employeelogin_label_username.Size = new System.Drawing.Size(67, 15);
            this.employeelogin_label_username.TabIndex = 1;
            this.employeelogin_label_username.Text = "Username:";
            // 
            // employeelogin_textbox_username
            // 
            this.employeelogin_textbox_username.Location = new System.Drawing.Point(338, 201);
            this.employeelogin_textbox_username.Name = "employeelogin_textbox_username";
            this.employeelogin_textbox_username.Size = new System.Drawing.Size(100, 23);
            this.employeelogin_textbox_username.TabIndex = 3;
            // 
            // employeelogin_textbox_password
            // 
            this.employeelogin_textbox_password.Location = new System.Drawing.Point(338, 229);
            this.employeelogin_textbox_password.Name = "employeelogin_textbox_password";
            this.employeelogin_textbox_password.Size = new System.Drawing.Size(100, 23);
            this.employeelogin_textbox_password.TabIndex = 5;
            // 
            // employeelogin_label_password
            // 
            this.employeelogin_label_password.AutoSize = true;
            this.employeelogin_label_password.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employeelogin_label_password.Location = new System.Drawing.Point(270, 232);
            this.employeelogin_label_password.Name = "employeelogin_label_password";
            this.employeelogin_label_password.Size = new System.Drawing.Size(62, 15);
            this.employeelogin_label_password.TabIndex = 4;
            this.employeelogin_label_password.Text = "Password:";
            // 
            // employee_button_login
            // 
            this.employee_button_login.Location = new System.Drawing.Point(350, 258);
            this.employee_button_login.Name = "employee_button_login";
            this.employee_button_login.Size = new System.Drawing.Size(75, 23);
            this.employee_button_login.TabIndex = 6;
            this.employee_button_login.Text = "Login";
            this.employee_button_login.UseVisualStyleBackColor = true;
            this.employee_button_login.Click += new System.EventHandler(this.employee_button_login_Click);
            // 
            // employeelogin_button_goback
            // 
            this.employeelogin_button_goback.Location = new System.Drawing.Point(350, 287);
            this.employeelogin_button_goback.Name = "employeelogin_button_goback";
            this.employeelogin_button_goback.Size = new System.Drawing.Size(75, 23);
            this.employeelogin_button_goback.TabIndex = 7;
            this.employeelogin_button_goback.Text = "Go Back";
            this.employeelogin_button_goback.UseVisualStyleBackColor = true;
            this.employeelogin_button_goback.Click += new System.EventHandler(this.employeelogin_button_goback_Click);
            // 
            // window_employeelogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.employeelogin_button_goback);
            this.Controls.Add(this.employee_button_login);
            this.Controls.Add(this.employeelogin_textbox_password);
            this.Controls.Add(this.employeelogin_label_password);
            this.Controls.Add(this.employeelogin_textbox_username);
            this.Controls.Add(this.employeelogin_label_username);
            this.Controls.Add(this.employeelogin_label_welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "window_employeelogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DHISG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeelogin_label_welcome;
        private System.Windows.Forms.Label employeelogin_label_username;
        private System.Windows.Forms.TextBox employeelogin_textbox_username;
        private System.Windows.Forms.TextBox employeelogin_textbox_password;
        private System.Windows.Forms.Label employeelogin_label_password;
        private System.Windows.Forms.Button employee_button_login;
        private System.Windows.Forms.Button employeelogin_button_goback;
    }
}