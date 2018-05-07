namespace Jasmine
{
    partial class Add_Or_Edit_Package
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
            this.text_data = new System.Windows.Forms.TextBox();
            this.text_id = new System.Windows.Forms.TextBox();
            this.Status_lab = new System.Windows.Forms.Label();
            this.lab_id = new System.Windows.Forms.Label();
            this.lab_Data = new System.Windows.Forms.Label();
            this.Add_or_edit_package_baton = new System.Windows.Forms.Button();
            this.text_status = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // text_data
            // 
            this.text_data.Location = new System.Drawing.Point(60, 64);
            this.text_data.Name = "text_data";
            this.text_data.Size = new System.Drawing.Size(149, 20);
            this.text_data.TabIndex = 3;
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(60, 38);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(149, 20);
            this.text_id.TabIndex = 2;
            // 
            // Status_lab
            // 
            this.Status_lab.AutoSize = true;
            this.Status_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Status_lab.Location = new System.Drawing.Point(3, 12);
            this.Status_lab.Name = "Status_lab";
            this.Status_lab.Size = new System.Drawing.Size(55, 16);
            this.Status_lab.TabIndex = 3;
            this.Status_lab.Text = "Status:";
            // 
            // lab_id
            // 
            this.lab_id.AutoSize = true;
            this.lab_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_id.Location = new System.Drawing.Point(33, 38);
            this.lab_id.Name = "lab_id";
            this.lab_id.Size = new System.Drawing.Size(25, 16);
            this.lab_id.TabIndex = 4;
            this.lab_id.Text = "Id:";
            // 
            // lab_Data
            // 
            this.lab_Data.AutoSize = true;
            this.lab_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_Data.Location = new System.Drawing.Point(13, 65);
            this.lab_Data.Name = "lab_Data";
            this.lab_Data.Size = new System.Drawing.Size(45, 16);
            this.lab_Data.TabIndex = 5;
            this.lab_Data.Text = "Data:";
            // 
            // Add_or_edit_package_baton
            // 
            this.Add_or_edit_package_baton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Add_or_edit_package_baton.Location = new System.Drawing.Point(215, 12);
            this.Add_or_edit_package_baton.Name = "Add_or_edit_package_baton";
            this.Add_or_edit_package_baton.Size = new System.Drawing.Size(136, 72);
            this.Add_or_edit_package_baton.TabIndex = 6;
            this.Add_or_edit_package_baton.Text = "Add/Edit";
            this.Add_or_edit_package_baton.UseVisualStyleBackColor = true;
            this.Add_or_edit_package_baton.Click += new System.EventHandler(this.Add_or_edit_package_baton_Click);
            // 
            // text_status
            // 
            this.text_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.text_status.FormattingEnabled = true;
            this.text_status.Items.AddRange(new object[] {
            "w systemie",
            "w magazynie",
            "w drodze",
            "dostarczono"});
            this.text_status.Location = new System.Drawing.Point(60, 11);
            this.text_status.Name = "text_status";
            this.text_status.Size = new System.Drawing.Size(149, 21);
            this.text_status.TabIndex = 7;
            // 
            // Add_Or_Edit_Package
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(461, 216);
            this.Controls.Add(this.text_status);
            this.Controls.Add(this.Add_or_edit_package_baton);
            this.Controls.Add(this.lab_Data);
            this.Controls.Add(this.lab_id);
            this.Controls.Add(this.Status_lab);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.text_data);
            this.Name = "Add_Or_Edit_Package";
            this.Text = "Add_Or_Edit_Package";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox text_data;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Label Status_lab;
        private System.Windows.Forms.Label lab_id;
        private System.Windows.Forms.Label lab_Data;
        private System.Windows.Forms.Button Add_or_edit_package_baton;
        private System.Windows.Forms.ComboBox text_status;
    }
}