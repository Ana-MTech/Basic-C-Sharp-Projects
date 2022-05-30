using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {

        Console.WriteLine("Which of Tolkien's novels do you prefer more?");
        Console.WriteLine("");
        Console.WriteLine("Please select one of the below title by choosing a corresponding number!");
        Console.WriteLine("");

        string[] Books = { "1. The Lord of the Rings", "2. The Silmarilliom", "3. The Fellowship of the Ring", "4. The Hobbit", "5. The Two Towers", "6. The Fall of Gondolin" };
        //string[] Books = new string[6];
        //Books[0] = "1.The Lord of the Rings";
        //Books[1] = "2.The Silmarilliom";
        //Books[2] = "3.The Fellowship of the Ring";
        //Books[3] = "4.The Hobbit";
        //Books[4] = "5.The Two Towers";
        //Books[5] = "6.The Fall of Gondolin";

        Console.WriteLine(Books[0]);
        Console.WriteLine(Books[1]);
        Console.WriteLine(Books[2]);
        Console.WriteLine(Books[3]);
        Console.WriteLine(Books[4]);
        Console.WriteLine(Books[5]);
        Console.WriteLine("");

        //string[] Books = new string[6];
        //Books[0] = "The Lord of the Rings";
        //Books[1] = "The Silmarilliom";
        //Books[2] = "The Fellowship of the Ring";
        //Books[3] = "The Hobbit";
        //Books[4] = "The Two Towers";
        //Books[5] = "The Fall of Gondolin";

        //int packageWeight = 0;
        //Console.WriteLine("Please enter the package weight.");
        //packageWeight = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("");

        int BookNumber = 0;
        BookNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        ////packageWeight = Convert.ToInt32(Console.ReadLine());
        //Console.ReadLine();



        //Console.WriteLine(n2[5]);
        //Console.ReadLine();



        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

        Console.ReadLine();
    }
}

