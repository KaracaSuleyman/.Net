using System;

namespace swichkeys
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * kullanıcıdan iki sayı alın
             * 1 e bastığında toplama
             * 2 e bastığında çıkarma
             * 3 e bastığında çarpma
             * 4 e bastığında bölme 
             */
            Console.WriteLine("Hangi hesaplamayı yapacağınızı ilk sayıyı giriniz");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hangi hesaplamayı yapacağınızı ikinci sayıyı giriniz");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hangi hesaplamayı yapacağınızı seçiniz \n 1: toplama \n 2: çıkarma \n 3:çarpma \n 4:bölme");
            int islem = Convert.ToInt32(Console.ReadLine());
            switch (islem)
            {
                case 1:
                    double toplam = (num1 + num2);
                    Console.WriteLine("Toplama işleminin sonucu " + toplam);
                    break;
                case 2:
                    double cikarma = (num1 - num2);
                    Console.WriteLine("Çıkarma işleminin sonucu " + cikarma);
                    break;
                case 3:
                    double carpma = (num1 * num2);
                    Console.WriteLine("Çarpma işleminin sonucu " + carpma);
                    break;
                case 4:
                    double bolme = (num1 / num2);
                    Console.WriteLine("Bölme işleminin sonucu " + bolme);
                    break;
                default:
                    Console.WriteLine("Seçim hatası");
                    break;


            }

        }
    }
}