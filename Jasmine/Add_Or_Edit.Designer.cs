namespace Jasmine
{
    partial class Add_Or_Edit
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
            this.text_street = new System.Windows.Forms.TextBox();
            this.text_lastname = new System.Windows.Forms.TextBox();
            this.text_name = new System.Windows.Forms.TextBox();
            this.Add_edited_baton = new System.Windows.Forms.Button();
            this.Name_lab = new System.Windows.Forms.Label();
            this.Street_lab = new System.Windows.Forms.Label();
            this.LastName_lab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_street
            // 
            this.text_street.Location = new System.Drawing.Point(93, 116);
            this.text_street.Name = "text_street";
            this.text_street.Size = new System.Drawing.Size(100, 20);
            this.text_street.TabIndex = 10;
            // 
            // text_lastname
            // 
            this.text_lastname.Location = new System.Drawing.Point(93, 90);
            this.text_lastname.Name = "text_lastname";
            this.text_lastname.Size = new System.Drawing.Size(100, 20);
            this.text_lastname.TabIndex = 9;
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(93, 64);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(100, 20);
            this.text_name.TabIndex = 8;
            // 
            // Add_edited_baton
            // 
            this.Add_edited_baton.Location = new System.Drawing.Point(199, 64);
            this.Add_edited_baton.Name = "Add_edited_baton";
            this.Add_edited_baton.Size = new System.Drawing.Size(105, 75);
            this.Add_edited_baton.TabIndex = 12;
            this.Add_edited_baton.Text = "Add/Edit";
            this.Add_edited_baton.UseVisualStyleBackColor = true;
            this.Add_edited_baton.Click += new System.EventHandler(this.Add_edited_baton_Click);
            // 
            // Name_lab
            // 
            this.Name_lab.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Name_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name_lab.Location = new System.Drawing.Point(26, 64);
            this.Name_lab.Name = "Name_lab";
            this.Name_lab.Size = new System.Drawing.Size(61, 20);
            this.Name_lab.TabIndex = 13;
            this.Name_lab.Text = "Name";
            // 
            // Street_lab
            // 
            this.Street_lab.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Street_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Street_lab.Location = new System.Drawing.Point(26, 119);
            this.Street_lab.Name = "Street_lab";
            this.Street_lab.Size = new System.Drawing.Size(61, 20);
            this.Street_lab.TabIndex = 14;
            this.Street_lab.Text = "Street";
            // 
            // LastName_lab
            // 
            this.LastName_lab.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LastName_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LastName_lab.Location = new System.Drawing.Point(23, 93);
            this.LastName_lab.Name = "LastName_lab";
            this.LastName_lab.Size = new System.Drawing.Size(64, 20);
            this.LastName_lab.TabIndex = 15;
            this.LastName_lab.Text = "LastName";
            // 
            // Add_Or_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(358, 281);
            this.Controls.Add(this.LastName_lab);
            this.Controls.Add(this.Street_lab);
            this.Controls.Add(this.Name_lab);
            this.Controls.Add(this.Add_edited_baton);
            this.Controls.Add(this.text_street);
            this.Controls.Add(this.text_lastname);
            this.Controls.Add(this.text_name);
            this.Name = "Add_Or_Edit";
            this.Text = "Add_Or_Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_street;
        private System.Windows.Forms.TextBox text_lastname;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Button Add_edited_baton;
        private System.Windows.Forms.Label Name_lab;
        private System.Windows.Forms.Label Street_lab;
        private System.Windows.Forms.Label LastName_lab;
    }
}