namespace CorEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int tam = 10)
        {
            System.Console.WriteLine("".PadLeft(tam, '='));
        }
        public static void DibujarTitulo(string titulo)
        {
            DibujarLinea(titulo.Length + 4);
            System.Console.WriteLine($"| {titulo} |");
            DibujarLinea(titulo.Length + 4);
        }
    }
}