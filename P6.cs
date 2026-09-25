using System;

abstract class Test

{

    public int a;

    public abstract void A();

}



class Example1 : Test

{

    public override void A()

    {

        Console.WriteLine("Example1.A");

        base.a++;

    }

}

class Example2 : Test

{

    public override void A()

    {

        Console.WriteLine("Example2.A");

        base.a--;

    }

}

class P6

{

    static void Main()

    {

        // Reference Example1 through Test type.

        Test test1 = new Example1();

        test1.A();

        // Reference Example2 through Test type.

        Test test2 = new Example2();

        test2.A();



        Console.WriteLine("=========================");
        Console.WriteLine("Name: Aesh Domadiya");
        Console.WriteLine("Enrollment no.: 24SOECE11008");

        Console.ReadLine();


    }

}