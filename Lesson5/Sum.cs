using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    internal class Sum
    {
        public int Calculation(dynamic x, ref int y)
        {
            dynamic result = 152;
            result += x;
            y++;
            return result;
        }
    }
}
