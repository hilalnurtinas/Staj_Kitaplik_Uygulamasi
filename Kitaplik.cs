using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplikk
{
    public class Kitaplik
    {
        private int rafSayisi;
        private Raf[] raflar;
        public Kitaplik[] kitaplik;


        public Kitaplik(int rafSayisi)
        {
            this.RafSayisi = rafSayisi;

            raflar = new Raf[rafSayisi];

            for (int i = 0; i < rafSayisi; i++)
            {
                raflar[i] = new Raf();
            }


        }
        public int RafSayisi { get => rafSayisi; set => rafSayisi = value; }

        public void kitapEkle(Kitap kitap, int rafNo)
        {
            if (rafNo >= 0 && rafNo < rafSayisi)
            {
                raflar[rafNo].kitapEkle(kitap);
            }
            else
            {
                Console.WriteLine("Raf numarası geçersiz!!!!!");
            }
        }

        public void kitapSilSiraNo(int rafNo, int siraNo)
        {
            if (rafNo >= 0 && rafNo < rafSayisi)
            {
                raflar[rafNo].kitapSilSiraNo(siraNo);
            }
            else
            {
                Console.WriteLine("Raf numarası geçersiz!!!!!");
            }
        }

        public void kitapSil(int rafNo, Kitap kitap)
        {
            if (rafNo >= 0 && rafNo < rafSayisi)
            {
                raflar[rafNo].kitapSil(kitap);
            }
            else
            {
                Console.WriteLine("Raf numarası geçersiz!!!!!");
            }
        }

        public int kitapAra(string kitapAdi)
        {
            for (int i = 0; i < rafSayisi; i++)
            {
                int siraNo = raflar[i].kitapAra(kitapAdi);
                if (siraNo != -1)
                {
                    return siraNo;
                }
            }
            return -1;
        }

        public void gosterRaf(int rafNo)
        {
            if (rafNo >= 0 && rafNo < rafSayisi)
            {
                raflar[rafNo].rafGoster();
            }
            else
            {
                Console.WriteLine("Raf numarası geçersiz!!!!!");
            }
        }

        public void tumRaflariGoster()
        {
            for (int i = 0; i < rafSayisi; i++)
            {
                Console.WriteLine($"Raf {i}:");
                raflar[i].rafGoster();
                Console.WriteLine();
            }
        }




    }
}
