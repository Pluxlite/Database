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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.insertCarId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.insertNameOfCar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.insertYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.insertColor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteInputName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InfoListBox
            // 
            this.InfoListBox.FormattingEnabled = true;
            this.InfoListBox.ItemHeight = 15;
            this.InfoListBox.Location = new System.Drawing.Point(35, 12);
            this.InfoListBox.Name = "InfoListBox";
            this.InfoListBox.Size = new System.Drawing.Size(481, 184);
            this.InfoListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(563, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name of Car";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button1.Location = new System.Drawing.Point(775, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(703, 12);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(193, 23);
            this.nameInput.TabIndex = 4;
            // 
            // insertCarId
            // 
            this.insertCarId.Location = new System.Drawing.Point(174, 227);
            this.insertCarId.Name = "insertCarId";
            this.insertCarId.Size = new System.Drawing.Size(193, 23);
            this.insertCarId.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(33, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name of Car";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // insertButton
            // 
            this.insertButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.insertButton.Location = new System.Drawing.Point(241, 366);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(126, 27);
            this.insertButton.TabIndex = 13;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // insertNameOfCar
            // 
            this.insertNameOfCar.Location = new System.Drawing.Point(174, 256);
            this.insertNameOfCar.Name = "insertNameOfCar";
            this.insertNameOfCar.Size = new System.Drawing.Size(193, 23);
            this.insertNameOfCar.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(33, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Car Id";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // insertYear
            // 
            this.insertYear.Location = new System.Drawing.Point(174, 285);
            this.insertYear.Name = "insertYear";
            this.insertYear.Size = new System.Drawing.Size(193, 23);
            this.insertYear.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(33, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Year";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // insertColor
            // 
            this.insertColor.Location = new System.Drawing.Point(174, 314);
            this.insertColor.Name = "insertColor";
            this.insertColor.Size = new System.Drawing.Size(193, 23);
            this.insertColor.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(33, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Color";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteInputName
            // 
            this.deleteInputName.Location = new System.Drawing.Point(703, 104);
            this.deleteInputName.Name = "deleteInputName";
            this.deleteInputName.Size = new System.Drawing.Size(193, 23);
            this.deleteInputName.TabIndex = 24;
            this.deleteInputName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button2.Location = new System.Drawing.Point(775, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 30);
            this.button2.TabIndex = 23;
            this.button2.Text = "Delete";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(563, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Name of Car";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 511);
            this.Controls.Add(this.deleteInputName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.insertColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.insertYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.insertNameOfCar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.insertCarId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InfoListBox);
            this.Name = "Form1";
            this.Text = "SQL Data Access";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox InfoListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox insertColor;
        private System.Windows.Forms.TextBox insertYear;
        private System.Windows.Forms.TextBox insertNameOfCar;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.TextBox insertCarId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox deleteInputName;
    }
}