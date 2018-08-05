using System;

namespace factory
{
    public class Application
    {
        private readonly IVacationPartFactory _partFactory;

        public Application(IVacationPartFactory partFactory)
        {
            _partFactory = partFactory;
        }

        public void Run()
        {
            var builder = new VacationSpecificationBuilder(
                _partFactory,
                new DateTime(2018, 8, 29), 
                7,
                "High Wycombe",
                "Santorini");

            builder.SelectHotel("Hilton");
            builder.SelectAirplane("Noisy one");

            var spec = builder.BuildVacation();
        }
    }
}