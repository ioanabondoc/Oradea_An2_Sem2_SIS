namespace StrongPasswordGenerator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_length = new System.Windows.Forms.ComboBox();
            this.checkBox_symbols = new System.Windows.Forms.CheckBox();
            this.checkBox_numbers = new System.Windows.Forms.CheckBox();
            this.checkBox_lowerchars = new System.Windows.Forms.CheckBox();
            this.checkBox_upperchars = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Generate = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_autosize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password length:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Include Symbols:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Include Uppercase Characters:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Include Lowercase Characters:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Include Numbers:";
            // 
            // comboBox_length
            // 
            this.comboBox_length.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_length.FormattingEnabled = true;
            this.comboBox_length.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.comboBox_length.Location = new System.Drawing.Point(159, 32);
            this.comboBox_length.Name = "comboBox_length";
            this.comboBox_length.Size = new System.Drawing.Size(121, 25);
            this.comboBox_length.TabIndex = 5;
            // 
            // checkBox_symbols
            // 
            this.checkBox_symbols.AutoSize = true;
            this.checkBox_symbols.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_symbols.Location = new System.Drawing.Point(168, 82);
            this.checkBox_symbols.Name = "checkBox_symbols";
            this.checkBox_symbols.Size = new System.Drawing.Size(100, 21);
            this.checkBox_symbols.TabIndex = 6;
            this.checkBox_symbols.Text = "( e.g. @#$% )";
            this.checkBox_symbols.UseVisualStyleBackColor = true;
            // 
            // checkBox_numbers
            // 
            this.checkBox_numbers.AutoSize = true;
            this.checkBox_numbers.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_numbers.Location = new System.Drawing.Point(168, 121);
            this.checkBox_numbers.Name = "checkBox_numbers";
            this.checkBox_numbers.Size = new System.Drawing.Size(105, 21);
            this.checkBox_numbers.TabIndex = 7;
            this.checkBox_numbers.Text = "( e.g. 123456 )";
            this.checkBox_numbers.UseVisualStyleBackColor = true;
            // 
            // checkBox_lowerchars
            // 
            this.checkBox_lowerchars.AutoSize = true;
            this.checkBox_lowerchars.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_lowerchars.Location = new System.Drawing.Point(216, 159);
            this.checkBox_lowerchars.Name = "checkBox_lowerchars";
            this.checkBox_lowerchars.Size = new System.Drawing.Size(117, 21);
            this.checkBox_lowerchars.TabIndex = 8;
            this.checkBox_lowerchars.Text = "( e.g. abcdefgh )";
            this.checkBox_lowerchars.UseVisualStyleBackColor = true;
            // 
            // checkBox_upperchars
            // 
            this.checkBox_upperchars.AutoSize = true;
            this.checkBox_upperchars.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_upperchars.Location = new System.Drawing.Point(216, 192);
            this.checkBox_upperchars.Name = "checkBox_upperchars";
            this.checkBox_upperchars.Size = new System.Drawing.Size(134, 21);
            this.checkBox_upperchars.TabIndex = 9;
            this.checkBox_upperchars.Text = "( e.g. ABCDEFGH )";
            this.checkBox_upperchars.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Location = new System.Drawing.Point(28, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Your new password:";
            // 
            // button_Generate
            // 
            this.button_Generate.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Generate.Location = new System.Drawing.Point(137, 231);
            this.button_Generate.Name = "button_Generate";
            this.button_Generate.Size = new System.Drawing.Size(196, 35);
            this.button_Generate.TabIndex = 11;
            this.button_Generate.Text = "Generate Password";
            this.button_Generate.UseVisualStyleBackColor = true;
            this.button_Generate.Click += new System.EventHandler(this.button_Generate_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(203, 283);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_password.Size = new System.Drawing.Size(223, 32);
            this.textBox_password.TabIndex = 12;
            // 
            // label_autosize
            // 
            this.label_autosize.AutoSize = true;
            this.label_autosize.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_autosize.Location = new System.Drawing.Point(252, 337);
            this.label_autosize.Name = "label_autosize";
            this.label_autosize.Size = new System.Drawing.Size(143, 24);
            this.label_autosize.TabIndex = 13;
            this.label_autosize.Text = "Password length:";
            this.label_autosize.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 382);
            this.Controls.Add(this.label_autosize);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.button_Generate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox_upperchars);
            this.Controls.Add(this.checkBox_lowerchars);
            this.Controls.Add(this.checkBox_numbers);
            this.Controls.Add(this.checkBox_symbols);
            this.Controls.Add(this.comboBox_length);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_length;
        private System.Windows.Forms.CheckBox checkBox_symbols;
        private System.Windows.Forms.CheckBox checkBox_numbers;
        private System.Windows.Forms.CheckBox checkBox_lowerchars;
        private System.Windows.Forms.CheckBox checkBox_upperchars;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Generate;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_autosize;
    }
}

