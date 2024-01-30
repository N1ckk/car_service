namespace CourseWork.Forms
{
    partial class FormSupply
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
            priceBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            textBox1 = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // priceBox
            // 
            priceBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            priceBox.Location = new Point(745, 472);
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(250, 24);
            priceBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(580, 200);
            label1.Name = "label1";
            label1.Size = new Size(141, 18);
            label1.TabIndex = 6;
            label1.Text = "ПІБ постачальника";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(580, 255);
            label2.Name = "label2";
            label2.Size = new Size(111, 18);
            label2.TabIndex = 7;
            label2.Text = "Марка машини";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(580, 315);
            label3.Name = "label3";
            label3.Size = new Size(122, 18);
            label3.TabIndex = 8;
            label3.Text = "Модель машини";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(580, 366);
            label4.Name = "label4";
            label4.Size = new Size(99, 18);
            label4.TabIndex = 9;
            label4.Text = "Назва деталі";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(580, 418);
            label5.Name = "label5";
            label5.Size = new Size(133, 18);
            label5.TabIndex = 10;
            label5.Text = "Кількість деталей";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(580, 472);
            label6.Name = "label6";
            label6.Size = new Size(96, 18);
            label6.TabIndex = 11;
            label6.Text = "Ціна за 1 од.";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(661, 536);
            button1.Name = "button1";
            button1.Size = new Size(245, 68);
            button1.TabIndex = 12;
            button1.Text = "Зафіксувати поставку";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(745, 197);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 26);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(745, 252);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(250, 26);
            comboBox2.TabIndex = 14;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(745, 307);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(250, 26);
            comboBox3.TabIndex = 15;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(745, 363);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(250, 26);
            comboBox4.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(745, 418);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 24);
            textBox1.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(684, 116);
            label7.Name = "label7";
            label7.Size = new Size(206, 29);
            label7.TabIndex = 18;
            label7.Text = "Додати поставку";
            // 
            // FormSupply
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1734, 895);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(priceBox);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormSupply";
            Text = "Постачання";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox priceBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private TextBox textBox1;
        private Label label7;
    }
}