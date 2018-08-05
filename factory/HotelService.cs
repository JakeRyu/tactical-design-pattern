using System;

namespace factory
{
    internal class HotelService : IHotelService
    {
        public IVacationPart MakeBooking(HotelInfo hotel, DateTime checkin, DateTime checkout)
        {
            Console.WriteLine("Waiting for remote hotel booking service to respond...");
            System.Threading.Thread.Sleep(300); // Waiting for remote service
            Console.WriteLine("Booking hotel {0} {1:dd-MMM-yyyy} - {2:dd-MMMM-yyyy}\n",
                hotel, checkin, checkout);
            return new DummyVacationPart("Hotel " + hotel.ToString());
            
        }
    }
}