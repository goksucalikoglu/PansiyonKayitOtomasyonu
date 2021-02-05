using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renkli_Rüyalar_Pansiyonu
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection
        public string kullanıcı ="";
        public string kullanıcısifre = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * From AdminGiris ", baglanti);
            SqlDataReader dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                kullanıcı = dr["Kullanici"].ToString();
                kullanıcısifre = dr["Sifre"].ToString();



            }
            dr.Close();


            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (KullaniciAdi.Text == kullanıcı && Sifre.Text == kullanıcısifre)
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
        }

        private void sifre_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {

                if (KullaniciAdi.Text == kullanıcı && Sifre.Text == kullanıcısifre)
                {
                    FrmYeniMüsteri yenimüsteri = new FrmYeniMüsteri();

                    yenimüsteri.Show();
                    this.Hide();

                }
            }   
        }

      
    }
}
