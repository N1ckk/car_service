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

namespace CourseWork.Forms
{
    public partial class FormAddModel : Form
    {
        public FormAddModel()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        DB db = new DB();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                db.openConection();
                string procedureName = "add_model";
                MySqlCommand c = new MySqlCommand(procedureName, db.getConnection());
                c.CommandType = CommandType.StoredProcedure;
                c.Parameters.AddWithValue("@car_m", textBox1.Text);
                c.ExecuteNonQuery();
                MessageBox.Show("Модель була успішно додана!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Перевірте коректність ведених даних!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
