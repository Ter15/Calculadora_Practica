using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class Models
    {
        public static double GetPower2(int number)
        {
            if (number >= 0)
            {
                int result = 1;
                for (int i = 0; i < number; i++)
                {
                    result *= 2;
                }
                return result;
            }
            else
            {
                double result = 1.0;
                for (int i = 0; i < -number; i++)
                {
                    result /= 2;
                }
                return result;
            }
        }
        public static int GetSummation(int numero)
        {
            int i;
            int result = 0;
            for (i = 1; i <= numero; i++)
            {
                result += i;
            }
            return result;
        }
        public static int GetFactorial(int numero)
        {
            int i;
            int result = 1;
            for (i = 1; i <= numero; i++)
            {
                result *= i;
            }
            return result;
        }
        public static bool IsPrime(int number)
        {
            int i = 2;
            while (i < number)
            {
                if ((number % i) == 0)
                {
                    return false;
                }
                i++;
            }
            return true;
        }
        public static int IsFibonacci(int number)
        {
            int a = 1;
            int aa = 0;
            int i = 0;
            System.Console.WriteLine(aa);
            System.Console.WriteLine(a);

            while (i < number)
            {
                System.Console.WriteLine(a + aa);

                int aux = aa;
                aa = a;
                a = aux + aa;
                i++;
                return a;
            }
            return 0;
        }


    }
}
