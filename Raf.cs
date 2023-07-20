using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplikk
{
    public class Raf
    {

        private Kitap[] kitaplar;

        public Raf()
        {
            kitaplar = new Kitap[100];
        }

        public void kitapEkle(Kitap kitap)
        {
            for (int i = 0; i < kitaplar.Length; i++)
            {
                if (kitaplar[i] == null)
                {
                    kitaplar[i] = kitap;
                    break;
                }
            }
        }

        public void kitapSilSiraNo(int siraNo)
        {
            if (siraNo >= 0 && siraNo < kitaplar.Length)
            {
                kitaplar[siraNo] = null;
            }
            else
            {
                Console.WriteLine("Sıra numarası geçersiz!!!!!");
            }
        }

        public void kitapSil(Kitap kitap)
        {
            for (int i = 0; i < kitaplar.Length; i++)
            {
                if (kitaplar[i] == kitap)
                {
                    kitaplar[i] = null;
                    break;
                }
            }
        }

        public void rafGoster()
        {
            for (int i = 0; i < kitaplar.Length; i++)
            {
                if (kitaplar[i] != null)
                {
                    Console.WriteLine($"{i}: {kitaplar[i]}");
                }
            }
        }

        public Kitap[] getKitaplar()
        {
            return kitaplar;
        }


    }
}
