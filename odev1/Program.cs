namespace odev1
{
    internal class Program
    {
        static void Main(string[] args)
        { /*
            Random rnd = new Random();
            int number = rnd.Next(10);
            byte attempt = 5;
            byte point = 0;

            while (true)
            {
                Console.WriteLine("select level :");
                string level = Console.ReadLine();

               
               

                while (true)
                {
                  
                    if (level == "K")
                    {
                        Console.WriteLine("Guess the number");
                        int user = int.Parse(Console.ReadLine());
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
                    else if (level == "O")
                    {
                        point += 25;
                        Console.WriteLine("you knew :))");
                        Console.WriteLine("your point:" + point);
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
                        Console.WriteLine("your point:" + point);
                        break;
                    }
                    else
                    {
                        attempt -= 3;
                        Console.WriteLine("wrong number!!! Try again!!!");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                break;
            }
            Console.WriteLine("Game Over:(");
            Console.ReadLine();
            */
            /*
            int[] sayilar = new int[10];
            Random rastgele=new Random();
            int i = 0;
            while (i<10)
            {
                int sayi = rastgele.Next(0, 20);
                if (sayilar.Contains(sayi))
                    continue; 
                sayilar[i]=sayi;
                i++;
               
            } Array.Sort(sayilar);
            foreach (int sayi in sayilar) 
            {
                Console.WriteLine(sayi);
                Console.ReadKey();
            }*/
            int[] sayilar= new int[10];
             Random rnd = new Random();
            int tutulan;
             for (int i = 1; i < sayilar.Length; i++)
            {
                tutulan = rnd.Next(1,11);
                for (int j = 0; j < i; j++)
                {
                    if (sayilar[j]==tutulan)
                    {
                        i--;
                        break;
                    }
                    else
                    {
                        sayilar[i] = tutulan;
                    }
                }
            }  
               for (int i = 1;i < sayilar.Length;i++)
               {
                Console.WriteLine(sayilar[i]);
               }
                    

        }
    }
}
