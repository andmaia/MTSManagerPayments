using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.Helpers
{
    public class DateValidator
    {
        public static bool BeAValidDate(DateTime birthDate)
        {
            return birthDate <= DateTime.Now.Date;
        }
    }
}
