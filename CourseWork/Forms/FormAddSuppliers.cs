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
    public partial class FormAddSuppliers : Form
    {
        DB db = new DB();
        public FormAddSuppliers()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            textBox1.MaxLength = 55;
            textBox2.MaxLength = 60;
            textBox3.MaxLength = 30;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "" & textBox3.Text != "")
            {
                db.openConection();
                string procedureName = "add_supplier";
                MySqlCommand c = new MySqlCommand(procedureName, db.getConnection());
                c.CommandType = CommandType.StoredProcedure;
                c.Parameters.AddWithValue("@sfn", textBox1.Text);
                c.Parameters.AddWithValue("@adress", textBox2.Text);
                c.Parameters.AddWithValue("@sphone", textBox3.Text);
                c.ExecuteNonQuery();
                MessageBox.Show("Постачальник додан до списку!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Перевірте коректність ведених даних!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
