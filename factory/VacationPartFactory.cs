using System;

namespace factory
{
    public class VacationPartFactory : IVacationPartFactory
    {
        private readonly IHotelSelector _hotelSelector;
        private readonly IHotelService _hotelService;
        private readonly IAirplaneService _airplaneService;

        public VacationPartFactory(
            IHotelSelector hotelSelector,
            IHotelService hotelService,
            IAirplaneService airplaneService
        )
        {
            _hotelSelector = hotelSelector;
            _hotelService = hotelService;
            _airplaneService = airplaneService;
        }
        public IVacationPart CreateHotelReservation(string town, string hotelName, DateTime arrivalDate, DateTime leaveDate)
        {
            var hotel = _hotelSelector.SelectHotel(town, hotelName);
            return _hotelService.MakeBooking(hotel, arrivalDate, leaveDate);
        }

        public IVacationPart CreateFlight(string companyName, string source, string destination, DateTime date)
        {
            return _airplaneService.SelectFlight(companyName, source, destination, date);
        }

        public IVacationPart CreateFerryBooking(string lineName, bool fromMainland, DateTime date)
        {
            throw new NotImplementedException();
        }

        public IVacationPart CreateDailyTrip(string tripName, DateTime date)
        {
            throw new NotImplementedException();
        }

        public IVacationPart CreateMassage(string salon, DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}