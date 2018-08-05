using System.Collections.Generic;
using System.Text;

namespace factory
{
    public class VacationSpecification
    {
        private IList<IVacationPart> _parts;

        public VacationSpecification(IList<IVacationPart> parts)
        {
            _parts = parts;
        }
    }
}