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
            c = a + b;
            Console.WriteLine("The sum is "+c);
            Console.WriteLine("program is complete");
            Console.ReadKey();
            
        
        }
    }
}
