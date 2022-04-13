using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
    public static class Math
    {
        public static decimal Add(decimal value1, decimal value2)
        {
            return value1 + value2;
        }

        public static decimal Substract(decimal value1, decimal value2)
        {
            return value1 - value2;
        }

        public static decimal Multiply(decimal value1, decimal value2)
        {
            return value1 * value2;
        }

        public static decimal Divide(decimal value1, decimal value2)
        {
            return value1 / value2;
        }
    }
}
