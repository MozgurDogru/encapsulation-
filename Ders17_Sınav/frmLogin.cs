using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders17_Sınav
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
             timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_login.Text.ToLower() == "nergis" && txt_password.Text == "123.")
            {
                //basarili
                frmMenu f = new frmMenu();
                f.ShowDialog();
            }

            else
            {
                
                //basarisiz
                MessageBox.Show("Login ve/veya şifrenizi Kontrol Ediniz!");
            }
        }

        private void txt_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }
    }
}
