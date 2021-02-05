using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Renkli_Rüyalar_Pansiyonu
{
    public partial class FrmGazeteler : Form
    {
        public FrmGazeteler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.hurriyet.com.tr/");   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.sabah.com.tr/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.sozcu.com.tr/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.haberturk.com/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://onedio.com/");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.fanatik.com.tr/");
        }
    }
}
