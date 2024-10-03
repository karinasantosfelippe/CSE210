using System;
using Develop03;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Reference ref1 = new("Mateus",3,1);
        Console.WriteLine(ref1.DisplayReference());

        Reference ref2 = new("Tiago",1,[5,6,7,8]);
        Console.WriteLine(ref2.DisplayReference());
        
        Reference ref3 = new("Lucas",10,[7,9]);
        Console.WriteLine(ref3.DisplayReference());
    }
}