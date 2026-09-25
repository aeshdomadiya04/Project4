using StaticVarApplication;
using System;
using System.Collections.Generic;
using System.Text;

namespace StaticVarApplication

{

    class StaticVar

    {

        public static int num;



        public void count()

        {

            num++;

        }

        //………………………………Missing statement……………………………….//      
        public static int getNum()
        {

            return num;

        }

}

class StaticTester

{

    static void Main(string[] args)

    {

        StaticVar s = new StaticVar();

        s.count();

        s.count();

        s.count();

        Console.WriteLine("Variable num: {0}", StaticVar.getNum());

        Console.ReadKey();

        Console.WriteLine("=========================");
        Console.WriteLine("Name: Aesh Domadiya");
        Console.WriteLine("Enrollment no.: 24SOECE11008");
        }

    }

}