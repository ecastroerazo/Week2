using System;
using System.Collections.Generic;

namespace FactorLogic
{
    public static class Factorizer
    {
        public static List<int> Factor(int number)
        {
            var factors = new List<int>();

            if (number < 2)
                return factors;

            while (number % 2 == 0)
            {
                factors.Add(2);
                number /= 2;
            }

            for (int i = 3; i * i <= number; i += 2)
            {
                while (number % i == 0)
                {
                    factors.Add(i);
                    number /= i;
                }
            }

            if (number > 2)
                factors.Add(number);

            return factors;
        }
    }
}

