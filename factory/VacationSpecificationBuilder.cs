using System;
using System.Collections.Generic;

namespace factory
{
    public class VacationSpecificationBuilder
    {
        private readonly IList<IVacationPart> _parts = new List<IVacationPart>();
        private readonly IVacationPartFactory _partFactory;
        private readonly DateTime _arrivalDate;
        private readonly int _totalNights;
        private readonly string _livingTown;
        private readonly string _destinationTown;

        public VacationSpecificationBuilder(
            IVacationPartFactory partFactory,
            DateTime arrivalDate, int totalNights,
            string livingTown, string destinationTown)
        {
            _partFactory = partFactory;
            _arrivalDate = arrivalDate;
            _totalNights = totalNights;
            _livingTown = livingTown;
            _destinationTown = destinationTown;
        }

        private DateTime DepartureDate => _arrivalDate.AddDays(_totalNights);

        public void SelectHotel(string hotelName)
        {
            var part = _partFactory.CreateHotelReservation(_destinationTown, hotelName, _arrivalDate, DepartureDate);
            _parts.Add(part);
        }

        public void SelectAirplane(string companyName)
        {
            _parts.Add(CreateFlightToDestination(companyName));
            _parts.Add(CreateFlightBack(companyName));
        }

        private IVacationPart CreateFlightToDestination(string companyName)
        {
            return _partFactory.CreateFlight(companyName, _livingTown, _destinationTown, _arrivalDate);
        } 
        
        private IVacationPart CreateFlightBack(string companyName)
        {
            return _partFactory.CreateFlight(companyName, _destinationTown, _livingTown, DepartureDate);
        }

        public VacationSpecification BuildVacation()
        {
            foreach(var part in _parts)
                part.Reserve();
            return new VacationSpecification(_parts);
        }
    }
}