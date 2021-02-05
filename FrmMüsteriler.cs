using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Renkli_Rüyalar_Pansiyonu
{
    public partial class FrmMüsteriler : Form
    {
        public FrmMüsteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = renkliruyalar.database.windows.net; Initial Catalog = RenkliRuyalarPansiyonu; Integrated Security = True");
        private void verilergoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MüsteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["müsteri_id"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            
            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilergoster();
        }
        int id =0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskTxtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtKimlikNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpGirisTarihi.Value = Convert.ToDateTime(listView1.SelectedItems[0].SubItems[9].Text);
            DtpCikisTarihi.Value = Convert.ToDateTime(listView1.SelectedItems[0].SubItems[10].Text);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (TxtOdaNo.Text == "101")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda101", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (TxtOdaNo.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda102", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (TxtOdaNo.Text == "103")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda103", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (TxtOdaNo.Text == "104")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda104", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (TxtOdaNo.Text == "105")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda105", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (TxtOdaNo.Text == "106")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda106", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (TxtOdaNo.Text == "107")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda107", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (TxtOdaNo.Text == "108")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda108", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (TxtOdaNo.Text == "109")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda109", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("delete from MüsteriEkle where TC="+TxtKimlikNo.Text.TrimEnd()+"", baglanti);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            verilergoster();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            comboBox1.Text="";
            MskTxtTelefon.Clear();
            TxtMail.Text = "";
            TxtKimlikNo.Clear();
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DtpCikisTarihi.Text = "";
            DtpGirisTarihi.Text = "";




        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MüsteriEkle set Adi='" + TxtAdi.Text + "',Soyadi='" + TxtSoyadi.Text + "',Cinsiyet='" + comboBox1.Text + "',Telefon='" + MskTxtTelefon.Text + "',Mail='" + TxtMail.Text + "',TC='" + TxtKimlikNo.Text + "',OdaNo='" + TxtOdaNo.Text + "',Ucret='" + TxtUcret.Text + "',GirisTarihi='" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "',CikisTarihi='" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "'where müsteri_id=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilergoster();
        }
        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from MüsteriEkle where Adi like'%" + textBox1.Text+ "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["müsteri_id"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
               
            }
            baglanti.Close();
        }

        private void FrmMüsteriler_Load(object sender, EventArgs e)
        {

        }

        private void TxtOdaNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}