using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int digitCone = 0; //Declare and initialize digitCone
            int digitCtwo = 0; //Declare and initialize digitCtwo
            var oneDigits = new List<int>(); //Declare list oneDigits used to break down number one to digits
            var twoDigits = new List<int>(); //Declare list twoDigits used to break down number two to digits
            int numOne, numTwo; //Declare integers numOne and numTwo
            bool loop = false; //Declare boolean loop and set it to false

            Console.WriteLine("Please enter a number:"); //Prompt user to enter a number

            while (!int.TryParse(Console.ReadLine(), out numOne)) //Begin while loop which will run as long as user input is not set as an integer
            {
                Console.WriteLine("Please enter a number:"); //When user input is not an integer, prompt user again to enter an integer
            }
            while (numOne > 0) //Begin while loop to break number down to digits
            {
                oneDigits.Add(numOne % 10); //Adds last digit of number to list oneDigits
                numOne /= 10; //Removes last digit of number after it has been added to list oneDigits
                ++digitCone; //Increment digitCone counter
            }

            while (loop == false) //Begin while loop to prompt user for second input and validate it is the same length as first number
            {
                Console.WriteLine("Enter a number the same digits as the first number"); //jPrompt user to enter number two
                while (!int.TryParse(Console.ReadLine(), out numTwo)) //Begin while loop which will run as long as user input is not set as an integer
                {
                    Console.WriteLine("You did not enter a number, please try again: "); //When user input is not an integer, prompt user again to enter an integer
                }
                digitCtwo = 0; //Sets digitCtwo counter to zero
                while (numTwo > 0)  //Begin while loop to break number down to digits
                {
                    twoDigits.Add(numTwo % 10); //Adds last digit of number to list twoDigits
                    numTwo /= 10; //Removes last digit of number after ithas been added to list twoDigits
                    ++digitCtwo; //Increment digitCtwo counter
                }
                if (digitCone == digitCtwo) //If statement to validate both numbers are the same length
                {
                    loop = true; //Breaks while loop for second input if both numbers are the same length
                }
                else
                {
                    Console.WriteLine("Your number was not the same length as your first number"); //Prompts user to enter second number again since second number input was not same length as first number
                }
            }
            oneDigits.Reverse(); //Reverses first number list to put back in original order
            twoDigits.Reverse(); //Reverses second number list to put back in original order

            int count = 0; //declare int and set value to 0 

            int[] added = new int[digitCone]; //Declares array to input added values of number one and two digits

            while (count < digitCone) //Begin while loop to add digits from both numbers in corresponding lists
            {
                added[count] = (oneDigits[count] + twoDigits[count]); //Adds digits and stores in added array
                count++; //Incrament count
            }

            bool nomatch = false; //Declare boolean nomatch and set it to false
            for (int i = 0; i < digitCtwo; i++) //Begin for loop to run based on number of digits from digitCtwo counter
            {
                if (added[i] != added[0]) //If statement checking if the digits do not match
                {
                    nomatch = true; //If any digit does not match sets boolean to true
                    break; //Breaks loop
                }
            }
            if (nomatch) //If statement to run depending on digits matching
            {
                Console.WriteLine("All numbers do not match."); //Promps if the digits did not all match and loop for loop was broken early
            }
            else
            {
                Console.WriteLine("All numbers match."); //Output indicating all digits matches
            }
            Console.WriteLine("Push any key to end program"); //Prompt user to enter a key to end program.
            Console.ReadLine(); //User input to end
        }
    }
}