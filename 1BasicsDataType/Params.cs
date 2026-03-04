// ________________________________________________ //
        // Practice Params - It is used as a parameter which can take the variable number of arguments of specific data type
        // It is useful when number of arguments is unknown

using System;
public static class Params
{

    // ______________________________________________________________________ //
    // Program to add the elements of array passed on the method
    // ______________________________________________________________________ //



    // public static int Add(params int[] ListNumbers)
    // {
    //     int total = 0;

    //     foreach(int i in ListNumbers)
    //     {
    //         total += i;
    //     }

    //     return total;
    // }


    // _________________________________________________________________//
    // Object type Params that allow any type of arguments and any number of arguments
    // ________________________________________________________________//

    public static string ConcatString(params string[] words)
    {
        return string.Join(" ", words);
    }
}