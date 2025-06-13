using Google.Protobuf.Collections;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SAD_UMKM_SOARE
{
    public partial class Inventory : Form
    {
        MainMenu frmmain; Purchase frmpurchase; Sale frmsale; Return frmreturn; ProfitLoss frmprofitloss; PerformanceSale frmperformance; TransactionRecord frmtransrec;
        ViewProduct frmviewprod;
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        DataTable dtbaju;
        string query;
        List<PictureBox> imagebaju = new List<PictureBox>();
        List<TextBox> namabaju = new List<TextBox>();
        List<TextBox> qty = new List<TextBox>();
        List<TextBox> price = new List<TextBox>();
        List<Label> lbqty = new List<Label>();
        List<Label> lbprice = new List<Label>();
        List<Button> btok = new List<Button>();
        int maxBottom;
        int lastY;
        int newY;
        List<Label> lbid = new List<Label>();
        List<Label> lbleft = new List<Label>();
        List<Label> lbrestock = new List<Label>();
        int count;
        DataTable dtremind = new DataTable();

        public Inventory()
        {
            InitializeComponent();
            p_baju.BackColor = ColorTranslator.FromHtml("#EAECF0");

            sqlConnect = new MySqlConnection("server =localhost;uid =root;pwd=Feli0102;database=soare3");
            dtbaju = new DataTable();
            query = "select * from vInventory;";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtbaju);
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            imagebaju.Add(pbbaju_1); imagebaju.Add(pbbaju_2); imagebaju.Add(pbbaju_3); imagebaju.Add(pbbaju_4);
            namabaju.Add(tbnama_1); namabaju.Add(tbnama_2); namabaju.Add(tbnama_3); namabaju.Add(tbnama_4);
            qty.Add(tbqty_1); qty.Add(tbqty_2); qty.Add(tbqty_3); qty.Add(tbqty_4);
            price.Add(tbprice_1); price.Add(tbprice_2); price.Add(tbprice_3); price.Add(tbprice_4);
            lbqty.Add(lbq_1); lbqty.Add(lbq_2); lbqty.Add(lbq_3); lbqty.Add(lbq_4);
            lbprice.Add(lbp_1); lbprice.Add(lbp_2); lbprice.Add(lbp_3); lbprice.Add(lbp_4);
            btok.Add(btok_1); btok.Add(btok_2); btok.Add(btok_3); btok.Add(btok_4);
            lbid.Add(lbid_1); lbid.Add(lbid_2); lbid.Add(lbid_3); lbid.Add(lbid_4);
            lbleft.Add(lbstock_1); lbleft.Add(lbstock_2); lbleft.Add(lbstock_3); lbleft.Add(lbstock_4);
            lbrestock.Add(lbrestock_1); lbrestock.Add(lbrestock_2); lbrestock.Add(lbrestock_3); lbrestock.Add(lbrestock_4);

            for (int i = 0; i < dtbaju.Rows.Count; i++)
            {
                if (i <= 3)
                {
                    imagebaju[i].Image = Image.FromFile(dtbaju.Rows[i][1].ToString());
                    imagebaju[i].Visible = true;
                    imagebaju[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    namabaju[i].Text = dtbaju.Rows[i][0].ToString();
                    namabaju[i].BackColor = ColorTranslator.FromHtml("#EAECF0");
                    namabaju[i].Visible = true;
                    namabaju[i].Enabled = true;
                    namabaju[i].ReadOnly = true;
                    qty[i].Text = dtbaju.Rows[i][2].ToString();
                    qty[i].BackColor = ColorTranslator.FromHtml("#EAECF0");
                    qty[i].Visible = true;
                    qty[i].Enabled = true;
                    qty[i].ReadOnly = true;
                    price[i].Text = dtbaju.Rows[i][3].ToString();
                    price[i].Visible = true;
                    lbqty[i].Visible = true;
                    lbprice[i].Visible = true;
                    btok[i].Visible = true;
                    btok[i].Click += ButtonOK_Click;
                    price[i].KeyPress += TextBox_KeyPress;
                }
                else if (i > 3)
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
            }
            query = "select * from vReminder;";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtremind);
            count = 0;

            if(dtremind.Rows.Count == 4)
            {
                bt_back.Enabled = false;
                bt_next.Enabled = false;
            }
            if (dtremind.Rows.Count < 4)
            {
                for (int i = 0; i < dtremind.Rows.Count; i++)
                {
                    lbid[i].Text = dtremind.Rows[i][0].ToString();
                    lbid[i].Visible = true;
                    lbid[i].BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    lbleft[i].Text = dtremind.Rows[i][1].ToString();
                    lbleft[i].Visible = true;
                    lbleft[i].BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    lbrestock[i].Text = dtremind.Rows[i][2].ToString();
                    lbrestock[i].Visible = true;
                    lbrestock[i].BackColor = ColorTranslator.FromHtml("#FFFFFF");
                }
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    lbid[i].Text = dtremind.Rows[i][0].ToString();
                    lbid[i].Visible = true;
                    lbid[i].BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    lbleft[i].Text = dtremind.Rows[i][1].ToString();
                    lbleft[i].Visible = true;
                    lbleft[i].BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    lbrestock[i].Text = dtremind.Rows[i][2].ToString();
                    lbrestock[i].Visible = true;
                    lbrestock[i].BackColor = ColorTranslator.FromHtml("#FFFFFF");
                }
            }
            bt_back.Enabled = false;
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
                p_baju.Size = new Size(1065, maxBottom + 295);
                //p_purchase.AutoScrollMinSize = new Size(p_purchase.Width, maxBottom + 300);


                // Cari elemen dengan posisi terendah di p_purchase
                lastY = p_baju.Controls.Cast<Control>()
                             .Max(c => c.Bottom); // Ambil posisi bawah elemen terakhir

                // Tambahkan jarak vertikal untuk elemen baru
                newY = lastY + 40;

                PictureBox fotobaju = new PictureBox()
                {
                    Name = $"pbbaju_{index}",
                    Location = new Point(60, newY),
                    Size = new Size(220, 210),
                    Image = Image.FromFile(dtbaju.Rows[dtindex][1].ToString()),
                    Visible = true,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                imagebaju.Add(fotobaju);

                TextBox textboxnama = new TextBox()
                {
                    Name = $"tbnama_{index}",
                    Text = dtbaju.Rows[dtindex][0].ToString(),
                    Location = new Point(300, newY),
                    Size = new Size(220, 60),
                    Font = new Font("Sans Serif Collection", 9),
                    BackColor = ColorTranslator.FromHtml("#EAECF0"),
                    TextAlign = HorizontalAlignment.Left,
                    BorderStyle = BorderStyle.None,
                    Multiline = true,
                    ReadOnly = true,
                };
                namabaju.Add(textboxnama);

                Label lbqtys = new Label()
                {
                    Name = $"lbq_{index}",
                    BackColor = ColorTranslator.FromHtml("#EAECF0"),
                    Text = "Quantity : ",
                    Font = new Font("Sans Serif Collection", 8),
                    Location = new Point(305, newY + 85)
                };
                lbqty.Add(lbqtys);

                Label lbprices = new Label()
                {
                    Name = $"lbp_{index}",
                    BackColor = ColorTranslator.FromHtml("#EAECF0"),
                    Text = "Price : ",
                    Font = new Font("Sans Serif Collection", 8),
                    Location = new Point(305, newY + 140)
                };
                lbprice.Add(lbprices);

                TextBox textboxqty = new TextBox()
                {
                    Name = $"tbqty_{index}",
                    Text = dtbaju.Rows[dtindex][2].ToString(),
                    Location = new Point(410, newY + 85),
                    Size = new Size(110, 30),
                    Font = new Font("Sans Serif Collection", 10),
                    BackColor = ColorTranslator.FromHtml("#EAECF0"),
                    TextAlign = HorizontalAlignment.Center,
                    BorderStyle = BorderStyle.None,
                    Multiline = true,
                    ReadOnly = true
                };
                qty.Add(textboxqty);

                TextBox textboxprice = new TextBox()
                {
                    Name = $"tbprice_{index}",
                    Text = dtbaju.Rows[dtindex][3].ToString(),
                    Location = new Point(410, newY + 140),
                    Size = new Size(110, 30),
                    Font = new Font("Sans Serif Collection", 10),
                    TextAlign = HorizontalAlignment.Center,
                    BorderStyle = BorderStyle.None,
                    Multiline = true,
                    Enabled = true
                };
                price.Add(textboxprice);

                Button btnok = new Button()
                {
                    Name = $"btok_{index}",
                    Size = new Size(70, 29),
                    BackgroundImage = Image.FromFile("C:\\Users\\felic\\Documents\\ISB UC\\ISB SEM 3\\SAD\\ASSET\\oke.png"),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Location = new Point(410, newY + 180),
                    FlatStyle = FlatStyle.Flat
                };
                btok.Add(btnok);

                btnok.FlatAppearance.BorderSize = 0;
                btnok.Click += ButtonOK_Click;
                textboxprice.KeyPress += TextBox_KeyPress;

                p_baju.Controls.Add(fotobaju);
                p_baju.Controls.Add(textboxnama);
                p_baju.Controls.Add(lbqtys);
                p_baju.Controls.Add(lbprices);
                p_baju.Controls.Add(textboxqty);
                p_baju.Controls.Add(textboxprice);
                p_baju.Controls.Add(btnok);
            }
            else if (oddeven == false)
            {

                Point lastpoint = imagebaju[index - 2].Location;
                newY = lastpoint.Y;
                PictureBox fotobaju = new PictureBox()
                {
                    Name = $"pbbaju_{index}",
                    Location = new Point(545, newY),
                    Size = new Size(220, 210),
                    Image = Image.FromFile(dtbaju.Rows[dtindex][1].ToString()),
                    Visible = true,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                imagebaju.Add(fotobaju);

                TextBox textboxnama = new TextBox()
                {
                    Name = $"tbnama_{index}",
                    Text = dtbaju.Rows[dtindex][0].ToString(),
                    Location = new Point(785, newY),
                    Size = new Size(220, 60),
                    Font = new Font("Sans Serif Collection", 9),
                    BackColor = ColorTranslator.FromHtml("#EAECF0"),
                    TextAlign = HorizontalAlignment.Left,
                    BorderStyle = BorderStyle.None,
                    Multiline = true,
                    ReadOnly = true
                };
                namabaju.Add(textboxnama);

                Label lbqtys = new Label()
                {
                    Name = $"lbq_{index}",
                    BackColor = ColorTranslator.FromHtml("#EAECF0"),
                    Text = "Quantity : ",
                    Font = new Font("Sans Serif Collection", 8),
                    Location = new Point(790, newY + 85)
                };
                lbqty.Add(lbqtys);

                Label lbprices = new Label()
                {
                    Name = $"lbp_{index}",
                    BackColor = ColorTranslator.FromHtml("#EAECF0"),
                    Text = "Price : ",
                    Font = new Font("Sans Serif Collection", 8),
                    Location = new Point(790, newY + 140)
                };
                lbprice.Add(lbprices);

                TextBox textboxqty = new TextBox()
                {
                    Name = $"tbqty_{index}",
                    Text = dtbaju.Rows[dtindex][2].ToString(),
                    Location = new Point(895, newY + 85),
                    Size = new Size(110, 30),
                    Font = new Font("Sans Serif Collection", 10),
                    BackColor = ColorTranslator.FromHtml("#EAECF0"),
                    TextAlign = HorizontalAlignment.Center,
                    BorderStyle = BorderStyle.None,
                    Multiline = true,
                    ReadOnly = true
                };
                qty.Add(textboxqty);

                TextBox textboxprice = new TextBox()
                {
                    Name = $"tbprice_{index}",
                    Text = dtbaju.Rows[dtindex][3].ToString(),
                    Location = new Point(895, newY + 140),
                    Size = new Size(110, 30),
                    Font = new Font("Sans Serif Collection", 10),
                    TextAlign = HorizontalAlignment.Center,
                    BorderStyle = BorderStyle.None,
                    Multiline = true,
                    Enabled = true
                };
                price.Add(textboxprice);

                Button btnok = new Button()
                {
                    Name = $"btok_{index}",
                    Size = new Size(70, 29),
                    BackgroundImage = Image.FromFile("C:\\Users\\felic\\Documents\\ISB UC\\ISB SEM 3\\SAD\\ASSET\\oke.png"),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Location = new Point(895, newY + 180),
                    FlatStyle = FlatStyle.Flat
                };
                btok.Add(btnok);

                btnok.FlatAppearance.BorderSize = 0;
                btnok.Click += ButtonOK_Click;
                textboxprice.KeyPress += TextBox_KeyPress;

                p_baju.Controls.Add(fotobaju);
                p_baju.Controls.Add(textboxnama);
                p_baju.Controls.Add(lbqtys);
                p_baju.Controls.Add(lbprices);
                p_baju.Controls.Add(textboxqty);
                p_baju.Controls.Add(textboxprice);
                p_baju.Controls.Add(btnok);
            }
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                string indexok = clickedButton.Name.Substring(clickedButton.Name.LastIndexOf("_") + 1);
                string nama = namabaju[(Convert.ToInt32(indexok) - 1)].Text;
                string harga = price[(Convert.ToInt32(indexok) - 1)].Text;
                int index = Convert.ToInt32(indexok) - 1;

                if (harga == "" || harga == "0")
                {
                    MessageBox.Show("Price Can't be Null");
                }
                else
                {
                    Edit(nama, harga);
                    //MessageBox.Show("Price Changed");
                }
            }
        }

        private void Edit(string name, string harga)
        {
            //query edit harga & hilang button ok & enable false textbox price
            query = $"call pUpdHarga('{name}', {harga});";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();

            DataTable dt = new DataTable();
            query = "select pakaian_harga_jual from vInventory;";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt);

            for (int i = 0; i < price.Count; i++)
            {
                price[i].Text = dt.Rows[i][0].ToString();
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bt_dashboard_Click(object sender, EventArgs e)
        {
            frmmain = new MainMenu();
            frmmain.Show();
            this.Close();
            Delete();
        }

        private void bt_purchase_Click(object sender, EventArgs e)
        {
            frmpurchase = new Purchase();
            frmpurchase.Show();
            this.Close();
            Delete();
        }

        private void bt_sale_Click(object sender, EventArgs e)
        {
            frmsale = new Sale();
            frmsale.Show();
            this.Close();
            Delete();
        }

        private void bt_return_Click(object sender, EventArgs e)
        {
            frmreturn = new Return();
            frmreturn.Show();
            this.Close();
            Delete();
        }

        private void bt_profitloss_Click(object sender, EventArgs e)
        {
            frmprofitloss = new ProfitLoss();
            frmprofitloss.Show();
            this.Close();
            Delete();
        }

        private void bt_performance_Click(object sender, EventArgs e)
        {
            frmperformance = new PerformanceSale();
            frmperformance.Show();
            this.Close();
            Delete();
        }

        private void bt_transrecord_Click(object sender, EventArgs e)
        {
            frmtransrec = new TransactionRecord();
            frmtransrec.Show();
            this.Close();
            Delete();
        }

        private void bt_viewprod_Click(object sender, EventArgs e)
        {
            frmviewprod = new ViewProduct();
            frmviewprod.Show();
            this.Close();
            Delete();
        }

        private void Delete()
        {
            for (int i = 0; i < 4; i++)
            {
                imagebaju[i].Visible = false;
                namabaju[i].Visible = false;
                qty[i].Visible = false;
                price[i].Visible = false;
                lbqty[i].Visible = false;
                lbprice[i].Visible = false;
                btok[i].Visible = false;
            }
            if (dtbaju.Rows.Count >= 5)
            {
                for (int i = 4; i < imagebaju.Count; i++)
                {
                    imagebaju[i].Dispose();
                    this.Controls.Remove(imagebaju[i]);
                    imagebaju.RemoveAt(i);
                }
                for (int i = 4; i < namabaju.Count; i++)
                {
                    namabaju[i].Dispose();
                    this.Controls.Remove(namabaju[i]);
                    namabaju.RemoveAt(i);
                }
                for (int i = 4; i < qty.Count; i++)
                {
                    qty[i].Dispose();
                    this.Controls.Remove(qty[i]);
                    qty.RemoveAt(i);
                }
                for (int i = 4; i < price.Count; i++)
                {
                    price[i].Dispose();
                    this.Controls.Remove(price[i]);
                    price.RemoveAt(i);
                }
                for (int i = 4; i < lbqty.Count; i++)
                {
                    lbqty[i].Dispose();
                    this.Controls.Remove(lbqty[i]);
                    lbqty.RemoveAt(i);
                }
                for (int i = 4; i < lbprice.Count; i++)
                {
                    lbprice[i].Dispose();
                    this.Controls.Remove(lbprice[i]);
                    lbprice.RemoveAt(i);
                }
                for (int i = 4; i < btok.Count; i++)
                {
                    btok[i].Dispose();
                    this.Controls.Remove(btok[i]);
                    btok.RemoveAt(i);
                }
            }
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            count = count - 4;
            if (count == 0)
            {
                bt_back.Enabled = false;
            }
            for (int i = count; i < (count + 4); i++)
            {
                lbid[i].Text = dtremind.Rows[i][0].ToString();
                lbid[i].Visible = true;
                lbleft[i].Text = dtremind.Rows[i][1].ToString();
                lbleft[i].Visible = true;
                lbrestock[i].Text = dtremind.Rows[i][1].ToString();
                lbrestock[i].Visible = true;
            }
            bt_next.Enabled = true;
        }

        private void bt_next_Click(object sender, EventArgs e)
        {
            count = count + 4;
            int baris = dtremind.Rows.Count;
            if (count + 3 <= baris)
            {
                for (int i = count; i < (count + 4); i++)
                {
                    for (int j = 0;  j <  4; j++)
                    {
                        lbid[j].Text = dtremind.Rows[i][0].ToString();
                        lbid[j].Visible = true;
                        lbleft[j].Text = dtremind.Rows[i][1].ToString();
                        lbleft[j].Visible = true;
                        lbrestock[j].Text = dtremind.Rows[i][2].ToString();
                        lbrestock[j].Visible = true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    lbid[i].Visible = false;
                    lbleft[i].Visible = false;
                    lbrestock[i].Visible = false;
                }
                int hitung = dtremind.Rows.Count + 1;
                for (int i = count; i < dtremind.Rows.Count; i++)
                {
                    for (int j = 0; j < hitung; j++)
                    {
                        lbid[j].Text = dtremind.Rows[i][0].ToString();
                        lbid[j].Visible = true;
                        lbleft[j].Text = dtremind.Rows[i][1].ToString();
                        lbleft[j].Visible = true;
                        lbrestock[j].Text = dtremind.Rows[i][2].ToString();
                        lbrestock[j].Visible = true;
                    }
                    if (i == dtremind.Rows.Count - 1)
                    {
                        bt_next.Enabled = false;
                    }
                }
            }
        }
    }
}
