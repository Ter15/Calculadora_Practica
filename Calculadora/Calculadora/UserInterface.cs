using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class UserInterface
    {
        public static void PrintMenu()
        {
            System.Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.WriteLine("            ------------------");
            System.Console.WriteLine("              Menú principal  ");
            System.Console.WriteLine("            ------------------");
            System.Console.ForegroundColor = ConsoleColor.White; 
            System.Console.WriteLine("1) Potencia en base 2");
            System.Console.WriteLine("2) Sumatorio de un número");
            System.Console.WriteLine("3) Calcular el factorial de un número");
            System.Console.WriteLine("4) Saber si un número es primo");
            System.Console.WriteLine("5) Imprimir la serie de Fibonacci");
            System.Console.WriteLine("0) Salir del programa \n \n");
            System.Console.Write(" Por favor, introduzca un número de la operación que desea realizar: ");
        }
        public static void PrintMenuPower2()
        {           
            System.Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("\n                     ~~~~~~~~~~~~~~~~~~~~~~~~~");
            System.Console.WriteLine("                        POTENCIA EN BASE 2  ");
            System.Console.WriteLine("                     ~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            System.Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("   Una potencia es el resultado de multiplicar un número por sí mismo varias veces."); 
            System.Console.WriteLine("   El número que multiplicamos se llama BASE, en este caso es 2.");
            System.Console.WriteLine("   El número de veces que multiplicamos la base se llama EXPONENTE. \n");
            System.Console.Write(" Por favor, introduzca el número exponente : ");
        }
        public static void PrintMenutSummation()
        {           
            System.Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine("\n                            ~~~~~~~~~~~~~~~");
            System.Console.WriteLine("                               SUMATORIO  ");
            System.Console.WriteLine("                            ~~~~~~~~~~~~~~~\n");
            System.Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("   La sumatoria o sumatorio se emplea para representar la suma de muchos o infinitos sumandos.\n");
            //System.Console.WriteLine("   Por ejemplo el sumatorio de 3:  Sumatorio de 3 = 1 + 2 + 3 = 5.\n");
            System.Console.Write(" Por favor, introduzca un número entero: ");
        }
        public static void PrintMenuFactorial()
        {
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("\n                           ~~~~~~~~~~~~~~~");
            System.Console.WriteLine("                              FACTORIAL  ");
            System.Console.WriteLine("                           ~~~~~~~~~~~~~~~\n");
            System.Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("    El factorial de un número entero positivo se define como el producto de ");
            System.Console.WriteLine("    todos los números naturales anteriores o iguales a él.");
            System.Console.WriteLine("    El factorial de un número entero negativo no existe. \n \n");
            System.Console.Write(" Por favor, introduzca un número entero: ");
        }
        public static void PrintMenuPrime()
        {           
            System.Console.ForegroundColor = ConsoleColor.Magenta;
            System.Console.WriteLine("\n                     ~~~~~~~~~~~~~~~~~~~~~");
            System.Console.WriteLine("                         NÚMEROS PRIMOS  ");
            System.Console.WriteLine("                     ~~~~~~~~~~~~~~~~~~~~~\n");
            System.Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("   Un número primo es un número natural mayor que 1 que tiene");
            System.Console.WriteLine("   únicamente dos divisores positivos distintos: él mismo y el 1.");
            System.Console.WriteLine("   Por el contrario, los números compuestos son los números naturales");
            System.Console.WriteLine("   que tienen algún divisor natural aparte de sí mismos y del 1. \n");
            System.Console.Write(" Por favor, introduzca un número entero: ");
        }
        public static void PrintMenuFibonacci()
        {          
            System.Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("\n                                    ~~~~~~~~~~~~~~~~~~~~~");
            System.Console.WriteLine("                                       SERIE FIBONACCI  ");
            System.Console.WriteLine("                                    ~~~~~~~~~~~~~~~~~~~~~\n");
            System.Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("   En matemáticas, la sucesión o serie de Fibonacci hace referencia a la secuencia "); 
            System.Console.WriteLine("   ordenada de números descrita por Leonardo de Pisa, matemático italiano del siglo XIII");
            System.Console.WriteLine("                       0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144,...");
            System.Console.WriteLine("   A cada uno de los elementos de la serie se le conoce con el nombre de número de Fibonacci.\n");
            System.Console.Write(" El número que insertes a continuación dará el resltado de la serie Fibinacci hasta ese mismo número.");
            System.Console.Write("\n Por favor, inserta un numero entero: ");
        }
        public static int ReadUserOption()
        {
            while (true)
            {
                try
                {
                    char n1 = System.Convert.ToChar(System.Console.ReadLine());
                    if ((n1 >= '0') && (n1 <= '5'))
                    return n1;
                }
                catch (System.Exception e)
                {
                    System.Console.WriteLine(" \n Has introducido un error. Por favor, vuelva a intentarlo");
                }
            }
        }
        public static int ReadIntegerNumber()
        {
            while (true)
            {
                try
                {
                    int n1 = System.Convert.ToInt32(System.Console.ReadLine());
                    return n1;
                }
                catch (System.Exception e)
                {
                    System.Console.WriteLine(" \n Has introducido un error. Por favor, vuelva a intentarlo");
                }
            }
        }
        public static double ReadDoubleNumber()
        {
            while (true)
            {
                try
                {
                    double n1 = System.Convert.ToDouble(System.Console.ReadLine());
                    return n1;
                }
                catch (System.Exception e)
                {
                    System.Console.WriteLine(" \n Has introducido un error. Por favor, vuelva a intentarlo");
                }
            }
        }
       


    }
}
