using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte x = 12;
            int y = 5;
            float z = 6.5f;
            double t = 11.75d;
            decimal k = 125.56m;
            char metin = 'E';
            string ad = "Serap Çelik";
            bool cevap = false;

            Console.WriteLine("hello word");
            Console.WriteLine(x);
            Console.WriteLine("X den gelen değer:"+x);
            Console.WriteLine("y den gelen değer:{0}", y);
            Console.WriteLine("Birinci sayı:{0} İkinci Sayı:{1} ",z,t);
            Console.WriteLine("birinci sayi:"+z+"ikinci sayi:"+t);
            Console.WriteLine("{0} {1} {2}",x,y,z);

            //Console.WriteLine("Adınız Nedir?");
            //string isim = Console.ReadLine();
            //Console.WriteLine("girilen isim:" + isim);


            ////tür dönüşümüm Convert.ToInt32()
            ////string a="12"; Convert.ToInt32(a)
            //Console.WriteLine("birinci sayıyı giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("ikinci sayıyı giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(sayi1 + sayi2);

            ////toplama +, çıkarma -, çarpma *, bölme /, ++,--
            //int sayi3 = 21;
            //int sayi4 = 5;
            //float sonuc;

            //sonuc = sayi3 / sayi4;
            //sonuc = Convert.ToSingle(sayi3) / Convert.ToSingle(sayi4);

            //Console.WriteLine(sonuc);
            //sonuc = Convert.ToSingle(sayi3 / sayi4);
            //Console.WriteLine(sonuc);

            Console.WriteLine("sayı giriniz");
            double sayi=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("yüzde oranı giriniz");
            byte yuzde=Convert.ToByte(Console.ReadLine());

            double sonuc = sayi + (sayi * yuzde / 100);
            Console.WriteLine(sonuc);
            decimal sonuc2 =Convert.ToDecimal(sayi + (sayi * yuzde / 100));
            decimal sonuc3 = (decimal)(sayi + sayi * yuzde / 100);
            int sonuc4 = (int)(sayi + sayi * yuzde / 100);
                     







            Console.ReadLine();
        }
    }
}
