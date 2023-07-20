using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplikk
{
    public class KitaplikYonetim
    {
        private Kitaplik kitaplik;

        public KitaplikYonetim(Kitaplik kitaplik)
        {
            this.Kitaplik = kitaplik;
        }

        public Kitaplik Kitaplik { get => kitaplik; set => kitaplik = value; }


        public bool kitapSat(Kitap kitap, Kart kart)
        {
            if (kitaplik.kitapAra(kitap.Ad) != -1)
            {
                if (kart.odemeYap(kitap.Fiyat))
                {
                    kitaplik.kitapSil(kitap);
                    return true;
                }
            }
            return false;
        }
    }
}
