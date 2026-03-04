// Type Casting
// - It means casting a variable data type to another data type

// Two type of Type Casting 
// 1. Implicit Type Conversion ( This is Type safe )  
// 2.Explicity Type Conversion (Manual Conversion)

// In Implicit Type Conversion - C# compiler converts a smaller data type to larger data type without any data loss ( this is why it is type safe) - jaise int to double
// byte -> short -> char -> int -> long -> float -> double
// small -> large (✅ numeric data type conversion is possible)
// large -> small (❌) - using Explicit Conversion✅

// In C# numeric type can converts among themselves but not to char or bool to ensure type safety
public class TypeCasting
{
    // ________________________________________
    // Implicit Type Conversion
    // ________________________________________

    // public static void Implicit()
    // {
    //     int i = 6;

    //     float f = i;

    //     double d = f;

    //     Console.WriteLine($"Type:{i.GetType().Name}, value:{i}");
    //     Console.WriteLine($"Type:{f.GetType().Name}, value:{f}");
    //     Console.WriteLine($"Type:{d.GetType().Name}, value:{d}");
    // }

    // ____________________________________________
    // Explicit Type Conversion
    // ____________________________________________

    // public static void Explicit()
    // {
    //     double d = 765.62;

    //     int i = (int)d;

    //     Console.WriteLine($"Type: {i.GetType().Name}, value: {i}");
    // }

    // ______________________________________________
    // Bulit-In Types by which Explicit conversion can be done
    // ______________________________________________

    public static void BuiltIn(String[] args)
    {
        int i = 12;
        double d = 765.12;
        float f = 56.123F;

        // Using Built- In Type Conversion Methods & Displaying Result
        Console.WriteLine(Convert.ToString(f));
        Console.WriteLine(Convert.ToInt32(d));
        Console.WriteLine(Convert.ToUInt32(f));
        Console.WriteLine(Convert.ToDouble(i));
        Console.WriteLine("GeeksforGeeks");
    }
}

