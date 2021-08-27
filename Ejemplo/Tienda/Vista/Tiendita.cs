using System;
using Entidades;
using Negocio;
namespace Vista
{
    class Tiendita
    {
        static void Main(string[] args)
        {
            Producto producto = new Producto();
            NegociosProducto negocio = new NegociosProducto();
            Console.WriteLine("Que producto decea comprar? " +
                "\n1 - Cafe Instataneo " +
                "\n2 - Jugo de Naranja " +
                "\n3 - Salsa de Tomate " +
                "\n4 - Consome de Pollo " +
                "\n5 - Churritos ");
            producto.Id = int.Parse(Console.ReadLine());

            producto = negocio.n_buscarproductoPorID(producto);

            if(producto == null)
            {
                Console.WriteLine("Ese producto no se encuentra");
            }
            else
            {
                Console.WriteLine("Datos del producto que va a comprar: " +
                    "\nNombre:  " + producto.Nombre +
                    "\nPrecio:  " + producto.Precio.ToString("00.00") +
                    "\nMarca: " + producto.Marca +
                    "\nExistencias:  " + producto.Existencia +"\n");

                Console.WriteLine("Cuantas unidades va a comprar?");
                int cantidad = int.Parse(Console.ReadLine());

                producto = negocio.n_venderProducto(producto, cantidad);

                if (producto != null)
                {
                    Console.WriteLine("Ahora quedan " + producto.Existencia + " existencias de " + " esta producto");
                }
            }
        }
    }
}
