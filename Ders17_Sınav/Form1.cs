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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //frmLogin formu açılacak
            //2 textbox ...txtlogin(sedat) ,txtsifre(123.)
            //eger login dogruysa ,frmmenu acılacak,yanlıssa tekrar login girisi yapılacak.

            //frmMenu den, Kapsulleme Random If formu acılacak


            //Kapsulleme Random If , Combobox ta ,BASLANGICTA toplama , carpma , cıkarma , bölme verilerini yazdırın


            //sonucbul butonuna tıklaninca, random 2 sayı üretecek (1-50 arasında ) label larda gösterecek.
            //myClass icindeki property lere gonderilecek(kapsülleme)
            // myClass mc = new myClass();
            //mc.sayi1 = 3;
            //mc.sayi2 = 5;  Kapsülleme(Encapsulation)
            //myClass icindeki metod cagrılacak.(parametre olarakta combobox taki islem adi)

            //combobox tan hangi işlemi seçtiysem ,
            //Comboboxtan secilen islemi yapıp geriye sonuc dönecek
            //eger bu sayilardan biri ya da ikisi 20 den kücük ise, sayi 20 kabul edilip ona göre islem yapılacak 
            //metod New diye cagrilacak
            //bölme ve cıkarma islemide,buyuk sayiyi kucuge bolecek.

        }
    }
}
