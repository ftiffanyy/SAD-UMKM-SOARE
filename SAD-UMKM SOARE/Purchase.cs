using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SAD_UMKM_SOARE
{
    public partial class Purchase : Form
    {
        MainMenu frmmain; Sale frmsale; Return frmreturn; Inventory frminvent; ProfitLoss frmprofitloss; PerformanceSale frmperformance; TransactionRecord frmtransrec;
        InvoicePurchase frminvoice;
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string pathimage; int count; string query;
        List<PictureBox> imagebaju = new List<PictureBox>();
        List<Label> lbmodel = new List<Label>();
        List<Button> btnmin = new List<Button>();
        List<Button> btnplus = new List<Button>();
        List<TextBox> tbqty = new List<TextBox>();
        List<Label> lbharga = new List<Label>();
        DataTable dtmodel; DataTable dtbaju;
        bool tfbaju;

        public Purchase()
        {
            InitializeComponent();
            p_purchase.BackColor = Color.White;
            cb_model.BackColor = Color.FromArgb(234, 236, 240);
            tb_harga.BackColor = Color.FromArgb(234, 236, 240);
            tb_size.BackColor = Color.FromArgb(234, 236, 240);
            tb_qty.BackColor = Color.FromArgb(234, 236, 240);
            tb_company.BackColor = Color.FromArgb(234, 236, 240);
            pb_insert.Image = Image.FromFile("C:\\Users\\felic\\Documents\\ISB UC\\ISB SEM 3\\SAD\\ASSET\\image.png");
            pb_insert.SizeMode = PictureBoxSizeMode.StretchImage;

            sqlConnect = new MySqlConnection("server =localhost;uid =root;pwd=Feli0102;database=soare3");
            dtmodel = new DataTable();
            query = "select * from pakaian where pakaian_nama not like '%Defect%' and PAKAIAN_STATUS_DEL = 0;";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtmodel);

            cb_model.DataSource = dtmodel;
            cb_model.DisplayMember = "pakaian_nama";
            cb_model.ValueMember = "pakaian_nama";
            cb_model.SelectedIndex = -1;
            tfbaju = false;
        }
        private void Purchase_Load(object sender, EventArgs e)
        {
            pb_baju2.Visible = false;
            lb_model2.Visible = false;
            bt_min2.Visible = false;
            bt_plus2.Visible = false;
            tb_qty2.Visible = false;
            lb_price2.Visible = false;
            bt_checkout.Visible = false;
            pb_baju1.Visible = false;
            lb_model1.Visible = false;
            bt_min1.Visible = false;
            bt_plus1.Visible = false;
            tb_qty1.Visible = false;
            lb_price1.Visible = false;
            pathimage = "";
            count = 0;
            query = "delete from btemp;";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            lbmodel.Add(lb_model1); lbmodel.Add(lb_model2);
            tbqty.Add(tb_qty1); tbqty.Add(tb_qty2);
        }

        private void bt_dashboard_Click(object sender, EventArgs e)
        {
            frmmain = new MainMenu();
            frmmain.Show();
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

        private void bt_performance_Click(object sender, EventArgs e)
        {
            frmperformance = new PerformanceSale();
            frmperformance.Show();
            this.Close();
        }

        private void tb_harga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tb_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void pb_insert_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pathimage = ofd.FileName;
                pb_insert.Image = Image.FromFile(pathimage);
                pb_insert.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            // ini save path image
        }

        private void bt_next_Click(object sender, EventArgs e)
        {
            DataTable dtcek = new DataTable();
            query = "select * from btemp;";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtcek);
            int countcek = dtcek.Rows.Count;
            string simpannama = cb_model.Text.ToLower();
            char last = simpannama[simpannama.Length - 1];
            bool isAngka = char.IsDigit(last);
            string textboxnama;
            if (isAngka == true)
            {
                textboxnama = cb_model.Text;
            }
            else
            {
                textboxnama = cb_model.Text + " size " + tb_size.Text;
            }

            for (int i = 0; i < countcek; i++)
            {
                if (dtcek.Rows[i][0].ToString().ToLower() == textboxnama.ToLower())
                {
                    tfbaju = true; break;
                }
            }

            if (cb_model.Text == "" || tb_size.Text == "" || tb_qty.Text == "" || tb_harga.Text == "" || pathimage == "" || tfbaju == true)
            {
                MessageBox.Show("Please Check Again");
            }
            else
            {
                bt_checkout.Visible = true;
                sqlCommand = new MySqlCommand();
                sqlCommand.Connection = sqlConnect;

                sqlCommand.CommandText = "insert into btemp (BTEMP_PAKAIAN_NAMA, BTEMP_DETAIL_BELI_QTY, BTEMP_PAKAIAN_HARGA_BELI, BTEMP_PAKAIAN_FOTO) values" +
                        "(@name,@stock, @price, @path)";

                if(tb_size.Enabled == false)
                {
                    sqlCommand.Parameters.AddWithValue("@name", cb_model.Text);
                }
                else
                {
                    sqlCommand.Parameters.AddWithValue("@name", cb_model.Text + " Size " + tb_size.Text);
                }
                sqlCommand.Parameters.AddWithValue("@stock", Convert.ToInt32(tb_qty.Text));
                sqlCommand.Parameters.AddWithValue("@price", Convert.ToInt32(tb_harga.Text));
                sqlCommand.Parameters.AddWithValue("@path", pathimage);

                sqlCommand.ExecuteNonQuery();

                //MessageBox.Show("Data Saved !");

                dtbaju = new DataTable();
                string query = "select * from btemp;";
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtbaju);
                count = dtbaju.Rows.Count;

                if (count == 1)
                {
                    pb_baju1.Visible = true;
                    lb_model1.Visible = true;
                    bt_min1.Visible = true;
                    bt_plus1.Visible = true;
                    tb_qty1.Visible = true;
                    lb_price1.Visible = true;
                    pb_baju1.Image = Image.FromFile(pathimage);
                    pb_baju1.SizeMode = PictureBoxSizeMode.StretchImage;
                    lb_model1.Text = dtbaju.Rows[0][0].ToString();
                    tb_qty1.Text = tb_qty.Text;
                    lb_price1.Text = Convert.ToInt32(tb_harga.Text).ToString("C", new CultureInfo("id-ID"));
                    bt_checkout.Text = "Checkout (1)";
                }
                else if (count == 2)
                {
                    pb_baju2.Visible = true;
                    lb_model2.Visible = true;
                    tb_qty2.Visible = true;
                    lb_price2.Visible = true;
                    bt_min2.Visible = true;
                    bt_plus2.Visible = true;
                    pb_baju2.Image = Image.FromFile(pathimage);
                    pb_baju2.SizeMode = PictureBoxSizeMode.StretchImage;
                    lb_model2.Text = dtbaju.Rows[1][0].ToString();
                    tb_qty2.Text = tb_qty.Text;
                    lb_price2.Text = Convert.ToInt32(tb_harga.Text).ToString("C", new CultureInfo("id-ID"));
                    bt_checkout.Text = "Checkout (2)";
                }
                else if (count >= 3)
                {
                    if (count > 9)
                    {
                        MessageBox.Show("Limit Purchase = 9");
                    }
                    else
                    {
                        int harga = Convert.ToInt32(dtbaju.Rows[count - 1][2]);
                        string convharga = harga.ToString("C", new CultureInfo("id-ID"));
                        AddButton(count - 2, dtbaju.Rows[count - 1][0].ToString(), Convert.ToInt32(dtbaju.Rows[count - 1][1]), dtbaju.Rows[count - 1][3].ToString(), convharga);
                    }
                }

                cb_model.Text = "";
                tb_size.Text = "";
                tb_qty.Text = "";
                tb_harga.Text = "";
                pathimage = "";
                pb_insert.Image = Image.FromFile("C:\\Users\\felic\\Documents\\ISB UC\\ISB SEM 3\\SAD\\ASSET\\image.png");
                pb_insert.SizeMode = PictureBoxSizeMode.StretchImage;
                tfbaju = false;
            }
        }

        private void AddButton(int index, string model, int quantity, string pathimage, string harga)
        {
            //p_purchase.Size = new Size(969, 500 + (index * 300));
            p_purchase.AutoScrollMinSize = new Size(p_purchase.Width, 500 + (count * 300));
            p_purchase.AutoScroll = true;
            //MessageBox.Show(p_purchase.Height.ToString());

            // baru
            int maxBottom = p_purchase.Controls.Cast<Control>()
                            .Max(c => c.Bottom);
            p_purchase.Size = new Size(969, maxBottom + 245);
            //p_purchase.AutoScrollMinSize = new Size(p_purchase.Width, maxBottom + 300);


            // Cari elemen dengan posisi terendah di p_purchase
            int lastY = p_purchase.Controls.Cast<Control>()
                         .Max(c => c.Bottom); // Ambil posisi bawah elemen terakhir

            // Tambahkan jarak vertikal untuk elemen baru
            int newY = lastY + 20;

            PictureBox fotobaju = new PictureBox()
            {
                Name = $"baju {count}",
                Location = new Point(140, newY), // Gunakan newY, bukan index * 240
                Size = new Size(200, 210),
                Image = Image.FromFile(pathimage),
                Visible = true,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            imagebaju.Add(fotobaju);


            Label labelbaju = new Label()
            {
                Name = $"lbbaju {count}",
                Text = model,
                Location = new Point(370, newY),
                Font = new Font("Sans Serif Collection", 12, FontStyle.Bold),
                Size = new Size(440, 39)
            };
            lbmodel.Add(labelbaju);

            Button buttonmin = new Button
            {
                Name = $"min {count}",
                Text = "-",
                Location = new Point(380, newY + 60),
                Size = new Size(35, 35),
                Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold)
            };
            btnmin.Add(buttonmin);

            TextBox textboxqty = new TextBox()
            {
                Name = $"qty {count}",
                Text = quantity.ToString(),
                Location = new Point(420, newY + 60),
                Size = new Size(88, 35),
                Font = new Font("Sans Serif Collection", 10),
                MaxLength = 6,
                TextAlign = HorizontalAlignment.Center
            };
            tbqty.Add(textboxqty);

            Button buttonplus = new Button
            {
                Name = $"plus {count}",
                Text = "+",
                Location = new Point(510, newY + 60),
                Size = new Size(35, 35),
                Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold)
            };
            btnplus.Add(buttonplus);

            Label labelharga = new Label()
            {
                Name = $"harga {count}",
                Text = harga,
                Location = new Point(375, newY + 110),
                Font = new Font("Sans Serif Collection", 12),
                Size = new Size(170, 39)
            };
            lbharga.Add(labelharga);
            //MessageBox.Show(labelharga.Name.ToString());
            buttonmin.Click += Buttonmin_Click;
            buttonplus.Click += Buttonplus_Click;

            p_purchase.Controls.Add(fotobaju);
            p_purchase.Controls.Add(labelbaju);
            p_purchase.Controls.Add(buttonmin);
            p_purchase.Controls.Add(buttonplus);
            p_purchase.Controls.Add(textboxqty);
            p_purchase.Controls.Add(labelharga);
            bt_checkout.Text = $"Checkout ({count})";

        }

        private void Buttonmin_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                string namabtn = clickedButton.Name.Substring(clickedButton.Name.LastIndexOf(" ") + 1);
                for (int i = 0; i < tbqty.Count; i++)
                {
                    string labeln = tbqty[i].Name.Substring(tbqty[i].Name.LastIndexOf(" ") + 1);
                    if (namabtn == labeln)
                    {
                        int angka = Convert.ToInt32(tbqty[i].Text) - 1;
                        tbqty[i].Text = angka.ToString();
                    }
                }
            }
        }

        private void Buttonplus_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                string namabtn = clickedButton.Name.Substring(clickedButton.Name.LastIndexOf(" ") + 1);
                for (int i = 0; i < tbqty.Count; i++)
                {
                    string labeln = tbqty[i].Name.Substring(tbqty[i].Name.LastIndexOf(" ") + 1);
                    if (namabtn == labeln)
                    {
                        int angka = Convert.ToInt32(tbqty[i].Text) + 1;
                        tbqty[i].Text = angka.ToString();
                    }
                }
            }
        }

        private void tb_size_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void bt_min1_Click(object sender, EventArgs e)
        {
            int angka = Convert.ToInt32(tb_qty1.Text) - 1;
            tb_qty1.Text = angka.ToString();
        }

        private void bt_plus1_Click(object sender, EventArgs e)
        {
            int angka = Convert.ToInt32(tb_qty1.Text) + 1;
            tb_qty1.Text = angka.ToString();
        }

        private void bt_min2_Click(object sender, EventArgs e)
        {
            int angka = Convert.ToInt32(tb_qty2.Text) - 1;
            tb_qty2.Text = angka.ToString();
        }

        private void bt_plus2_Click(object sender, EventArgs e)
        {
            int angka = Convert.ToInt32(tb_qty2.Text) + 1;
            tb_qty2.Text = angka.ToString();
        }

        private void bt_checkout_Click(object sender, EventArgs e)
        {
            if (tb_company.Text == "")
            {
                MessageBox.Show("Please Fill Company Name");
            }
            else
            {
                bool cekcart = false;
                for (int i = 0; i < tbqty.Count(); i++)
                {
                    if (tbqty[i].Text == "0")
                    {
                        cekcart = true; break;
                    }
                }
                if (cekcart == true)
                {
                    MessageBox.Show("Please Check Again");
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        sqlCommand = new MySqlCommand();
                        sqlCommand.Connection = sqlConnect;
                        sqlCommand.CommandText = $"update BTEMP set BTEMP_DETAIL_BELI_QTY = {Convert.ToInt32(tbqty[i].Text)} where BTEMP_PAKAIAN_NAMA = '{lbmodel[i].Text}';";
                        sqlCommand.ExecuteNonQuery();
                    }
                    query = $"CALL pInsBeliDetailPak('{tb_company.Text}');";
                    sqlCommand = new MySqlCommand(query, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();

                    //invoice
                    frminvoice = new InvoicePurchase();
                    frminvoice.Show();
                    this.Close();

                    //delete button, label, dll

                    if (count >= 3)
                    {
                        for (int i = 2; i < lbmodel.Count; i++)
                        {
                            lbmodel[i].Dispose();
                            this.Controls.Remove(lbmodel[i]);
                            lbmodel.RemoveAt(i);
                        }
                        for (int i = 2; i < tbqty.Count; i++)
                        {
                            tbqty[i].Dispose();
                            this.Controls.Remove(tbqty[i]);
                            tbqty.RemoveAt(i);
                        }
                        for (int i = 0; i < imagebaju.Count; i++)
                        {
                            imagebaju[i].Dispose();
                            this.Controls.Remove(imagebaju[i]);
                            imagebaju.RemoveAt(i);
                        }
                        for (int i = 0; i < btnmin.Count; i++)
                        {
                            btnmin[i].Dispose();
                            this.Controls.Remove(btnmin[i]);
                            btnmin.RemoveAt(i);
                        }
                        for (int i = 0; i < btnplus.Count; i++)
                        {
                            btnplus[i].Dispose();
                            this.Controls.Remove(btnplus[i]);
                            btnplus.RemoveAt(i);
                        }
                        for (int i = 0; i < lbharga.Count; i++)
                        {
                            lbharga[i].Dispose();
                            this.Controls.Remove(lbharga[i]);
                            lbharga.RemoveAt(i);
                        }
                    }

                    // delete btemp
                    query = "delete from btemp;";
                    sqlCommand = new MySqlCommand(query, sqlConnect);
                    sqlConnect.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                }
            }
        }

        private void cb_model_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool cek = false; int index = -1;
            for (int i = 0; i < dtmodel.Rows.Count;i++)
            {
                if (dtmodel.Rows[i][1].ToString().ToLower() == cb_model.Text.ToLower())
                {
                    cek = true;
                    index = i;
                    break;
                }
            }
            if (cek == true)
            {
                tb_harga.Text = dtmodel.Rows[index][3].ToString();
                string nama = dtmodel.Rows[index][1].ToString();
                tb_size.Text = nama.Substring(nama.LastIndexOf(" ") + 1);
                tb_size.Enabled = false;
                pb_insert.Image = Image.FromFile(dtmodel.Rows[index][5].ToString());
                tb_harga.ReadOnly = true;
                pathimage = dtmodel.Rows[index][5].ToString();
            }
            else
            {
                tb_size.Enabled = true;
                tb_harga.ReadOnly = false;
            }
        }

        private void cb_model_TextChanged(object sender, EventArgs e)
        {
            tfbaju = false;
            bool cek = false; int index = -1;
            string namamodel = cb_model.Text.ToLower() + " size " + tb_size.Text;
            for (int i = 0; i < dtmodel.Rows.Count; i++)
            {
                if (dtmodel.Rows[i][1].ToString().ToLower() == namamodel)
                {
                    cek = true;
                    index = i;
                    break;
                }
            }
            if (cek == true)
            {
                tb_harga.Text = dtmodel.Rows[index][3].ToString();
                string nama = dtmodel.Rows[index][1].ToString();
                tb_size.Text = nama.Substring(nama.LastIndexOf(" ") + 1);
                tb_size.Enabled = false;
                tb_harga.ReadOnly = true;
                pb_insert.Image = Image.FromFile(dtmodel.Rows[index][5].ToString());
                pathimage = dtmodel.Rows[index][5].ToString();
            }
            else
            {
                tb_size.Enabled = true;
                tb_harga.ReadOnly = false;
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            pb_baju2.Visible = false;
            lb_model2.Visible = false;
            bt_min2.Visible = false;
            bt_plus2.Visible = false;
            tb_qty2.Visible = false;
            lb_price2.Visible = false;
            bt_checkout.Visible = false;
            pb_baju1.Visible = false;
            lb_model1.Visible = false;
            bt_min1.Visible = false;
            bt_plus1.Visible = false;
            tb_qty1.Visible = false;
            lb_price1.Visible = false;
            pathimage = "";

            if (count >= 3)
            {
                for (int i = 2; i < lbmodel.Count; i++)
                {
                    lbmodel[i].Dispose();
                    this.Controls.Remove(lbmodel[i]);
                    lbmodel.RemoveAt(i);
                }
                for (int i = 2; i < tbqty.Count; i++)
                {
                    tbqty[i].Dispose();
                    this.Controls.Remove(tbqty[i]);
                    tbqty.RemoveAt(i);
                }
                for (int i = 0; i < imagebaju.Count; i++)
                {
                    imagebaju[i].Dispose();
                    this.Controls.Remove(imagebaju[i]);
                    imagebaju.RemoveAt(i);
                }
                for (int i = 0; i < btnmin.Count; i++)
                {
                    btnmin[i].Dispose();
                    this.Controls.Remove(btnmin[i]);
                    btnmin.RemoveAt(i);
                }
                for (int i = 0; i < btnplus.Count; i++)
                {
                    btnplus[i].Dispose();
                    this.Controls.Remove(btnplus[i]);
                    btnplus.RemoveAt(i);
                }
                for (int i = 0; i < lbharga.Count; i++)
                {
                    lbharga[i].Dispose();
                    this.Controls.Remove(lbharga[i]);
                    lbharga.RemoveAt(i);
                }
            }
            count = 0;
            dtbaju = new DataTable();
            // hilang btemp
            query = "delete from btemp;";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
        }
    }
}
