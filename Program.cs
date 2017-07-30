using System;

namespace wk41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Console.WriteLine("Whats your first name name?");
            var firstName = Console.ReadLine();
            Console.WriteLine(firstName);
            Console.WriteLine("Whats your Last name name?");
            var lastName = Console.ReadLine();
            Console.WriteLine(lastName);
            
            //Start the program with Clear();
           
            
            
            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
            
        }
    }
}
