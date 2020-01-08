using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisSistemi
{
  public  class Menu
    {
        public string MenuAdi { get; set; }
        public Boyut MenuBoyutu { get; set; }
        public string EkstraMalzemeAdi { get; set; }
        public int MenuFiyati { get; set; }
        public int EkstraMalzemeFiyati { get; set; }
        public int SiparisAdedi { get; set; }
       
    }
   public enum Boyut
    {
        Küçük,
        Orta,
        Büyük,
        Ekstra_Büyük

    }
}
