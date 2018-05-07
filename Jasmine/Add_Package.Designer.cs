namespace Jasmine
{
    partial class Add_Package
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.text_search_name = new System.Windows.Forms.TextBox();
            this.text_search_lastname = new System.Windows.Forms.TextBox();
            this.Search_Button = new System.Windows.Forms.Button();
            this.Add_Package_button = new System.Windows.Forms.Button();
            this.button_edit_package = new System.Windows.Forms.Button();
            this.button_delete_package = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 365);
            this.dataGridView1.TabIndex = 8;
            // 
            // text_search_name
            // 
            this.text_search_name.Location = new System.Drawing.Point(93, 63);
            this.text_search_name.Name = "text_search_name";
            this.text_search_name.Size = new System.Drawing.Size(100, 20);
            this.text_search_name.TabIndex = 10;
            // 
            // text_search_lastname
            // 
            this.text_search_lastname.Location = new System.Drawing.Point(199, 63);
            this.text_search_lastname.Name = "text_search_lastname";
            this.text_search_lastname.Size = new System.Drawing.Size(100, 20);
            this.text_search_lastname.TabIndex = 11;
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(12, 60);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(75, 23);
            this.Search_Button.TabIndex = 9;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // Add_Package_button
            // 
            this.Add_Package_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Add_Package_button.Location = new System.Drawing.Point(12, 8);
            this.Add_Package_button.Name = "Add_Package_button";
            this.Add_Package_button.Size = new System.Drawing.Size(151, 41);
            this.Add_Package_button.TabIndex = 12;
            this.Add_Package_button.Text = "Add";
            this.Add_Package_button.UseVisualStyleBackColor = true;
            this.Add_Package_button.Click += new System.EventHandler(this.Add_Package_button_Click);
            // 
            // button_edit_package
            // 
            this.button_edit_package.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_edit_package.Location = new System.Drawing.Point(169, 8);
            this.button_edit_package.Name = "button_edit_package";
            this.button_edit_package.Size = new System.Drawing.Size(151, 41);
            this.button_edit_package.TabIndex = 13;
            this.button_edit_package.Text = "Edit";
            this.button_edit_package.UseVisualStyleBackColor = true;
            this.button_edit_package.Click += new System.EventHandler(this.button_edit_package_Click);
            // 
            // button_delete_package
            // 
            this.button_delete_package.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_delete_package.Location = new System.Drawing.Point(326, 8);
            this.button_delete_package.Name = "button_delete_package";
            this.button_delete_package.Size = new System.Drawing.Size(151, 41);
            this.button_delete_package.TabIndex = 14;
            this.button_delete_package.Text = "Delete";
            this.button_delete_package.UseVisualStyleBackColor = true;
            this.button_delete_package.Click += new System.EventHandler(this.button_delete_package_Click);
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_back.Location = new System.Drawing.Point(483, 8);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(151, 41);
            this.button_back.TabIndex = 15;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_exit.Location = new System.Drawing.Point(637, 8);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(151, 41);
            this.button_exit.TabIndex = 16;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Add_Package
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_delete_package);
            this.Controls.Add(this.button_edit_package);
            this.Controls.Add(this.Add_Package_button);
            this.Controls.Add(this.text_search_name);
            this.Controls.Add(this.text_search_lastname);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Add_Package";
            this.Text = "Add_Package";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox text_search_name;
        private System.Windows.Forms.TextBox text_search_lastname;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Button Add_Package_button;
        private System.Windows.Forms.Button button_edit_package;
        private System.Windows.Forms.Button button_delete_package;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_exit;
    }
}