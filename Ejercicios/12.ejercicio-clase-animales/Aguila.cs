using System;
public class Aguila: Aves // <- Herencia
{
    public bool EsSalvaje { get; set; }
    private int GarrasFilosas { get; set; } // <- Encapsulamiento

    public void VolarAlto() // <- Abstraccion
    {
      Console.WriteLine("Volando alto...");
    }
    public Aguila() // <- Polimorfismo
    {
        EsSalvaje = false;
    }

    public Aguila(bool EsSalvaje) // <- Polimorfismo
    {
       Console.WriteLine("Es salvaje..."); 
    }
}