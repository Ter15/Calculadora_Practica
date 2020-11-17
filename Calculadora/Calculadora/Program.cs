using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface.PrintMenu();
            int option = UserInterface.ReadUserOption();

            switch (option)
            {
                case 1:

                    UserInterface.PrintMenuPower2();
                    int numero = UserInterface.ReadUserOption();
                    Models.GetPower2(numero);
                    break;
            }
           



        }
    }
}
