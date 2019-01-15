using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifMetodlari
{
    class Magaza
    {
        public int MagazaID { get; set; }
        public string  MagazaAdi { get; set; }
        public ArrayList Kitaplar { get; set; } = new ArrayList();
        public Adres Adres { get; set; }

        public void MagazaKitaplariYazdir()
        {
            KitapIslemer kislemler = new KitapIslemer();
            foreach (var item in Kitaplar)
            {  
                kislemler.EkranaYaz((Kitap)item);
            }
        }
    }

    
}
