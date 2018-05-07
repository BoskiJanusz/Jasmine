namespace Jasmine
{
    partial class User
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
            this.button_exit = new System.Windows.Forms.Button();
            this.text_find = new System.Windows.Forms.TextBox();
            this.button_find = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.lab_find_name = new System.Windows.Forms.Label();
            this.lab_find_lastname = new System.Windows.Forms.Label();
            this.lab_find_status = new System.Windows.Forms.Label();
            this.lab_find_date = new System.Windows.Forms.Label();
            this.lab_find_street = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_exit.Location = new System.Drawing.Point(111, 351);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(200, 35);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // text_find
            // 
            this.text_find.Location = new System.Drawing.Point(111, 243);
            this.text_find.Name = "text_find";
            this.text_find.Size = new System.Drawing.Size(200, 20);
            this.text_find.TabIndex = 1;
            // 
            // button_find
            // 
            this.button_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_find.Location = new System.Drawing.Point(111, 269);
            this.button_find.Name = "button_find";
            this.button_find.Size = new System.Drawing.Size(200, 35);
            this.button_find.TabIndex = 2;
            this.button_find.Text = "Find";
            this.button_find.UseVisualStyleBackColor = true;
            this.button_find.Click += new System.EventHandler(this.button_find_Click);
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_back.Location = new System.Drawing.Point(111, 310);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(200, 35);
            this.button_back.TabIndex = 3;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // lab_find_name
            // 
            this.lab_find_name.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lab_find_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_find_name.Location = new System.Drawing.Point(107, 43);
            this.lab_find_name.Name = "lab_find_name";
            this.lab_find_name.Size = new System.Drawing.Size(204, 29);
            this.lab_find_name.TabIndex = 4;
            // 
            // lab_find_lastname
            // 
            this.lab_find_lastname.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lab_find_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_find_lastname.Location = new System.Drawing.Point(107, 81);
            this.lab_find_lastname.Name = "lab_find_lastname";
            this.lab_find_lastname.Size = new System.Drawing.Size(204, 29);
            this.lab_find_lastname.TabIndex = 5;
            // 
            // lab_find_status
            // 
            this.lab_find_status.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lab_find_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_find_status.Location = new System.Drawing.Point(107, 121);
            this.lab_find_status.Name = "lab_find_status";
            this.lab_find_status.Size = new System.Drawing.Size(204, 29);
            this.lab_find_status.TabIndex = 6;
            // 
            // lab_find_date
            // 
            this.lab_find_date.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lab_find_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_find_date.Location = new System.Drawing.Point(107, 160);
            this.lab_find_date.Name = "lab_find_date";
            this.lab_find_date.Size = new System.Drawing.Size(204, 29);
            this.lab_find_date.TabIndex = 7;
            // 
            // lab_find_street
            // 
            this.lab_find_street.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lab_find_street.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_find_street.Location = new System.Drawing.Point(107, 202);
            this.lab_find_street.Name = "lab_find_street";
            this.lab_find_street.Size = new System.Drawing.Size(204, 29);
            this.lab_find_street.TabIndex = 8;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(438, 395);
            this.Controls.Add(this.lab_find_street);
            this.Controls.Add(this.lab_find_date);
            this.Controls.Add(this.lab_find_status);
            this.Controls.Add(this.lab_find_lastname);
            this.Controls.Add(this.lab_find_name);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_find);
            this.Controls.Add(this.text_find);
            this.Controls.Add(this.button_exit);
            this.Name = "User";
            this.Text = "User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.TextBox text_find;
        private System.Windows.Forms.Button button_find;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label lab_find_name;
        private System.Windows.Forms.Label lab_find_lastname;
        private System.Windows.Forms.Label lab_find_status;
        private System.Windows.Forms.Label lab_find_date;
        private System.Windows.Forms.Label lab_find_street;
    }
}