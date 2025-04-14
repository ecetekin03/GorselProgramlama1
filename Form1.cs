using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            
            


            // Kullanıcıdan alınan veriler
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            DateTime dogumTarihi = dtDogum.Value;
            double boy = Convert.ToDouble(txtBoy.Text);
            double kilo = Convert.ToDouble(txtKilo.Text);

            // VKİ Hesaplama
            boy = boy / 100;
            double vki = VKIHesapla(boy, kilo);
            string vkiYorum = VKIYorumu(vki);

            // Burç Hesaplama
            int gun = dogumTarihi.Day;
            int ay = dogumTarihi.Month;
            string burc = BurcHesapla(gun, ay);
            string burcYorum = GetBurcYorumu(burc);
            string dosyaAdi = burc
                .Replace("ç", "c")
                .Replace("Ç", "C")
                .Replace("ğ", "g")
                .Replace("Ğ", "G")
                .Replace("ı", "i")
                .Replace("İ", "I")
                .Replace("ö", "o")
                .Replace("Ö", "O")
                .Replace("ş", "s")
                .Replace("Ş", "S")
                .Replace("ü", "u")
                .Replace("Ü", "U");

            string burcResmi = $"{dosyaAdi}.png";


            // SQL Bağlantısı ve Veritabanına Veri Ekleme
            string connectionString = @"Data Source=TEKIN-HP-HOME;Initial Catalog=GP;Integrated Security=True";


            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                // SQL komutunu hazırlıyoruz
                SqlCommand cmd = new SqlCommand("INSERT INTO Kisiler (Ad, Soyad, Gun, Ay, Yil, Burc, Yorum, BurcResmi, VKI, VKIYorum) " +
                                                "VALUES (@Ad, @Soyad, @Gun, @Ay, @Yil, @Burc, @Yorum, @BurcResmi, @VKI, @VKIYorum)", conn);

                // Parametreleri ekleyelim
                cmd.Parameters.AddWithValue("@Ad", ad);
                cmd.Parameters.AddWithValue("@Soyad", soyad);
                cmd.Parameters.AddWithValue("@Gun", gun);
                cmd.Parameters.AddWithValue("@Ay", dogumTarihi.ToString("MMMM", new System.Globalization.CultureInfo("tr-TR")));
                cmd.Parameters.AddWithValue("@Yil", dogumTarihi.Year);
                cmd.Parameters.AddWithValue("@Burc", burc);
                cmd.Parameters.AddWithValue("@Yorum", burcYorum);
                cmd.Parameters.AddWithValue("@BurcResmi", burcResmi);
                cmd.Parameters.AddWithValue("@VKI", vki);
                cmd.Parameters.AddWithValue("@VKIYorum", vkiYorum);

                // Veritabanına kaydedelim
                cmd.ExecuteNonQuery();
                MessageBox.Show("Veri başarıyla kaydedildi!");

                // Burç resmini formda gösterelim
                string imagePath = Path.Combine(Application.StartupPath, "burclar", $"{burcResmi}");
                if (File.Exists(imagePath))
                {
                    picBurc.Image = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show($"Resim bulunamadı: {imagePath}");
                }
                // Formda burç ve vki bilgilerini göster
                burc1.Text = "Burcunuz: " + burc;
                burc2.Text = "Burç Yorumu: " + burcYorum;
                Ibl1.Text = "VKİ: " + vki.ToString("0.00"); 
                Ibl2.Text = "VKİ Yorumu: " + vkiYorum;



            }

            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        // VKİ hesaplama fonksiyonu
        private double VKIHesapla(double boy, double kilo)
        {
            return kilo / (boy * boy);
        }

        // VKİ yorumlama fonksiyonu
        private string VKIYorumu(double vki)
        {
            if (vki < 18.5)
                return "Zayıf";
            else if (vki >= 18.5 && vki < 24.9)
                return "Normal";
            else if (vki >= 25 && vki < 29.9)
                return "Fazla Kilolu";
            else
                return "Obez";
        }

        // Burç hesaplama fonksiyonu
        private string BurcHesapla(int gun, int ay)
        {
            if ((ay == 3 && gun >= 21) || (ay == 4 && gun <= 19)) return "Koç";
            if ((ay == 4 && gun >= 20) || (ay == 5 && gun <= 20)) return "Boğa";
            if ((ay == 5 && gun >= 21) || (ay == 6 && gun <= 20)) return "İkizler";
            if ((ay == 6 && gun >= 21) || (ay == 7 && gun <= 22)) return "Yengeç";
            if ((ay == 7 && gun >= 23) || (ay == 8 && gun <= 22)) return "Aslan";
            if ((ay == 8 && gun >= 23) || (ay == 9 && gun <= 22)) return "Başak";
            if ((ay == 9 && gun >= 23) || (ay == 10 && gun <= 22)) return "Terazi";
            if ((ay == 10 && gun >= 23) || (ay == 11 && gun <= 21)) return "Akrep";
            if ((ay == 11 && gun >= 22) || (ay == 12 && gun <= 21)) return "Yay";
            if ((ay == 12 && gun >= 22) || (ay == 1 && gun <= 19)) return "Oğlak";
            if ((ay == 1 && gun >= 20) || (ay == 2 && gun <= 18)) return "Kova";
            return "Balık"; // 19 Şubat - 20 Mart
        }



        // Burç yorumu fonksiyonu
        private string GetBurcYorumu(string burc)
        {
            switch (burc)
            {
                case "Koç":
                    return "Enerjik ve cesursunuz.";
                case "Boğa":
                    return "Kararlı ve sabırlısınız.";
                case "İkizler":
                    return "Zeki ve iletişimci bir kişiliğiniz var.";
                case "Yengeç":
                    return "Duygusal ve empatik birisiniz.";
                case "Aslan":
                    return "Lider ruhlu ve gururlusunuz.";
                case "Başak":
                    return "Düzenli ve dikkatli bir insansınız.";
                case "Terazi":
                    return "Adil ve sosyal kişiliğe sahipsiniz.";
                case "Akrep":
                    return "Tutkulu ve gizemlisiniz.";
                case "Yay":
                    return "Özgür ruhlu ve iyimser birisiniz.";
                case "Oğlak":
                    return "Sorumlu ve disiplinli bir kişiliğiniz var.";
                case "Kova":
                    return "Bağımsız ve yenilikçi birisiniz.";
                case "Balık":
                    return "Hayalperest ve hassas bir insansınız.";
                default:
                    return "Burç yorumu bulunamadı.";
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void burcYorum_Click(object sender, EventArgs e)
        {

        }
    }
}
