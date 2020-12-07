using System;
public class Loro: Aves // <- Herencia
{
    public bool EsAdulto { get; set; }
    public void Hablar() // <- Abstraccion
    {
        Console.WriteLine("Hablando...");
    }

    public Loro() // <- Polimorfismo
    {
        EsAdulto = true;
    }

    public Loro(bool EsAdulto) // <- Polimorfismo
    {
      Console.WriteLine("...");  
    }
    
}