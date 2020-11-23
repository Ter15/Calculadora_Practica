using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            bool TerminateProgram = false;
            while (TerminateProgram == false)
            {
                UserInterface.PrintMenu();
                int option = UserInterface.ReadUserOption();

                switch (option)
                {
                    case 1: 
                        UserInterface.PrintMenuPower2();
                        int number1 = System.Convert.ToInt32(UserInterface.ReadIntegerNumber());
                        Models.GetPower2(number1);
                        System.Console.Write("El resultado es: " + System.Convert.ToDouble(Models.GetPower2(number1))); // QUIERO 3 DECIMALES
                        System.Console.Write("\n \n");
                        System.Console.ReadLine();
                        break;
                    case 2:
                        UserInterface.PrintMenutSummation();
                        int number2 = UserInterface.ReadIntegerNumber();
                        Models.GetSummation(number2);
                        System.Console.Write("El resultado es: " + Models.GetSummation(number2));
                        System.Console.Write("\n \n");
                        System.Console.ReadLine();
                        break;
                    case 3:
                        UserInterface.PrintMenuFactorial();
                        int number3 = UserInterface.ReadIntegerNumber();
                        if (number3 >= 0)
                        {
                            Models.GetFactorial(number3);
                            System.Console.Write("El resultado es: " + Models.GetFactorial(number3));
                            System.Console.Write("\n \n");
                            System.Console.ReadLine();
                        }
                        else
                        {
                            System.Console.WriteLine("Has introducido un número negativo. Recuerda que el factorial de un número negativo no existe. \n \n");
                            System.Console.ReadLine();
                        }
                        break;
                    case 4:
                        UserInterface.PrintMenuPrime();
                        int number4 = UserInterface.ReadIntegerNumber();
                        Models.IsPrime(number4);
                        System.Console.Write("¿El número introducido es primo? " + Models.IsPrime(number4));
                        System.Console.Write("\n \n");
                        System.Console.ReadLine();
                        break;
                    case 5:  //NO SÉ COMO REALIZAR ESTE EJERCICIO
                        UserInterface.PrintMenuFibonacci();
                        int number5 = UserInterface.ReadIntegerNumber();
                        Models.IsFibonacci(number5);
                        System.Console.Write("\n \n");
                        System.Console.ReadLine();
                        break;
                    case 0:
                        TerminateProgram = true;
                        System.Console.WriteLine("\n                  Gracias por usar la CALCULADORA DE ESTER, esperamos verle pronto.");
                        System.Console.ReadLine();
                        break;

                }

            }



        }
    }
}
