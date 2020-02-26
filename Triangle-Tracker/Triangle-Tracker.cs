using System;
using System.Collections.Generic;

public class Triangle
{
    public int oneLength;
    public int twoLength;
    public int threeLength;

    public void TriangleType()
    {
        if((oneLength + twoLength < threeLength) || (oneLength + threeLength < twoLength) || (threeLength + twoLength < oneLength))
        {
            Console.WriteLine("Thats not a Triangle");
        }
         else if ((oneLength == twoLength) &&  (twoLength == threeLength) && (threeLength == oneLength))
        {
            Console.WriteLine("Its an Equalateral Triangle");
        }
        else if ((oneLength != twoLength) && (twoLength != threeLength))
        {
            Console.WriteLine("Its a Scalene Triangle");
        }
        else 
        {
            Console.WriteLine("Its an Isosceles");
        }
    }
}
        public class Program
        {
            public static void Main()
            {
                Triangle triOne = new Triangle();
                triOne.oneLength = 6;
                triOne.twoLength = 6;
                triOne.threeLength = 6;

                Triangle triTwo = new Triangle();
                triTwo.oneLength = 4;
                triTwo.twoLength = 6;
                triTwo.threeLength = 6;

                Triangle triThree = new Triangle();
                triThree.oneLength = 4;
                triThree.twoLength = 6;
                triThree.threeLength = 8;

                Triangle triFour = new Triangle();
                triFour.oneLength = 4;
                triFour.twoLength = 6;
                triFour.threeLength = 12;

                triOne.TriangleType();
                triTwo.TriangleType();
                triThree.TriangleType();
                triFour.TriangleType();
            }
        }

