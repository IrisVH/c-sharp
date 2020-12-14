using System;
using System.Collections.Generic;

public class Cuentas
{
    public int Codigo { get; set; }

    public string Descripcion { get; set; }

    public string Saldo { get; set; }
   

    public Cuentas(int codigo, string descripcion, string saldo)
    {
        Codigo = codigo;
        Descripcion = descripcion;
        Saldo = saldo;
    }

    

}