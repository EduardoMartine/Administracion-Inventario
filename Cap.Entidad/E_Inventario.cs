using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap.Entidad
{
    public class E_Inventario_Usuarios
    {
        
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Rol { get; set; }
        public string Correo { get; set; }
        public string Pass { get; set; }
           
   
    }
    public class E_Inventario_Productos
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Cantidad { get; set; }
        public string Precio { get; set; }
    }
}
