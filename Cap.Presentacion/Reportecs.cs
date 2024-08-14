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
    public partial class Reportecs : Form
    {
        public Reportecs()
        {
            InitializeComponent();
        }

        private void Reportecs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventarioDataSet.Productos' table. You can move, or remove it, as needed.
            this.productosTableAdapter.Fill(this.inventarioDataSet.Productos);

            this.reportViewer1.RefreshReport();
            
        }
    }
}
