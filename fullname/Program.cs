using System;

namespace fullname
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("First Name: ");
            string a = Console.ReadLine();
            Console.WriteLine("Middle Name: ");
            string b = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            string c = Console.ReadLine();
            Console.WriteLine("Full Name = " +a + " " + b + " " + c);
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value of i = " + i);
        }
    }
}
