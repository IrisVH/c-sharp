using System;
public class Mono : Mamifero // <- Herencia


{
 private int Manos { get; set; }  // <- Encapsulamiento
 public bool LeGustanBananas { get; set; }  // <- Abstraccion

  public void Chillar()  // <- Abstraccion
 {
  Console.WriteLine("Uuaa uuaa uuaa");
 }
}

 
