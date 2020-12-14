using System;

namespace Proyecto_Final
{
    class Program
    {
        static void Main(string[] args)
        {
           MovimientodeCuentas c = new MovimientodeCuentas();
            
            string opcion = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("   Bienvenido   ");
                Console.WriteLine("Cajero Automatico");
                Console.WriteLine("==================");
                Console.WriteLine("");
                
                Console.WriteLine("1 - Saldo de cuenta");
                Console.WriteLine("2 - Retirar");
                Console.WriteLine("3 - Depositar");
                Console.WriteLine("0 - Salir");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write("Elija una opcion:");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        MovimientodeCuentas.ListarCuentas();
                        break;
                    case "2":
                        MovimientodeCuentas.RetiroSaldo();
                        break;
                    case "3":
                        MovimientodeCuentas.DepositoSaldo();
                        break;      
                                              
                    default:
                        break;
                   }
                    if (opcion == "0") {
                    break;
               }
            }   

        }
    }
}
