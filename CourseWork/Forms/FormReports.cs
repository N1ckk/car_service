using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork.Forms
{
    public partial class FormReports : Form
    {

        DB db = new DB();

        public FormReports()
        {
            InitializeComponent();
            LoadTheme();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            ShowCombo1();
            ShowCombo2();
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

        private void FormReports_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = -1;
            label5.Text = label2.Text;
            int p1 = Convert.ToInt32(comboBox1.SelectedItem.ToString());
            dgw.DataSource = null;
            dgw.Rows.Clear();
            dgw.Columns.Clear();
            db.openConection();
            string s = $"call purchase_details({p1})";
            MySqlCommand command = new MySqlCommand(s, db.getConnection());
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            dgw.DataSource = table;
            decimal sum = 0;
            int lastRowIndex = table.Rows.Count - 1;
            int lastColumnIndex = table.Columns.Count - 1;
            DataRow newRow = table.NewRow();
            table.Rows.Add(newRow);

            // Проходим по каждой строке и суммируем значения последнего столбца
            foreach (DataRow row in table.Rows)
            {
                if (row[lastColumnIndex] != DBNull.Value)
                {
                    sum += Convert.ToDecimal(row[lastColumnIndex]);
                }
            }

            // Устанавливаем значение суммы в последнюю ячейку новой строки
            newRow[lastColumnIndex] = sum;

            // Привязываем обновленный DataTable к DataGridView
            dgw.DataSource = table;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ShowCombo1()
        {
            for (int i = 1; i < 13; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
        }

        private void ShowCombo2()
        {
            for (int i = 1; i < 13; i++)
            {
                comboBox2.Items.Add(i.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            label5.Text = label3.Text;
            int p2 = Convert.ToInt32(comboBox2.SelectedItem.ToString());
            dgw.DataSource = null;
            dgw.Rows.Clear();
            dgw.Columns.Clear();

            db.openConection();
            string s = $"call consumption_details({p2})";
            MySqlCommand command = new MySqlCommand(s, db.getConnection());
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table); // Заполняем таблицу данными
            dgw.DataSource = table;

            DataRow newRow = table.NewRow();
            table.Rows.Add(newRow);

            int lastRowIndex = table.Rows.Count - 1;
            int lastColumnIndex = table.Columns.Count - 1;

            decimal sum = 0;

            // Проходим по каждой строке и суммируем значения последнего столбца
            foreach (DataRow row in table.Rows)
            {
                if (row[lastColumnIndex] != DBNull.Value)
                {
                    sum += Convert.ToDecimal(row[lastColumnIndex]);
                }
            }

            // Устанавливаем значение суммы в последнюю ячейку новой строки
            newRow[lastColumnIndex] = sum;

            // Привязываем обновленный DataTable к DataGridView
            dgw.DataSource = table;
        }
    }
}
