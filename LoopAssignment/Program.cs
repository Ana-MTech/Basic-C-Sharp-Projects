using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you old enough to get driving license? Please enter your age. ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool Guessed = number >= 18;

            do
            {
                switch (number)
                {
           
                case 18:
                    Console.WriteLine("You are old enough to get driving license.");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                case 12:
                    Console.WriteLine("You are not old enough to get driving license.");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                case 19:
                    Console.WriteLine("You are old enough to get driving license.");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                case 17:
                    Console.WriteLine("You are not old enough to get driving license.");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("You are old enough to get driving license.");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                }
            }
            while (!Guessed);
        
            //Console.ReadLine();

            Console.WriteLine("Insert your password? Please provide an 4 number combination.");
            int number1 = Convert.ToInt32(Console.ReadLine());
            bool Guessed1 = number == 1118;         

            while (!Guessed1) ;

           switch (number1)
            {
                case 1118:
                    Console.WriteLine("Your password is correct.");
                    break;
                case 1881:
                    Console.WriteLine("Your password is not correct. Try again.");
                    break;
                default:
                    Console.WriteLine("Your password is not correct.");
                    break;
            }
            Console.ReadLine();

        }
    }
}
