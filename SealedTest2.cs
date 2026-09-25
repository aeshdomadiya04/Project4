using System;
using System.Collections.Generic;
using System.Text;

namespace project4
{


    sealed class A

    {

        public int x;

        public int y;

    }


    class SealedTest2

    {

        static void Main()

        {

            A sc = new A();

            sc.x = 110;

            sc.y = 150;

            Console.WriteLine("x = {0}, y = {1}", sc.x, sc.y);

            Console.WriteLine("=========================");
            Console.WriteLine("Name: Aesh Domadiya");
            Console.WriteLine("Enrollment no.: 24SOECE11008");
        }

    }
}