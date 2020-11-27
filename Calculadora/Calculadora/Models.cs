using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class Models
    {/// <summary>
     /// This function calculates the exponent of 2
     /// </summary>
     /// <param name="number"> This parameter is the one entered by the user, which is the one you want to calculate  </param>
     /// <returns> 
     /// Returns the result, if the number entered is positive
     /// Returns the result, if the number entered is negative
     /// </returns>
        public static double GetPower2(double number)
        {
            if (number >= 0)
            {
                double result = 1.0;
                for (int i = 0; i < number; i++)
                    result *= 2.0;
                return result;
            }
            else
            {
                double  result = 1.0;
                for (double i = 0; i < -number; i++)
                    result /= 2;
                return result;
            }
        }
        /// <summary>
        /// Calculates the sum of a number
        /// </summary>
        /// <param name="numero">this parameter is the one entered by the user, which is the one you want to calculate</param>
        /// <returns> 
        /// Returns the solution of the summation
        /// </returns>
        public static int GetSummation(int number)
        {
            int i;
            int result = 0;
            if (number >= 0)
            {
                for (i = 1; i <= number; i++)
                    result += i;
                return result;
            }
            else
            {
                for (int j = 0; j >= number; j--)
                    result += j;
                return result;
            }
        }
        /// <summary>
        /// Calculate the factorial of the number.
        /// </summary>
        /// <param name="numero">this parameter is the one entered by the user, which is the one you want to calculate</param>
        /// <returns>
        /// Returns the solution of the factorial.
        /// </returns>
        public static int GetFactorial(int numero)
        {
            int i;
            int result = 1;
            for (i = 1; i <= numero; i++)
                result *= i;
            return result;
        }
        /// <summary>
        /// Calculate if a number is prime.
        /// </summary>
        /// <param name="number">this parameter is the one entered by the user, which is the one you want to calculate</param>
        /// <returns>
        /// Returns true if a number is prime or false if a number is not prime.
        /// </returns>
        public static bool IsPrime(int number)
        {
            int i = 2;
            while (i < number)
            {
                if ((number % i) == 0)
                    return false;
                i++;
            }
            return true;
        }
        /// <summary>
        /// Calculate the Fibonacci series.
        /// </summary>
        /// <param name="number"> this parameter is the one entered by the user, which is the one you want to calculate </param>
        /// <returns>
        /// Returns serial numbers up to the number the user has entered.
        /// </returns>
        public static string IsFibonacci(int number)
        {
            int n1 = 1;
            int n2 = 0;
            int i = 2;
            string result = "";
            result = result + " " + n2;
            result = result+ " " + n1;
     
            while (i < number)
            {
                result = result + " " + (n1 + n2);
                int aux = n2;
                n2 = n1;
                n1 = aux + n2;
                i++;
            }
            return result;
        }
    }
}
