using System;

namespace factory
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            new Application(
                new VacationPartFactory(
                    new HotelSelector(),
                    new HotelService(),
                    new AirplaneService()))
                .Run();

            Console.ReadLine();
        }
    }
}