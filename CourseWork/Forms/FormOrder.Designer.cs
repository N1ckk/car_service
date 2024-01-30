namespace CourseWork.Forms
{
    partial class FormOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
            button1 = new Button();
            label1 = new Label();
            name_clientBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            phoneBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(636, 525);
            button1.Name = "button1";
            button1.Size = new Size(250, 68);
            button1.TabIndex = 0;
            button1.Text = "Замовити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(599, 462);
            label1.Name = "label1";
            label1.Size = new Size(133, 18);
            label1.TabIndex = 1;
            label1.Text = "Кількість деталей";
            // 
            // name_clientBox
            // 
            name_clientBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            name_clientBox.Location = new Point(773, 196);
            name_clientBox.Name = "name_clientBox";
            name_clientBox.Size = new Size(169, 24);
            name_clientBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(599, 199);
            label2.Name = "label2";
            label2.Size = new Size(123, 18);
            label2.TabIndex = 3;
            label2.Text = "ПІБ користувача";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(599, 300);
            label3.Name = "label3";
            label3.Size = new Size(138, 18);
            label3.TabIndex = 6;
            label3.Text = "Марка автомобіля";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(599, 351);
            label4.Name = "label4";
            label4.Size = new Size(140, 18);
            label4.TabIndex = 7;
            label4.Text = "Модель автомібля";
            // 
            // phoneBox
            // 
            phoneBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            phoneBox.Location = new Point(773, 247);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(169, 24);
            phoneBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(599, 247);
            label5.Name = "label5";
            label5.Size = new Size(149, 18);
            label5.TabIndex = 9;
            label5.Text = "Мобільний телефон";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(599, 407);
            label6.Name = "label6";
            label6.Size = new Size(99, 18);
            label6.TabIndex = 10;
            label6.Text = "Назва деталі";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(615, 123);
            label7.Name = "label7";
            label7.Size = new Size(312, 29);
            label7.TabIndex = 13;
            label7.Text = "Оформлення замовлення";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(773, 348);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(169, 26);
            comboBox2.TabIndex = 17;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(775, 297);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(169, 26);
            comboBox1.TabIndex = 16;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(773, 404);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(169, 26);
            comboBox3.TabIndex = 18;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(773, 459);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(169, 26);
            comboBox4.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(933, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 33);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormOrder
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 806);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(phoneBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(name_clientBox);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormOrder";
            Text = "Замовлення";
            Load += FormOrder_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox name_clientBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox phoneBox;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private PictureBox pictureBox1;
    }
}