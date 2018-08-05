using System;

namespace factory
{
    public interface IHotelService
    {
        IVacationPart MakeBooking(HotelInfo hotel, DateTime checkin, DateTime checkout);
    }
}