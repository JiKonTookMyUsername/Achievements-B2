using System;
using System.IO;

namespace streamwriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[3]; // Array to hold the names 

            Console.WriteLine("Typ here your top 3 TV shows: ");

            for (int i = 0; i < 3; i++)
            {
                names[i] = Console.ReadLine();
                WriteToFile(names[i]);
            }
            

        }
        static void WriteToFile(string txt) {
            // Define our one and only variable
           

            // Write to text file

            StreamWriter writeToFile = new StreamWriter(@"top3.txt");

            
            writeToFile.WriteLine(txt);
            

            writeToFile.Close();


           

        }
    }
}
