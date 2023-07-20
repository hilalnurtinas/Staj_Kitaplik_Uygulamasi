using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplikk
{
    public class YetiskinKarti
    {
        private Kart[] kartlar;
        private string sahip;
        private int id;
        private double bakiye;

        public YetiskinKarti(int id, string sahip, double bakiye)
        {
            this.Id = id;
            this.Sahip = sahip;
            this.Bakiye = bakiye;

        }

        public string Sahip { get => sahip; set => sahip = value; }
        public int Id { get => id; set => id = value; }
        public double Bakiye { get => bakiye; set => bakiye = value; }
        internal Kart[] Kartlar { get => kartlar; set => kartlar = value; }

        public override bool odemeYap(double miktar)
        {
            if (Bakiye >= miktar)
            {
                Bakiye -= miktar;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
