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
    public partial class productos : Form
    {
        public productos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        E_Inventario_Productos objEntidad = new E_Inventario_Productos();
        N_Inventario objNegocio = new N_Inventario();

        void LsitarProducto()
        {
            DataTable dt = objNegocio.N_Productos();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productos_Load(object sender, EventArgs e)
        {
            LsitarProducto();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Producto Mostrado");
        }
    }
}
