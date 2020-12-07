using System;
public class Peces:Animal // <- Herencia
{
    public int NumeroAletas { get; set; }  // <- Abstraccion
    public bool DeAguaDulce { get; set; }
    
    public void Nadar()  // <- Abstraccion
    {
        Console.WriteLine("Nadando...");
        
    }
}