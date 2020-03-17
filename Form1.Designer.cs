namespace FormUI
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
            this.InfoListBox = new System.Windows.Forms.ListBox();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoListBox
            // 
            this.InfoListBox.FormattingEnabled = true;
            this.InfoListBox.ItemHeight = 15;
            this.InfoListBox.Location = new System.Drawing.Point(35, 12);
            this.InfoListBox.Name = "InfoListBox";
            this.InfoListBox.Size = new System.Drawing.Size(481, 379);
            this.InfoListBox.TabIndex = 0;
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(152, 411);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(270, 23);
            this.NameInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(35, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name of Car";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button1.Location = new System.Drawing.Point(300, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 511);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.InfoListBox);
            this.Name = "Form1";
            this.Text = "SQL Data Access";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox InfoListBox;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}