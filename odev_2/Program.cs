namespace odev_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];
            Random rnd = new Random();
            int tutulan;
            for (int i = 1; i < sayilar.Length; i++)
            {
                tutulan = rnd.Next(1, 11);
                for (int j = 0; j < i; j++)
                {
                    if (sayilar[j] == tutulan)
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
            for (int i = 1; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

        }
    }
}
