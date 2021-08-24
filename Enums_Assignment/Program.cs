using System;

namespace Enums_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type what day it is today:\n");
            var userInput = Console.ReadLine();
            try
            {
                //Converting the string to the enum type
                var currentDay = Enum.Parse(typeof(Days_Of_The_Week), userInput);
                Console.WriteLine($"\n\nToday is {currentDay}");
            }

            catch (System.ArgumentException ex)
            {
                Console.WriteLine("\n\nPlease type a day of the week");
            }
            finally
            {
                Console.WriteLine("\n\nThank you for using my programme");
            }
        }
    }
}
            
               
                


