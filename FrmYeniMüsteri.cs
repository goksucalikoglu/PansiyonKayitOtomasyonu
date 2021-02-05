using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Drawing;

namespace Renkli_Rüyalar_Pansiyonu
{
    public partial class FrmYeniMüsteri : Form
    {
        public FrmYeniMüsteri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(
        private void BtnOda101_Click(object sender, EventArgs eventArgs)
        {
            Button sndr = (Button)sender;
            TxtOdaNo.Text = sndr.Tag.ToString();
                 
        }

        private void BtnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Gösterir");
        }

        private void BtnBosOda_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Mor Renkli Butonlar Boş Odaları Gösterir");
        }
        DateTime KucukTarih;
        DateTime BuyukTarih;
        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            KucukTarih = Convert.ToDateTime(DtpGirisTarihi.Value.ToShortDateString());
            BuyukTarih = Convert.ToDateTime(DtpCikisTarihi.Value.ToShortDateString());

            TimeSpan Sonuc;
            Sonuc = BuyukTarih - KucukTarih;
            label11.Text = Sonuc.TotalDays.ToString();
            Ucret = Convert.ToInt32(label11.Text)*100;
            TxtUcret.Text = Ucret.ToString();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {   
            if(TxtAdi.Text != "" && TxtSoyadi.Text != "")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into MüsteriEkle(Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "','" + comboBox1.Text + "','" + MskTxtTelefon.Text + "','" + TxtMail.Text + "','" + TxtKimlikNo.Text + "','" + TxtOdaNo.Text + "','" + TxtUcret.Text + "','" + DtpGirisTarihi.Value.ToString("dd-MM-yyyy") + "','" + DtpCikisTarihi.Value.ToString("dd-MM-yyyy") + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Müşteri Kaydı Yapıldı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("insert into Oda"+TxtOdaNo.Text.TrimEnd()+"(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();



                ///////// Sakın alttaki satırları silme
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox || item is ComboBox || item is MaskedTextBox || item is DateTimePicker)
                    {
                        item.ResetText();
                    }
                }
                /////////
            }
            else
            {
                MessageBox.Show("AD SOYAD BOŞ BIRAKILAMAZ", "UYARI", MessageBoxButtons.OK);
            }
         
        }
     
    

        
        private void FrmYeniMüsteri_Load(object sender, EventArgs e)
        {
            //Oda101
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select * from Oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                BtnOda101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda101.Text != "101")
            {
                BtnOda101.BackColor = Color.Red;
                BtnOda101.Enabled = false;
            }
            //Oda102 
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * from Oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                BtnOda102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda102.Text != "102")
            {
                BtnOda102.BackColor = Color.Red;
                BtnOda102.Enabled = false;
            }
            //Oda103
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select * from Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                BtnOda103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda103.Text != "103")
            {
                BtnOda103.BackColor = Color.Red;
                BtnOda103.Enabled = false;
            }
            //Oda104
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select * from Oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                BtnOda104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda104.Text != "104")
            {
                BtnOda104.BackColor = Color.Red;
                BtnOda104.Enabled = false;
            }
            //Oda105
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select * from Oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            if (oku5.Read())
            {
                BtnOda105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            baglanti.Close();
            oku5.Close();
            if (BtnOda105.Text != "105")
            {
                BtnOda105.BackColor = Color.Red;
                BtnOda105.Enabled = false;
            }
            //Oda106
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select * from Oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                BtnOda106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda106.Text != "106")
            {
                BtnOda106.BackColor = Color.Red;
                BtnOda106.Enabled = false;
            }
            //Oda107
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("Select * from Oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                BtnOda107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda107.Text != "107")
            {
                BtnOda107.BackColor = Color.Red;
                BtnOda107.Enabled = false;
            }
            //Oda108
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("Select * from Oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                BtnOda108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda108.Text != "108")
            {
                BtnOda108.BackColor = Color.Red;
                BtnOda108.Enabled = false;
            }
            //Oda109
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("Select * from Oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();
            while (oku9.Read())
            {
                BtnOda109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda109.Text != "109")
            {
                BtnOda109.BackColor = Color.Red;
                BtnOda109.Enabled = false;
            }
           
            

        }

        private void DtpGirisTarihi_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    }

//Data Source=renkliruyalar.database.windows.net;Initial Catalog=RenkliRuyalarPansiyonu;Integrated Security=True