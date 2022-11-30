using System;
using CorEscuela.Entidades;

namespace ProyectoEscuela
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Plazti School", 2012, TiposEscuela.Primaria, pais: "Colombia", ciudad: "Bogotá");
            Console.WriteLine(escuela);
        }
    }
}