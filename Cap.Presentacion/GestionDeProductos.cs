using Cap.Dato;
using Cap.Entidad;
using Cap.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap.Presentacion
{
    public partial class GestionDeProductos : Form
    {
        public GestionDeProductos()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void GestionDeProductos_Load(object sender, EventArgs e)
        {
            LsitarProducto();
        }
        E_Inventario_Productos Registro = new E_Inventario_Productos();
        N_Inventario objNegocio = new N_Inventario();
        D_Inventario inventario = new D_Inventario();

        void LsitarProducto()
        {
            DataTable dt = objNegocio.N_Productos();
            dataGridView1.DataSource = dt;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox6.Text);
            string Nombre =textBox1.Text;
            string Tipo =textBox2.Text;
            string Cantidad=textBox3.Text;
            string precio=textBox4.Text;

            Registro.ID = id;
            Registro.Nombre = Nombre;
            Registro.Tipo = Tipo;
            Registro.Cantidad = Cantidad;
            Registro.Precio = precio;

            inventario.Modificar(Registro);

            MessageBox.Show("Producto Modificado");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox6.Text);
            Registro.ID = id;
            inventario.Mostrardato(Registro);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox6.Text);
            Registro.ID = id;
            inventario.Eliminarregistro(Registro);
        }
    }
}
