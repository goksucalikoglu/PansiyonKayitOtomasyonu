using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Renkli_Rüyalar_Pansiyonu
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fr = new FrmAdminGiris();
            fr.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYeniMüsteri fr = new FrmYeniMüsteri();
            fr.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMüsteriler fr = new FrmMüsteriler();
            fr.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmGelirGider fr = new FrmGelirGider();
            fr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmStoklar fr = new FrmStoklar();
            fr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmRadyoDinle fr = new FrmRadyoDinle();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmOdalar fr = new FrmOdalar();
            fr.Show();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Renkli Rüyalar Pansiyonu Kayıt Uygulaması /2020-Elazığ");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmGazeteler fr = new FrmGazeteler();
            fr.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmSifreGuncellecs fr = new FrmSifreGuncellecs();
            fr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmMesajlar fr = new FrmMesajlar();
            fr.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }
    }
}
