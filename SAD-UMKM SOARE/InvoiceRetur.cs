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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAD_UMKM_SOARE
{
    public partial class InvoiceRetur : Form
    {
        MainMenu frmmain;
        List<TextBox> tbid = new List<TextBox>();
        List<TextBox> tbmodel = new List<TextBox>();
        List<TextBox> tbqty = new List<TextBox>();
        List<TextBox> tbamount = new List<TextBox>();
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        DataTable dtretur; DataTable dtpakaian;
        string query; int count;

        public InvoiceRetur()
        {
            InitializeComponent();
            lb_idretur.BackColor = ColorTranslator.FromHtml("#223559");
            lb_idretur.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            tb_customer.BackColor = ColorTranslator.FromHtml("#223559");
            tb_customer.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            lb_date.BackColor = ColorTranslator.FromHtml("#223559");
            lb_date.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            tb_total.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            sqlConnect = new MySqlConnection("server =localhost;uid =root;pwd=Feli0102;database=soare3");
            dtretur = new DataTable();
            query = "select * from vHeaderReturn;";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtretur);
        }

        private void InvoiceRetur_Load(object sender, EventArgs e)
        {
            tbid.Add(tb_id1); tbid.Add(tb_id2); tbid.Add(tb_id3); tbid.Add(tb_id4); tbid.Add(tb_id5); tbid.Add(tb_id6); tbid.Add(tb_id7); tbid.Add(tb_id8); tbid.Add(tb_id9);
            tbmodel.Add(tb_name1); tbmodel.Add(tb_name2); tbmodel.Add(tb_name3); tbmodel.Add(tb_name4); tbmodel.Add(tb_name5); tbmodel.Add(tb_name6); tbmodel.Add(tb_name7); tbmodel.Add(tb_name8); tbmodel.Add(tb_name9);
            tbqty.Add(tb_qty1); tbqty.Add(tb_qty2); tbqty.Add(tb_qty3); tbqty.Add(tb_qty4); tbqty.Add(tb_qty5); tbqty.Add(tb_qty6); tbqty.Add(tb_qty7); tbqty.Add(tb_qty8); tbqty.Add(tb_qty9);
            tbamount.Add(tb_amount1); tbamount.Add(tb_amount2); tbamount.Add(tb_amount3); tbamount.Add(tb_amount4); tbamount.Add(tb_amount5); tbamount.Add(tb_amount6); tbamount.Add(tb_amount7); tbamount.Add(tb_amount8); tbamount.Add(tb_amount9);
            lb_idretur.Text = "#" + dtretur.Rows[0][0].ToString();
            tb_customer.Text = dtretur.Rows[0][2].ToString();
            DateTime date = (DateTime)dtretur.Rows[0][1];
            lb_date.Text = date.ToString("dd/MM/yyyy");
            tb_total.Text = "TOTAL " + Convert.ToInt32(dtretur.Rows[0][3]).ToString("C", new CultureInfo("id-ID")); ;

            dtpakaian = new DataTable();
            query = "select * from vInvoiceReturn;";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtpakaian);
            count = dtpakaian.Rows.Count;

            for (int i = 0; i < count; i++)
            {
                tbid[i].Text = dtpakaian.Rows[i][0].ToString();
                tbmodel[i].Text = dtpakaian.Rows[i][1].ToString();
                tbqty[i].Text = dtpakaian.Rows[i][2].ToString();
                tbamount[i].Text = Convert.ToInt32(dtpakaian.Rows[i][3]).ToString("C", new CultureInfo("id-ID"));

                tbid[i].BackColor = ColorTranslator.FromHtml("#FFFFFF");
                tbmodel[i].BackColor = ColorTranslator.FromHtml("#FFFFFF");
                tbqty[i].BackColor = ColorTranslator.FromHtml("#FFFFFF");
                tbamount[i].BackColor = ColorTranslator.FromHtml("#FFFFFF");
                tbid[i].Visible = true;
                tbmodel[i].Visible = true;
                tbqty[i].Visible = true;
                tbamount[i].Visible = true;

                tbid[i].Enabled = true;
                tbqty[i].Enabled = true;
                tbamount[i].Enabled = true;
                tbmodel[i].Enabled = true;

                tbid[i].KeyPress += textBox_KeyPress;
                tbmodel[i].KeyPress += textBox_KeyPress;
                tbqty[i].KeyPress += textBox_KeyPress;
                tbamount[i].KeyPress += textBox_KeyPress;
            }
            tb_total.KeyPress += textBox_KeyPress;
            tb_customer.KeyPress += textBox_KeyPress;
        }


        private void bt_back_Click(object sender, EventArgs e)
        {
            frmmain = new MainMenu();
            frmmain.Show();
            this.Close();

            for (int i = 0; i < count; i++)
            {
                tbid[i].Visible = false;
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
