using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using a for loop to loop and print numbers from 1 to 10

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            Console.Clear();

            //a program that asks you to enter a password and keeps asking until the user enters the correct
            string correctpassword = "noma123";
            Console.WriteLine("Please enter a password");
            string password = Console.ReadLine();

            while (correctpassword != password)

            {

                Console.WriteLine("Please enter the correct password");
                password = Console.ReadLine();//as for the password again in the loop otherwise the message will be displayed multiple times

            }
            Console.WriteLine("correct password");
            Console.ReadLine();
            Console.Clear();

            //ask a user to guess a number and keep asking them until they get it right
            int random = 90;
            int guessTheNumber;
            Console.WriteLine("Please Guess a number from 80 t0 90");
             

            do
            {
                Console.WriteLine("Your guess");
                guessTheNumber = int.Parse(Console.ReadLine());

                if (guessTheNumber != random)
                {
                    Console.WriteLine("Try again");
                }
            }
            while (guessTheNumber != random);
                
                    Console.WriteLine("you guessed the number right");
                Console.ReadLine();
            

        }
    }
}
