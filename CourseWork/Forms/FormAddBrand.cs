using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CourseWork.Forms
{
    public partial class FormAddBrand : Form
    {
        public FormAddBrand()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        DB db = new DB();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                db.openConection();
                string procedureName = "add_brand";
                MySqlCommand c = new MySqlCommand(procedureName, db.getConnection());
                c.CommandType = CommandType.StoredProcedure;
                c.Parameters.AddWithValue("@car_b",textBox1.Text);
                c.ExecuteNonQuery();
                MessageBox.Show("Марка була успішно додана!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Перевірте коректність ведених даних!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
