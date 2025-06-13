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

namespace SAD_UMKM_SOARE
{
    public partial class Login : Form
    {
        MainMenu frmmain;
        public Login()
        {
            InitializeComponent();
            tb_username.BackColor = Color.FromArgb(234, 236, 240);
            tb_password.BackColor = Color.FromArgb(234, 236, 240);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            
            if(tb_username.Text == "admin" &&  tb_password.Text == "admin")
            {
                MainMenu frm = new MainMenu();
                frm.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password Salah");
            }
            tb_username.Text = "";
            tb_password.Text = "";
            
            
        }
    }
}
