namespace ProyectoFinal_ED
{
	partial class FormPilas
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			titulo = new Label();
			boxEntradaDatos = new TextBox();
			buttonRegresar = new Button();
			buttonGuardarPila = new Button();
			buttonOrdenarPila = new Button();
			buttonEliminarPila = new Button();
			buttonEditarPila = new Button();
			buttonMostrarPila = new Button();
			buttonBuscarPila = new Button();
			SuspendLayout();
			// 
			// titulo
			// 
			titulo.AutoSize = true;
			titulo.BackColor = SystemColors.ActiveCaption;
			titulo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			titulo.ForeColor = SystemColors.ControlLightLight;
			titulo.Location = new Point(414, 51);
			titulo.Name = "titulo";
			titulo.Size = new Size(86, 46);
			titulo.TabIndex = 0;
			titulo.Text = "Pilas";
			titulo.Click += label1_Click;
			// 
			// boxEntradaDatos
			// 
			boxEntradaDatos.BackColor = SystemColors.InactiveBorder;
			boxEntradaDatos.BorderStyle = BorderStyle.None;
			boxEntradaDatos.Location = new Point(378, 145);
			boxEntradaDatos.Margin = new Padding(3, 4, 3, 4);
			boxEntradaDatos.Name = "boxEntradaDatos";
			boxEntradaDatos.PlaceholderText = "Nombre de la pelicula";
			boxEntradaDatos.Size = new Size(161, 20);
			boxEntradaDatos.TabIndex = 1;
			// 
			// buttonRegresar
			// 
			buttonRegresar.Location = new Point(796, 553);
			buttonRegresar.Margin = new Padding(3, 4, 3, 4);
			buttonRegresar.Name = "buttonRegresar";
			buttonRegresar.Size = new Size(86, 31);
			buttonRegresar.TabIndex = 8;
			buttonRegresar.Text = "Regresar";
			buttonRegresar.UseVisualStyleBackColor = true;
			buttonRegresar.Click += btnRegresar_Click;
			// 
			// buttonGuardarPila
			// 
			buttonGuardarPila.Location = new Point(335, 257);
			buttonGuardarPila.Margin = new Padding(3, 4, 3, 4);
			buttonGuardarPila.Name = "buttonGuardarPila";
			buttonGuardarPila.Size = new Size(94, 31);
			buttonGuardarPila.TabIndex = 2;
			buttonGuardarPila.Text = "Guardar";
			buttonGuardarPila.UseVisualStyleBackColor = true;
			buttonGuardarPila.Click += buttonGuardarPila_Click;
			// 
			// buttonOrdenarPila
			// 
			buttonOrdenarPila.Location = new Point(335, 420);
			buttonOrdenarPila.Name = "buttonOrdenarPila";
			buttonOrdenarPila.Size = new Size(94, 29);
			buttonOrdenarPila.TabIndex = 6;
			buttonOrdenarPila.Text = "Ordenar";
			buttonOrdenarPila.UseVisualStyleBackColor = true;
			// 
			// buttonEliminarPila
			// 
			buttonEliminarPila.Location = new Point(492, 258);
			buttonEliminarPila.Name = "buttonEliminarPila";
			buttonEliminarPila.Size = new Size(94, 29);
			buttonEliminarPila.TabIndex = 3;
			buttonEliminarPila.Text = "Eliminar";
			buttonEliminarPila.UseVisualStyleBackColor = true;
			// 
			// buttonEditarPila
			// 
			buttonEditarPila.Location = new Point(335, 341);
			buttonEditarPila.Name = "buttonEditarPila";
			buttonEditarPila.Size = new Size(94, 29);
			buttonEditarPila.TabIndex = 4;
			buttonEditarPila.Text = "Editar";
			buttonEditarPila.UseVisualStyleBackColor = true;
			// 
			// buttonMostrarPila
			// 
			buttonMostrarPila.Location = new Point(492, 341);
			buttonMostrarPila.Name = "buttonMostrarPila";
			buttonMostrarPila.Size = new Size(94, 29);
			buttonMostrarPila.TabIndex = 5;
			buttonMostrarPila.Text = "Mostrar";
			buttonMostrarPila.UseVisualStyleBackColor = true;
			// 
			// buttonBuscarPila
			// 
			buttonBuscarPila.Location = new Point(492, 420);
			buttonBuscarPila.Name = "buttonBuscarPila";
			buttonBuscarPila.Size = new Size(94, 29);
			buttonBuscarPila.TabIndex = 7;
			buttonBuscarPila.Text = "Buscar";
			buttonBuscarPila.UseVisualStyleBackColor = true;
			// 
			// FormPilas
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(914, 600);
			Controls.Add(buttonOrdenarPila);
			Controls.Add(buttonBuscarPila);
			Controls.Add(buttonMostrarPila);
			Controls.Add(buttonEditarPila);
			Controls.Add(buttonEliminarPila);
			Controls.Add(buttonGuardarPila);
			Controls.Add(buttonRegresar);
			Controls.Add(boxEntradaDatos);
			Controls.Add(titulo);
			Margin = new Padding(3, 4, 3, 4);
			Name = "FormPilas";
			Text = "FormPilas";
			Load += FormPilas_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label titulo;
		private TextBox boxEntradaDatos;
		private Button buttonRegresar;
		private Button buttonGuardarPila;
		private Button buttonOrdenarPila;
		private Button buttonEliminarPila;
		private Button buttonEditarPila;
		private Button buttonMostrarPila;
		private Button buttonBuscarPila;
	}
}