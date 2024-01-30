using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CourseWork.Forms
{
    public partial class FormLogin : Form
    {
        public static FormLogin Instance;
        public static string login { get; set; }
        public static string password { get; set; }
        DB db = new DB();

        public FormLogin()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            loginField.MaxLength = 55;
            passField.MaxLength = 75;
            Instance = this;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            db.openConection();
            string query = $"SELECT Role FROM Users WHERE u_login='{loginField.Text}' AND password='{passField.Text}'";
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                string role = reader.GetString(0);
                if (role == "user")
                {
                    login = loginField.Text;
                    password = passField.Text;
                    FormClient fc = new FormClient();
                    reader.Close();
                    MessageBox.Show("Ви успішно авторизувалися!", "Авторизація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fc.ShowDialog();
                    this.Hide();
                }
                else
                {
                    FormAdmin fa = new FormAdmin(this);
                    MessageBox.Show("Ви успішно авторизувалися!", "Авторизація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fa.ShowDialog();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("НЕ авторизовано! Перевірте коректність введених даних.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            reader.Close();
        }


        private void button1_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            passField.UseSystemPasswordChar = false;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            passField.UseSystemPasswordChar = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
        }

        private void linkLabel_Click(object sender, EventArgs e)
        {
            FormRegistration fr = new FormRegistration();
            fr.Show();
            this.Hide();
        }

        private void linkLabel_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void linkLabel_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
