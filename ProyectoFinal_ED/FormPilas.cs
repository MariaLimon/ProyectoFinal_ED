﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_ED
{
	public partial class FormPilas : Form
	{
		public FormPilas()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void FormPilas_Load(object sender, EventArgs e)
		{

		}

		private void buttonRegresar_Click(object sender, EventArgs e)
		{
			this.Close();

		}

		private void buttonGuardarPila_Click(object sender, EventArgs e)
		{
			String nombrePelicula = boxEntradaDatos.Text; //obtener texto del tesbox
			MessageBox.Show("la pelicula es:" + nombrePelicula); //mostrar
		}

    }
}
