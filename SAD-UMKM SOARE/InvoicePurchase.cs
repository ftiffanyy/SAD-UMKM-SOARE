using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAD_UMKM_SOARE
{
    public partial class InvoicePurchase : Form
    {
        MainMenu frmmain;
        List<Label> lbangka = new List<Label>();
        List<TextBox> tbmodel = new List<TextBox>();
        List<TextBox> tbqty = new List<TextBox>();
        List<TextBox> tbamount = new List<TextBox>();
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        DataTable dtbeli; DataTable dtpakaian;
        string query; int count;

        public InvoicePurchase()
        {
            InitializeComponent();
            lb_idbeli.BackColor = ColorTranslator.FromHtml("#223559");
            lb_idbeli.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            tb_company.BackColor = ColorTranslator.FromHtml("#223559");
            tb_company.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            lb_date.BackColor = ColorTranslator.FromHtml("#223559");
            lb_date.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            tb_total.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            sqlConnect = new MySqlConnection("server =localhost;uid =root;pwd=Feli0102;database=soare3");
            dtbeli = new DataTable();
            query = "select beli_nama_supplier, beli_tanggal, beli_id, beli_harga_total from beli order by 3 desc limit 1;";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtbeli);
        }

        private void InvoicePurchase_Load(object sender, EventArgs e)
        {
            lbangka.Add(lb_1); lbangka.Add(lb_2); lbangka.Add(lb_3); lbangka.Add(lb_4); lbangka.Add(lb_5); lbangka.Add(lb_6); lbangka.Add(lb_7); lbangka.Add(lb_8); lbangka.Add(lb_9);
            tbmodel.Add(tb_name1); tbmodel.Add(tb_name2); tbmodel.Add(tb_name3); tbmodel.Add(tb_name4); tbmodel.Add(tb_name5); tbmodel.Add(tb_name6); tbmodel.Add(tb_name7); tbmodel.Add(tb_name8); tbmodel.Add(tb_name9);
            tbqty.Add(tb_qty1); tbqty.Add(tb_qty2); tbqty.Add(tb_qty3); tbqty.Add(tb_qty4); tbqty.Add(tb_qty5); tbqty.Add(tb_qty6); tbqty.Add(tb_qty7); tbqty.Add(tb_qty8); tbqty.Add(tb_qty9);
            tbamount.Add(tb_amount1); tbamount.Add(tb_amount2); tbamount.Add(tb_amount3); tbamount.Add(tb_amount4); tbamount.Add(tb_amount5); tbamount.Add(tb_amount6); tbamount.Add(tb_amount7); tbamount.Add(tb_amount8); tbamount.Add(tb_amount9);
            lb_idbeli.Text = "#" + dtbeli.Rows[0][2].ToString();
            tb_company.Text = dtbeli.Rows[0][0].ToString();
            DateTime date = (DateTime)dtbeli.Rows[0][1];
            lb_date.Text = date.ToString("dd/MM/yyyy");
            tb_total.Text = "TOTAL " + Convert.ToInt32(dtbeli.Rows[0][3]).ToString("C", new CultureInfo("id-ID")); ;

            dtpakaian = new DataTable();
            query = "select * from vInvoicePurchase;";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtpakaian);
            count = dtpakaian.Rows.Count;

            for (int i = 0; i < count; i++)
            {
                tbmodel[i].Text = dtpakaian.Rows[i][0].ToString();
                tbqty[i].Text = dtpakaian.Rows[i][1].ToString();
                tbamount[i].Text = Convert.ToInt32(dtpakaian.Rows[i][2]).ToString("C", new CultureInfo("id-ID"));

                lbangka[i].BackColor = ColorTranslator.FromHtml("#FFFFFF");
                tbmodel[i].BackColor = ColorTranslator.FromHtml("#FFFFFF");
                tbqty[i].BackColor = ColorTranslator.FromHtml("#FFFFFF");
                tbamount[i].BackColor = ColorTranslator.FromHtml("#FFFFFF");
                lbangka[i].Visible = true;
                tbmodel[i].Visible = true;
                tbqty[i].Visible = true;
                tbamount[i].Visible = true;
                tbmodel[i].KeyPress += textBox_KeyPress;
                tbqty[i].KeyPress += textBox_KeyPress;
                tbamount[i].KeyPress += textBox_KeyPress;
            }
            tb_total.KeyPress += textBox_KeyPress;
            tb_company.KeyPress += textBox_KeyPress;
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            frmmain = new MainMenu();
            frmmain.Show();
            this.Close();

            for (int i = 0; i < count; i++)
            {
                lbangka[i].Visible = false;
                tbmodel[i].Visible = false;
                tbqty[i].Visible = false;
                tbamount[i].Visible = false;
            }
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Mencegah karakter apa pun dimasukkan
        }
    }
}
