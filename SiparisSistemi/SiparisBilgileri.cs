using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisSistemi
{
    public partial class SiparisBilgileri : Form
    {
        public SiparisBilgileri()
        {
            InitializeComponent();
        }

        private void SiparisBilgileri_Load(object sender, EventArgs e)
        {
            string[] siparisler = new string[] { };
            siparisler = File.ReadAllLines(Application.StartupPath + @"\siparisler");
            string[] siparisler2 = new string[] { };
            siparisler2 = File.ReadAllLines(Application.StartupPath + @"\siparisler2");
            for (int i = 0; i < siparisler.Length; i+=2)
            {
                listvTumSiparisler.Items.Add(new ListViewItem(new[] { siparisler[i] }));
            }

            int toplamgelir = 0;
            for (int i = 1; i < siparisler.Length; i += 2)
            {
              toplamgelir+=Convert.ToInt32(siparisler[i]);
            }

            lblCiro.Text = toplamgelir.ToString();
            lblToplamSiparisSayisi.Text = (siparisler.Length / 2).ToString();



            int toplamurun = 0;
            int toplamekstrageliri = 0;
            string[] lines = File.ReadAllLines(Application.StartupPath + @"\siparisler2");
            foreach (string line in lines)
            {
                string[] col = line.Split(new char[] { ',' });
               toplamurun +=Convert.ToInt32(col[0])+ Convert.ToInt32(col[2]);
            }
            lblSatilanUrunAdedi.Text = toplamurun.ToString();
            foreach (string line in lines)
            {
                string[] col = line.Split(new char[] { ',' });
                toplamekstrageliri += Convert.ToInt32(col[3]) ;
            }
            lblEkstraMalzemeGeliri.Text = toplamekstrageliri.ToString();

        }

        
    }
}
