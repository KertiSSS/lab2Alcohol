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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(874, 444);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(144, 120);
            button1.TabIndex = 0;
            button1.Text = "Wynik";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Wynik_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(12, 96);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 14;
            label1.Text = "Rozmiar pojemnika";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(191, 96);
            label2.Name = "label2";
            label2.Size = new Size(226, 15);
            label2.TabIndex = 15;
            label2.Text = "Procentowa zawartość alkoholu w napoju";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(481, 96);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 16;
            label3.Text = "Liczba drinków";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(364, 9);
            label4.Name = "label4";
            label4.Size = new Size(300, 32);
            label4.TabIndex = 17;
            label4.Text = "Alcohol Content Calculator";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(483, 155);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(84, 25);
            textBox1.TabIndex = 18;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 157);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(109, 23);
            comboBox1.TabIndex = 20;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.White;
            comboBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(191, 153);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(226, 25);
            comboBox2.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(638, 96);
            label5.Name = "label5";
            label5.Size = new Size(147, 15);
            label5.TabIndex = 22;
            label5.Text = "Całkowita objętość napoju";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(638, 155);
            label6.Name = "label6";
            label6.Size = new Size(152, 15);
            label6.TabIndex = 23;
            label6.Text = "Objętość czystego alkoholu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(874, 96);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(874, 155);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 576);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private ComboBox comboBox1;
        public ComboBox comboBox2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}

