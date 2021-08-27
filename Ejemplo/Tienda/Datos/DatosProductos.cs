using System;
using Entidades;
namespace Datos
{
    public class DatosProductos
    {
        Producto producto1 = new Producto(1,"Cafe Instantaneo",0.15,"Coscafe",60);
        Producto producto2 = new Producto(2, "Jugo de Naranja", 0.45, "Del valle", 20);
        Producto producto3 = new Producto(3, "Salsa de tomate", 0.60, "Naturas", 30);
        Producto producto4 = new Producto(4, "Consome de Pollo", 0.12, "Continental", 64);
        Producto producto5 = new Producto(5, "Churrito", 0.10, "Diana", 100);

        public Producto buscarProductoPorID(Producto producto)
        {
            if (producto.Id == 1)
            {
                producto = producto1;
                return producto;
            }
            else if (producto.Id == 2)
            {
                producto = producto2;
                return producto;
            }
            else if (producto.Id == 3)
            {
                producto = producto3;
                return producto;
            }
            else if (producto.Id == 4)
            {
                producto = producto4;
                return producto;
            }
            else if (producto.Id == 5)
            {
                producto = producto5;
                return producto;
            }
            else
            {
                return null;
            }

        }

        public Producto venderProducto(Producto producto,int cantidad)
        {
            producto.Existencia = (producto.Existencia - cantidad);

            return producto;
        }
    }
}
