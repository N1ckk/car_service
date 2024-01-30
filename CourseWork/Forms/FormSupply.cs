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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CourseWork.Forms
{
    public partial class FormSupply : Form
    {
        DB db = new DB();
        public FormSupply()
        {
            InitializeComponent();
            LoadTheme();
            ShowCombo1();
            ShowCombo2();
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            priceBox.MaxLength = 15;
        }

        private void ShowCombo1()
        {
            db.openConection();
            string query = "select s_full_name from supply_workers;";
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string value = reader["s_full_name"].ToString();
                comboBox1.Items.Add(value);
            }
            reader.Close();
        }

        private void ShowCombo2()
        {
            db.openConection();
            string query = "select brand from car_brand;";
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string value = reader["brand"].ToString();
                comboBox2.Items.Add(value);
            }
            reader.Close();
        }

        private void ShowCombo4()
        {
            db.openConection();
            string query = $"select name from details join car_brand_model using (id_mm) join car_brand using (id_b) join car_model " +
                $"using (id_m) where brand = '{comboBox2.SelectedItem.ToString()}' " +
                $"and model = '{comboBox3.SelectedItem.ToString()}';";
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string value = reader["name"].ToString();
                comboBox4.Items.Add(value);
            }
            reader.Close();
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
            string procedureName = "supplie";
            string price = priceBox.Text;
            int number;
            if ((int.TryParse(price, out _)) & (comboBox1.SelectedItem != null) & (comboBox2.SelectedItem != null) & (comboBox3.SelectedItem != null) &
                (comboBox4.SelectedItem != null) & (int.TryParse(textBox1.Text, out number)))
            {
                int price1 = Convert.ToInt32(price);
                db.openConection();
                MySqlCommand command = new MySqlCommand(procedureName, db.getConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@full_n", comboBox1.SelectedItem.ToString());
                command.Parameters.AddWithValue("@car_b", comboBox2.SelectedItem.ToString());
                command.Parameters.AddWithValue("@car_m", comboBox3.SelectedItem.ToString());
                command.Parameters.AddWithValue("@namee", comboBox4.SelectedItem.ToString());
                command.Parameters.AddWithValue("@price", Convert.ToInt32(priceBox.Text));
                command.Parameters.AddWithValue("@sq", number);
                command.ExecuteNonQuery();
                MessageBox.Show("Поствка зафіксована", "Постачання", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Поставка НЕ зафіксована. Перевірте коректність введених даних", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Enabled = true;
            comboBox4.Enabled = false;
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            db.openConection();
            string query = $"select model from car_model join car_brand_model using (id_m) join car_brand using (id_b) where brand = '{comboBox2.SelectedItem.ToString()}'; ";
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string value = reader["model"].ToString();
                comboBox3.Items.Add(value);
            }
            reader.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Enabled = true;
            comboBox4.Items.Clear();
            ShowCombo4();
        }
    }
}
