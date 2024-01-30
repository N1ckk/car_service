namespace CourseWork.Forms
{
    partial class FormWorkersInfo
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
            dgw = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgw).BeginInit();
            SuspendLayout();
            // 
            // dgw
            // 
            dgw.AllowUserToAddRows = false;
            dgw.AllowUserToDeleteRows = false;
            dgw.BackgroundColor = SystemColors.Control;
            dgw.BorderStyle = BorderStyle.None;
            dgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw.Location = new Point(214, 136);
            dgw.Name = "dgw";
            dgw.RowHeadersVisible = false;
            dgw.RowHeadersWidth = 51;
            dgw.RowTemplate.Height = 29;
            dgw.Size = new Size(721, 343);
            dgw.TabIndex = 30;
            dgw.CellEndEdit += dgw_CellEndEdit;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(358, 72);
            label1.Name = "label1";
            label1.Size = new Size(408, 32);
            label1.TabIndex = 31;
            label1.Text = "Список співробітників сервісу";
            // 
            // FormWorkersInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1734, 895);
            Controls.Add(label1);
            Controls.Add(dgw);
            Name = "FormWorkersInfo";
            Text = "Співробітники";
            ((System.ComponentModel.ISupportInitialize)dgw).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgw;
        private Label label1;
    }
}