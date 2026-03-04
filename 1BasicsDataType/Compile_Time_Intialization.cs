// there are two types of intialization
// compile time intialization
// run time intialization

using System;

class Compile_Time_Intialization
{

    int a; // compile time intialization // only decalaration // compiler will provide default value 0 to it

    public static void Run()
    {
        int b = 32;

        Console.WriteLine($"value of b is : {b}");

        Compile_Time_Intialization obj = new Compile_Time_Intialization();

        Console.WriteLine("value of a is : "+obj.a);

    }
}