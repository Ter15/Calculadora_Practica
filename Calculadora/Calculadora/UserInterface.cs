using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class UserInterface
    {
        /// <summary>
        /// This function prints the main menu.
        /// </summary>
        public static void PrintMainMenu()
        {
            PrintHead ("Menú principal", ConsoleColor.Cyan, "-", "-");
            System.Console.WriteLine("1) Potencia en base 2");
            System.Console.WriteLine("2) Sumatorio de un número");
            System.Console.WriteLine("3) Calcular el factorial de un número");
            System.Console.WriteLine("4) Saber si un número es primo");
            System.Console.WriteLine("5) Imprimir la serie de Fibonacci");
            System.Console.WriteLine("0) Salir del programa \n \n");
            System.Console.Write(" Por favor, introduzca un número de la operación que desea realizar: ");
        }
        /// <summary>
        ///  This function prints the base menu 2. 
        /// </summary>
        public static void PrintLaunchPower2Menu()
        {
            PrintHead("POTENCIA EN BASE 2", ConsoleColor.Yellow, "*", "¨");
            System.Console.WriteLine("   Una potencia es el resultado de multiplicar un número por sí mismo varias veces."); 
            System.Console.WriteLine("   El número que multiplicamos se llama BASE, en este caso es 2.");
            System.Console.WriteLine("   El número de veces que multiplicamos la base se llama EXPONENTE. \n");
            System.Console.Write(" Por favor, introduzca el número EXPONENTE: ");
        }
        /// <summary>
        /// This function prints the summation menu.
        /// </summary>
        public static void PrintMenutSummation()
        {
            PrintHead("SUMATORIO", ConsoleColor.Yellow, " =", "");
            System.Console.WriteLine("   La sumatoria o sumatorio se emplea para representar la suma de muchos o infinitos sumandos.\n");
            System.Console.Write(" Por favor, introduzca un número entero: ");
        }
        /// <summary>
        /// This function prints the factorial of a number menu.
        /// </summary>
        public static void PrintMenuFactorial()
        {
            PrintHead("FACTORIAL", ConsoleColor.Yellow, "¨"," ");
            System.Console.WriteLine("    El factorial de un número entero positivo se define como el producto de ");
            System.Console.WriteLine("    todos los números naturales anteriores o iguales a él.");
            System.Console.WriteLine("    El factorial de un número entero negativo no existe. \n \n");
            System.Console.Write(" Por favor, introduzca un número entero: ");
        }
        /// <summary>
        /// This function prints the prime numbers menu.
        /// </summary>
        public static void PrintMenuPrime()
        {
            PrintHead("NÚMERO PRIMO", ConsoleColor.Yellow, "*", "*");
            System.Console.WriteLine("   Un número primo es un número natural mayor que 1 que tiene");
            System.Console.WriteLine("   únicamente dos divisores positivos distintos: él mismo y el 1.");
            System.Console.WriteLine("   Por el contrario, los números compuestos son los números naturales");
            System.Console.WriteLine("   que tienen algún divisor natural aparte de sí mismos y del 1. \n");
            System.Console.Write(" Por favor, introduzca un número entero: ");
        }
        /// <summary>
        /// This function prints the menu of the Fibonacci series.
        /// </summary>
        public static void PrintMenuFibonacci()
        {
            PrintHead("SERIE FIBONACCI", ConsoleColor.Yellow, "~", "~");
            System.Console.WriteLine("   En matemáticas, la sucesión o serie de Fibonacci hace referencia a la secuencia "); 
            System.Console.WriteLine("   ordenada de números descrita por Leonardo de Pisa, matemático italiano del siglo XIII");
            System.Console.WriteLine("                       0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144,...");
            System.Console.WriteLine("   A cada uno de los elementos de la serie se le conoce con el nombre de número de Fibonacci.\n");
            System.Console.Write(" El número que insertes a continuación será el número de carácteres de la serie Fibinacci.");
            System.Console.Write("\n Por favor, inserta un numero entero: ");
        }
        /// <summary>
        /// This function reads the number that the user enters to choose the from the main menu.
        /// </summary>
        /// <returns> 
        /// Return a number from 0 to 5 
        /// Returns an error, because the user has entered a number or character other than 0,1,2,3,4 and 5.
        /// </returns> 
        public static int ReadUserOption()
        {
            while (true)
            {
                try
                {
                    int n1 = System.Convert.ToInt32(System.Console.ReadLine());
                    if ((n1 >= 0) && (n1 <= 5))
                    return n1;
                }
                catch (System.Exception e)
                {
                    System.Console.WriteLine(" \n Has introducido un error. Por favor, vuelva a intentarlo");
                }
            }
        }
        /// <summary>
        /// This function reads the integers entered to perform one of the operations. 
        /// </summary>
        /// <returns>
        /// Returns an integer. 
        /// Returns an error because an actual number or a character other than a number has been entered.
        /// </returns>
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
        /// <summary>
        /// This function reads a real number entered by the user to perform some operation.
        /// </summary>
        /// <returns>
        /// Return a real number.
        /// Returns an error because a character other than a number has been entered.
        ///  </returns> 
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
        /// <summary>
        /// This function gives color to the letters of the title and writes a line of characters up and down.
        /// </summary>
        /// <param name="title">In this parameter you enter the name of the title you want to see colored</param>
        /// <param name="color">this parameter is to choose the color</param>
        /// <param name="Linecharacter1">This parameter is to enter a character type that will appear on the top and bottom lines. It will appear in the even-numbered holes</param>
        /// <param name="Linecharacter2">This parameter is to enter a character type that will appear on the top and bottom lines. It will appear in the odd-numbered holes</param>
        public static void PrintHead(string title, ConsoleColor color, string Linecharacter1, string Linecharacter2)
        {
            int contCaracter = title.Length;
            System.Console.ForegroundColor = color;
            for (int i = 0; i <= contCaracter + 3; i++)
            {
                if ((i % 2) == 0)
                    System.Console.Write(" " + Linecharacter1);
                else
                    System.Console.Write(" " + Linecharacter2);
            }
            System.Console.WriteLine("");
            System.Console.WriteLine("           " + title);
            for (int i = 0; i <= contCaracter + 3; i++)
            {
                if ((i % 2) == 0)
                    System.Console.Write(" " + Linecharacter1);
                else
                    System.Console.Write(" " + Linecharacter2);
            }
            System.Console.WriteLine("");
            System.Console.ResetColor();
        }
    }
}
