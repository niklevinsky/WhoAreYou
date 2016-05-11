using System;
using System.Text.RegularExpressions;

namespace WhoAreYou
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            
            Console.WriteLine("Enter First Name: ");
            person.FirstName = Console.ReadLine();
            while(!Utilities.IsValidName(person.FirstName))
            {
                Console.WriteLine("INVALID NAME! Enter First Name: ");
                person.FirstName = Console.ReadLine();
            }
            
            Console.WriteLine("Enter Last Name: ");
            person.LastName = Console.ReadLine();
            while(!Utilities.IsValidName(person.LastName))
            {
                Console.WriteLine("INVALID NAME! Enter Last Name: ");
                person.LastName = Console.ReadLine();
            }
            
            Console.WriteLine("Enter Age: ");
            string AgeInput = Console.ReadLine();
            while(!Utilities.IsValidAge(AgeInput))
            {
                Console.WriteLine("INVALID AGE! Enter Age: ");
                AgeInput = Console.ReadLine();
            }
            person.Age = int.Parse(AgeInput);

            Console.WriteLine("Hello " + person.FirstName + " " + person.LastName + " (" + person.Age + " years old)");
        }
    }
    
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    
    public class Utilities
    {
        public static bool IsValidName(string nameInput)
        {
            if (Regex.IsMatch(nameInput, @"^[a-zA-Z]+$") && !String.IsNullOrEmpty(nameInput))
                return true;
            else
                return false;
        }
        
        public static bool IsValidAge(string numberInput)
        {
            int FinalAge;
            int.TryParse(numberInput, out FinalAge);
            if (FinalAge > 0 && FinalAge < 150)
                return true;
            else
                return false;
                
        }
    }
    
}