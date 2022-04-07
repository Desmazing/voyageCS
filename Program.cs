// baby steps with C#
using System;

namespace myproject
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hello, World!");
            string fname, lname;
            Console.WriteLine("Enter your first name: ");
            fname = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            lname = Console.ReadLine();
            Console.Write("Your full name is "+fname+" "+lname);

        }
    }
}

