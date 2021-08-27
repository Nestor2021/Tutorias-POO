using Datos;
using Entidades;
using System;

namespace Negocio
{
    public class NegociosUsuarios
    {
        DatosUsuarios datos = new DatosUsuarios();

        public EntidadUsuario negocioIniciarSesion(EntidadUsuario usuario)
        {
            if (usuario.Nombre == "" || usuario.Contraseña == "")
            {
                Console.WriteLine("Es obligatorio ingresar su nombre y contraseña!");
                return null;
            }
            else
            {
                usuario = datos.iniciarSesion(usuario);

                if(usuario == null)
                {
                    Console.WriteLine("Este usuario no esta registrado en el sistema!");
                    return null;
                }
                else
                {
                    Console.WriteLine("Inicio de sesion exitoso");
                    return usuario;
                }
            }
        }
    }
}
