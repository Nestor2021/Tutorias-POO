using System;

namespace Entidades
{
    public class Vehiculo
    {
        private int id;
        private string marca;
        private string modelo;
        private string color;
        private int año;
        private double precio;
        private int existencia;

        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }
        public int Año { get => año; set => año = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Existencia { get => existencia; set => existencia = value; }
        
        public Vehiculo() { }

        public Vehiculo(int id, string marca, string modelo, string color, int año, double precio, int existencia)
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.año = año;
            this.precio = precio;
            this.existencia = existencia;
        }
    }
}
