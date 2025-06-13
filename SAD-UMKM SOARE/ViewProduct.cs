using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAD_UMKM_SOARE
{
    public partial class ViewProduct : Form
    {
        MainMenu frmmain;
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        DataTable dtbaju;
        string query;
        int index;
        public ViewProduct()
        {
            InitializeComponent();
        }

        private void ViewProduct_Load(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection("server =localhost;uid =root;pwd=Feli0102;database=soare3");
            sqlConnect.Open();
            dtbaju = new DataTable();
            query = "select * from vProductInvent;";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtbaju);
            dgvbaju.DataSource = dtbaju;

            dgvbaju.DefaultCellStyle.Font = new Font("Arial", 20);
            for (int i = 0; i < dtbaju.Rows.Count; i++)
            {
                dgvbaju.Rows[i].Height = 40;
            }
            dgvbaju.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvbaju.EnableHeadersVisualStyles = false;
            dgvbaju.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 30);
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            frmmain = new MainMenu();
            frmmain.Show();
            this.Close();
        }

        private void cb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtbaju = new DataTable();
            query = $"call pFilterInvent('{cb_filter.SelectedItem}');";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtbaju);
            dgvbaju.DataSource = dtbaju;
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            string id = dtbaju.Rows[index][0].ToString();
            //MessageBox.Show(id);
            query = $"call pDelInvent('{id}');";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlCommand.ExecuteNonQuery();

            dtbaju = new DataTable();
            query = "select * from vProductInvent;";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtbaju);
            dgvbaju.DataSource = dtbaju;
            cb_filter.SelectedIndex = -1;
        }

        private void dgvbaju_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }
    }
}
