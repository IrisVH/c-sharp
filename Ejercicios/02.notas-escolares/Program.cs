using System;

namespace notas_escolares
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1= new Alumno();
            alumno1.Codigo=1;
            alumno1.Nombre="Juan";
            alumno1.ingresarNota();

             Alumno alumno2= new Alumno();
            alumno2.Codigo=2;
            alumno2.Nombre="Pedro";
            alumno2.ingresarNota();

            Console.WriteLine("Alumno:"+alumno1.Nombre);
            Console.WriteLine("Alumno:"+ alumno2.Nombre);
        }
    }
}
