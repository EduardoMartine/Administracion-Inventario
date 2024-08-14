using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cap.Dato;
using Cap.Entidad;

namespace Cap.Negocio
{
    public class N_Inventario
    {
        
        public bool VerificarCredenciales(string nombreUsuario, string contrasena)
        {
            // Aquí llamas al método en la capa de datos que verifica las credenciales en la base de datos
            List<E_Inventario_Usuarios> usuarios = ListaUsuario(nombreUsuario, contrasena); // Suponiendo que este método busca usuarios por nombre de usuario

            // Verifica si se encontró algún usuario con ese nombre
            if (usuarios.Count > 0)
            {
                // Se encontró un usuario con ese nombre, ahora verifica la contraseña
                E_Inventario_Usuarios usuarioEncontrado = usuarios[0]; // Suponiendo que solo hay un usuario con ese nombre

                // Compara las contraseñas
                if (usuarioEncontrado.Pass == contrasena)
                {
                    // La contraseña coincide, inicio de sesión exitoso
                    return true;
                }
            }

            // Si no se encontró usuario con ese nombre o la contraseña no coincide, inicio de sesión fallido
            return false;
        }
        D_Inventario objDato = new D_Inventario();
        public List<E_Inventario_Usuarios> ListaUsuario(string buscar,string contrasena)
        {
            return objDato.D_Usuarios(buscar, contrasena);
        }
        public void Insertando(E_Inventario_Usuarios categoria)
        {
            objDato.InsertarUsuarioo(categoria);
        }
        public DataTable N_Productos()
        {
            return objDato.D_Productos();
        }
        

  
        public void Insertarr(E_Inventario_Productos categoria)
        {
            objDato.InsertarProducto(categoria);
        }

        public void Modificando(E_Inventario_Productos categoria)
        {
            objDato.Modificar(categoria);
        }
        public void EliminandoRegistro(E_Inventario_Productos categoria)
        {
            objDato.Eliminarregistro(categoria);
        }

        public bool IniciarSesion(string nombre, string contrasena)
        {
            throw new NotImplementedException();
        }
    }
}
