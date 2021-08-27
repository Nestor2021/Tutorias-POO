using System;
using Datos;
using Entidades;

namespace Negocio
{
    public class NegociosVehiculo
    {
        DatosVehiculo datos = new DatosVehiculo();

        public Vehiculo n_buscarvehiculoPorID(Vehiculo vehiculo)
        {
            if (vehiculo.Id < 1 || vehiculo.Id > 5)
            {
                return null;
            }
            else
            {
                vehiculo = datos.buscarVehiculoPorID(vehiculo);

                if (vehiculo == null)
                {
                    return null;
                }
                else
                {
                    return vehiculo;
                }
            }

        }

        public Vehiculo n_venderVehiculo(Vehiculo vehiculo, int cantidad)
        {
            if (cantidad > vehiculo.Existencia)
            {
                Console.WriteLine("Lo sentimos, no puedes comprar mas de " + vehiculo.Existencia + " vehiculos");
                return null;
            }
            else
            {
                vehiculo = datos.venderProducto(vehiculo, cantidad);
                Console.WriteLine("Se realizo una venta de  " + cantidad + " vehiculo,  de marca  " + vehiculo.Marca
                    + "\nTotal de la venta $ " + calcularTotal(vehiculo.Precio, cantidad).ToString("00.00"));
                return vehiculo;
            }
        }
        public double calcularTotal(double precio, int cantidad)
        {
            double total = (precio * cantidad);
            return total;
        }


    }
}
