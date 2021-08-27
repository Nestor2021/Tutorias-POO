using System;
using System.Collections.Generic;
using System.Text;

namespace Veterianaria2
{
    class Mascota
    {
        private String nombre;
        private String especie;
        private String raza;
        private double peso;
        private int edad;
        private string sexo;

       

        public string Nombre { get => nombre; set => nombre = value; }
        public string Especie { get => especie; set => especie = value; }
        public string Raza { get => raza; set => raza = value; }
        public double Peso { get => peso; set => peso = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Sexo { get => sexo; set => sexo = value; }

        public void Vacunar() {
            Console.WriteLine("La mascota ha sido vacunada");
        }
        public void Examinar() {
            Console.WriteLine("La mascota ha sido examinada");
        }
        public void Operar() {
            Console.WriteLine("La mascota ha sido operada");
        }

       
        public Mascota(string nombre, string especie)
        {
            this.nombre = nombre;
            this.especie = especie;
            
        }
    }
}
