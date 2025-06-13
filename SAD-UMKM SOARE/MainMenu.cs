using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SAD_UMKM_SOARE
{
    public partial class MainMenu : Form
    {
        Login frmlogin; Purchase frmpurchase; Sale frmsale; Return frmreturn; Inventory frminvent; ProfitLoss frmprofitloss; PerformanceSale frmperformance; TransactionRecord frmtransrec;
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        DataTable dtsold; DataTable dtsales; DataTable dtprofit; DataTable dtgrafik;
        string query;
        List<TextBox> tbmodel = new List<TextBox>();
        List<TextBox> tbqty = new List<TextBox>();
        DataTable dtnew;

        public MainMenu()
        {
            InitializeComponent();
            sqlConnect = new MySqlConnection("server =localhost;uid =root;pwd=Feli0102;database=soare3");
            dtsold = new DataTable();
            query = "call PGetLatestTotalItemSold();";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtsold);
            lb_sold.BackColor = ColorTranslator.FromHtml("#344054");
            lb_sold.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            lb_1.BackColor = ColorTranslator.FromHtml("#344054");
            lb_1.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            lb_2.BackColor = ColorTranslator.FromHtml("#344054");
            lb_2.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            lb_3.BackColor = ColorTranslator.FromHtml("#344054");
            lb_3.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            tbmodel.Add(tbnama_1); tbmodel.Add(tbnama_2); tbmodel.Add(tbnama_3);
            tbqty.Add(tbqty_1); tbqty.Add(tbqty_2); tbqty.Add(tbqty_3);
            if (dtsold.Rows.Count == 0)
            {
                lb_sold.Text = "";
                for(int i = 0; i < 3; i++)
                {
                    tbmodel[i].Visible = false;
                    tbqty[i].Visible = false;
                }
                lb_1.Visible = false;
                lb_2.Visible = false;
                lb_3.Visible = false;
            }
            else
            {
                lb_sold.Text = dtsold.Rows[0][1].ToString();

                dtsales = new DataTable();
                query = "CALL PGetTop3ItemSales();";
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtsales);

                for (int i = 0; i < 3; i++)
                {
                    tbmodel[i].Text = dtsales.Rows[i][1].ToString();
                    tbqty[i].Text = dtsales.Rows[i][2].ToString();
                    tbmodel[i].BackColor = ColorTranslator.FromHtml("#344054");
                    tbmodel[i].ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                    tbqty[i].BackColor = ColorTranslator.FromHtml("#344054");
                    tbqty[i].ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                    tbmodel[i].KeyPress += textBox_KeyPress;
                    tbqty[i].KeyPress += textBox_KeyPress;
                    tbmodel[i].Visible = true;
                    tbqty[i].Visible = true;
                }
                lb_1.Visible = true;
                lb_2.Visible = true;
                lb_3.Visible = true;
            }

            dtprofit = new DataTable();
            query = "select concat('Rp', format(fSumNetSalesAll(), 0, 'id_ID'));";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtprofit);
            lb_profit.Text = dtprofit.Rows[0][0].ToString();
            lb_profit.BackColor = ColorTranslator.FromHtml("#344054");
            lb_profit.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

            dtnew = new DataTable();
            query = "select fNewArrival();";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtnew);
            tb_new.Text = dtnew.Rows[0][0].ToString();
            tb_new.BackColor = ColorTranslator.FromHtml("#344054");
            tb_new.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            tb_new.ReadOnly = true;

            //grafik profit n loss
            dtgrafik = new DataTable();
            query = $"CALL pProfitLossAll();";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtgrafik);

            Chart linechart = new Chart();
            ChartArea chartArea = new ChartArea();
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            linechart.ChartAreas.Add(chartArea);
            linechart.Location = new Point(415, 399);
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

            // quotes
            List<string> quotes = new List<string>()
            {
               "'In order to succeed. We must first believe that we can.' - Nikos Kazantzakis",
               "'The only way to do great work is to love what you do.' - Steve Jobs",
               "'Success is not final; failure is not fatal: It is the courage to continue that counts.' - Winston S. Churchill",
               "'Believe you can and you're halfway there.' - Theodore Roosevelt",
               "'Don't watch the clock; do what it does. Keep going.' - Sam Levenson",
               "'The future belongs to those who believe in the beauty of their dreams.' - Eleanor Roosevelt",
               "'Hardships often prepare ordinary people for an extraordinary destiny.' - C.S. Lewis",
               "'Success usually comes to those who are too busy to be looking for it.' - Henry David Thoreau",
               "'What you do today can improve all your tomorrows.' - Ralph Marston",
               "'The only limit to our realization of tomorrow will be our doubts of today.' - Franklin D. Roosevelt",
               "'The secret of getting ahead is getting started.' - Mark Twain",
               "'Quality is not an act, it is a habit.' - Aristotle",
               "'Setting goals is the first step in turning the invisible into the visible.' - Tony Robbins",
               "'You don't have to be great to start, but you have to start to be great.' - Zig Ziglar",
               "'The best way to predict the future is to create it.' - Peter Drucker",
               "'Your time is limited, don't waste it living someone else's life.' - Steve Jobs",
               "'The harder the conflict, the greater the triumph.' - Thomas Paine",
               "'Dream big and dare to fail.' - Norman Vaughan",
               "'Act as if what you do makes a difference. It does.' - William James",
               "'Keep your face always toward the sunshine - and shadows will fall behind you.' - Walt Whitman",
               "'Opportunities don't happen. You create them.' - Chris Grosser"
            };
            Random random = new Random();
            int index = random.Next(quotes.Count);
            tb_quotes.Text = quotes[index];
            tb_quotes.ReadOnly = true;
            tb_quotes.BackColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            frmlogin = new Login();
            frmlogin.Show();
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

        private void bt_transrecord_Click(object sender, EventArgs e)
        {
            frmtransrec = new TransactionRecord();
            frmtransrec.Show();
            this.Close();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Mencegah karakter apa pun dimasukkan
        }
    }
}
