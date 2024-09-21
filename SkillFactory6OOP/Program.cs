using System;

class Program
{

    class Rectangle
    {
        public int a;
        public int b;

        public int Square()
        {
            return a * b;
        }

        public Rectangle(int aSide, int bSide)
        {
            a = aSide;
            b = bSide;
        }

        public Rectangle(int eqSides)
        {
            a = eqSides;
            b = eqSides;
        }

        public Rectangle()
        {
            a = 6;
            b = 4;
        }


    }


    public static void Main(string[] args)
    {

    }
}
