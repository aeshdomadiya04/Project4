using System;
using System.Collections.Generic;
using System.Text;

class X
{
    public virtual void F() { Console.WriteLine("X.F"); }
    public virtual void F2() { Console.WriteLine("X.F2"); }
}

class Y : X
{
    sealed public override void F() { Console.WriteLine("Y.F"); }
    public override void F2() { Console.WriteLine("Y.F2"); }
}

class Z : Y
{
    // Cannot override F because Y.F is sealed; hide it instead
    new public void F() { Console.WriteLine("Z.F"); }

    // Overriding F2
    public override void F2() { Console.WriteLine("Z.F2"); }
}

class SealedMethodTest
{
    static void Main()
    {
        X Obj1 = new X();
        Obj1.F();
        Obj1.F2();

        Y Obj2 = new Y();
        Obj2.F();
        Obj2.F2();

        Z Obj3 = new Z();
        Obj3.F();
        Obj3.F2();

        Console.WriteLine("=========================");
        Console.WriteLine("Name: Aesh Domadiya");
        Console.WriteLine("Enrollment no.: 24SOECE11008");
    }
}