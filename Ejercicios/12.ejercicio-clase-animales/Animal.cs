using System;
public abstract class Animal
{
    public string Nombre { get; set; } // <- Abstraccion
    public void Dormir()   // <- Abstraccion
    { 
     Console.WriteLine("Durmiendo...");
    }
    
    public void Comer()  // <- Abstraccion
    {
        Console.WriteLine("Comiendo...");
    }
}