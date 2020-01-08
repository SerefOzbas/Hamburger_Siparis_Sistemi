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
    public partial class EkstraMalzemeEkle : Form
    {
        public EkstraMalzemeEkle()
        {
            InitializeComponent();
        }

        private void BtnEkstraMalzemeKaydet_Click(object sender, EventArgs e)
        {
            Menu newEkstraMalzeme = new Menu();
            newEkstraMalzeme.EkstraMalzemeAdi = txtEkstaraMalzemeAdi.Text;
            newEkstraMalzeme.EkstraMalzemeFiyati = Convert.ToInt32(txtEkstraMalzemeEkleFiyat.Text);

            StreamWriter sw = File.AppendText(Application.StartupPath + @"\ekstramalzeme");
            sw.WriteLine(newEkstraMalzeme.EkstraMalzemeAdi);          
            sw.WriteLine(newEkstraMalzeme.EkstraMalzemeFiyati);
            sw.Close();      
            temizle();
            MessageBox.Show("Ekstra malzeme başarıyla eklendi.");
        }

        public void temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
                else if (item is ComboBox)
                {
                    item.Text = string.Empty;
                }
                else if (item is NumericUpDown)
                {
                    item.Text = string.Empty;
                }
            }
        }
    }
}
