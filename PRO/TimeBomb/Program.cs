using System;

namespace TimeBomb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); 

            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine("Bomb goes off in {0}", i);
                System.Threading.Thread.Sleep(1000);
            }

            Console.WriteLine("BOOOOOOOM!");
            
        }
    }
}

