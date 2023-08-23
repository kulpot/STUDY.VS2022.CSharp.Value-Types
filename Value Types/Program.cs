using System;

//ref link:https://www.youtube.com/watch?v=EzcOF5nM1M8&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=8
//  stack - low room vs heap - high room storage

//class Cow
struct Cow      // value type   -- stored directly to stack
{
    public int mooCount;
    int numStomachs;
    //int numStomachs;
    //int numStomachs;
    //int numStomachs;
    //Udder udder;
    //public Cow()
    //{
    //    udder = new Udder();
    //}
}

struct Fraction
{
    int numerator;
    int denominator;
}

//class Udder
//{
//    int numTeets;
//    double ouncesOfMilk;
//}

class MainClass
{
    static void Main()
    {
        int i = 5;
        //Fraction myFraction = new Fraction(3, 4);
        //Cow c;
        Cow c = new Cow();
        //c.mooCount = 654;
        Console.WriteLine(c.mooCount);
    }
}