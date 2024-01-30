using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CourseWork.Forms
{
    public partial class FormDetails : Form
    {
        DB db = new DB();
        FormLogin f = new FormLogin();

        public FormDetails()
        {
            InitializeComponent();
            LoadTheme();
            DetailsShow();
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
            //label1.ForeColor = ThemeColor.SecondaryColor;
        }

        public void DetailsShow()
        {
            dgw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgw.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            db.openConection();
            string s = "select name as Назва, description as Опис, brand as Марка, model as Модель, quantity as Кількість, price_d as Ціна from details " +
                "join car_brand_model using (id_mm) join car_brand using (id_b) join car_model using (id_m) where quantity>0;";
            MySqlCommand command = new MySqlCommand(s, db.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgw.DataSource = table;
        }

        private void butn_search_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void butn_search_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void FormDetails_Load(object sender, EventArgs e)
        {

        }

        private void searchBox_TextChanged_1(object sender, EventArgs e)
        {
            string searchText = searchBox.Text;
            MySqlCommand command = new MySqlCommand();
            if (searchBox.Text == "")
            {
                command.Connection = db.getConnection();
                command.CommandText = "select name as Назва, description as Опис, brand as Марка, model as Модель, quantity as Кількість, price_d as Ціна from details " +
                    " join car_brand_model using (id_mm) join car_brand using (id_b) join car_model using (id_m) where quantity>0;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgw.DataSource = table;
            }
            else
            {
                command.Connection = db.getConnection();
                command.CommandText = $"select name as Назва, description as Опис, brand as Марка, model as Модель, quantity as Кількість, " +
                    $"price_d as Ціна from details join car_brand_model using (id_mm) join car_brand using (id_b) join car_model using (id_m) " +
                    $"where brand = '{searchBox.Text}'  or model = '{searchBox.Text}' or name = '{searchBox.Text}' or description = '{searchBox.Text}'" +
                    $" and quantity>0";
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgw.DataSource = table;
            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (dgw != null)
            {
                dgw.Sort(dgw.Columns["Кількість"], ListSortDirection.Ascending);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (dgw != null)
            {
                dgw.Sort(dgw.Columns["Кількість"], ListSortDirection.Descending);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (dgw != null)
            {
                dgw.Sort(dgw.Columns["Ціна"], ListSortDirection.Ascending);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (dgw != null)
            {
                dgw.Sort(dgw.Columns["Ціна"], ListSortDirection.Descending);
            }
        }
    }
}
