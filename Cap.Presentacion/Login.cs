using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cap.Negocio;
using Cap.Entidad;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Cap.Dato;
using System.Data.SqlClient;

namespace Cap.Presentacion
{
    public partial class Login : Form
    {
        
        private D_Inventario _dInventario;
        private N_Inventario bn = new N_Inventario();
        public Login()
        {
            InitializeComponent();
        }
        private E_Inventario_Usuarios ObtenerCategoriaDesdeInterfaz()
        {
            E_Inventario_Usuarios categoria = new E_Inventario_Usuarios();

            categoria.Nombre = textBox1.Text;
            categoria.Pass= textBox2.Text;
          
            return categoria;


        }
        E_Inventario_Usuarios Registro = new E_Inventario_Usuarios();
        D_Inventario inventario = new D_Inventario();
        private void button1_Click(object sender, EventArgs e)
        {
            Form inv = new Inventario1();
            inv.Show();
            this.Hide();
            MessageBox.Show("Iniciado Correctamente Admin");



        }
        N_Inventario objNegocio = new N_Inventario();
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox2.BringToFront();
            textBox2.PasswordChar= '\0';
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox3.BringToFront();
            textBox2.PasswordChar = '*';
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Registro = new Registrocs();
            Registro.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form inv = new Inventario1();
            inv.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            _dInventario = new D_Inventario();
        }
    }
}
