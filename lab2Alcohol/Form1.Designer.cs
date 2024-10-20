namespace lab2Alcohol
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
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox7 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(876, 315);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(144, 120);
            button1.TabIndex = 0;
            button1.Text = "Całkowita objętość napoju";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Całkowitaobjętośćnapoju_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(874, 442);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(146, 120);
            button2.TabIndex = 1;
            button2.Text = "Objętość czystego alkoholu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Objętośćczystegoalkoholu_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Gray;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(14, 136);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 56);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Gray;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(191, 136);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(239, 56);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox7.BackColor = Color.Gray;
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox7.ForeColor = Color.Black;
            textBox7.Location = new Point(456, 85);
            textBox7.Margin = new Padding(4, 3, 4, 3);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(0, 22);
            textBox7.TabIndex = 8;
            textBox7.Tag = "";
            textBox7.Text = "Количество сосудов";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Gray;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(456, 137);
            textBox4.Margin = new Padding(4, 3, 4, 3);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(152, 56);
            textBox4.TabIndex = 10;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Gray;
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox5.Location = new Point(664, 83);
            textBox5.Margin = new Padding(4, 3, 4, 3);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(356, 25);
            textBox5.TabIndex = 11;
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Gray;
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox6.ForeColor = Color.FromArgb(128, 255, 255);
            textBox6.Location = new Point(16, 14);
            textBox6.Margin = new Padding(4, 3, 4, 3);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(1003, 37);
            textBox6.TabIndex = 12;
            textBox6.Text = "Alcohol Content Calculator";
            textBox6.TextAlign = HorizontalAlignment.Center;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(16, 83);
            label1.Name = "label1";
            label1.Size = new Size(111, 17);
            label1.TabIndex = 14;
            label1.Text = "Rozmiar pojemnika";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(191, 85);
            label2.Name = "label2";
            label2.Size = new Size(228, 17);
            label2.TabIndex = 15;
            label2.Text = "Procentowa zawartość alkoholu w napoju";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gray;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(456, 83);
            label3.Name = "label3";
            label3.Size = new Size(86, 17);
            label3.TabIndex = 16;
            label3.Text = "Liczba statków";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 576);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox7);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}

