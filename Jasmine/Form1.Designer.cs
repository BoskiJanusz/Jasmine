namespace Jasmine
{
    partial class Form1
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
            this.Add_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Search_Button = new System.Windows.Forms.Button();
            this.text_search_lastname = new System.Windows.Forms.TextBox();
            this.text_search_name = new System.Windows.Forms.TextBox();
            this.Edit_baton = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_Button
            // 
            this.Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Add_Button.Location = new System.Drawing.Point(3, 12);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(151, 41);
            this.Add_Button.TabIndex = 1;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Delete_Button.Location = new System.Drawing.Point(317, 12);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(151, 41);
            this.Delete_Button.TabIndex = 3;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(123, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(414, 365);
            this.dataGridView1.TabIndex = 7;
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(123, 56);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(75, 23);
            this.Search_Button.TabIndex = 4;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // text_search_lastname
            // 
            this.text_search_lastname.Location = new System.Drawing.Point(310, 59);
            this.text_search_lastname.Name = "text_search_lastname";
            this.text_search_lastname.Size = new System.Drawing.Size(100, 20);
            this.text_search_lastname.TabIndex = 6;
            // 
            // text_search_name
            // 
            this.text_search_name.Location = new System.Drawing.Point(204, 59);
            this.text_search_name.Name = "text_search_name";
            this.text_search_name.Size = new System.Drawing.Size(100, 20);
            this.text_search_name.TabIndex = 5;
            // 
            // Edit_baton
            // 
            this.Edit_baton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Edit_baton.Location = new System.Drawing.Point(160, 12);
            this.Edit_baton.Name = "Edit_baton";
            this.Edit_baton.Size = new System.Drawing.Size(151, 41);
            this.Edit_baton.TabIndex = 2;
            this.Edit_baton.Text = "Edit";
            this.Edit_baton.UseVisualStyleBackColor = true;
            this.Edit_baton.Click += new System.EventHandler(this.Edit_baton_Click);
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_back.Location = new System.Drawing.Point(474, 12);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(127, 41);
            this.button_back.TabIndex = 8;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_exit.Location = new System.Drawing.Point(607, 12);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(130, 41);
            this.button_exit.TabIndex = 9;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(761, 520);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.Edit_baton);
            this.Controls.Add(this.text_search_name);
            this.Controls.Add(this.text_search_lastname);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Add_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.TextBox text_search_lastname;
        private System.Windows.Forms.TextBox text_search_name;
        private System.Windows.Forms.Button Edit_baton;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_exit;
    }
}

