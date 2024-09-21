using System;

class Program
{
    class Bus
    {
        public int? Load;

        public void PrintStatus()
        {
            if ((Load.HasValue)&&(Load > 0))
            {
                Console.WriteLine("В автобусе {0} пассажиров", Load.Value);
            }
            else
            {
                Console.WriteLine("Автобус пуст");
            }
        }
    }

    public static void Main(string[] args)
    {

    } 
}
