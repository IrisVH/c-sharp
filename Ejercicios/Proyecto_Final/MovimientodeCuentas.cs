using System;
public class MovimientodeCuentas

{
      public static string[,] cuentas= new string[5,3]
        {
            {"001","Juan Reyes    ","10000"},
            {"002","Carlos Perez  ","50000"},
            {"003","Mauricio Islas","20000"},
            {"004","Raul Ortega   ","100000"},
            {"005","Maria Diaz    ","20000"},

           
        };
         public static void ListarCuentas(){
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Listado de Cuentas de Clientes");
            Console.WriteLine("*******************************");
            Console.WriteLine("Codigo, Descripcion  y  Saldo");

            for (int i = 0; i < 5; i++)
            {
              Console.WriteLine(cuentas[i,0]+" |  "+ cuentas[i,1]+"  |  "+ cuentas[i,2]);  
            }
            Console.ReadLine();
        }

       
        public static void movimientoSaldo(string codigo,int cantidad,string tipoMovimiento){
             for (int i = 0; i < 5; i++)
            {
               if (cuentas[i,0]==codigo){
                   if (tipoMovimiento=="+"){
                    cuentas[i,2]=(Int32.Parse(cuentas[i,2])+cantidad).ToString();
                   }else{
                    cuentas[i,2]=(Int32.Parse(cuentas[i,2])-cantidad).ToString();
                   }
                   
               }
            }
        }




           public static void RetiroSaldo(){
           string cantidad="";
           string codigo="";
           
           Console.Clear();
           Console.WriteLine();
           Console.WriteLine("Retiro de saldo");
           Console.WriteLine("***************");
           Console.Write("Ingrese el codigo del Cliente: ");
           codigo = Console.ReadLine();
           if (codigo == null)
        {
            Console.WriteLine("Cuenta no encontrada");
            Console.ReadLine();
            return;
        }  else
         {
           Console.Write("Ingrese la cantidad a Retirar: ");
           cantidad = Console.ReadLine();
           movimientoSaldo(cantidad,Int32.Parse(cantidad),"-");
            Console.WriteLine("Desea continuar? s/n");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n") {
             return;
            }
        }
           
           
        }

    
           public static void DepositoSaldo(){
           string cantidad="";
           string codigo="";
           
           Console.Clear();
           Console.WriteLine();
           Console.WriteLine("Deposito");
           Console.WriteLine("********");
           Console.Write("Ingrese el codigo del Cliente: ");
           codigo = Console.ReadLine();
           
           
           if (codigo == null)
          
            {
            Console.WriteLine("Cuenta no encontrada");
            Console.ReadLine();
            return;
            } else {
           Console.Write("Ingrese la cantidad a depositar:");
           cantidad=Console.ReadLine();
           movimientoSaldo(cantidad,Int32.Parse(cantidad),"+"); 
          }
            Console.WriteLine("Desea continuar? s/n");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n") {
             return;
            }
        }
    
       
    }

