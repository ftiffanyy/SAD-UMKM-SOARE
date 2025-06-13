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
using System.Windows.Forms.DataVisualization.Charting;

namespace SAD_UMKM_SOARE
{
    public partial class PerformanceSale : Form
    {
        MainMenu frmmain; Purchase frmpurchase; Sale frmsale; Return frmreturn; Inventory frminvent; ProfitLoss frmprofitloss; TransactionRecord frmtransrec;
        List<Label> lbno = new List<Label>();
        List<TextBox> tbmodel = new List<TextBox>();
        List<TextBox> tbqty = new List<TextBox>();
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string query;
        DataTable dtpie;

        public PerformanceSale()
        {
            InitializeComponent();
            sqlConnect = new MySqlConnection("server =localhost;uid =root;pwd=Feli0102;database=soare3");

        }

        private void PerformanceSale_Load(object sender, EventArgs e)
        {
            lbno.Add(lb_1); lbno.Add(lb_2); lbno.Add(lb_3);
            tbmodel.Add(tbnama_1); tbmodel.Add(tbnama_2); tbmodel.Add(tbnama_3);
            tbqty.Add(tbqty_1); tbqty.Add(tbqty_2); tbqty.Add(tbqty_3);
            tb_most.BackColor = ColorTranslator.FromHtml("#EAECF0");
            tb_most.ReadOnly = true;

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

        private void bt_transrecord_Click(object sender, EventArgs e)
        {
            frmtransrec = new TransactionRecord();
            frmtransrec.Show();
            this.Close();
        }

        private void bt_generate_Click(object sender, EventArgs e)
        {
            dtpie = new DataTable();
            query = $"CALL GetTop3ItemSalesByDate('{dateawal.Value.ToString("yyyy-MM-dd")}', '{dateakhir.Value.ToString("yyyy-MM-dd")}');";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtpie);
            if(dtpie.Rows.Count > 0 )
            {
                if(dtpie.Rows.Count >= 3)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        lbno[i].BackColor = ColorTranslator.FromHtml("#344054");
                        lbno[i].ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                        lbno[i].Visible = true;
                        tbmodel[i].Text = dtpie.Rows[i][1].ToString();
                        tbmodel[i].BackColor = ColorTranslator.FromHtml("#344054");
                        tbmodel[i].ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                        tbmodel[i].Visible = true;
                        tbmodel[i].ReadOnly = true;
                        tbqty[i].Text = dtpie.Rows[i][2].ToString();
                        tbqty[i].BackColor = ColorTranslator.FromHtml("#344054");
                        tbqty[i].ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                        tbqty[i].Visible = true;
                        tbqty[i].ReadOnly = true;
                    }
                }
                else
                {
                    for (int i = 0; i < dtpie.Rows.Count; i++)
                    {
                        lbno[i].BackColor = ColorTranslator.FromHtml("#344054");
                        lbno[i].ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                        lbno[i].Visible = true;
                        tbmodel[i].Text = dtpie.Rows[i][1].ToString();
                        tbmodel[i].BackColor = ColorTranslator.FromHtml("#344054");
                        tbmodel[i].ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                        tbmodel[i].Visible = true;
                        tbmodel[i].ReadOnly = true;
                        tbqty[i].Text = dtpie.Rows[i][2].ToString();
                        tbqty[i].BackColor = ColorTranslator.FromHtml("#344054");
                        tbqty[i].ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                        tbqty[i].Visible = true;
                        tbqty[i].ReadOnly = true;
                    }
                }
                tb_most.Text = dtpie.Rows[0][1].ToString();
                tb_most.BackColor = ColorTranslator.FromHtml("#344054");
                tb_most.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                tb_most.Visible = true;
                tb_most.ReadOnly = true;
                
                Chart piechart1 = new Chart();
                ChartArea chartArea = new ChartArea();
                piechart1.ChartAreas.Add(chartArea);
                piechart1.Location = new Point(962, 399);
                piechart1.Size = new Size(416, 364);
                piechart1.Palette = ChartColorPalette.Excel;
                Series series1 = new Series();
                series1.ChartType = SeriesChartType.Pie;
                series1.IsVisibleInLegend = true;
                //series1.IsValueShownAsLabel = true;
                 
                foreach (DataRow row in dtpie.Rows)
                {
                    string category = row["Item Name"].ToString();
                    int value = Convert.ToInt32(row["Quantity"]);
                    series1.Points.AddXY(category, value);
                }

                piechart1.Series.Add(series1);
                this.Controls.Add(piechart1);
            }
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
