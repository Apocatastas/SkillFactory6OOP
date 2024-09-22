using System;

class Program
{

    class Square
    {
        public int side;

        public double Area()
        {
            return side * side;
        }

        public int Perimeter()
        {
            return side * 4;
        }
    }

    class Triangle
    {
        public int sideA;
        public int sideB;
        public int sideC;

        public int Perimeter()
        {
            return sideA + sideB + sideC;
        }

        public double HeronSideProcessor(int side)
        {
            return Perimeter() / 2 - side;
        }

        public double Area()
        {
            return Math.Sqrt( Perimeter() / 2
                              * HeronSideProcessor(sideA)
                              * HeronSideProcessor(sideB)
                              * HeronSideProcessor(sideC)
                             );
        }
    }

    class Circle
    {
        public int radius;

        public double circleLength()
        {
            return 2 * Math.PI * radius;
        }

        public double circleArea()
        {
            return Math.PI * radius * radius;
        }
    }


    public static void Main(string[] args)
    {

    } 
}
