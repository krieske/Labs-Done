using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateOne, dateTwo; //Declare both DateTime variables for user input.
            Console.WriteLine("Please enter a date (MM/dd/yyyy):"); //Prompt user to enter a date.
            while (!DateTime.TryParse(Console.ReadLine(), out dateOne)) //Execute while loop to cycle as long as user input is not DateTime variable.
            {
                Console.WriteLine("You did not enter a valid date try again"); //Response when user input is not DateTime variable.
            }
            Console.WriteLine("Please enter a second date (MM/dd/yyyy):"); //Prompt user to enter a second date.
            while (!DateTime.TryParse(Console.ReadLine(), out dateTwo)) //Execute while loop to cycle as long as second user input is not DateTime variable.
            {
                Console.WriteLine("You did not enter a valid date try again"); //Response when user input is not DateTime variable.
            }

            String days = (dateTwo - dateOne).TotalDays.ToString(); //Declare and initialize string that subtracts the second date from the first and saves the value in days to the string.
            String hours = (dateTwo - dateOne).TotalHours.ToString(); //Declare and initialize that subtracts the second date from the first and saves the value in hours to the string.
            String minutes = (dateTwo - dateOne).TotalMinutes.ToString(); //Declare and initialize that subtracts the second date from the first and saves the value in minutes to the string.
            Console.WriteLine("The difference between the two dates is " + days + " days."); //Output difference between both dates in days.
            Console.WriteLine("The difference between the two dates is " + hours + " hours."); //Output difference between both dates in hours.
            Console.WriteLine("The difference between the two dates is " + minutes + " minutes."); //Output difference between both dates in minutes.
            Console.WriteLine("Push any key to exit."); //Prompt user for input to terminate program.
            Console.ReadLine(); //User input to terminate.
        }
    }
}
