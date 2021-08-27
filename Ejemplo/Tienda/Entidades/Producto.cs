using System;

namespace Entidades
{
    public class Producto
    {
        private int id;
        private string nombre;
        private double precio;
        private string marca;
        private int existencia;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Existencia { get => existencia; set => existencia = value; }

        public Producto() { }

        public Producto(int id, string nombre, double precio, string marca, int existencia)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.marca = marca;
            this.existencia = existencia;
        }
    }
}
