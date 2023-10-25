using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;

namespace SondersGP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        ArrayList katilimcilar = new ArrayList(); //katilimcilari tutan liste
        string[] kazananlar; //kazananları tutan dizi
        int kazananSayisi = 1; //kullanıcının seçeceği kazanan sayısı
        string katilimciIsmi; //geçici değer tutan değişken
        int kazananNo; //Rasgele değer üretilip içinde tutan geçici değişken
        int siraNo = 1; //listbox'ta isimlerinumara sırasıyla göstermek için gerekli değişken 
        Random rasgeleSayi = new Random(); //Rasgele değer üretmek için gerekli nesne değişkeni
        string cikisdegeri; //Katılımcı girişi ekranından çıkmak için gerekli değeri tutan değişken
        private void Form1_Load(object sender, EventArgs e)
        {
            kazananGosterButon.Visible = false;
            cekilisYapButon.Visible = false;
            katilimciEkleButon.Enabled = false;
        }
        
        private void button3_Click(object sender, EventArgs e) //degerlerButon
        {
            bool dogruDegerGirildi = false;

            while (!dogruDegerGirildi)
            {
                try
                {
                    kazananSayisi = Convert.ToInt32(Interaction.InputBox("Kazanacak Kişi Sayısı", "ekran", "buraya", 400, 370));
                    if (kazananSayisi == 0)
                    {
                        MessageBox.Show("0'dan farklı değer giriniz.");
                    }
                    else
                    {
                        kazananlar = new string[kazananSayisi];

                        cikisdegeri = Interaction.InputBox("İsim giriş ekranı çıkış değeri", "ekran", "buraya", 400, 370);
                        dogruDegerGirildi = true;
                    }           
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("Değer girmediniz.");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Hatalı türde değer girdiniz. Lütfen tekrar deneyin.");
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Girdiğiniz değer çok büyük. Lütfen tekrar deneyin.");
                }
            }
            katilimciEkleButon.Enabled = true;
            degerlerButon.Visible = false;
        }

        
        private void button1_Click(object sender, EventArgs e) //katilimciEkleButon
        {
            while (true)
            {
                bool dogruDegerGirildi2 = false;

                while (!dogruDegerGirildi2)
                {
                    try
                    {
                        katilimciIsmi = Interaction.InputBox("Çıkmak için gerekli değer: " + cikisdegeri, "İsim Girişi", "buraya", 400, 370);
                        dogruDegerGirildi2 = true;
                    }
                    catch (ArgumentNullException)
                    {
                        MessageBox.Show("Değer girmediniz.");
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Hatalı türde değer girdiniz. Lütfen tekrar deneyin.");
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("Girdiğiniz değer çok büyük. Lütfen tekrar deneyin.");
                    }                   
                }

                if (katilimciIsmi == cikisdegeri)
                {
                    if (katilimcilar.Count < kazananSayisi)
                    {
                        MessageBox.Show("Belirlediğiniz kazanan sayısı altında kişi eklediniz! Lütfen katılımcı ekleyiniz..");
                    }
                    else
                    {
                        cekilisYapButon.Visible = true;
                        katilimciEkleButon.Location = new Point(318, 131);
                        break;
                    }             
                }
                else
                {
                    katilimcilar.Add(katilimciIsmi);
                    listBox1.Items.Add(siraNo + ". " + katilimciIsmi);
                    siraNo++;          
                }
            }
        }

        
        private void button2_Click(object sender, EventArgs e) //cekilisYapButon
        {
            int i = 0;
            for (i = 0; i < kazananlar.Length; i++)
            {
                kazananNo = rasgeleSayi.Next(katilimcilar.Count);
                kazananlar[i] = katilimcilar[kazananNo].ToString();
                katilimcilar.RemoveAt(kazananNo);
                listBox2.Items.Add((i + 1) + ". " + kazananlar[i]);
            }

            katilimciEkleButon.Visible = false;
            cekilisYapButon.Visible = false;
            kazananGosterButon.Visible = true;
            kazananGosterButon.Location = new Point(302, 190);

            MessageBox.Show("Çekilişiniz Bitmiştir..");        
        }
        
        private void button4_Click(object sender, EventArgs e) //kazananGosterButon
        {
            listBox3.Visible = false;
        }


        //geçersiz metodlar
        private void tekrarCekilisButon_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}
