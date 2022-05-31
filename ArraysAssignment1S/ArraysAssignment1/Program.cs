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
    
        Console.WriteLine(Books[0]);
        Console.WriteLine(Books[1]);
        Console.WriteLine(Books[2]);
        Console.WriteLine(Books[3]);
        Console.WriteLine(Books[4]);
        Console.WriteLine(Books[5]);
        Console.WriteLine("");
       
        int BookNumber = 0;
        BookNumber = Convert.ToInt32(Console.ReadLine())-1;
        Console.WriteLine(Books[BookNumber]);
        Console.WriteLine("");


        Console.WriteLine("We have 4 book clubs, choose one that best suite your time table...All club meet at our Library but in different times and days");
        Console.WriteLine("");
        Console.WriteLine("Choose the one that best siute you by choosing the corresponding number");
        Console.WriteLine("");
        Console.WriteLine("1. at 9am every Saturday, 2. 10.30am on Saturday, 3. 5pm on Friday, 4. at 5pm on Tuesday");
        Console.WriteLine("");
       
        int[] Times = { 1, 2, 3, 4 };

        //Console.WriteLine(Times[0]);
        //Console.WriteLine(Times[1]);
        //Console.WriteLine(Times[2]);
        //Console.WriteLine(Times[3]);
        //Console.WriteLine("");

        int MeetingTime = 0;
        MeetingTime = Convert.ToInt32(Console.ReadLine()) - 1;

        if (MeetingTime <= 4)
        {
            Console.WriteLine("You choose number " + Times[MeetingTime] + " combination for your book club meeting.");
        }
        else
        {
            Console.WriteLine($"{MeetingTime} is an meeting combination that does not exist.");
        }

        Console.WriteLine("Where would you like to travel?");
        Console.WriteLine("");
        Console.WriteLine("Choose one of these...");
        Console.WriteLine("");

        string[] names = { "Paris", "Brasil", "New York", "Rome", "Sidney", "Tokio"};

        Console.WriteLine(names[0]);
        Console.WriteLine(names[1]);
        Console.WriteLine(names[2]);
        Console.WriteLine(names[3]);
        Console.WriteLine(names[4]);
        Console.WriteLine(names[5]);
        Console.WriteLine("");

        int TownName = 0;
        TownName = Convert.ToInt32(Console.ReadLine()) - 1;
        Console.WriteLine("You choose the " + names[TownName] + ".");
        Console.ReadLine();
    }
}

