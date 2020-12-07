using System;
public class Gato: Mamifero // <- Herencia
{
   public string Pelaje { get; set; } // <- Abstraccion
   public bool CaeParado { get; set; }// <- Abstraccion
   

    private void Lamer() // <- Encapsulamiento
    {
        Console.WriteLine("Lamiendo..."); 

    }    
    
   public void Maullar()   // <-Abstraccion
    {
        Console.WriteLine("Miau miau miau");
    }
}
