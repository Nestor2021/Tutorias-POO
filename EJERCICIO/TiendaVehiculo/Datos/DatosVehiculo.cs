using System;
using Entidades;

namespace Datos
{
    public class DatosVehiculo
    {
        Vehiculo vehiculo1 = new Vehiculo(1, "Nissan","Sedan", "Azul", 2010,5000.00,15);
        Vehiculo vehiculo2 = new Vehiculo(2, "Toyota", "Sedan", "Rojo", 2012, 7000.00, 25);
        Vehiculo vehiculo3 = new Vehiculo(3, "Jeep", "Camioneta", "Negra", 2013, 8500.00, 35);
        Vehiculo vehiculo4 = new Vehiculo(4, "Honda", "Sedan", "Gris", 2015, 7500.00, 75);
        Vehiculo vehiculo5 = new Vehiculo(1, "Hyundai", "Sedan", "Amarillo", 2007, 4500.00, 100);

        public Vehiculo buscarVehiculoPorID(Vehiculo vehiculo)
        {
            if (vehiculo.Id == 1)
            {
                vehiculo = vehiculo1;
                return vehiculo;
            }
            else if (vehiculo.Id == 2)
            {
                vehiculo = vehiculo2;
                return vehiculo;
            }
            else if (vehiculo.Id == 3)
            {
                vehiculo = vehiculo3;
                return vehiculo;
            }
            else if (vehiculo.Id == 4)
            {
                vehiculo = vehiculo4;
                return vehiculo;
            }
            else if (vehiculo.Id == 5)
            {
                vehiculo = vehiculo5;
                return vehiculo;
            }
            else
            {
                return null;
            }

        }

        public Vehiculo venderProducto(Vehiculo vehiculo, int cantidad)
        {
            vehiculo.Existencia = (vehiculo.Existencia - cantidad);

            return vehiculo;
        }

    }
}
