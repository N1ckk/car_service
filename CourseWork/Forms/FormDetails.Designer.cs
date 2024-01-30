namespace CourseWork.Forms
{
    partial class FormDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetails));
            dgw = new DataGridView();
            pictureBox1 = new PictureBox();
            searchBox = new TextBox();
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton2 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgw).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgw
            // 
            dgw.AllowUserToAddRows = false;
            dgw.AllowUserToDeleteRows = false;
            dgw.BackgroundColor = SystemColors.Control;
            dgw.BorderStyle = BorderStyle.None;
            dgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw.Location = new Point(83, 127);
            dgw.Name = "dgw";
            dgw.ReadOnly = true;
            dgw.RowHeadersVisible = false;
            dgw.RowHeadersWidth = 51;
            dgw.RowTemplate.Height = 29;
            dgw.Size = new Size(1225, 316);
            dgw.TabIndex = 29;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(83, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 31);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // searchBox
            // 
            searchBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchBox.Location = new Point(124, 62);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(312, 24);
            searchBox.TabIndex = 27;
            searchBox.TextChanged += searchBox_TextChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(269, 471);
            label1.Name = "label1";
            label1.Size = new Size(224, 32);
            label1.TabIndex = 30;
            label1.Text = "Фільтри пошуку";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(83, 524);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(378, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Кількість в наявності, за зростанням";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged_1;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(468, 524);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(223, 29);
            radioButton3.TabIndex = 38;
            radioButton3.TabStop = true;
            radioButton3.Text = "Ціна, за зростанням";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton4.Location = new Point(468, 566);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(201, 29);
            radioButton4.TabIndex = 36;
            radioButton4.TabStop = true;
            radioButton4.Text = "Ціна, за спаднням";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(83, 566);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(366, 29);
            radioButton2.TabIndex = 35;
            radioButton2.TabStop = true;
            radioButton2.Text = "Кількість в наявності, за спаданням";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // FormDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1734, 895);
            Controls.Add(radioButton3);
            Controls.Add(radioButton4);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Controls.Add(radioButton2);
            Controls.Add(dgw);
            Controls.Add(pictureBox1);
            Controls.Add(searchBox);
            Name = "FormDetails";
            Text = "Пошук деталей";
            Load += FormDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dgw).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgw;
        private PictureBox pictureBox1;
        private TextBox searchBox;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton4;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
    }
}