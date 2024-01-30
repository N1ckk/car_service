using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;
using System.Collections;
using Microsoft.VisualBasic.ApplicationServices;

namespace CourseWork.Forms
{
    public partial class FormMyCabinet : Form
    {
        DB db = new DB();
        string log = String.Empty;
        string pass = String.Empty;
        public FormMyCabinet()
        {
            InitializeComponent();
            button3.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label12.Visible = false;
            name_clientBox.Visible = false;
            phoneBox.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            LoadTheme();
            loginField.Text = FormLogin.login;
            passField.Text = FormLogin.password;
            log = loginField.Text;
            pass = passField.Text;
            ShowFIO();
            ShowOrder();
        }

        private void ShowCombo1()
        {
            db.openConection();
            string query = "select brand from car_brand;";
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string value = reader["brand"].ToString();
                comboBox1.Items.Add(value);
            }
            reader.Close();
        }

        private void ShowCombo3()
        {
            db.openConection();
            string query = $"select name from details join car_brand_model using (id_mm) join car_brand using (id_b) join car_model " +
                $"using (id_m) where brand = '{comboBox1.SelectedItem.ToString()}' " +
                $"and model = '{comboBox2.SelectedItem.ToString()}';";
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string value = reader["name"].ToString();
                comboBox3.Items.Add(value);
            }
            reader.Close();
        }

        private void ShowCombo4()
        {
            db.openConection();
            string query = $"select quantity from details join car_brand_model using (id_mm) join car_brand using (id_b) join car_model " +
                $"using (id_m) where brand = '{comboBox1.SelectedItem.ToString()}' " +
                $"and model = '{comboBox2.SelectedItem.ToString()}';";
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            int result = Convert.ToInt32(command.ExecuteScalar());
            for (int i = 1; i < result + 1; i++)
            {
                comboBox4.Items.Add(Convert.ToInt32(i));
            }
        }
        public int globalres = 0;

        public void ShowFIO()
        {
            db.openConection();
            string s = $"select id_c from users where u_login = '{log}'";
            MySqlCommand com = new MySqlCommand(s, db.getConnection());
            int result = Convert.ToInt32(com.ExecuteScalar());
            globalres = result;
            string s1 = $"select c_full_name from client join users using (id_c) where id_c = {result}";
            MySqlCommand command = new MySqlCommand(s1, db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            string res = String.Empty;
            while (reader.Read())
            {
                string value = reader.GetString("c_full_name");
                res += value + Environment.NewLine;
            }
            reader.Close();
            string s2 = $"select c_mob_number from client join users using (id_c) where id_c = {result}";
            MySqlCommand com1 = new MySqlCommand(s2, db.getConnection());
            MySqlDataReader reader1 = com1.ExecuteReader();
            string res1 = String.Empty;
            while (reader1.Read())
            {
                string value1 = reader1.GetString("c_mob_number");
                res1 += value1 + Environment.NewLine;
            }
            reader1.Close();
            textBox2.Visible = true;
            label11.Visible = true;
            label10.Visible = true;
            textBox1.Visible = true;
            textBox2.Text = res;
            textBox1.Text = res1;
        }

        private void ShowOrder()
        {
            if (FormOrder.state == true)
            {
                textBox2.Visible = false;
                label11.Visible = false;
                label10.Visible = false;
                textBox1.Visible = false;
                button3.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label12.Visible = true;
                name_clientBox.Visible = true;
                phoneBox.Visible = true;
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
                name_clientBox.Text = FormOrder.full_name;
                phoneBox.Text = FormOrder.mobile_n;
                ShowCombo1();
                comboBox1.SelectedItem = $"{FormOrder.brand}";
                comboBox2.SelectedItem = $"{FormOrder.model}";
                comboBox3.SelectedItem = $"{FormOrder.name}";
                comboBox4.SelectedItem = $"{FormOrder.quantity}";
                label12.Text = "З вас " + Convert.ToString(FormOrder.p) + " грн";
            }
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loginField.Text != log)
            {
                db.openConection();
                MySqlCommand comm = new MySqlCommand($"select id_u from users where u_login = '{log}'", db.getConnection());
                object result = comm.ExecuteScalar();
                int userId = Convert.ToInt32(result);
                MySqlCommand command = new MySqlCommand("UPDATE car_service.users SET u_login=@Column1 WHERE id_u=@ID", db.getConnection());
                command.Parameters.AddWithValue("@Column1", loginField.Text);
                command.Parameters.AddWithValue("@ID", userId);
                command.ExecuteNonQuery();
                log = loginField.Text;
                MessageBox.Show("Логін змінено!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Логін не змінено!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (passField.Text != pass)
            {
                db.openConection();
                MySqlCommand comm = new MySqlCommand($"select id_u from users where password = '{pass}'", db.getConnection());
                object result = comm.ExecuteScalar();
                int userId = Convert.ToInt32(result);
                MySqlCommand command = new MySqlCommand("UPDATE car_service.users SET password=@Column1 WHERE id_u=@ID", db.getConnection());
                command.Parameters.AddWithValue("@Column1", passField.Text);
                command.Parameters.AddWithValue("@ID", userId);
                command.ExecuteNonQuery();
                pass = passField.Text;
                MessageBox.Show("Пароль змінено!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Пароль не змінено!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox2.Enabled = true;
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            db.openConection();
            string query = $"select model from car_model join car_brand_model using (id_m) join car_brand using (id_b) where brand = '{comboBox1.SelectedItem.ToString()}'; ";
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string value = reader["model"].ToString();
                comboBox2.Items.Add(value);
            }
            reader.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Enabled = false;
            comboBox3.Enabled = true;
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            ShowCombo3();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Enabled = true;
            comboBox4.Items.Clear();
            ShowCombo4();
        }
        public static bool s = false;
        public static string g = "";

        private void button3_Click(object sender, EventArgs e)
        {
            string procedureName = "EditOrder";
            if ((Regex.IsMatch(phoneBox.Text, @"^\+380\d{9}$")) & (name_clientBox.Text.Any(char.IsLetter)) & (comboBox1.SelectedItem != null)
            & (comboBox2.SelectedItem != null) & (comboBox3.SelectedItem != null) & (comboBox4.SelectedItem != null))
            {
                s = true;
                string car_b = comboBox1.SelectedItem.ToString();
                string car_m = comboBox2.SelectedItem.ToString();
                string named = comboBox3.SelectedItem.ToString();
                int q = Convert.ToInt32(comboBox4.SelectedItem);
                db.openConection();
                MySqlCommand command = new MySqlCommand(procedureName, db.getConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@full_n", name_clientBox.Text);
                command.Parameters.AddWithValue("@car_b", car_b);
                command.Parameters.AddWithValue("@car_m", car_m);
                command.Parameters.AddWithValue("@mobile", phoneBox.Text);
                command.Parameters.AddWithValue("@named", named);
                command.Parameters.AddWithValue("@q", q);
                command.Parameters.AddWithValue("@q1", FormOrder.quantity);
                command.ExecuteNonQuery();
                MySqlCommand c1 = new MySqlCommand($"select price_d*{q} from details join car_brand_model using (id_mm) join car_brand using (id_b)" +
  $" join car_model using (id_m) where brand = '{car_b}' and model = '{car_m}' and name = '{named}'", db.getConnection());
                MySqlDataReader reader = c1.ExecuteReader();
                while (reader.Read())
                {
                    decimal pricee = reader.GetDecimal($"price_d*{q}");
                    FormOrder.p = 0;
                    FormOrder.p = Convert.ToInt32(pricee);
                }
                reader.Close();
                g = Convert.ToString(FormOrder.p);
                label12.Text = "З вас " + Convert.ToString(FormOrder.p) + " грн";
                MessageBox.Show("Замовлення відредаговано!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Замовлення НЕ відредаговано. Перевірте коректність введених даних!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void name_clientBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("UPDATE car_service.client SET c_full_name=@Column1 WHERE id_c=@ID", db.getConnection());
            command.Parameters.AddWithValue("@Column1", textBox2.Text);
            command.Parameters.AddWithValue("@ID", globalres);
            command.ExecuteNonQuery();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("UPDATE car_service.client SET c_mob_number=@Column1 WHERE id_c=@ID", db.getConnection());
            command.Parameters.AddWithValue("@Column1", textBox1.Text);
            command.Parameters.AddWithValue("@ID", globalres);
            command.ExecuteNonQuery();
        }
    }
}
