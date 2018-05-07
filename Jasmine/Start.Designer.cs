namespace Jasmine
{
    partial class Start
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
            this.button_user = new System.Windows.Forms.Button();
            this.button_courier = new System.Windows.Forms.Button();
            this.button_admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_user
            // 
            this.button_user.BackColor = System.Drawing.Color.Gray;
            this.button_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_user.Location = new System.Drawing.Point(12, 12);
            this.button_user.Name = "button_user";
            this.button_user.Size = new System.Drawing.Size(306, 214);
            this.button_user.TabIndex = 0;
            this.button_user.Text = "User";
            this.button_user.UseVisualStyleBackColor = false;
            this.button_user.Click += new System.EventHandler(this.button_user_Click);
            // 
            // button_courier
            // 
            this.button_courier.BackColor = System.Drawing.Color.Gray;
            this.button_courier.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_courier.Location = new System.Drawing.Point(324, 12);
            this.button_courier.Name = "button_courier";
            this.button_courier.Size = new System.Drawing.Size(306, 214);
            this.button_courier.TabIndex = 1;
            this.button_courier.Text = "Courier";
            this.button_courier.UseVisualStyleBackColor = false;
            this.button_courier.Click += new System.EventHandler(this.button_courier_Click);
            // 
            // button_admin
            // 
            this.button_admin.BackColor = System.Drawing.Color.Gray;
            this.button_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_admin.Location = new System.Drawing.Point(635, 12);
            this.button_admin.Name = "button_admin";
            this.button_admin.Size = new System.Drawing.Size(306, 214);
            this.button_admin.TabIndex = 2;
            this.button_admin.Text = "Admin";
            this.button_admin.UseVisualStyleBackColor = false;
            this.button_admin.Click += new System.EventHandler(this.button_admin_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(953, 261);
            this.Controls.Add(this.button_admin);
            this.Controls.Add(this.button_courier);
            this.Controls.Add(this.button_user);
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_user;
        private System.Windows.Forms.Button button_courier;
        private System.Windows.Forms.Button button_admin;
    }
}