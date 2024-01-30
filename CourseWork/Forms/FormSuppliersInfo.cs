using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork.Forms
{
    public partial class FormSuppliersInfo : Form
    {
        DB db = new DB();

        public FormSuppliersInfo()
        {
            InitializeComponent();
            ShowSuppliers();
            dataGridView1.Columns[0].ReadOnly = true;
        }

        private void ShowSuppliers()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            db.openConection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            string s = "SELECT id_sw as Код, s_full_name as ПІБ, adress as Адреса, s_mob_number as МобТелефон from supply_workers";
            MySqlCommand command = new MySqlCommand(s, db.getConnection());
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void FormSuppliersInfo_Load(object sender, EventArgs e)
        {

        }

        private void dgw_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            MySqlCommand command = new MySqlCommand("UPDATE car_service.supply_workers SET s_full_name=@Column1, adress=@Column2, " +
"s_mob_number=@Column3 WHERE id_sw=@ID", db.getConnection());
            command.Parameters.AddWithValue("@Column1", dataGridView1.Rows[e.RowIndex].Cells["ПІБ"].Value);
            command.Parameters.AddWithValue("@Column2", dataGridView1.Rows[e.RowIndex].Cells["Адреса"].Value);
            command.Parameters.AddWithValue("@Column3", dataGridView1.Rows[e.RowIndex].Cells["МобТелефон"].Value);
            command.Parameters.AddWithValue("@ID", dataGridView1.Rows[e.RowIndex].Cells["Код"].Value);
            command.ExecuteNonQuery();
        }

        private void dgw_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dgw2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgw2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                DataGridViewRow selectedRow = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index];
                int id = (int)selectedRow.Cells["Код"].Value;
                MySqlCommand command = new MySqlCommand("select id_sw as КодПостчальника, s_full_name as ПІБ, name as Назва, brand as Марка, model as Модель, s_quantity " +
                    "as Кількість, price as Ціна, date_supplies as Дата from supplies join supply_workers using (id_sw) join supplie_details " +
                    $"using(id_del) join details using(id_d) join car_brand_model using(id_mm) join car_brand using (id_b) join " +
                    $"car_model using (id_m) where id_sw = {id}", db.getConnection());
                adapter = new MySqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                dgw2.DataSource = table;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
