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
    public partial class FormRegistration : Form
    {
        DB db = new DB();
        int k = 0;
        public FormRegistration()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            loginBox.MaxLength = 55;
            passBox.MaxLength = 75;
        }

        private void registration_Click(object sender, EventArgs e)
        {
            string result = String.Empty;
            db.openConection();
            MySqlCommand command = new MySqlCommand($"select u_login from users where u_login = '{loginBox.Text}';", db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            reader.Close();
            if ((loginBox.Text != "") & (passBox.Text != "") & (passBox1.Text != "") & (!reader.HasRows) & (passBox.Text == passBox1.Text))
            {
                k++;
                FormLogin f = new FormLogin();
                MySqlCommand com = new MySqlCommand($"call registration('{loginBox.Text}','{passBox1.Text}')", db.getConnection());
                com.ExecuteNonQuery();
                this.Close();
                f.Show();
                MessageBox.Show("Ви успішно зареєстровані", "Реєстрація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Логін вже зайнятий або введені паролі не співпадають!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            passBox.UseSystemPasswordChar = false;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            passBox.UseSystemPasswordChar = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            passBox1.UseSystemPasswordChar = false;
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            passBox1.UseSystemPasswordChar = true;
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
        }

        private void FormRegistration_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (k == 0)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            k++;
            FormLogin f = new FormLogin();
            f.Show();
            this.Close();
        }
    }
}
