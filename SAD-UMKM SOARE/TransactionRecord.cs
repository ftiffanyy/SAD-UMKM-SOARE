using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAD_UMKM_SOARE
{
    public partial class TransactionRecord : Form
    {
        MainMenu frmmain; Purchase frmpurchase; Sale frmsale; Return frmreturn; Inventory frminvent; ProfitLoss frmprofitloss; PerformanceSale frmperformance;
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        DataTable dtbaju;
        string query;
        int index;

        public TransactionRecord()
        {
            InitializeComponent();
        }

        private void TransactionRecord_Load(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection("server =localhost;uid =root;pwd=Feli0102;database=soare3");
            sqlConnect.Open();
        }

        private void bt_dashboard_Click(object sender, EventArgs e)
        {
            frmmain = new MainMenu();
            frmmain.Show();
            this.Close();
        }

        private void bt_purchase_Click(object sender, EventArgs e)
        {
            frmpurchase = new Purchase();
            frmpurchase.Show();
            this.Close();
        }

        private void bt_sale_Click(object sender, EventArgs e)
        {
            frmsale = new Sale();
            frmsale.Show();
            this.Close();
        }

        private void bt_return_Click(object sender, EventArgs e)
        {
            frmreturn = new Return();
            frmreturn.Show();
            this.Close();
        }

        private void bt_inventory_Click(object sender, EventArgs e)
        {
            frminvent = new Inventory();
            frminvent.Show();
            this.Close();
        }

        private void bt_profitloss_Click(object sender, EventArgs e)
        {
            frmprofitloss = new ProfitLoss();
            frmprofitloss.Show();
            this.Close();
        }

        private void bt_performance_Click(object sender, EventArgs e)
        {
            frmperformance = new PerformanceSale();
            frmperformance.Show();
            this.Close();
        }

        private void cb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_type.SelectedItem = "General";
            TransRecord(cb_filter.SelectedItem.ToString(), cb_type.SelectedItem.ToString());
        }

        private void cb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            TransRecord(cb_filter.SelectedItem.ToString(), cb_type.SelectedItem.ToString());
        }

        private void TransRecord(string filter, string type)
        {
            dtbaju = new DataTable();
            query = $"call pTransactionRecord('{filter}', '{type}');";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtbaju);
            dgvbaju.DataSource = dtbaju;

            if (filter == "Purchase")
            {
                if(type == "General")
                {
                    dgvbaju.Columns["BELI ID"].DisplayIndex = 0;
                    dgvbaju.Columns["BELI HARGA TOTAL"].DisplayIndex = 1;
                    dgvbaju.Columns["BELI TANGGAL"].DisplayIndex = 2;
                    dgvbaju.Columns["NAMA SUPPLIER"].DisplayIndex = 3;
                    dgvbaju.Columns["BELI JUMLAH VARIAN"].DisplayIndex = 4;
                }
                else if (type == "Detail")
                {
                    dgvbaju.Columns["DETAIL BELI ID"].DisplayIndex = 0;
                    dgvbaju.Columns["PAKAIAN ID"].DisplayIndex = 1;
                    dgvbaju.Columns["BELI ID"].DisplayIndex = 2;
                    dgvbaju.Columns["DETAIL BELI QTY"].DisplayIndex = 3;
                }
            }
            else if (filter == "Sales")
            {
                if (type == "General")
                {
                    dgvbaju.Columns["JUAL ID"].DisplayIndex = 0;
                    dgvbaju.Columns["JUAL HARGA TOTAL"].DisplayIndex = 1;
                    dgvbaju.Columns["JUAL TANGGAL"].DisplayIndex = 2;
                    dgvbaju.Columns["NAMA CUSTOMER"].DisplayIndex = 3;
                    dgvbaju.Columns["JUAL JUMLAH VARIAN"].DisplayIndex = 4;
                }
                else if (type == "Detail")
                {
                    dgvbaju.Columns["DETAIL JUAL ID"].DisplayIndex = 0;
                    dgvbaju.Columns["PAKAIAN ID"].DisplayIndex = 1;
                    dgvbaju.Columns["JUAL ID"].DisplayIndex = 2;
                    dgvbaju.Columns["DETAIL JUAL QTY"].DisplayIndex = 3;
                    dgvbaju.Columns["PROFIT"].DisplayIndex = 4;
                    dgvbaju.Columns["HARGA JUAL"].DisplayIndex = 5;
                }
            }
            else if (filter == "Return")
            {
                if (type == "General")
                {
                    dgvbaju.Columns["RETUR ID"].DisplayIndex = 0;
                    dgvbaju.Columns["JUAL ID"].DisplayIndex = 1;
                    dgvbaju.Columns["RETUR TANGGAL"].DisplayIndex = 2;
                    dgvbaju.Columns["RETUR JUMLAH VARIAN"].DisplayIndex = 3;
                }
                else if (type == "Detail")
                {
                    dgvbaju.Columns["DETAIL RETUR ID"].DisplayIndex = 0;
                    dgvbaju.Columns["PAKAIAN ID"].DisplayIndex = 1;
                    dgvbaju.Columns["RETUR ID"].DisplayIndex = 2;
                    dgvbaju.Columns["DETAIL RETUR QTY"].DisplayIndex = 3;
                    dgvbaju.Columns["DETAIL RETUR LOSS"].DisplayIndex = 4;
                }
            }
        }

        private void dgvbaju_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            string id = dtbaju.Rows[index][0].ToString();
            //MessageBox.Show(id);
            query = $"call pDelTransRecord('{cb_filter.SelectedItem.ToString()}', '{cb_type.SelectedItem.ToString()}', '{id}');";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            TransRecord(cb_filter.SelectedItem.ToString(), cb_type.SelectedItem.ToString());
        }
    }
}
