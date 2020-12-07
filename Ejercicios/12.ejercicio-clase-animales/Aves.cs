using System;

public abstract class Aves: Animal // <- Herencia
{
    public int Alas { get; set; } // <- Abstraccion

    public string ColorPlumaje { get; set; } // <- Abstraccion
    public void Volar()  // <- Abstraccion
    {
     Console.WriteLine("Volando...");
    }


}