
namespace Healthcare_UI
{
    partial class main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.welcome_label_title = new System.Windows.Forms.Label();
            this.window_button_checkin = new System.Windows.Forms.Button();
            this.window_button_employeelogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcome_label_title
            // 
            this.welcome_label_title.AutoSize = true;
            this.welcome_label_title.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcome_label_title.Location = new System.Drawing.Point(208, 18);
            this.welcome_label_title.Name = "welcome_label_title";
            this.welcome_label_title.Size = new System.Drawing.Size(359, 54);
            this.welcome_label_title.TabIndex = 0;
            this.welcome_label_title.Text = "Welcome to DHISG";
            // 
            // window_button_checkin
            // 
            this.window_button_checkin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.window_button_checkin.Location = new System.Drawing.Point(100, 281);
            this.window_button_checkin.Name = "window_button_checkin";
            this.window_button_checkin.Size = new System.Drawing.Size(180, 67);
            this.window_button_checkin.TabIndex = 1;
            this.window_button_checkin.Text = "Checkin for Appointment";
            this.window_button_checkin.UseVisualStyleBackColor = true;
            this.window_button_checkin.Click += new System.EventHandler(this.window_button_checkin_Click);
            // 
            // window_button_employeelogin
            // 
            this.window_button_employeelogin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.window_button_employeelogin.Location = new System.Drawing.Point(508, 281);
            this.window_button_employeelogin.Name = "window_button_employeelogin";
            this.window_button_employeelogin.Size = new System.Drawing.Size(180, 67);
            this.window_button_employeelogin.TabIndex = 2;
            this.window_button_employeelogin.Text = "Employee Login";
            this.window_button_employeelogin.UseVisualStyleBackColor = true;
            this.window_button_employeelogin.Click += new System.EventHandler(this.window_button_employeelogin_Click);
            // 
            // window_welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.window_button_employeelogin);
            this.Controls.Add(this.window_button_checkin);
            this.Controls.Add(this.welcome_label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "window_welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DHISG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_label_title;
        private System.Windows.Forms.Button window_button_checkin;
        private System.Windows.Forms.Button window_button_employeelogin;
    }
}

