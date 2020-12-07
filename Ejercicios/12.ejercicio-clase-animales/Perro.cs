using System;
public class Perro: Mamifero // <- Herencia
{
    public bool EsDomestico { get; set; }
    
    public bool ParaCazar { get; set; }
    public bool BuenOlfato { get; set; }

    public Perro() // <- Polimorfismo
    {
        EsDomestico = true;
    }

    public Perro(bool esDomestico) // <- Polimorfismo
    {
        EsDomestico = esDomestico;
    }

    public void Ladrar() // <- Abstraccion
    {
        Console.WriteLine("Gua gua gua");
    }

    public void Tamano() // <- Abstraccion
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() // <- Encapsulamiento
    {
        Console.WriteLine("Es un perro grande");
    }

    private void OtroMetodo() // <- Encapsulamiento
    {

    }
}
