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
    public partial class FormWorkersInfo : Form
    {
        DB db = new DB();
        public FormWorkersInfo()
        {
            InitializeComponent();
            ShowWorkers();
            dgw.Columns[0].ReadOnly = true;
        }

        private void ShowWorkers()
        {
            dgw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgw.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            db.openConection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            string s = "SELECT id_em as Код, e_full_name as ПІБ, position as Посада, e_mob_number as МобТелефон from employee";
            MySqlCommand command = new MySqlCommand(s, db.getConnection());
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dgw.DataSource = table;
        }

        private void dgw_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            MySqlCommand command = new MySqlCommand("UPDATE car_service.employee SET e_full_name=@Column1, position=@Column2, " +
    "e_mob_number=@Column3 WHERE id_em=@ID", db.getConnection());
            command.Parameters.AddWithValue("@Column1", dgw.Rows[e.RowIndex].Cells["ПІБ"].Value);
            command.Parameters.AddWithValue("@Column2", dgw.Rows[e.RowIndex].Cells["Посада"].Value);
            command.Parameters.AddWithValue("@Column3", dgw.Rows[e.RowIndex].Cells["МобТелефон"].Value);
            command.Parameters.AddWithValue("@ID", dgw.Rows[e.RowIndex].Cells["Код"].Value);
            command.ExecuteNonQuery();
        }

        private void FormWorkersInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
