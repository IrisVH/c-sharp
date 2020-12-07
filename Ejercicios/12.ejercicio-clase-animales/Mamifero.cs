using System;

public abstract class Mamifero: Animal
{
    public int Patas { get; set; }  // <- Abstraccion

    public void Caminar()   // <- Abstraccion
    {
        Console.WriteLine("Caminando...");
    }
}