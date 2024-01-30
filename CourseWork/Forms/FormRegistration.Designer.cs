namespace CourseWork.Forms
{
    partial class FormRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistration));
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            registration = new Button();
            passBox1 = new TextBox();
            loginBox = new TextBox();
            passBox = new TextBox();
            button1 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(55, 200, 130);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1734, 80);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(759, 20);
            label1.Name = "label1";
            label1.Size = new Size(232, 42);
            label1.TabIndex = 0;
            label1.Text = "Реєстрація";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(registration);
            panel1.Controls.Add(passBox1);
            panel1.Controls.Add(loginBox);
            panel1.Controls.Add(passBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(1734, 815);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1099, 411);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 40);
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1096, 411);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 40);
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1099, 320);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(45, 40);
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1096, 320);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 40);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(630, 419);
            label4.Name = "label4";
            label4.Size = new Size(96, 29);
            label4.TabIndex = 30;
            label4.Text = "Пароль";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(630, 328);
            label3.Name = "label3";
            label3.Size = new Size(96, 29);
            label3.TabIndex = 29;
            label3.Text = "Пароль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(630, 241);
            label2.Name = "label2";
            label2.Size = new Size(74, 29);
            label2.TabIndex = 28;
            label2.Text = "Логін";
            // 
            // registration
            // 
            registration.FlatAppearance.BorderColor = Color.FromArgb(51, 51, 76);
            registration.FlatAppearance.MouseOverBackColor = Color.White;
            registration.FlatStyle = FlatStyle.Flat;
            registration.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            registration.Location = new Point(924, 503);
            registration.Name = "registration";
            registration.Size = new Size(220, 53);
            registration.TabIndex = 27;
            registration.Text = "Зареєструватися";
            registration.UseVisualStyleBackColor = true;
            registration.Click += registration_Click;
            // 
            // passBox1
            // 
            passBox1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            passBox1.Location = new Point(766, 411);
            passBox1.Name = "passBox1";
            passBox1.Size = new Size(311, 41);
            passBox1.TabIndex = 26;
            passBox1.UseSystemPasswordChar = true;
            // 
            // loginBox
            // 
            loginBox.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            loginBox.Location = new Point(766, 233);
            loginBox.Multiline = true;
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(311, 41);
            loginBox.TabIndex = 24;
            loginBox.UseSystemPasswordChar = true;
            // 
            // passBox
            // 
            passBox.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            passBox.Location = new Point(766, 320);
            passBox.Name = "passBox";
            passBox.Size = new Size(311, 41);
            passBox.TabIndex = 23;
            passBox.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.FromArgb(51, 51, 76);
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(630, 503);
            button1.Name = "button1";
            button1.Size = new Size(220, 53);
            button1.TabIndex = 33;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1734, 895);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormRegistration";
            Text = "Реєстрація";
            FormClosed += FormRegistration_FormClosed;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Button registration;
        private TextBox passBox1;
        private TextBox loginBox;
        private TextBox passBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Button button1;
    }
}