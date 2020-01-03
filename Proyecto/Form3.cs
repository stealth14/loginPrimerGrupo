using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'nORTHWINDDataSet.Clientes_mexicanos' Puede moverla o quitarla según sea necesario.
            this.clientes_mexicanosTableAdapter.Fill(this.nORTHWINDDataSet.Clientes_mexicanos);

        }

        private void clientes_mexicanosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
