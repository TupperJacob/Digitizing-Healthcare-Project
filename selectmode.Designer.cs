
namespace Healthcare_UI
{
    partial class selectmode
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
            this.selectmode_label_title = new System.Windows.Forms.Label();
            this.selectmode_button_host = new System.Windows.Forms.Button();
            this.selectmode_button_Client = new System.Windows.Forms.Button();
            this.selectmode_button_offline = new System.Windows.Forms.Button();
            this.selectmode_button_help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectmode_label_title
            // 
            this.selectmode_label_title.AutoSize = true;
            this.selectmode_label_title.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectmode_label_title.Location = new System.Drawing.Point(148, 9);
            this.selectmode_label_title.Name = "selectmode_label_title";
            this.selectmode_label_title.Size = new System.Drawing.Size(480, 54);
            this.selectmode_label_title.TabIndex = 0;
            this.selectmode_label_title.Text = "Select Mode of Operation";
            // 
            // selectmode_button_host
            // 
            this.selectmode_button_host.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectmode_button_host.Location = new System.Drawing.Point(330, 193);
            this.selectmode_button_host.Name = "selectmode_button_host";
            this.selectmode_button_host.Size = new System.Drawing.Size(116, 40);
            this.selectmode_button_host.TabIndex = 1;
            this.selectmode_button_host.Text = "Host";
            this.selectmode_button_host.UseVisualStyleBackColor = true;
            this.selectmode_button_host.Click += new System.EventHandler(this.selectmode_button_host_Click);
            // 
            // selectmode_button_Client
            // 
            this.selectmode_button_Client.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectmode_button_Client.Location = new System.Drawing.Point(330, 239);
            this.selectmode_button_Client.Name = "selectmode_button_Client";
            this.selectmode_button_Client.Size = new System.Drawing.Size(116, 40);
            this.selectmode_button_Client.TabIndex = 2;
            this.selectmode_button_Client.Text = "Client";
            this.selectmode_button_Client.UseVisualStyleBackColor = true;
            // 
            // selectmode_button_offline
            // 
            this.selectmode_button_offline.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectmode_button_offline.Location = new System.Drawing.Point(330, 285);
            this.selectmode_button_offline.Name = "selectmode_button_offline";
            this.selectmode_button_offline.Size = new System.Drawing.Size(116, 40);
            this.selectmode_button_offline.TabIndex = 3;
            this.selectmode_button_offline.Text = "Offline";
            this.selectmode_button_offline.UseVisualStyleBackColor = true;
            // 
            // selectmode_button_help
            // 
            this.selectmode_button_help.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectmode_button_help.Location = new System.Drawing.Point(330, 331);
            this.selectmode_button_help.Name = "selectmode_button_help";
            this.selectmode_button_help.Size = new System.Drawing.Size(116, 40);
            this.selectmode_button_help.TabIndex = 4;
            this.selectmode_button_help.Text = "Help";
            this.selectmode_button_help.UseVisualStyleBackColor = true;
            // 
            // selectmode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectmode_button_help);
            this.Controls.Add(this.selectmode_button_offline);
            this.Controls.Add(this.selectmode_button_Client);
            this.Controls.Add(this.selectmode_button_host);
            this.Controls.Add(this.selectmode_label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "selectmode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "selectmode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectmode_label_title;
        private System.Windows.Forms.Button selectmode_button_host;
        private System.Windows.Forms.Button selectmode_button_Client;
        private System.Windows.Forms.Button selectmode_button_offline;
        private System.Windows.Forms.Button selectmode_button_help;
    }
}