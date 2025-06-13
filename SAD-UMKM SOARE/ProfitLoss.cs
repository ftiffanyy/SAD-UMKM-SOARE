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
using System.Windows.Forms.DataVisualization.Charting;

namespace SAD_UMKM_SOARE
{
    public partial class ProfitLoss : Form
    {
        MainMenu frmmain; Purchase frmpurchase; Sale frmsale; Return frmreturn; Inventory frminvent; PerformanceSale frmperformance; TransactionRecord frmtransrec;
        List<PictureBox> imagecust = new List<PictureBox>();
        List<TextBox> namacust = new List<TextBox>();
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        DataTable dtcust; DataTable dtgrafik; DataTable dtprofitloss; DataTable dtcount;
        string query;


        public ProfitLoss()
        {
            InitializeComponent();
        }

        private void ProfitLoss_Load(object sender, EventArgs e)
        {
            imagecust.Add(pb_1); imagecust.Add(pb_2); imagecust.Add(pb_3); imagecust.Add(pb_4);
            namacust.Add(tbnama_1); namacust.Add(tbnama_2); namacust.Add(tbnama_3); namacust.Add(tbnama_4);

            sqlConnect = new MySqlConnection("server =localhost;uid =root;pwd=Feli0102;database=soare3");
            tb_most.BackColor = ColorTranslator.FromHtml("#344054");
            tb_most.ReadOnly = true;
            lb_sold.Visible = false;
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

        private void bt_performance_Click(object sender, EventArgs e)
        {
            frmperformance = new PerformanceSale();
            frmperformance.Show();
            this.Close();
        }

        private void bt_transrecord_Click(object sender, EventArgs e)
        {
            frmtransrec = new TransactionRecord();
            frmtransrec.Show();
            this.Close();
        }

        private void bt_generate_Click(object sender, EventArgs e)
        {
            dtcust = new DataTable();
            query = $"CALL pLatestCustomer('{dateawal.Value.ToString("yyyy-MM-dd")}','{dateakhir.Value.ToString("yyyy-MM-dd")}');";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtcust);
            for (int i = 0; i < dtcust.Rows.Count; i++)
            {
                imagecust[i].Visible = true;
                namacust[i].Text = dtcust.Rows[i][0].ToString();
                namacust[i].Visible = true;
                namacust[i].BackColor = ColorTranslator.FromHtml("#344054");
                namacust[i].ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            }

            dtgrafik = new DataTable();
            query = $"CALL pProfitLoss('{dateawal.Value.ToString("yyyy-MM-dd")}','{dateakhir.Value.ToString("yyyy-MM-dd")}');";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtgrafik);

            Chart linechart = new Chart();
            ChartArea chartArea = new ChartArea();
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            linechart.ChartAreas.Add(chartArea);
            linechart.Location = new Point(962, 399);
            linechart.Size = new Size(416, 364);
            Series series1 = new Series();
            series1.ChartType = SeriesChartType.Line;
            series1.IsVisibleInLegend = true;
            series1.IsValueShownAsLabel = true;
            series1.Color = Color.Blue;
            series1.BorderWidth = 2;

            foreach (DataRow row in dtgrafik.Rows)
            {
                string category = row["tanggal"].ToString();
                int value = Convert.ToInt32(row["net_sales"]);
                series1.Points.AddXY(category, value);
            }

            linechart.Series.Add(series1);
            this.Controls.Add(linechart);

            dtprofitloss = new DataTable();
            query = $"select concat('Rp', format(fSumNetSales('{dateawal.Value.ToString("yyyy-MM-dd")}','{dateakhir.Value.ToString("yyyy-MM-dd")}'), 0, 'id_ID'));";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtprofitloss);
            tb_most.Text = dtprofitloss.Rows[0][0].ToString();
            tb_most.BackColor = ColorTranslator.FromHtml("#344054");
            tb_most.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            tb_most.Visible = true;
            tb_most.ReadOnly = true;

            dtcount = new DataTable();
            query = $"select fCountTransactions('{dateawal.Value.ToString("yyyy-MM-dd")}','{dateakhir.Value.ToString("yyyy-MM-dd")}');";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtcount);
            lb_sold.Text = dtcount.Rows[0][0].ToString();
            lb_sold.BackColor = ColorTranslator.FromHtml("#F7FAFF");
            lb_sold.Visible = true;

        }

        private void dateawal_ValueChanged(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Chart)
                {
                    Chart chart = (Chart)control;
                    chart.Dispose();
                    this.Controls.Remove(chart);
                }
            }
        }

        private void dateakhir_ValueChanged(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Chart)
                {
                    Chart chart = (Chart)control;
                    chart.Dispose();
                    this.Controls.Remove(chart);
                }
            }
        }
    }
}
