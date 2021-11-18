using System;

namespace Array8
{
    class Program
    {
        static void Main(string[] args)
        {
            // isim giriniz...
            // hangi günler müsaitsiniz...
            // müsaitlik saatlerinizi belirtiniz...
            string[] gunler = new string[1];
            string[] adlar = new string[1];
            char durum;
            char statu;

            do
            {

         


                // isim giriniz...
                Console.WriteLine("Ad-Soyadınızı giriniz");
                string ad = Console.ReadLine();

                if (Array.IndexOf(adlar, ad) == -1)
                    adlar[adlar.Length - 1] = ad;
                else
                    Console.WriteLine("Daha önce eklediniz...");

                Console.WriteLine("*****************************************************************");


                do
                {
                    Console.WriteLine("Gün giriniz");
                    string gun = Console.ReadLine();

                    if (Array.IndexOf(gunler, gun) == -1)
                        gunler[gunler.Length - 1] = gun;
                    else
                        Console.WriteLine("Daha önce eklediniz...");

                    Console.WriteLine("Başka gün girmek istermisiniz?? e/h");
                    durum = Convert.ToChar(Console.ReadLine());

                    if (durum == 'e')
                        Array.Resize(ref gunler, gunler.Length + 1);

                } while (durum == 'e');


                Console.WriteLine("Yeni Bir kullanıcı eklemek ister misiniz?? e/h");
                statu = Convert.ToChar(Console.ReadLine());

                if (statu == 'e')
                    Array.Resize(ref adlar, adlar.Length + 1);


            } while (statu == 'e');

            Console.WriteLine("*****************************************************************");
            // hangi günler müsaitsiniz...

            string[] musaitGunler = new string[gunler.Length];
            string[] musaitDegilGunler = new string[gunler.Length];

            for (int i = 0; i < gunler.Length; i++)
            {

                Console.WriteLine($"Girilen {gunler[i]} Günde Müsait misiniz??? e/h");
                char cevapMusait = Convert.ToChar(Console.ReadLine());

                if (cevapMusait == 'e')
                {
                    musaitGunler[i] = gunler[i];
                }

                else
                {
                    musaitDegilGunler[i] = gunler[i];

                }


            }

            Console.WriteLine("Müsait olunan günler");
            Console.WriteLine("*****************************************************************");
            foreach (var item1 in adlar)
            {
                        
                foreach (var item in musaitGunler)
                {
                    if (item is not null)
                        Console.WriteLine($"{item1} kullanıcının müsait olan gün {item}");
                }
          
                Console.WriteLine("*****************************************************************");
                Console.WriteLine("Müsait olunmayan günler");

                foreach (var item in musaitDegilGunler)
                    {
                    if(item is not null)
                        Console.WriteLine($"{item1} kullanıcının müsait olmayan gün {item}");
                    }
 
                Console.WriteLine("*****************************************************************");
            }
            Console.WriteLine("Sizin için gün seçmemi istermisiniz??? e/h");
            char cevap = Convert.ToChar(Console.ReadLine());
            if (cevap == 'e')
            {
                Random rnd = new Random(); // Random sınıf rasgele sayı üretmek için kulanılan sınıftır..
                //rnd.Next(); 2 milyara kadar sayı üretir...
                int sansliIndex = rnd.Next(gunler.Length - 1);
                Console.WriteLine($"Dersi yapacağımız gün = {gunler[sansliIndex]}");
            }

            Console.ReadKey();
        }
    }
    }
