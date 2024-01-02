namespace odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                    if (level == "O")
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

        }
    }
}
