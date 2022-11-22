using System;

namespace KullanicidanAlinanSayilardanTekCiftBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen kaç sayı alınacağını giriniz");
            int secim = Convert.ToInt32(Console.ReadLine());
            int tek = 0;
            int cift = 0;
            for(int i=1; i<=secim; i++)

            {
                Console.WriteLine("Sayı giriniz");
                double num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                {
                    tek++;
                }
                else
                {
                    cift++;
                }
            }
            Console.WriteLine("Girilen tek sayı adedi: " + tek);
            Console.WriteLine("Girilen çift sayı adedi: " + cift);
        }
    }
}
