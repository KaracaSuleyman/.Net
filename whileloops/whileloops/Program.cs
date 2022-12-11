using System;

namespace whileloops
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5 kere adımzı soyadımızı 3 er saniye arayla yazdıralım yazdıralım..
            /*  int i = 0;
              while (i < 5)
              {
                  i++;
                  Console.WriteLine(i+". Suleyman Karaca");
                  System.Threading.Thread.Sleep(3000);    // ====> işlemin kaç saniyede olacağını belirler 

            // klavyeden sıfır girilene kadar çift sayıları topla tek sayıları çıkar ve sonucu ekrana getiren programı yazınız
             int topla = 0;
             int sayi=1;
            int count = 0;
            while (sayi != 0)
            {
                Console.WriteLine("Lütfen sayı giriniz");
                sayi = Convert.ToInt32(Console.ReadLine());
               


                if(sayi  == 0) break;
             
                else if(sayi %2 ==0)
                {
                    topla += sayi;
                    Console.WriteLine("sayı toplamı: " + topla);
                    count++;


                }
                else
                {
                    topla -= sayi;
                    Console.WriteLine("sayı toplamı: "+topla);
                    count++;
                }
                
            }
            Console.WriteLine("girilen sayı adedi: " + count + "\ngirilen sayıların toplamı: " + topla);
            */



            // kullanıcının girdiği sayının faktöriyelini bul
            Console.WriteLine("Lütfen faktöriyelini hesaplamak istediğiniz sayıyı giriniz");
            int sayı = Convert.ToInt32(Console.ReadLine());
            
            int faktöriyel = 1;
            while (sayı != 0)
            {
                Console.Write(sayı+".");
                faktöriyel = faktöriyel*sayı;
                sayı--;
                
                
                
            }

            Console.WriteLine("!= "+faktöriyel);
        }
    }
}
  

