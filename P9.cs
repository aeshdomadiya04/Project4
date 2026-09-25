using System;

class P9
{
    public static void Main()
    {
        int x = 0;
        try
        {
            // This statement causes DivideByZeroException
            int div = 100 / x;

            Console.WriteLine(div);
        }
        catch (DivideByZeroException)
        {
            // Handle division by zero
            Console.WriteLine("Cannot divide by zero.");
        }
        finally
        {
            // This block always executes
            Console.WriteLine("Finally block executed.");
        }

        Console.WriteLine("Program completed.");
        Console.Read();

        Console.WriteLine("=========================");
        Console.WriteLine("Name: Aesh Domadiya");
        Console.WriteLine("Enrollment no.: 24SOECE11008");
    }
}
