
namespace Healthcare_UI
{
    partial class optionsmenu
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
            this.optionsmenu_label_title = new System.Windows.Forms.Label();
            this.optionsmenu_button_input = new System.Windows.Forms.Button();
            this.optionsmenu_button_upload = new System.Windows.Forms.Button();
            this.optionsmenu_button_search = new System.Windows.Forms.Button();
            this.optionsmenu_button_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // optionsmenu_label_title
            // 
            this.optionsmenu_label_title.AutoSize = true;
            this.optionsmenu_label_title.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.optionsmenu_label_title.Location = new System.Drawing.Point(225, 9);
            this.optionsmenu_label_title.Name = "optionsmenu_label_title";
            this.optionsmenu_label_title.Size = new System.Drawing.Size(326, 54);
            this.optionsmenu_label_title.TabIndex = 0;
            this.optionsmenu_label_title.Text = "Select an Option:";
            // 
            // optionsmenu_button_input
            // 
            this.optionsmenu_button_input.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.optionsmenu_button_input.Location = new System.Drawing.Point(329, 197);
            this.optionsmenu_button_input.Name = "optionsmenu_button_input";
            this.optionsmenu_button_input.Size = new System.Drawing.Size(117, 32);
            this.optionsmenu_button_input.TabIndex = 1;
            this.optionsmenu_button_input.Text = "Make New Form";
            this.optionsmenu_button_input.UseVisualStyleBackColor = true;
            this.optionsmenu_button_input.Click += new System.EventHandler(this.optionsmenu_button_input_Click);
            // 
            // optionsmenu_button_upload
            // 
            this.optionsmenu_button_upload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.optionsmenu_button_upload.Location = new System.Drawing.Point(329, 235);
            this.optionsmenu_button_upload.Name = "optionsmenu_button_upload";
            this.optionsmenu_button_upload.Size = new System.Drawing.Size(117, 32);
            this.optionsmenu_button_upload.TabIndex = 2;
            this.optionsmenu_button_upload.Text = "Upload Document";
            this.optionsmenu_button_upload.UseVisualStyleBackColor = true;
            this.optionsmenu_button_upload.Click += new System.EventHandler(this.optionsmenu_button_upload_Click);
            // 
            // optionsmenu_button_search
            // 
            this.optionsmenu_button_search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.optionsmenu_button_search.Location = new System.Drawing.Point(329, 273);
            this.optionsmenu_button_search.Name = "optionsmenu_button_search";
            this.optionsmenu_button_search.Size = new System.Drawing.Size(117, 43);
            this.optionsmenu_button_search.TabIndex = 3;
            this.optionsmenu_button_search.Text = "Search for Document";
            this.optionsmenu_button_search.UseVisualStyleBackColor = true;
            this.optionsmenu_button_search.Click += new System.EventHandler(this.optionsmenu_button_search_Click);
            // 
            // optionsmenu_button_logout
            // 
            this.optionsmenu_button_logout.Location = new System.Drawing.Point(347, 322);
            this.optionsmenu_button_logout.Name = "optionsmenu_button_logout";
            this.optionsmenu_button_logout.Size = new System.Drawing.Size(75, 23);
            this.optionsmenu_button_logout.TabIndex = 4;
            this.optionsmenu_button_logout.Text = "Logout";
            this.optionsmenu_button_logout.UseVisualStyleBackColor = true;
            this.optionsmenu_button_logout.Click += new System.EventHandler(this.optionsmenu_button_logout_Click);
            // 
            // optionsmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.optionsmenu_button_logout);
            this.Controls.Add(this.optionsmenu_button_search);
            this.Controls.Add(this.optionsmenu_button_upload);
            this.Controls.Add(this.optionsmenu_button_input);
            this.Controls.Add(this.optionsmenu_label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "optionsmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "optionsmenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label optionsmenu_label_title;
        private System.Windows.Forms.Button optionsmenu_button_input;
        private System.Windows.Forms.Button optionsmenu_button_upload;
        private System.Windows.Forms.Button optionsmenu_button_search;
        private System.Windows.Forms.Button optionsmenu_button_logout;
    }
}