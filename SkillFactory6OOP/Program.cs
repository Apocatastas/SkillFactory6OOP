using System;

class Program
{
    В классах нужно объявить поля для длин сторон(радиус) и
        методы для получения площади и периметра(длины окружности)
        без их реализации и без конструкторов.

    class Square
    {
        int side;

        double Area()
        {
            return side * side;
        }

        int Perimeter()
        {
            return side * 4;
        }
    }

    class Triangle
    {
        int sideA;
        int sideB;
        int sideC;

        int Perimeter()
        {
            return sideA + sideB + sideC;
        }

        double HeronSideProcessor(int side)
        {
            return Perimeter() / 2 - side;
        }

        double Area()
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
        int radius;

        double circleLength()
        {
            return 2 * Math.PI * radius;
        }

        double circleArea()
        {
            return Math.PI * radius * radius;
        }
    }


    public static void Main(string[] args)
    {

    } 
}
