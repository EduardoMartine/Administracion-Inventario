using Cap.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cap.Dato;
using Cap.Negocio;

namespace Cap.Presentacion
{
    public partial class Anadirproducto : Form
    {


        public Anadirproducto()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
                
               
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            E_Inventario_Productos nuevoProducto = new E_Inventario_Productos();
            nuevoProducto.Nombre = textBox1.Text;
            nuevoProducto.Tipo = textBox2.Text;
            nuevoProducto.Cantidad = textBox3.Text;
            nuevoProducto.Precio = textBox4.Text;

            // Crear una instancia de la capa de negocio
            N_Inventario negocioInventario = new N_Inventario();

            // Llamar al método para insertar el producto
            negocioInventario.Insertarr(nuevoProducto);
            MessageBox.Show("Ingresado");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }
        E_Inventario_Productos objEntidad = new E_Inventario_Productos();
        N_Inventario objNegocio = new N_Inventario();
       
        void LsitarProducto()
        {
            DataTable dt = objNegocio.N_Productos();
            dataGridView1.DataSource = dt;
        }
        private void Anadirproducto_Load(object sender, EventArgs e)
        {
            LsitarProducto();
        }
    }
}
