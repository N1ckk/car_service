using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork.Forms
{
    public partial class FormOrder : Form
    {
        DB db = new DB();
        public static string nam_e = String.Empty;
        public static string phone = String.Empty;
        public static bool state = false;

        public FormOrder()
        {
            InitializeComponent();
            LoadTheme();
            ShowCombo1();
            if (state == true )
            {
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
            if(FormMyCabinet.s==true)
            {
                
            }
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            name_clientBox.MaxLength = 55;
            phoneBox.MaxLength = 30;
            name_clientBox.Text = nam_e;
            phoneBox.Text = phone;

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

        public static string full_name = String.Empty;
        public static string mobile_n = String.Empty;
        public static string brand = String.Empty;
        public static string model = String.Empty;
        public static string name = String.Empty;
        public static int quantity = 0;
        public static int p = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            string procedureName = "order_r";
            string full_n = name_clientBox.Text;
            string mobile = phoneBox.Text;
            nam_e = full_n;
            phone = mobile;
            if ((Regex.IsMatch(mobile, @"^\+380\d{9}$")) & (full_n.Any(char.IsLetter)) & (comboBox1.SelectedItem != null)
            & (comboBox2.SelectedItem != null) & (comboBox3.SelectedItem != null) & (comboBox4.SelectedItem != null))
            {
                db.openConection();
                pictureBox1.Visible = true;
                string price = String.Empty;
                string car_b = comboBox1.SelectedItem.ToString();
                string car_m = comboBox2.SelectedItem.ToString();
                string named = comboBox3.SelectedItem.ToString();
                int q = Convert.ToInt32(comboBox4.SelectedItem);
                MySqlCommand c1 = new MySqlCommand($"select price_d*{q} from details join car_brand_model using (id_mm) join car_brand using (id_b)" +
    $" join car_model using (id_m) where brand = '{car_b}' and model = '{car_m}' and name = '{named}'", db.getConnection());
                MySqlDataReader reader = c1.ExecuteReader();
                while (reader.Read())
                {
                    decimal pricee = reader.GetDecimal($"price_d*{q}");
                    p = p + Convert.ToInt32(pricee);
                }
                reader.Close();
                MySqlCommand command = new MySqlCommand(procedureName, db.getConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@full_n", full_n);
                command.Parameters.AddWithValue("@car_b", car_b);
                command.Parameters.AddWithValue("@car_m", car_m);
                command.Parameters.AddWithValue("@mobile", mobile);
                command.Parameters.AddWithValue("@named", named);
                command.Parameters.AddWithValue("@q", q);
                command.ExecuteNonQuery();
                full_name = name_clientBox.Text;
                mobile_n = phoneBox.Text;
                brand = car_b;
                model = car_m;
                name = named;
                quantity = q;
                string proc = "add_fio";
                MySqlCommand c = new MySqlCommand(proc, db.getConnection());
                c.CommandType = CommandType.StoredProcedure;
                c.Parameters.AddWithValue("@full", full_n);
                c.Parameters.AddWithValue("@login", FormLogin.login);
                c.ExecuteNonQuery();
                state = true;
                MessageBox.Show("Замовлення прийнято! З вас " + p + " грн", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Замовлення НЕ прийнято. Перевірте коректність введених даних!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {

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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Enabled = true;
            comboBox4.Items.Clear();
            ShowCombo4();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Enabled = false;
            comboBox3.Enabled = true;
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            ShowCombo3();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (FormMyCabinet.s == true)
            {
                MessageBox.Show("Замовлення прийнято! З вас " + FormMyCabinet.g + " грн", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Замовлення прийнято! З вас " + p + " грн", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }
    }
}