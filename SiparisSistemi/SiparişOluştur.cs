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
    public partial class Sipariş_Oluştur : Form
    {
        public Sipariş_Oluştur()
        {
            InitializeComponent();
        }
       
        private void Button1_Click(object sender, EventArgs e)
        {
            Menu newSiparis = new Menu();
            newSiparis.MenuAdi = cmbMenusec.SelectedItem.ToString();
            newSiparis.MenuBoyutu = (Boyut)cmbBoyutSec.SelectedItem;
            newSiparis.EkstraMalzemeAdi = cmbEkstraSec.SelectedItem.ToString();
            newSiparis.SiparisAdedi = (int)numericSiparisAdet.Value;

            StreamWriter sw = File.AppendText(Application.StartupPath + @"\siparisler");
            sw.WriteLine(lblSiparisBilgi.Text);
            sw.WriteLine(lblToplamTutar.Text);
            sw.Close();
            StreamWriter sw2 = File.AppendText(Application.StartupPath + @"\siparisler2");
            sw2.WriteLine(numericSiparisAdet.Value.ToString() + "," + cmbMenusec.SelectedItem.ToString() + "," +ekstraadet.ToString() + "," + ekstrafiyat.ToString() + "," + lblToplamTutar.Text);
            sw2.Close();

            DialogResult dialogResult = MessageBox.Show("Siparişi tamamlamak istediğinizden emin misiniz", "Sipariş Tamamla", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                lblSiparisBilgi.Text = "";
                lblToplamTutar.Text = "";
                for (int i = listvEkstraMalzeme.Items.Count - 1; i >= 0; i--)
                {       
                        listvEkstraMalzeme.Items[i].Remove();     
                }
                cmbMenusec.Text = "";
                cmbEkstraSec.Text = "";
                cmbBoyutSec.Text = "";
                numericSiparisAdet.Value = 0;
                ekstrafiyat = 0;
                ekstraadet = 0;
            }
           
        }

        private void Sipariş_Oluştur_Load(object sender, EventArgs e)
        {
           
            string[] menuler = new string[] { };
            menuler = File.ReadAllLines(Application.StartupPath + @"\menu");
            for (int i = 0; i < menuler.Length; i+=2)
            {
                cmbMenusec.Items.Add(menuler[i]);
                cmbMenusec.SelectedItem = menuler[0];
            }

            cmbBoyutSec.DataSource = Enum.GetValues(typeof(Boyut));

            string[] ekstraMalzemeler = new string[] { };
            ekstraMalzemeler = File.ReadAllLines(Application.StartupPath + @"\ekstramalzeme");
            for (int i = 0; i < ekstraMalzemeler.Length; i += 2)
            {
                cmbEkstraSec.Items.Add(ekstraMalzemeler[i]);              
                            
            }
          
        }

        public  int ekstrafiyat = 0;
        public int ekstraadet=0;
        private void CmbEkstraSec_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string[] ekstraMalzemeler = new string[] { };
            ekstraMalzemeler = File.ReadAllLines(Application.StartupPath + @"\ekstramalzeme");

            listvEkstraMalzeme.Items.Add(new ListViewItem(new[] { cmbEkstraSec.SelectedItem.ToString() }));
           
           ekstrafiyat += Convert.ToInt32(ekstraMalzemeler[cmbEkstraSec.SelectedIndex*2 + 1]);
           
            ekstraadet++;
        }

        private void ListvEkstraMalzeme_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem eachItem in listvEkstraMalzeme.SelectedItems)
            {
                listvEkstraMalzeme.Items.Remove(eachItem);
            }
        }

        int menuToplam;
        public int menuadet;
        private void NumericSiparisAdet_ValueChanged(object sender, EventArgs e)
        {
            int menufiyat;
            string[] menuler = new string[] { };
            menuler = File.ReadAllLines(Application.StartupPath + @"\menu");
            
           menufiyat = Convert.ToInt32(menuler[cmbMenusec.SelectedIndex*2 + 1]);
             
            menuToplam = menufiyat * (int)numericSiparisAdet.Value;
            menuadet =(int) numericSiparisAdet.Value;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string[] ekstraMalzemeler = new string[listvEkstraMalzeme.Items.Count] ;
            for (int i = 0; i <listvEkstraMalzeme.Items.Count ; i++)
            {
                ekstraMalzemeler[i] = listvEkstraMalzeme.Items[i].Text.ToString();
            }
            int ToplamTutar = menuToplam + ekstrafiyat+boyutFiyat;
            lblToplamTutar.Text = ToplamTutar.ToString();
            lblSiparisBilgi.Text = (int)numericSiparisAdet.Value + " tane " + cmbBoyutSec.SelectedItem.ToString() + " boy " + cmbMenusec.SelectedItem.ToString() + " menü siparişini "+string.Join("-",ekstraMalzemeler)  + " ekstra malzemeleri ile sipariş verdiniz";
        }

        int boyutFiyat;
        private void CmbBoyutSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoyutSec.SelectedIndex==0)
            {
                boyutFiyat = 0;
            }
            else if (cmbBoyutSec.SelectedIndex == 1)
            {
                boyutFiyat = 2;
            }
            else if (cmbBoyutSec.SelectedIndex == 2)
            {
                boyutFiyat = 4;
            }
            else if (cmbBoyutSec.SelectedIndex == 3)
            {
                boyutFiyat = 6;
            }
        }

        private void ListvEkstraMalzeme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
