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

namespace WindowsFormsApp1
{
    public partial class FrmSifreGuncellecs : Form
    {
        public FrmSifreGuncellecs()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = LENOVO\\SQLEXPRESS; Initial Catalog = RenkliRuyalarPansiyonu; Integrated Security = True");
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update AdminGiris set Kullanici='" + TxtKullaniciAdi.Text + "',Sifre='" + TxtSifre.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }


       
    }
}
