using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CourseWork.Forms
{
    public partial class FormDetails2 : Form
    {
        DB db = new DB();
        FormLogin f = new FormLogin();
        MySqlDataAdapter adapter;
        DataTable table;

        public FormDetails2()
        {
            //LoadTheme();
            InitializeComponent();
            DetailsShow();
            dgw.Columns["КодДеталь"].ReadOnly = true;
        }
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchBox.Text;
            MySqlCommand command = new MySqlCommand();
            if (searchBox.Text == "")
            {
                command.Connection = db.getConnection();
                command.CommandText = "select id_d as КодДеталь, id_mm as КодАвтомобіль, name as Назва, description as Опис, brand as Марка, model as Модель, quantity as Кількість, price_d as Ціна from details " +
                    " join car_brand_model using (id_mm) join car_brand using (id_b) join car_model using (id_m) where quantity>0;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgw.DataSource = table;
            }
            else
            {
                command.Connection = db.getConnection();
                command.CommandText = $"select id_d as КодДетаь, id_mm as КодАвтомобіль, name as Назва, description as Опис, brand as Марка, model as Модель, quantity as Кількість, " +
                    $"price_d as Ціна from details join car_brand_model using (id_mm) join car_brand using (id_b) join car_model using (id_m) " +
                    $"where brand = '{searchBox.Text}'  or model = '{searchBox.Text}' or name = '{searchBox.Text}' or description = '{searchBox.Text}'" +
                    $" and quantity>0";

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgw.DataSource = table;
            }
        }

        public void DetailsShow()
        {
            dgw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgw.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            db.openConection();
            string s = "select id_d as КодДеталь, id_mm as КодАвтомобіль, name as Назва, description as Опис, brand as Марка, model as Модель, quantity as Кількість, price_d as Ціна from details" +
                " join car_brand_model using (id_mm) join car_brand using (id_b) join car_model using (id_m);";
            MySqlCommand command = new MySqlCommand(s, db.getConnection());
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dgw.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormDetails2Two f = new FormDetails2Two();
            f.ShowDialog();
            //this.Hide();
        }

        private void dgw_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            MySqlCommand command = new MySqlCommand("UPDATE car_service.details SET name=@Column1, description=@Column2, quantity=@Column3 WHERE id_d=@ID", db.getConnection());
            command.Parameters.AddWithValue("@Column1", dgw.Rows[e.RowIndex].Cells["Назва"].Value);
            command.Parameters.AddWithValue("@Column2", dgw.Rows[e.RowIndex].Cells["Опис"].Value);
            command.Parameters.AddWithValue("@Column3", dgw.Rows[e.RowIndex].Cells["Кількість"].Value);
            command.Parameters.AddWithValue("@ID", dgw.Rows[e.RowIndex].Cells["КодДеталь"].Value);
            command.ExecuteNonQuery();
            string s = "update_brand";
            MySqlCommand command1 = new MySqlCommand(s, db.getConnection());
            command1.CommandType = System.Data.CommandType.StoredProcedure;
            command1.Parameters.AddWithValue("@car_b", dgw.Rows[e.RowIndex].Cells["Марка"].Value);
            command1.Parameters.AddWithValue("@id_m", dgw.Rows[e.RowIndex].Cells["КодАвтомобіль"].Value);
            command1.ExecuteNonQuery();
            string s1 = "update_model";
            MySqlCommand command2 = new MySqlCommand(s1, db.getConnection());
            command2.CommandType = System.Data.CommandType.StoredProcedure;
            command2.Parameters.AddWithValue("@car_m", dgw.Rows[e.RowIndex].Cells["Модель"].Value);
            command2.Parameters.AddWithValue("@idm", dgw.Rows[e.RowIndex].Cells["КодАвтомобіль"].Value);
            command2.ExecuteNonQuery();
        }

        private void dgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
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
