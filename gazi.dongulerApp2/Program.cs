namespace gazi.dongulerApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //{                                          // row : satır demektir.
            //    for (int i = 0; i < 5; i++)            // column : sütun demektir.
            //    {
            //        for (int j = 0; j <5 ; i++)
            //        {
            //            Console.Write((i+j)%2==0 ? "*":" ");
            //        }
            //    }
            //    Console.WriteLine();
            //Console.WriteLine("enter row count:");
            //int row = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter column count:");
            //int column = int.Parse(Console.ReadLine());
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; i++)
            //    {
            //        Console.Write((i + j) % 2 == 0 ? "*" : " ");
            //    }


            //}
            //Console.WriteLine();

            //abcd=4*dcba
            // abcd
            /* 
           for (int a =0 ; a < 9 ; a++) 
           {
            for(int b =0 ; b < 9 ; b++)
               {
                   for (int c = 0; c < 9; c++)
                   {
                       for (int d = 0; d <9; d++)
                       {
                          if (1000*a+100*b+10*c+d==4*(1000*d+100*c+10*b+a)

                               Console.WriteLine($"{a}{b}{d}{c}");
                               break;

                           }

                       }

                   }                
               }*/

            // hipotenüs uzunlunluğu 100 birime kadar olan dik üçenleri yazdırınız.

            //for (int a = 1; a < 100; a++) 
            //{ 
            //  for(int b = 1; b < 100; b++)
            //    {
            //        for (int c = 1; c < 100; c++)
            //        {
            //            if (a * a == b * b + c * c)

            //                Console.WriteLine($"{a} {b} {c}");

            //            // başlangıç değeri giriniz:3
            //            // bitiş değeri giriniz:15
            //            //5-7-11-13
            //        }

            /* Console.WriteLine("enter starting number");                                  // üst kısma bool sonuc:false diye değer ata
             int starting_number = int.Parse(Console.ReadLine());                          //    her döngüden çıkmka için for un altına if ve brak koy .
             Console.WriteLine("enter end number");
             int end_number = int.Parse(Console.ReadLine());


             for (int i = starting_number; i < end_number; i++)
             {
                 int count = 0;

                 for (int j = 2; j <= (i / 2); i++)
                 {
                     if (i % j == 0)
                     {
                         Console.WriteLine("sayı asaldır");
                         count++;

                     }

                 }
                         Console.WriteLine(count > 0 ? $"{i}-is not prime":$"{i}-prime");

                     } 


                 }

                 } */
            //int count = 0;
            //    while (count<5)
            //{                                       // parantezlerin içi true olduğu sürece döner 
            //    Console.WriteLine("Gazi");          // her true  değerinde döner.
            //    count++;
            //}



            //int toplam = 0;
            //while (true)
            //{

            //    Console.WriteLine("bir sayı giriniz.");
            //    int sayi = int.Parse(Console.ReadLine());
            //    toplam+= sayi;

            //    Console.WriteLine("devam etmek istiyor musunuz?");
            //    string cvp = Console.ReadLine();
            //    if (cvp == "H")
            //        break;
            //}
            //Console.WriteLine(toplam);

            //do                                           // true olsa da olmasa da bir kere mutlaka yazacak
            //{                                            // True ise zaten sonsuz döngü
            //    Console.WriteLine("Gazi");

            //} while (true);

            //kullanıcı ne girene kadar döngü dönsün

            //int toplam = 0;
            //string cvp;                                      
            //do
            //{
            //    Console.WriteLine("Bir sayı giriniz");                                  // zaten içinde if olduğu için if olmazsa olur.
            //    int sayi=int.Parse(Console.ReadLine());
            //    toplam += sayi;
            //    Console.WriteLine("Devam etmek istiyor musunuz?");           //ASCII TABLE kod tablosu yetersiz bir tablo UNİCODE TABLE ile değişti .
            //     cvp= Console.ReadLine();

            //} while (cvp=="E");
            //Console.WriteLine(toplam);

            //for (int i = 0; i < 10; i++)       // 10 haneli karışık rastgele karakter atıyor. write sayesinde yan yana atıyor.
            //{
            //    Random rnd = new Random();
            //    int number = rnd.Next(127);
            //    Console.Write((char)number);
            //}

            // BİLGİSAYARA SAYI TUTTURUP BİLMEYE ÇALIŞIYORUZ

            //Random rnd = new Random();
            //int number = rnd.Next(10);
            //byte attempt = 3;


            //while (true)
            //{
            //    Console.WriteLine("Guess the number:");
            //    int user = int.Parse(Console.ReadLine());
            //    if (user == number)
            //    {
            //        Console.WriteLine("you won!!");
            //        break;
            //    }
            //    else
            //    {
            //        attempt--;
            //        Console.WriteLine("Wrong number! Try again! ");
            //        Console.ReadKey();                      // READKEY YAZILI OLANI SİLMEDEN  ÖNCE GÖSTERİYOR.
            //        Console.Clear();
            //    }
            //    if (attempt == 0)
            //    {                                             // 3 tane hak tanıdık.
            //        Console.WriteLine("you lost!");
            //        break;                                          // kolay orta zor için seviye geliştirme
            //    }                                                   // puanlama yap seviyeye göre azalma yapsın her  seviyede puan alma zorlaşacak
            //}                                                       // bilemedikçe azalacak 



            Random rnd = new Random();
            int number=rnd.Next(0,10);
            byte attempt = 5;
            byte point = 0;

            while (true)
            {
                Console.WriteLine("select level :");
                string level = Console.ReadLine();
                 
               
                while (true)
                {
                    Console.WriteLine("Guess the number");
                    int user=int.Parse(Console.ReadLine());

                    if (level == "K")
                    {
                        if (user == number)
                        {
                            point += 20;
                            Console.WriteLine("you knew :D");
                            Console.WriteLine("your poit:" + point);
                            Console.ReadLine();
                            break;
                        } 
                        else
                        {
                            attempt--;
                            Console.WriteLine("Wrong number!Try again!");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    if (level =="O")
                    {
                        point += 25;
                        Console.WriteLine("you knew :))");
                        Console.WriteLine("your point:"+point);
                        break;
                    }
                    else
                    {
                        attempt -= 2;
                        Console.WriteLine("wrong number!! Try again!!");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    if (level == "Z")
                    {
                        point += 35;
                        Console.WriteLine("you knew");
                        Console.WriteLine("your point:"+point);
                        break;
                    }
                    else
                    {
                        attempt-=3;
                        Console.WriteLine("wrong number!!! Try again!!!");
                        Console.ReadKey ();
                        Console.Clear();
                    }
                }    break;
            }
            Console.WriteLine("Game Over:(");
            Console.ReadLine();









        }

    }



}

















