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
    public partial class FormAddEmployee : Form
    {
        DB db = new DB();
        public FormAddEmployee()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                db.openConection();
                string procedureName = "add_employee";
                MySqlCommand c = new MySqlCommand(procedureName, db.getConnection());
                c.CommandType = CommandType.StoredProcedure;
                c.Parameters.AddWithValue("@full", textBox1.Text);
                c.Parameters.AddWithValue("@pos", textBox2.Text);
                c.Parameters.AddWithValue("@number", textBox3.Text);
                c.ExecuteNonQuery();
                MessageBox.Show("Працівник був успішно додан!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Перевірте коректність ведених даних!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
