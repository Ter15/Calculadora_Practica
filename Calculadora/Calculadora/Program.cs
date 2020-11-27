using System;

namespace Calculadora
{
    class Program
    {
        /// <summary>
        /// Here you control everything that has to go out on the screen and what has to be entered to do the operations.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string INTROMAIN = "  Introduzca intro para volver al Menú Principal.";
            const string LINEJUMP = "\n \n";
            bool TerminateProgram = false;
            while (TerminateProgram == false)
            {
                System.Console.Clear();
                UserInterface.PrintMainMenu();
                int option = UserInterface.ReadUserOption();
                
                switch (option)
                {
                    case 1:
                        System.Console.Clear();
                        UserInterface.PrintLaunchPower2Menu();
                        double number1 = System.Convert.ToDouble(UserInterface.ReadDoubleNumber());
                        double n1 = Models.GetPower2(number1);
                        System.Console.Write("El resultado es: " + n1);      
                        System.Console.Write(LINEJUMP);
                        System.Console.Write(INTROMAIN);
                        System.Console.ReadLine();
                        break;
                    case 2:
                        System.Console.Clear();
                        UserInterface.PrintMenutSummation();   
                        int number2 = UserInterface.ReadIntegerNumber();
                        int n2 = Models.GetSummation(number2);
                        System.Console.Write("El resultado es: " + n2);
                        System.Console.Write(LINEJUMP);
                        System.Console.Write(INTROMAIN);
                        System.Console.ReadLine();
                        break;
                    case 3:
                        System.Console.Clear();
                        UserInterface.PrintMenuFactorial();
                        int number3 = UserInterface.ReadIntegerNumber();
                        if (number3 >= 0)
                        {
                            int n3 = Models.GetFactorial(number3);
                            System.Console.Write("El resultado es: " + n3);
                            System.Console.Write(LINEJUMP);
                            System.Console.Write(INTROMAIN);
                            System.Console.ReadLine();
                        }
                        else
                        {
                            System.Console.WriteLine("\n Has introducido un número negativo. Recuerda que el factorial de un número negativo no existe. \n \n");
                            System.Console.ReadLine();
                        }
                        break;
                    case 4:
                        System.Console.Clear();
                        UserInterface.PrintMenuPrime();
                        int number4 = UserInterface.ReadIntegerNumber();
                        bool n4 = Models.IsPrime(number4);
                        if (n4 == true)
                            System.Console.WriteLine("El número " + number4 + " es primo");
                        else
                            System.Console.WriteLine("El número " + number4 + " no es primo");
                        System.Console.Write(LINEJUMP);
                        System.Console.Write(INTROMAIN);
                        System.Console.ReadLine();
                        break;
                    case 5:
                        
                        System.Console.Clear();
                        UserInterface.PrintMenuFibonacci();
                        int number5 = UserInterface.ReadIntegerNumber();
                        if(number5 > 0)
                        {
                            string result = Models.IsFibonacci(number5);
                            System.Console.Write("La serie es la siguinte: " + result);
                            System.Console.Write(LINEJUMP);
                            System.Console.Write(INTROMAIN);
                            System.Console.ReadLine();
                        }
                        else
                        {
                            System.Console.WriteLine("\n Has introducido un número negativo. \n \n");
                            System.Console.Write(INTROMAIN);
                            System.Console.ReadLine();
                        }
                        break; 
                    case 0:
                        System.Console.Clear();
                        TerminateProgram = true;
                        System.Console.WriteLine("\n                  ¡Gracias por usar la CALCULADORA DE ESTER!"); 
                        System.Console.WriteLine("\n                            Esperamos verle pronto. \n");
                        System.Console.Write("Introduzca intro para salir.");
                        System.Console.ReadLine();
                        break;

                }

            }
        }
    }
}
