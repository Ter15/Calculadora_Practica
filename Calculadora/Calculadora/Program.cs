using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                UserInterface.PrintMenu();
                int option = UserInterface.ReadUserOption();

                switch (option)
                {
                    case 1:
                        UserInterface.PrintMenuPower2();
                        int number1 = UserInterface.ReadUserOption();
                        Models.GetPower2(number1);
                        System.Console.Write("El resultado es: " + Models.GetPower2(number1));
                        System.Console.Write("\n \n");
                        // me tengo que esperar a que de a intro
                        break;
                    case 2:
                        UserInterface.PrintMenutSummation();
                        int number2 = UserInterface.ReadUserOption();
                        Models.GetSummation(number2);
                        System.Console.Write("El resultado es: " + Models.GetSummation(number2));
                        System.Console.Write("\n \n");
                        // me tengo que esperar a que de a intro
                        break;
                    case 3:
                        UserInterface.PrintMenuFactorial();
                        int number3 = UserInterface.ReadUserOption();
                        if (number3 >= 0)
                        {
                            Models.GetFactorial(number3);
                            System.Console.Write("El resultado es: " + Models.GetFactorial(number3));
                            System.Console.Write("\n \n");
                            // me tengo que esperar a que de a intro
                        }
                        else
                        {
                            System.Console.WriteLine("Has introducido un número negativo. Recuerda que el factorial de un número negativo no existe. \n \n");
                            // me tengo que esperar a que de a intro
                        }
                        break;
                    case 4:
                        UserInterface.PrintMenuPrime();
                        int number4 = UserInterface.ReadUserOption();
                        Models.IsPrime(number4);
                        System.Console.Write("¿El número introducido es primo? " + Models.IsPrime(number4));
                        System.Console.Write("\n \n");
                        // me tengo que esperar a que de a intro
                        break;
                    case 5:  //NO SÉ COMO REALIZAR ESTE EJERCICIO
                        UserInterface.PrintMenuFibonacci();
                        int number5 = UserInterface.ReadUserOption();
                        Models.IsFibonacci(number5);
                        System.Console.Write("¿El número introducido es primo? " + Models.IsFibonacci(number5));
                        System.Console.Write("\n \n");
                        // me tengo que esperar a que de a intro
                        break;
                    case 0:
                        System.Console.WriteLine("\n                  Gracias por usar la CALCULADORA DE ESTER, esperamos verle pronto.");
                        // me tengo que esperar a que de a intro
                        break;

                }

            }



        }
    }
}
