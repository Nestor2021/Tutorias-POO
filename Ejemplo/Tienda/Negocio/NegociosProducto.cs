using System;
using Entidades;
using Datos;


namespace Negocio
{
    public class NegociosProducto
    {
        DatosProductos datos = new DatosProductos();

        public Producto n_buscarproductoPorID(Producto producto)
        {
            if(producto.Id < 1 || producto.Id > 5)
            {
                return null;
            }
            else
            {
                producto = datos.buscarProductoPorID(producto);

                if(producto == null)
                {
                    return null;
                }
                else
                {
                    return producto;
                }
            }
            
        }
        public Producto n_venderProducto(Producto producto,int cantidad)
        {
            if(cantidad > producto.Existencia)
            {
                Console.WriteLine("Lo sentimos, no puedes comprar mas de " + producto.Existencia + " unidades");
                return null;
            }
            else
            {
                producto = datos.venderProducto(producto, cantidad);
                Console.WriteLine("Se vendieron " + cantidad + " unidades de " + producto.Nombre
                    + "\nTotal de la venta $ " + calcularTotal(producto.Precio, cantidad).ToString("00.00"));
                return producto;
            }
        }

        public double calcularTotal(double precio,int cantidad)
        {
            double total = (precio * cantidad);
            return total;
        }
    }
}
