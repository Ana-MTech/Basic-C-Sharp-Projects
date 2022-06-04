using System;
using System.Collections.Generic;
    class Program
    {
    static void Main(string[] args)
    {
        //1. Part assignement:

        //string[] names = { "Dog", "Cat", "Horse", "Batterfly" };
        //Console.WriteLine(names[0]);
        //Console.WriteLine(names[1]);
        //Console.WriteLine(names[2]);
        //Console.WriteLine(names[3]);
        //Console.WriteLine("");    

        //Console.WriteLine("Type a word or phrase to add");
        //string userInput = Console.ReadLine();
        //Console.WriteLine("");

        //for (int i = 0; i < names.Length; i++)
        //{         
        //    names[i] = names[i] + " " + userInput;         
        //    Console.WriteLine(names[i]);  
        //}

        //2. Part assignement:

        //int i = 0;
        //while (true)

        //    {       
        //    Console.WriteLine($"i = {i}");
        //    i++;

        //    //Fixing the loop with 'break'
        //    if (i > 8)
        //    {
        //        break;
        //    }
        //    }


        //3. Part assignement:

        // int i = 0;
        // while (i < 7)
        //{
        //    Console.WriteLine(i + " ");
        //    i++;
        //}

        //int i = 1;
        //while (i <= 5)
        //{
        //    Console.WriteLine(i + " ");
        //    i++;
        //}

        //4. Part assignement:

        //List<string> names = new List<string>() { "Rob", "Ema", "Matthew", "Leon", "Martina" };

        //Console.WriteLine("Enter one of the following names: \nRob, \nEma, \nMatthew, \nLeon, \nMartina\n");
        //string userInput = Console.ReadLine();

        //bool matchExist = false;

        //for (int i = 0; i < names.Count; i++)
        //{
        //    if (names[i] == userInput)
        //    {
        //        matchExist = true;
        //        Console.WriteLine("Your selection index is: " + i);
        //    }
        //}
        //if (matchExist == false)
        //    {
        //        Console.WriteLine("Sorry, this is not the list");              
        //    }

        //5. Part assignement:

        //List<string> towns = new List<string>() { "Rome", "Paris", "Berlin", "Zagreb", "Vienna", "Berlin" };

        //Console.WriteLine("Enter one of the following towns: \nRome, \nParis, \nBerlin, \nZagreb, \nVienna\n");
        //string userInput = Console.ReadLine();   

        //bool matchExist = false;

        //for (int i = 0; i < towns.Count; i++)
        //{
        //    if (towns[i] == userInput)
        //    {
        //        matchExist = true;
        //        Console.WriteLine("Your selection index is: " + i + ", " + userInput);         
        //    }
        //}
        //if (matchExist == false)
        //{
        //    Console.WriteLine("Sorry, this is not the list");
        //}

        //6. Part assignement:

        List<string> colours = new List<string>() { "Red", "White", "Black", "White", "Blue", "Green" };
        Console.WriteLine("We have the following colours: \nRed, \nWhite, \nBlack, \nBlue, \nGreen\n");
        Console.WriteLine(colours);
       
        Console.ReadLine();
    }
    }








