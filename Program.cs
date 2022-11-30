namespace Escuela
{
    public class Escuela
    {
        public string nombre;
        public string direccion;
        public int añoFundacion;

        public void Timbrar()
        {
            Console.Beep(1000, 1500);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var miEscuela = new Escuela();
                miEscuela.nombre = "Platzi";
                miEscuela.direccion = "Joaquín Turina 14";
                miEscuela.añoFundacion = 30;
                miEscuela.Timbrar();
            
            Console.WriteLine(miEscuela);
        }
    }
}