using System;

namespace KullanicidanIstidigiKadarSayiAlipToplama
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * kullanıcının belirlediği kadar sayıyı yine kullanıcıdan alarak toplayan program

             */
            Console.WriteLine("Lütfen kaç sayı toplamak istediğinizi giriniz");
            int kacKere = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            for (int i = 1; i <= kacKere; i++)
            {

                Console.WriteLine("Lütfen sayı giriniz");
                int num = Convert.ToInt32(Console.ReadLine());
                toplam += num;
            }
            Console.WriteLine(toplam);
        }
    }
}