using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class Models
    {
        public static double GetPower2(int number)
        {
            if ( number >= 0)
            {
                int result = 1;
                for (int i = 0; i < number; i++)

                    result *= 2;
                return result;
            }
            else // potencias elevadas a menos algo 
            {
                double result = 1.0;
                for (int i = 0; i < -number; i++)
                    result /= 2;
                return result;
            }
        }
    }
}
