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
    public partial class MenuEkle : Form
    {
        public MenuEkle()
        {
            InitializeComponent();
        }

        private void BtnMenuKaydet_Click(object sender, EventArgs e)
        {
            Menu newMenu = new Menu();
            newMenu.MenuAdi = txtMenuAdi.Text;
            newMenu.MenuFiyati =Convert.ToInt32(txtMenuFiyat.Text);
            StreamWriter sw = File.AppendText(Application.StartupPath + @"\menu");
            sw.WriteLine(newMenu.MenuAdi);     
            sw.WriteLine(newMenu.MenuFiyati);           
            sw.Close();
           
            temizle();
            MessageBox.Show("Menü başarıyla eklendi.");
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
