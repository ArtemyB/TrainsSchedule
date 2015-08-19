using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bordushko.TrainsSchedule.Utils
{
    public static class CheckUp
    {
        public static bool IsAnyStringEmpty(params string[] strings)
        {
            return strings.Any(str => str == String.Empty);
        }
    }
}
