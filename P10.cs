//10: Arrange the code to get desirable output


using System;

// User-defined exception class
class MyException : Exception
{
    // Constructor accepting exception message
    public MyException(string str) : base(str)
    {
        //Console.WriteLine("User defined exception");
    }
}

// Main client class
class P10
{
    public static void Main()
    {
        try
        {
            // Throw user-defined exception
            throw new MyException("my exception generated.");
        }
        catch (Exception e)
        {
            // Display exception message
            Console.WriteLine("Exception caught here: " + e.Message);
        }

        // This statement executes after catch
        Console.WriteLine("LAST STATEMENT");

        Console.WriteLine("=========================");
        Console.WriteLine("Name: Aesh Domadiya");
        Console.WriteLine("Enrollment no.: 24SOECE11008");

        Console.ReadKey();
    }
}

// Output:

//Exception caught here: my exception generated.

//         LAST STATEMENT