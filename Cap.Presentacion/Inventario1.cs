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
    public partial class Inventario1 : Form
    {
        public Inventario1()
        {
            InitializeComponent();
        }
        private void AbrirForm(object formhija)
        {
            if(this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fh);
            this.panel2.Tag = fh;
            fh.Show();
        }
        private void AbrirFormm(object formhija)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fh);
            this.panel2.Tag = fh;
            fh.ShowDialog();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AbrirForm(new productos());
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            AbrirForm(new Anadirproducto());
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            AbrirForm(new GestionDeProductos());
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            AbrirForm(new Reportecs());
            
        }
    }
}
