using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAD_UMKM_SOARE
{
    public partial class Sale : Form
    {
        MainMenu frmmain; Purchase frmpurchase; Return frmreturn; Inventory frminvent; ProfitLoss frmprofitloss; PerformanceSale frmperformance; TransactionRecord frmtransrec;
        InvoiceSale frminvoicesale;
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        DataTable dtbaju;
        string query;
        List<PictureBox> imagebaju = new List<PictureBox>();
        List<TextBox> namabaju = new List<TextBox>();
        int maxBottom;
        int lastY;
        int newY;
        List<TextBox> model = new List<TextBox>();
        List<TextBox> qty = new List<TextBox>();
        List<TextBox> price = new List<TextBox>();
        DataTable dtcart;
        int count;


        public Sale()
        {
            InitializeComponent();
            p_baju.BackColor = ColorTranslator.FromHtml("#EAECF0");
            tb_customer.BackColor = ColorTranslator.FromHtml("#223559");
            tb_customer.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

            sqlConnect = new MySqlConnection("server =localhost;uid =root;pwd=Feli0102;database=soare3");
            dtbaju = new DataTable();
            query = "select * from vSale;";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtbaju);
            dtbaju.Columns.Add("cart");
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            imagebaju.Add(pbbaju_1); imagebaju.Add(pbbaju_2); imagebaju.Add(pbbaju_3); imagebaju.Add(pbbaju_4); imagebaju.Add(pbbaju_5); imagebaju.Add(pbbaju_6);
            namabaju.Add(tbnama_1); namabaju.Add(tbnama_2); namabaju.Add(tbnama_3); namabaju.Add(tbnama_4); namabaju.Add(tbnama_5); namabaju.Add(tbnama_6);
            model.Add(tbmodel_1); model.Add(tbmodel_2); model.Add(tbmodel_3); model.Add(tbmodel_4); model.Add(tbmodel_5); model.Add(tbmodel_6); model.Add(tbmodel_7);
            qty.Add(tbqty_1); qty.Add(tbqty_2); qty.Add(tbqty_3); qty.Add(tbqty_4); qty.Add(tbqty_5); qty.Add(tbqty_6); qty.Add(tbqty_7);
            price.Add(tbprice_1); price.Add(tbprice_2); price.Add(tbprice_3); price.Add(tbprice_4); price.Add(tbprice_5); price.Add(tbprice_6); price.Add(tbprice_7);

            for (int i = 0; i < dtbaju.Rows.Count; i++)
            {
                if(i <= 5)
                {
                    imagebaju[i].Image = Image.FromFile(dtbaju.Rows[i][1].ToString());
                    imagebaju[i].Visible = true;
                    imagebaju[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    namabaju[i].Text = dtbaju.Rows[i][0].ToString();
                    namabaju[i].Visible = true;
                    namabaju[i].BackColor = ColorTranslator.FromHtml("#EAECF0");
                }
                else if (i > 5)
                {
                    if (i % 2 == 0)
                    {
                        AddButton(i + 1, i, true);
                    }
                    else
                    {
                        AddButton(i + 1, i, false);
                    }
                }
                dtbaju.Rows[i][4] = 0;
            }

            query = "delete from jtemp;";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            bt_done.Visible = false;
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

        private void AddButton(int index, int dtindex, bool oddeven)
        {
            if (oddeven == true)
            {
                //p_purchase.Size = new Size(969, 500 + (index * 300));
                p_baju.AutoScrollMinSize = new Size(p_baju.Width, 1000 + ((index / 2) * 300));
                p_baju.AutoScroll = true;
                //MessageBox.Show(p_purchase.Height.ToString());

                // baru
                maxBottom = p_baju.Controls.Cast<Control>()
                                .Max(c => c.Bottom);
                p_baju.Size = new Size(555, maxBottom + 295);
                //p_purchase.AutoScrollMinSize = new Size(p_purchase.Width, maxBottom + 300);


                // Cari elemen dengan posisi terendah di p_purchase
                lastY = p_baju.Controls.Cast<Control>()
                             .Max(c => c.Bottom); // Ambil posisi bawah elemen terakhir

                // Tambahkan jarak vertikal untuk elemen baru
                newY = lastY + 25;

                PictureBox fotobaju = new PictureBox()
                {
                    Name = $"pbbaju_{index}",
                    Location = new Point(30, newY),
                    Size = new Size(220, 210),
                    Image = Image.FromFile(dtbaju.Rows[dtindex][1].ToString()),
                    Visible = true,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                imagebaju.Add(fotobaju);

                TextBox textboxnama = new TextBox()
                {
                    Name = $"qty {index}",
                    Text = dtbaju.Rows[dtindex][0].ToString(),
                    Location = new Point(30, newY + 215),
                    Size = new Size(220, 60),
                    Font = new Font("Sans Serif Collection", 9),
                    BackColor = ColorTranslator.FromHtml("#EAECF0"),
                    TextAlign = HorizontalAlignment.Center,
                    BorderStyle = BorderStyle.None,
                    Enabled = false,
                    Multiline = true
                };
                namabaju.Add(textboxnama);

                fotobaju.Click += Picturebaju_Click;

                p_baju.Controls.Add(fotobaju);
                p_baju.Controls.Add(textboxnama);
            }
            else if (oddeven == false)
            {

                Point lastpoint = imagebaju[index - 2].Location;
                newY = lastpoint.Y;

                PictureBox fotobaju = new PictureBox()
                {
                    Name = $"pbbaju_{index}",
                    Location = new Point(300, newY),
                    Size = new Size(220, 210),
                    Image = Image.FromFile(dtbaju.Rows[dtindex][1].ToString()),
                    Visible = true,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                imagebaju.Add(fotobaju);

                TextBox textboxnama = new TextBox()
                {
                    Name = $"qty {index}",
                    Text = dtbaju.Rows[dtindex][0].ToString(),
                    Location = new Point(300, newY + 215),
                    Size = new Size(220, 60),
                    Font = new Font("Sans Serif Collection", 9),
                    BorderStyle = BorderStyle.None,
                    BackColor = ColorTranslator.FromHtml("#EAECF0"),
                    TextAlign = HorizontalAlignment.Center,
                    Multiline = true,
                    Enabled = false
                };
                namabaju.Add(textboxnama);

                fotobaju.Click += Picturebaju_Click;

                p_baju.Controls.Add(fotobaju);
                p_baju.Controls.Add(textboxnama);
            }
        }

        private void Picturebaju_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox clickedPicture)
            {
                string indexfoto = clickedPicture.Name.Substring(clickedPicture.Name.LastIndexOf("_") + 1);
                string nama = namabaju[(Convert.ToInt32(indexfoto) - 1)].Text;
                AddtoCart(nama);
            }
        }

        private void pbbaju_1_Click(object sender, EventArgs e)
        {
            AddtoCart(tbnama_1.Text);
        }

        private void pbbaju_2_Click(object sender, EventArgs e)
        {
            AddtoCart(tbnama_2.Text);
        }

        private void pbbaju_3_Click(object sender, EventArgs e)
        {
            AddtoCart(tbnama_3.Text);
        }

        private void pbbaju_4_Click(object sender, EventArgs e)
        {
            AddtoCart(tbnama_4.Text);
        }

        private void pbbaju_5_Click(object sender, EventArgs e)
        {
            AddtoCart(tbnama_5.Text);
        }

        private void pbbaju_6_Click(object sender, EventArgs e)
        {
            AddtoCart(tbnama_6.Text);
        }
        private void AddtoCart(string name)
        {
            int harga = 0;
            for(int i = 0; i < dtbaju.Rows.Count; i++)
            {
                if (dtbaju.Rows[i][0].ToString() == name)
                {
                    // cek stock baju & qty keranjang
                    if (dtbaju.Rows[i][3].ToString() == dtbaju.Rows[i][4].ToString())
                    {
                        MessageBox.Show("Out of Stock");
                    }
                    else
                    {
                        bt_done.Visible = true;
                        dtcart = new DataTable();
                        query = "select * from jtemp;";
                        sqlCommand = new MySqlCommand(query, sqlConnect);
                        sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                        sqlDataAdapter.Fill(dtcart);
                        count = dtcart.Rows.Count;

                        DataTable dtcek = new DataTable();
                        query = $"CALL pInsJtemp('{name}');";
                        sqlCommand = new MySqlCommand(query, sqlConnect);
                        sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                        sqlDataAdapter.Fill(dtcek);
                        
                        if (dtcek.Rows[0][0].ToString() == "full")
                        {
                            MessageBox.Show("kosong");
                        }
                        else if (dtcek.Rows[0][0].ToString() == "insert")
                        {
                            //MessageBox.Show("ada");
                            dtbaju.Rows[i][4] = Convert.ToInt32(dtbaju.Rows[i][4]) + 1;
                            model[count].Text = name;
                            qty[count].Text = dtbaju.Rows[i][4].ToString();
                            int cartprice = Convert.ToInt32(dtbaju.Rows[i][2]);
                            price[count].Text = cartprice.ToString("C", new CultureInfo("id-ID"));
                            model[count].Visible = true;
                            qty[count].Visible = true;
                            price[count].Visible = true;
                            model[count].BackColor = ColorTranslator.FromHtml("#FFFFFF");
                            qty[count].BackColor = ColorTranslator.FromHtml("#FFFFFF");
                            price[count].BackColor = ColorTranslator.FromHtml("#FFFFFF");
                            
                            
                            
                        }
                        else if (dtcek.Rows[0][0].ToString() == "update")
                        {
                            //MessageBox.Show("update");
                            dtbaju.Rows[i][4] = Convert.ToInt32(dtbaju.Rows[i][4]) + 1;
                            for (int j = 0; j < model.Count; j++)
                            {
                                if (model[j].Text == name)
                                {
                                    qty[j].Text = (Convert.ToInt32(qty[j].Text) + 1).ToString();
                                    price[j].Text = (Convert.ToInt32(dtbaju.Rows[i][2]) * Convert.ToInt32(qty[j].Text)).ToString("C", new CultureInfo("id-ID"));
                                }
                            }
                        }
                    }
                }
                int totalint = Convert.ToInt32(dtbaju.Rows[i][2]) * Convert.ToInt32(dtbaju.Rows[i][4]);
                harga += totalint;
            }
            tb_total.Text = "Total " + (harga.ToString("C", new CultureInfo("id-ID")));
            tb_total.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            tb_total.Visible = true;
        }

        private void bt_done_Click(object sender, EventArgs e)
        {
            if (tb_customer.Text == "")
            {
                MessageBox.Show("Please Fill Customer Name");
            }
            else
            {
                query = $"CALL pInsJual('{tb_customer.Text}');";
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                //invoice
                frminvoicesale = new InvoiceSale();
                frminvoicesale.Show();
                this.Close();

                //visible false
                for(int i = 0; i < model.Count; i++)
                {
                    model[i].Visible = false;
                    qty[i].Visible = false;
                    price[i].Visible = false;
                }
                tb_total.Text = "0";

                // hapus dan visible false 
                for (int i  = 0; i < 6; i++)
                {
                    imagebaju[i].Visible = false;
                    namabaju[i].Visible = false;
                }
                if (count >= 7)
                {
                    for (int i = 6; i < imagebaju.Count; i++)
                    {
                        imagebaju[i].Dispose();
                        this.Controls.Remove(imagebaju[i]);
                        imagebaju.RemoveAt(i);
                    }
                    for (int i = 6; i < namabaju.Count; i++)
                    {
                        namabaju[i].Dispose();
                        this.Controls.Remove(namabaju[i]);
                        namabaju.RemoveAt(i);
                    }
                }
            }
        }
    }
}
