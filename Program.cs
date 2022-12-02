using CorEscuela.Entidades;
using CorEscuela.Util;

namespace ProyectoEscuela
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();

            Printer.DibujarTitulo("Bienvenidos a la escuela");
            ImprimirCursosEscuela(engine.Escuela);
        }

        private static bool removerCurso(Curso cursoRemovido)
        {
            return cursoRemovido.Nombre == "301";
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.DibujarTitulo("Cursos de la escuela");

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