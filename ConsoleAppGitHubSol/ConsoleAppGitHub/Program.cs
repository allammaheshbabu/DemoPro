using ConsoleAppGitHub;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b,c;
            Console.WriteLine("Enter a value :");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b value :");
            b = Convert.ToInt32(Console.ReadLine());
            ArthamaticOperations obj1= new ArthamaticOperations();
            c = obj1.Add(a, b);
            Console.WriteLine("The sum is "+c);
            c = obj1.Sub(a, b);
            Console.WriteLine("The sub is " + c);
            c = obj1.Mul(a, b);
            Console.WriteLine("The Mul is " + c);
            c = obj1.Div(a, b);
            Console.WriteLine("The Div is " + c);
            Console.WriteLine("program is complete");
            Console.ReadKey();
            
        
        }
    }
}
