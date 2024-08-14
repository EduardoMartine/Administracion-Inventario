using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cap.Entidad;
using System.Configuration;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Cap.Dato
{
    public class D_Inventario
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Cone"].ConnectionString);


     public List<E_Inventario_Usuarios> D_Usuarios(string Nombre,string contrasena)
        {
            SqlDataReader Leer;
            SqlCommand cmd = new SqlCommand("sp_LeerUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            cmd.Parameters.AddWithValue("@Nombre",Nombre);
            Leer = cmd.ExecuteReader();

            List<E_Inventario_Usuarios> ListaUsuarios = new List<E_Inventario_Usuarios>();
            if (Leer.Read())
            {
                
            }
            cn.Close();
            Leer.Close();
            return ListaUsuarios;
        }
      
       
        public void InsertarUsuarioo(E_Inventario_Usuarios Registro)
        {
            SqlCommand cmd = new SqlCommand("sp_Registrar", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();

            cmd.Parameters.AddWithValue("@Nombre", Registro.Nombre);
            cmd.Parameters.AddWithValue("@Correo", Registro.Correo);
            cmd.Parameters.AddWithValue("@Pass", Registro.Pass);

            cmd.ExecuteNonQuery();
            cn.Close();
        }
        
        public void InsertarProducto(E_Inventario_Productos Registro)
        {
            SqlCommand cmd = new SqlCommand("InsertarProducto", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();


            cmd.Parameters.AddWithValue("@Nombre", Registro.Nombre);
            cmd.Parameters.AddWithValue("@Tipo", Registro.Tipo);
            cmd.Parameters.AddWithValue("@Cantidad", Registro.Cantidad);
            cmd.Parameters.AddWithValue("@Precio", Registro.Precio);
           

            cmd.ExecuteNonQuery();
            cn.Close();

        }
        public void Mostrardato(E_Inventario_Productos Registro)
        {
            SqlCommand cmd = new SqlCommand("Mostrardatos", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();

            cmd.Parameters.AddWithValue("@ID", Registro.ID);

            SqlDataReader reader = cmd.ExecuteReader();

            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void Modificar(E_Inventario_Productos Registro)
        {
            SqlCommand cmd = new SqlCommand("ModificarProducto", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();

            cmd.Parameters.AddWithValue("@ID", Registro.ID);
            cmd.Parameters.AddWithValue("@Nombre", Registro.Nombre);
            cmd.Parameters.AddWithValue("@Tipo", Registro.Tipo);
            cmd.Parameters.AddWithValue("@Cantidad", Registro.Cantidad);
            cmd.Parameters.AddWithValue("@Precio", Registro.Precio);

            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void Eliminarregistro(E_Inventario_Productos Registro)
        {
            SqlCommand cmd = new SqlCommand("EliminarProducto", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();

            cmd.Parameters.AddWithValue("@ID", Registro.ID);

            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public DataTable D_Productos()
        {
            SqlCommand cmd = new SqlCommand("sp_Producto", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool existeUsuario(int idUsuario, string nombreUsuario, string contrasenia)
        {
            bool existe = false;
            try
            {
                cn.Open();
                var comando = new SqlCommand("SELECT * FROM Usuarios WHERE idUsuario = @idUsuario AND nombreUsuario = @nombreUsuario AND contrasenia = @contrasenia", cn);
                comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                comando.Parameters.AddWithValue("@contrasenia", contrasenia);
                var reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    existe = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return existe;
        }

    }   

}
