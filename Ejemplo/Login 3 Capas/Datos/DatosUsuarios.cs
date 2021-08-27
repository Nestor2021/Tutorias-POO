using System;
using Entidades;

namespace Datos
{
    public class DatosUsuarios
    {
        //Declarar objetos de tipo usuario
        //Estos simularan ser nuestra base de datos
        EntidadUsuario admin = new EntidadUsuario("Nestor", "12345", 20, "Administrador");
        EntidadUsuario usuario1 = new EntidadUsuario("Marcos", "12345", 20, "Uusario Normal");
        EntidadUsuario usuario2 = new EntidadUsuario("Daniel", "12345", 18, "Uusario Normal");

        //Metodo para iniciar sesion en el sistema
        public EntidadUsuario iniciarSesion(EntidadUsuario usuario)
        {
            //Lo primero es cverificar el nombre y l contaseña del usuario
            if (usuario.Nombre == admin.Nombre && usuario.Contraseña == admin.Contraseña)
            {
                usuario = admin;
                return usuario;
            }
            else if (usuario.Nombre == usuario1.Nombre && usuario.Contraseña == usuario1.Contraseña)
            {
                usuario = usuario1;
                return usuario;

            }
            else if (usuario.Nombre == usuario2.Nombre && usuario.Contraseña == usuario2.Contraseña)
            {
                usuario = usuario2;
                return usuario;
            }
            else
            {
                return null;
            }
        }
    }
}
