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
    public partial class Registrocs : Form
    {
        public Registrocs()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox2.Text;
            string correo = textBox1.Text;
            string contraseña = textBox3.Text;

            // Aquí debes llamar al método en tu capa de negocio (N_Inventario) para insertar el nuevo usuario
            N_Inventario capaNegocio = new N_Inventario();
            capaNegocio.Insertando(new E_Inventario_Usuarios
            {
                Nombre = nombre,
                Correo = correo,
                Pass = contraseña
            });

            
            MessageBox.Show("¡Registro exitoso! Ahora puedes iniciar sesión con tu nuevo usuario.");
            Form inv =new Inventario1();
            inv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
