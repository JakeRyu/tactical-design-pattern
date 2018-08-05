using System;

namespace factory
{
    internal class DummyVacationPart : IVacationPart
    {
        private readonly string _name;

        public DummyVacationPart(string name)
        {
            _name = name;
        }

        public void Reserve()
        {
            Console.WriteLine($"Making reservation - {_name}");
        }

        public void Purchase()
        {
            Console.WriteLine($"Purchasing {_name}");
        }

        public void Cancel()
        {
            throw new NotImplementedException();
        }
    }
}