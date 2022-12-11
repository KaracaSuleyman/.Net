using System;

namespace ders06_12_2022_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(101);
            int input;
            int count = 0;
            do
            {
                Console.WriteLine("Lutfen 0 ile 100 arasında bir sayı giriniz");
                 input = Convert.ToInt32(Console.ReadLine());
                if (input < sayi)
                {
                    Console.WriteLine("Daha büyük bir sayı gir!!");
                    count++;
                }
                else if (input > sayi)
                {
                    Console.WriteLine("Daha küçük bir sayı gir");
                    count++;
                }
                else
                    count++;

            } while (sayi != input);
            Console.WriteLine("tebrikler!! Girdiğiniz sayı: " + input + " tahmin etmek istenilen sayı: " + sayi+ " "+ count+". denemede buldunuz");

            /*
             * random sınıfı içerisinden, Next metodu kullanılarak rastgele sayı oluşturulur.
             * Next() ile int türünden herhangibir sayı üretilir
             * Next(10,100) 10 dahil 100 dahil değil arasında sayı üretir.
             */

            int num = 0;
            int toplam = 0;


            do {
                toplam += num;
                num++;
            } while (num<=100);
            Console.WriteLine(toplam);

        }
    }
}
