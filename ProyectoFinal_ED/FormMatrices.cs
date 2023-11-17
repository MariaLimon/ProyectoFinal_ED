using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_ED
{
	public partial class FormMatrices : Form
	{
		public FormMatrices()
		{
			InitializeComponent();
		}

        private void buttonGuardarMatrices_Click(object sender, EventArgs e)
        {
            String nombrePelicula = boxEntradaDatos.Text; //obtener texto del tesbox
            MessageBox.Show("la pelicula es:" + nombrePelicula); //mostrar
        }

        
    }
}
