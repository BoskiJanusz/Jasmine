namespace Jasmine
{
    partial class Kurier
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
            this.button_add_new = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_add_new
            // 
            this.button_add_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_add_new.Location = new System.Drawing.Point(67, 49);
            this.button_add_new.Name = "button_add_new";
            this.button_add_new.Size = new System.Drawing.Size(236, 128);
            this.button_add_new.TabIndex = 0;
            this.button_add_new.Text = "Add new package";
            this.button_add_new.UseVisualStyleBackColor = true;
            this.button_add_new.Click += new System.EventHandler(this.button_add_new_Click);
            // 
            // button_edit
            // 
            this.button_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_edit.Location = new System.Drawing.Point(67, 183);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(236, 128);
            this.button_edit.TabIndex = 1;
            this.button_edit.Text = "Edit package";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_back.Location = new System.Drawing.Point(67, 317);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(236, 75);
            this.button_back.TabIndex = 16;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // Kurier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 431);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_add_new);
            this.Name = "Kurier";
            this.Text = "Kurier";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_add_new;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_back;
    }
}