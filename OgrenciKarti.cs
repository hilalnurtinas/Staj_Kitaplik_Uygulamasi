using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplikk
{
    public class OgrenciKarti
    {
        private double bonus;
        private string sahip;
        private int id;
        private double bakiye;
        private Kart[] kartlar;

        public OgrenciKarti(int id, string sahip, double bakiye )
        {
            this.Id = id;
            this.Sahip = sahip;
            this.Bakiye = bakiye;

            this.Bonus = 0;

        }
        public double Bonus { get => bonus; set => bonus = value; }
        public string Sahip { get => sahip; set => sahip = value; }
        public double Bakiye { get => bakiye; set => bakiye = value; }
        public int Id { get => id; set => id = value; }
        internal Kart[] Kartlar { get => kartlar; set => kartlar = value; }

        public override bool odemeYap(double miktar)
        {
            double totalMiktar = miktar;
            
            if (bonus >= miktar)
            {
                bonus -= miktar;
            }
            else
            {
                totalMiktar -= bonus;
                bonus = 0;
                if (Bakiye >= totalMiktar)
                {
                    Bakiye -= totalMiktar;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }



    }
}
