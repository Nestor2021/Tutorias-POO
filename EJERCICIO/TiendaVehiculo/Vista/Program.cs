using System;
using Negocio;
using Entidades;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo vehiculo = new Vehiculo();
            NegociosVehiculo negocio = new NegociosVehiculo();
            Console.WriteLine("Que Vehiculo decea comprar? " +
                "\n1 - NISSAN " +
                "\n2 - TOYOTA " +
                "\n3 - JEEP " +
                "\n4 - HONDA " +
                "\n5 - HYUNDAI " +
                "\n -------------------------------------------------");
            vehiculo.Id = int.Parse(Console.ReadLine());

            vehiculo = negocio.n_buscarvehiculoPorID(vehiculo);

            if (vehiculo == null)
            {
                Console.WriteLine("Ese Vehiculo no se encuentra por el momento");
            }
            else
            {
                Console.WriteLine("Datos del Vehiculo que decea adquirir: " +
                    " " +
                    "\nMarca:  " + vehiculo.Marca +
                    "\nModelo:  " + vehiculo.Modelo +
                    "\nColor:  " + vehiculo.Color +
                    "\nAño:  " + vehiculo.Año +
                    "\nPrecio:  " + vehiculo.Precio.ToString("00.00") +
                    "\nExistencias:  " + vehiculo.Existencia +
                    "\n -------------------------------------------------");

                Console.WriteLine("Cuantos vehiculos decea comprar comprar?");
                int cantidad = int.Parse(Console.ReadLine());

                vehiculo = negocio.n_venderVehiculo(vehiculo, cantidad);

                if (vehiculo != null)
                {
                    Console.WriteLine("Ahora quedan " + vehiculo.Existencia + " existencias de " + " vehiculos");
                }
            }
        }
    }
}
