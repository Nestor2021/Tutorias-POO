using System;

namespace Veterianaria2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veterinaria");

            //Declarar una Mascota
            Mascota Perro = new Mascota("Firulais","Perro");

            Console.WriteLine("El nombre de la mascota es: " + Perro.Nombre);
            Perro.Nombre = "Dogi";
            Console.WriteLine("El nombre de la mascota es: " + Perro.Nombre);
            Console.WriteLine("El especie de la mascota es: " + Perro.Especie);
        }
    }
}
