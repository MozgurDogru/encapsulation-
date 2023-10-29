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
    public partial class frmKapsulleme_Random_If : Form
    {
        public frmKapsulleme_Random_If()
        {
            InitializeComponent();
        }

        private void btn_Sonuc_Bul_Click(object sender, EventArgs e)
        {
            Random random= new Random();
            int number1 = random.Next(1,50);
            int number2 = random.Next(1,50);

            lbl_number1.Text = number1.ToString();
            lbl_number2.Text = number2.ToString();

            myClass mc= new myClass();
            mc.number1 = number1;//public set
            mc.number2 = number2;

            if (cmb_Dort_islem.SelectedItem != null)
            {
                int sonuc = mc.dortislem(cmb_Dort_islem.SelectedItem.ToString());
                lbl_Sonuc.Text = "Girdiğiniz" + number1 + "ve" + number2 + "sayilarinin" + cmb_Dort_islem.SelectedItem.ToString() + " değeri = " + sonuc.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen önce listeden işlem seçiniz.");
            }
           
        }

       

        private void frmKapsulleme_Random_If_Load(object sender, EventArgs e)
        {
            cmb_Dort_islem.Items.Add("Toplama");
            cmb_Dort_islem.Items.Add("Çıkarma");
            cmb_Dort_islem.Items.Add("Çarpma");
            cmb_Dort_islem.Items.Add("Bölme");

        }

        private void cmb_Dort_islem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
