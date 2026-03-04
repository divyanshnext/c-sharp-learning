//String in C# is Object of the System.String class

// keyword string and class name String are both aliases for System.String, so they can used interchangebly

using System;

public class StringPrac
{
    public static void Main()
    {
        // declare a string name using "System.String" class
        // System.String Name;
        // Name = "divyansh";

        // String id;
        // id = "33";

        // string mrk;
        // mrk = "97";


        // Console.WriteLine($"name is: {Name}");
        // Console.WriteLine($"id id: {id}");
        // Console.WriteLine($"mark is {mrk}");
        

        // Console.WriteLine("Enter your rank");
        // String rank = Console.ReadLine();
        // Console.WriteLine($"rank is {rank}");

        //__________________________________________________________________________//
        // Create a string from a character array
        //_________________________________________________________________________//
        
        char[] array = ['D','I','V','Y','A','N','S','H'];
        string s = new string(array);

        Console.WriteLine(s);
        //_________________________________________________________________________//
    }
}