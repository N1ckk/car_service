namespace CourseWork.Forms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            linkLabel = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            loginField = new TextBox();
            buttonLogin = new Button();
            passField = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(linkLabel);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(loginField);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(passField);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1734, 895);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(643, 411);
            label3.Name = "label3";
            label3.Size = new Size(96, 29);
            label3.TabIndex = 12;
            label3.Text = "Пароль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(643, 324);
            label2.Name = "label2";
            label2.Size = new Size(74, 29);
            label2.TabIndex = 11;
            label2.Text = "Логін";
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.BorderStyle = BorderStyle.FixedSingle;
            linkLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel.Location = new Point(815, 582);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new Size(152, 20);
            linkLabel.TabIndex = 10;
            linkLabel.Text = "Ще немає аккаунта?";
            linkLabel.Click += linkLabel_Click;
            linkLabel.MouseLeave += linkLabel_MouseLeave;
            linkLabel.MouseHover += linkLabel_MouseHover;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1098, 410);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(45, 40);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1095, 410);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 40);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // loginField
            // 
            loginField.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            loginField.Location = new Point(766, 324);
            loginField.Multiline = true;
            loginField.Name = "loginField";
            loginField.ShortcutsEnabled = false;
            loginField.Size = new Size(311, 41);
            loginField.TabIndex = 6;
            loginField.TabStop = false;
            loginField.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            buttonLogin.FlatAppearance.BorderColor = Color.FromArgb(51, 51, 76);
            buttonLogin.FlatAppearance.MouseOverBackColor = Color.White;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogin.Location = new Point(785, 505);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(220, 53);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Увійти";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            buttonLogin.MouseLeave += button1_MouseLeave;
            buttonLogin.MouseHover += button1_MouseHover;
            // 
            // passField
            // 
            passField.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            passField.Location = new Point(766, 410);
            passField.Name = "passField";
            passField.Size = new Size(311, 41);
            passField.TabIndex = 4;
            passField.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(55, 200, 130);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1734, 80);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(751, 18);
            label1.Name = "label1";
            label1.Size = new Size(232, 42);
            label1.TabIndex = 0;
            label1.Text = "Авторизація";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1734, 895);
            Controls.Add(panel1);
            Name = "FormLogin";
            Text = "Вхід/Реєстрація";
            FormClosed += FormLogin_FormClosed;
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox passField;
        private Button buttonLogin;
        private TextBox loginField;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label linkLabel;
        private Label label3;
        private Label label2;
    }
}