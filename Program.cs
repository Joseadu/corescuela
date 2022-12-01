using CorEscuela.Entidades;

namespace ProyectoEscuela
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Plazti School", 2012, TiposEscuela.Primaria, pais: "Colombia", ciudad: "Bogotá");
            Console.WriteLine(escuela);

            escuela.Cursos = new List<Curso>(){
                new Curso() {
                    Nombre = "101",
                    Jornada = TiposJornada.Mañana
                },
                    new Curso() {
                    Nombre = "201",
                    Jornada = TiposJornada.Mañana
                },
                    new Curso() {
                    Nombre = "301",
                    Jornada = TiposJornada.Mañana
                }
            };

            escuela.Cursos.Add(
                new Curso() {
                    Nombre = "102",
                    Jornada = TiposJornada.Tarde
                }
            );
            escuela.Cursos.Add(
                new Curso() {
                    Nombre = "202",
                    Jornada = TiposJornada.Tarde
                }
            );

            var otraColeccion = new List<Curso>(){
                new Curso() {
                    Nombre = "401",
                    Jornada = TiposJornada.Tarde
                },
                new Curso() {
                    Nombre = "501",
                    Jornada = TiposJornada.Mañana
                },
                new Curso() {
                    Nombre = "502",
                    Jornada = TiposJornada.Mañana
                }
            };

            System.Console.WriteLine("====================");
            ImprimirCursosEscuela(escuela);
        }

        private static bool removerCurso(Curso cursoRemovido)
        {
            return cursoRemovido.Nombre == "301";
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
    }
}