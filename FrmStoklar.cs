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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection
        private void Veriler()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select*from Stoklar",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gida"].ToString();
                ekle.SubItems.Add(oku["İcecek"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());
                listView1.Items.Add(ekle);
        

            }
            baglanti.Close();
        }
        private void Veriler2()
        {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select*from Faturalar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku2["Elektrik"].ToString();
                ekle.SubItems.Add(oku2["Su"].ToString());
                ekle.SubItems.Add(oku2["İnternet"].ToString());
                listView2.Items.Add(ekle);


            }
            baglanti.Close();
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Stoklar (Gida,İcecek,Cerezler) values ('" + TxtGidalar.Text + "','" + Txtİcecekler.Text + "','" + TxtAtistirmaliklar.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Veriler();
        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            Veriler();
            Veriler2();
            

        }

        private void BtnKaydet2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into Faturalar (Elektrik,Su,İnternet) values ('" + TxtElektrik.Text + "','" + TxtSu.Text + "','" + Txtİnternet.Text + "')", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            Veriler2();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
    }

