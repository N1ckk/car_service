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
    public partial class FormDetails2Two : Form
    {
        DB db = new DB();
        public FormDetails2Two()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            textBox1.MaxLength = 50;
            textBox2.MaxLength = 120;
            comboBox2.Enabled = false;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            ShowCombo1();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") & (textBox2.Text != "") & (comboBox1.SelectedItem != null) & (comboBox2.SelectedItem != null))
            {
                string car_b = comboBox1.SelectedItem.ToString();
                string car_m = comboBox2.SelectedItem.ToString();
                db.openConection();
                string procedureName = "add_detail";
                MySqlCommand c = new MySqlCommand(procedureName, db.getConnection());
                c.CommandType = CommandType.StoredProcedure;
                c.Parameters.AddWithValue("@namee", textBox1.Text);
                c.Parameters.AddWithValue("@des", textBox2.Text);
                c.Parameters.AddWithValue("@car_b", car_b);
                c.Parameters.AddWithValue("@car_m", car_m);
                c.ExecuteNonQuery();
                MessageBox.Show("Деталь додана до списку деталей. Тепер замовте поставку доданої деталі!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = true;
            comboBox2.Items.Clear();
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
    }
}
