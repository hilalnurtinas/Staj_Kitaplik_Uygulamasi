using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplikk
{
    abstract class Kart
    {
        private int id;
        private string sahip;
        private double bakiye;

        public int Id { get => id; set => id = value; }
        public string Sahip { get => sahip; set => sahip = value; }
        public double Bakiye { get => bakiye; set => bakiye = value; }



        public override string ToString()
        {
            return " Kart ID: " + id + " Sahip: " + sahip + " Bakiye: " + bakiye;
        }


        public abstract bool odemeYap(double miktar)
        {
            return true;    
        }



    }
}
