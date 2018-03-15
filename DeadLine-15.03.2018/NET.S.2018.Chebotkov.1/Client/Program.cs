using System;

using Cars;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            auto.AutoInfo("Zaporojec");

            MiniCar miniCar = new MiniCar();
            miniCar.MiniCarInfo("Daewoo");

            SportCar sportCar = new SportCar();
            sportCar.SportCarInfo("BMW 3 GT");

            Console.ReadLine();
        }
    }
}