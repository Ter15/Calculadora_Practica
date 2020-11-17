using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class UserInterface
    {
        public static void PrintMenu()
        {
            //System.Console.BackgroundColor = System.ConsoleColor.Red;
            //System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.WriteLine("------------------");
            System.Console.WriteLine("  Menú principal  ");
            System.Console.WriteLine("------------------");
            System.Console.WriteLine("1) Potencia en base 2");
            System.Console.WriteLine("2) Sumatorio de un número");
            System.Console.WriteLine("3) Calcular el factorial de un número");
            System.Console.WriteLine("4) Saber si un número es primo");
            System.Console.WriteLine("5) Imprimir la serie de Fibonacci");
            System.Console.WriteLine("0) Salir del programa \n \n");
        
            System.Console.Write("Por favor, introduzca el número de la operación que desea realizar: ");
            

        }
        public static void PrintMenuPower2()
        {
            //System.Console.BackgroundColor = System.ConsoleColor.Red;
            //System.Console.ForegroundColor = System.ConsoleColor.Yellow;
           System.Console.WriteLine("");
           System.Console.WriteLine("---------------------");
           System.Console.WriteLine("  POTENCIA EN BASE 2  ");
           System.Console.WriteLine("---------------------");
           System.Console.WriteLine("   Una potencia es el resultado de multiplicar un número por sí mismo varias veces."); 
           System.Console.WriteLine("   El número que multiplicamos se llama BASE, en este caso es 2.");
           System.Console.WriteLine("   El número de veces que multiplicamos la base se llama  EXPONENTE. \n");
           System.Console.Write("Por favor, introduzca el número exponente : ");

        }

         public static int ReadUserOption()
         {
            int n1 = System.Convert.ToInt32(System.Console.ReadLine());
            return n1;
         }











    }
}
