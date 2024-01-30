namespace CourseWork.Forms
{
    partial class FormSuppliersInfo
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
            dataGridView1 = new DataGridView();
            dgw2 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgw2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(214, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(689, 299);
            dataGridView1.TabIndex = 31;
            dataGridView1.CellEndEdit += dgw_CellEndEdit;
            dataGridView1.SelectionChanged += dgw_SelectionChanged;
            // 
            // dgw2
            // 
            dgw2.AllowUserToAddRows = false;
            dgw2.AllowUserToDeleteRows = false;
            dgw2.BackgroundColor = SystemColors.Control;
            dgw2.BorderStyle = BorderStyle.None;
            dgw2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw2.Location = new Point(214, 543);
            dgw2.Name = "dgw2";
            dgw2.ReadOnly = true;
            dgw2.RowHeadersVisible = false;
            dgw2.RowHeadersWidth = 51;
            dgw2.RowTemplate.Height = 29;
            dgw2.Size = new Size(1015, 241);
            dgw2.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(403, 34);
            label1.Name = "label1";
            label1.Size = new Size(306, 32);
            label1.TabIndex = 33;
            label1.Text = "Список постчальників";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(531, 477);
            label2.Name = "label2";
            label2.Size = new Size(348, 32);
            label2.TabIndex = 34;
            label2.Text = "Інформація про поставки";
            label2.Click += label2_Click;
            // 
            // FormSuppliersInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1734, 895);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgw2);
            Controls.Add(dataGridView1);
            Name = "FormSuppliersInfo";
            Text = "Постачальники";
            Load += FormSuppliersInfo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgw2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dgw2;
        private Label label1;
        private Label label2;
    }
}