using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisSistemi
{
    public partial class AnaForm : Form
    {
        

        public AnaForm()
        {
            InitializeComponent();
        }

        private void SiparişVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item is Sipariş_Oluştur)
                {
                    item.BringToFront();
                    return;
                }
            }
            Sipariş_Oluştur siparisolustur = new Sipariş_Oluştur();
            siparisolustur.MdiParent = this;
            siparisolustur.Show();
        }

        private void SİparişBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item is SiparisBilgileri)
                {
                    item.BringToFront();
                    return;
                }
            }
            SiparisBilgileri siparisbilgileri = new SiparisBilgileri();
            siparisbilgileri.MdiParent = this;
            siparisbilgileri.Show();
        }

        private void MenüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item is MenuEkle)
                {
                    item.BringToFront();
                    return;
                }
            }
            MenuEkle menuekle = new MenuEkle();
            menuekle.MdiParent = this;
            menuekle.Show();
        }

        private void EkstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item is EkstraMalzemeEkle)
                {
                    item.BringToFront();
                    return;
                }
            }
            EkstraMalzemeEkle esktramalzemeekle = new EkstraMalzemeEkle();
            esktramalzemeekle.MdiParent = this;
            esktramalzemeekle.Show();
        }

       
    }
}
