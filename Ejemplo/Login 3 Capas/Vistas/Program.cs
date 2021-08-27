using System;
using Entidades;
using Negocio;

namespace Vistas
{
    class Program
    {
        static void Main(string[] args)
        {
            EntidadUsuario usuario = new EntidadUsuario();
            NegociosUsuarios negocio = new NegociosUsuarios();

            Console.WriteLine("BIENVENIDO AL SISTEMA " + 
                "/nPara iniciar debe ingresar su nombre: ");
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Ahora ingrese su contraseña:");
            usuario.Contraseña = Console.ReadLine();

            usuario = negocio.negocioIniciarSesion(usuario);

            if (usuario == null)
            {
                Console.WriteLine("Lo sentimos");
            }
            else
            {
                Console.WriteLine("Bienvenido " + usuario.Nombre + " al sistema" +
                    "/n A continuacion le mostraremos sus datos: " +
                    "/nnombre: " + usuario.Nombre +
                    "/nedad: " + usuario.Edad +
                    "/nrol: " + usuario.Rol);
            }
        }
    }
}
