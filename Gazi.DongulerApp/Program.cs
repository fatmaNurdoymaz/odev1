namespace Gazi.DongulerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             matrixlerde önce sütun sonra satır.
            \t bit tap boşluk demek
            
             */
            /*
            for (int i = 0; i <3; i++)
            {
             for(int j = 0; j < ;4 j++)
                {
                    Console.Write($"{i},{j} \t");
                }
            }
            Console.WriteLine(  );
            */                                          
            /*                                            
             for (int i = 1;i <= 5;i++)                     
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
            
            }
             Console.WriteLine(); */

            for (int i = 0; i <5 ; i++)
            { 
                for (int j = 0; j < i++ ; j++)
                {
                    Console.Write("*");
                }

            }
            Console.WriteLine( );






        }
    }
}
