using System;

namespace what_am_i
{
    class Program
    {
        static void Main(string[] args)
        {
            Characters luigi = new Characters("Luigi!"); 
            Characters mario = new Characters("Mario!");
            Characters wario = new Characters("Wario!");
            Characters peach = new Characters("Peach!");
        }
    }
}

public class Characters 
{
    public Characters(string name)
    {
        Console.WriteLine(name); 
    }
}

