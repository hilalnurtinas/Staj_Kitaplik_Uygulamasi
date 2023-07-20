using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplikk
{
    public class Kitap
    {
        private string ad;
        private string yazar;
        private string isbn;
        private double fiyat;

        public Kitap(string ad, string yazar, string isbn, double fiyat)
        {
            this.Ad = ad;
            this.Yazar = yazar; 
            this.Isbn = isbn;   
            this.Fiyat = fiyat;
            
        }

        public string Ad { get => ad; set => ad = value; }
        public string Yazar { get => yazar; set => yazar = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public double Fiyat { get => fiyat; set => fiyat = value; }


        public override string ToString()
        {
            return "Ad: " + ad + " Yazar: " + yazar +  " ISBN: " + isbn + " Fiyat: "+ fiyat;
        }
    }
}
