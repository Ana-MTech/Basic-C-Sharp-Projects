using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> intList = new List<int>() { 5, 10, 20, 100, 40, 160, 80 };
        Console.WriteLine(intList[0]);
        Console.WriteLine(intList[1]);
        Console.WriteLine(intList[2]);
        Console.WriteLine(intList[3]);
        Console.WriteLine(intList[4]);
        Console.WriteLine(intList[5]);
        Console.WriteLine(intList[6]);

        try
        {
            Console.WriteLine("Type an number to divide each number in the list.");
            int result = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Pick a second number.");
            //int numberTwo = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Dividing the two...");
            //int numberThree = numberOne / numberTwo;
            //Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            //Console.ReadLine();

            foreach(int item in intList)
            {
               // int result1 = item / intList[0];

                int result1 = item / result;
            }

        }
        catch (FormatException ex)
        {
            //Console.WriteLine(ex.Message);    custom message below
            Console.WriteLine("Please type a whole number.");
            return;     //add for example with finally read line
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }

    }
}

