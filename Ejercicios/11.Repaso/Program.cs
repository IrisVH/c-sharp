﻿using System;

namespace _11_Repaso_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Utilerias u = new Utilerias();
            u.FormatoMoneda(100);

            Alumno a1 = new Alumno(1, "Juan", "12345");
            Alumno a2 = new Alumno(2, "Pedro", "12345");
            Alumno a3 = new Alumno(3, "Pablo", "12345");
            Alumno a4 = new Alumno(4, "Jose", "12345");

            Profesor p = new Profesor(1, "Jose", 20000);
            Gerente g = new Gerente(1, "Maria", 80000);

            // Persona persona = new Persona();
            // persona.EnviarMensaje("Juan");

            a1.EnviarMensaje();
            p.EnviarMensaje();
            g.EnviarMensaje();


            Console.WriteLine(a1.Nombre + " " + a1.NoCarnet);
            Console.WriteLine(p.Nombre + " " + p.Salario.ToString());
            Console.WriteLine(g.Nombre + " " + g.Salario.ToString());
        }
    }
}
