using CorEscuela.Entidades;

namespace ProyectoEscuela
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Plazti School", 2012, TiposEscuela.Primaria, pais: "Colombia", ciudad: "Bogotá");
            Console.WriteLine(escuela);

            escuela.Cursos = new Curso[] {
                    new Curso() {
                    Nombre = "101"
                },
                    new Curso() {
                    Nombre = "201"
                },
                    new Curso() {
                    Nombre = "301"
                }
            };

            ImprimirCursosEscuela(escuela);
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Console.WriteLine("====================");
            Console.WriteLine("Cursos de la escuela");
            Console.WriteLine("====================");

            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    System.Console.WriteLine($"Nombre {curso.Nombre}, Id{curso.UniqueId}");
                }
            }
        }
        // private static void ImprimirCursos(Curso[] arrayCursos)
        // {
        //     foreach (var curso in arrayCursos)
        //     {
        //         System.Console.WriteLine($"Nombre {curso.Nombre}, Id{curso.UniqueId}");
        //     }
        // }
    }
}