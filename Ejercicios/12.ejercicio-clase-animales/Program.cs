using System;

namespace _12_ejercicio_clase_animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilidades.EnviarCorreo();

            Perro p = new Perro();
            p.Nombre = "Firulais";
            p.Patas = 4;
            p.ParaCazar = true;
            p.BuenOlfato = true;
            p.EsDomestico = true;
            p.Comer();
            p.Caminar();
            p.Ladrar();
            p.Tamano();
            Console.WriteLine(p.Nombre);
            Console.WriteLine(p.Patas);
            Console.WriteLine();

            Gato g = new Gato();
            g.Nombre = "Garfield";
            g.Patas = 4;
            g.Pelaje = "Peludo";
            g.Comer();
            g.Caminar();
            g.Maullar();
            Console.WriteLine(g.Nombre);
            Console.WriteLine(g.Patas);
            Console.WriteLine();

            Mono m = new Mono();
            m.Nombre = "Mike";
            m.Patas = 2;
            m.LeGustanBananas=true;
            m.Comer();
            m.Caminar();
            m.Chillar();
            m.Dormir();
            Console.WriteLine(m.Nombre);
            Console.WriteLine(m.Patas);
            Console.WriteLine();

            Aguila a = new Aguila();
            a.Nombre = "Malcom";
            a.Alas=2;
            a.ColorPlumaje = "Blanco";
            a.Comer();
            a.VolarAlto();
            a.Volar();
            Console.WriteLine(a.Nombre);
            Console.WriteLine(a.ColorPlumaje);
            Console.WriteLine();

            Loro l = new Loro();
            l.Nombre = "Mike";
            a.Alas=2;
            l.ColorPlumaje="verde";
            l.Comer();
            l.Hablar();
            l.Volar();
            Console.WriteLine(l.Nombre);
            Console.WriteLine(l.ColorPlumaje);
            Console.WriteLine();

            Peces P = new Peces();
            P.Nombre = "Marlin";
            P.NumeroAletas = 4;
            P.Comer();
            P.Nadar();
            P.Dormir();
            Console.WriteLine(P.Nombre);
            Console.WriteLine();

            PezGlobo pg = new PezGlobo();
            pg.Nombre = "Ruperto";
            pg.NumeroAletas = 4;
            pg.Comer();
            pg.Dormir();
            pg.Nadar();
            pg.Inflarse();
            Console.WriteLine(pg.Nombre);
            Console.WriteLine();
        }
    }
}