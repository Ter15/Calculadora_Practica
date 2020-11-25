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
            bool TerminateProgram = false;
            while (TerminateProgram == false)
            {
                UserInterface.PrintMainMenu();
                int option = UserInterface.ReadUserOption();

                switch (option)
                {
                    case 1:
                        UserInterface.PrintLaunchPower2Menu();
                        double number1 = System.Convert.ToDouble(UserInterface.ReadDoubleNumber());
                        double n1 = Models.GetPower2(number1);
                        System.Console.Write("El resultado es: " + n1);       // PERFECTO, SALEN CON DECIMALES PERO NECESITO EL DOUBLE  // AQUI NO LOS VOY A USAR ------QUIERO 3 DECIMALES // number1.ToString("N3")
                        System.Console.Write("\n \n");
                        System.Console.Write("Introduzca intro para volver al Menú Principal");
                        System.Console.ReadLine();
                        break;
                    case 2:
                        UserInterface.PrintMenutSummation();   // PERFECTO. NO TOCAR.
                        int number2 = UserInterface.ReadIntegerNumber();
                        int n2 = Models.GetSummation(number2);
                        System.Console.Write("El resultado es: " + n2);
                        System.Console.Write("\n \n");
                        System.Console.Write("Introduzca intro para volver al Menú Principal");
                        System.Console.ReadLine();
                        break;
                    case 3:
                        UserInterface.PrintMenuFactorial();
                        int number3 = UserInterface.ReadIntegerNumber();
                        if (number3 >= 0)
                        {
                            int n3 = Models.GetFactorial(number3);
                            System.Console.Write("El resultado es: " + n3);
                            System.Console.Write("\n \n");
                            System.Console.Write("Introduzca intro para volver al Menú Principal");
                            System.Console.ReadLine();
                        }
                        else
                        {
                            System.Console.WriteLine("\n Has introducido un número negativo. Recuerda que el factorial de un número negativo no existe. \n \n");
                            System.Console.ReadLine();
                        }
                        break;
                    case 4:
                        UserInterface.PrintMenuPrime();
                        int number4 = UserInterface.ReadIntegerNumber();
                        bool n4 = Models.IsPrime(number4);
                        System.Console.Write("¿El número introducido es primo? " + n4);
                        System.Console.Write("\n \n");
                        System.Console.Write("Introduzca intro para volver al Menú Principal");
                        System.Console.ReadLine();
                        break;
                    case 5:  //NO SÉ COMO REALIZAR ESTE EJERCICIO
                        UserInterface.PrintMenuFibonacci();
                        int number5 = UserInterface.ReadIntegerNumber();
                        int n5 = Models.IsFibonacci(number5);
                        System.Console.Write( "Esta es la serie: " + n5);
                        System.Console.Write("\n \n");
                        System.Console.ReadLine();
                        break;
                    case 0:
                        TerminateProgram = true;
                        System.Console.WriteLine("\n                  Gracias por usar la CALCULADORA DE ESTER, esperamos verle pronto.");
                        System.Console.Write("Introduzca intro para salir");
                        System.Console.ReadLine();
                        break;

                }

            }
        }
    }
}
