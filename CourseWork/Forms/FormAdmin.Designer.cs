namespace CourseWork.Forms
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            panelDesktopPane = new Panel();
            panelDesktopPanel = new Panel();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnReporting = new Button();
            btnEditing = new Button();
            btnOrders = new Button();
            btnDetails = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            panelTitleBar = new Panel();
            lblTitle = new Label();
            panelDesktopPane.SuspendLayout();
            panel1.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Controls.Add(panelDesktopPanel);
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(220, 80);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(1514, 815);
            panelDesktopPane.TabIndex = 5;
            // 
            // panelDesktopPanel
            // 
            panelDesktopPanel.Dock = DockStyle.Fill;
            panelDesktopPanel.Location = new Point(0, 0);
            panelDesktopPanel.Name = "panelDesktopPanel";
            panelDesktopPanel.Size = new Size(1514, 815);
            panelDesktopPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 47, 51);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnReporting);
            panel1.Controls.Add(btnEditing);
            panel1.Controls.Add(btnOrders);
            panel1.Controls.Add(btnDetails);
            panel1.Controls.Add(panelLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 895);
            panel1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Gainsboro;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 345);
            button2.Name = "button2";
            button2.Size = new Size(220, 53);
            button2.TabIndex = 7;
            button2.Text = "  Звіти";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Gainsboro;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 292);
            button1.Name = "button1";
            button1.Size = new Size(220, 53);
            button1.TabIndex = 6;
            button1.Text = "   Співробітники";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btnReporting
            // 
            btnReporting.Dock = DockStyle.Top;
            btnReporting.FlatAppearance.BorderSize = 0;
            btnReporting.FlatStyle = FlatStyle.Flat;
            btnReporting.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnReporting.ForeColor = Color.Gainsboro;
            btnReporting.Image = (Image)resources.GetObject("btnReporting.Image");
            btnReporting.ImageAlign = ContentAlignment.MiddleLeft;
            btnReporting.Location = new Point(0, 239);
            btnReporting.Name = "btnReporting";
            btnReporting.Size = new Size(220, 53);
            btnReporting.TabIndex = 5;
            btnReporting.Text = "  Постчальники";
            btnReporting.TextAlign = ContentAlignment.MiddleLeft;
            btnReporting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReporting.UseVisualStyleBackColor = true;
            btnReporting.Click += button1_Click;
            // 
            // btnEditing
            // 
            btnEditing.Dock = DockStyle.Top;
            btnEditing.FlatAppearance.BorderSize = 0;
            btnEditing.FlatStyle = FlatStyle.Flat;
            btnEditing.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditing.ForeColor = Color.Gainsboro;
            btnEditing.Image = (Image)resources.GetObject("btnEditing.Image");
            btnEditing.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditing.Location = new Point(0, 186);
            btnEditing.Name = "btnEditing";
            btnEditing.Size = new Size(220, 53);
            btnEditing.TabIndex = 4;
            btnEditing.Text = "   Додавання";
            btnEditing.TextAlign = ContentAlignment.MiddleLeft;
            btnEditing.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditing.UseVisualStyleBackColor = true;
            btnEditing.Click += btnReporting_Click;
            // 
            // btnOrders
            // 
            btnOrders.Dock = DockStyle.Top;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrders.ForeColor = Color.Gainsboro;
            btnOrders.Image = (Image)resources.GetObject("btnOrders.Image");
            btnOrders.ImageAlign = ContentAlignment.BottomLeft;
            btnOrders.Location = new Point(0, 133);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(220, 53);
            btnOrders.TabIndex = 2;
            btnOrders.Text = " Постачання";
            btnOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnOrders.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnDetails
            // 
            btnDetails.Dock = DockStyle.Top;
            btnDetails.FlatAppearance.BorderSize = 0;
            btnDetails.FlatStyle = FlatStyle.Flat;
            btnDetails.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDetails.ForeColor = Color.Gainsboro;
            btnDetails.Image = (Image)resources.GetObject("btnDetails.Image");
            btnDetails.ImageAlign = ContentAlignment.MiddleLeft;
            btnDetails.Location = new Point(0, 80);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(220, 53);
            btnDetails.TabIndex = 0;
            btnDetails.Text = "  Деталі";
            btnDetails.TextAlign = ContentAlignment.MiddleLeft;
            btnDetails.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDetails.UseVisualStyleBackColor = true;
            btnDetails.Click += btnDetails_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(13, 44, 51);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(49, 30);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 0;
            label1.Text = "Автосервіс";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(55, 200, 130);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1514, 80);
            panelTitleBar.TabIndex = 4;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(655, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(205, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Головне меню";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1734, 895);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panel1);
            Name = "FormAdmin";
            Text = "Автосервіс";
            FormClosed += FormAdmin_FormClosed;
            Load += FormAdmin_Load;
            panelDesktopPane.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDesktopPane;
        private Panel panelDesktopPanel;
        private Panel panel1;
        private Button btnEditing;
        private Button btnOrders;
        private Button btnDetails;
        private Panel panelLogo;
        private Label label1;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Button btnReporting;
        private Button button1;
        private Button button2;
    }
}