using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork.Forms
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            //label1.ForeColor = ThemeColor.SecondaryColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDetails2Two F = new FormDetails2Two();
            F.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCarBrand f = new FormCarBrand();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAddSuppliers f = new FormAddSuppliers();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormAddBrand f = new FormAddBrand();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormAddModel f = new FormAddModel();
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormAddEmployee f = new FormAddEmployee();
            f.ShowDialog();
        }
    }
}
