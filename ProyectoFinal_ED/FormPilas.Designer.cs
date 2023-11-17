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
            this.titulo = new System.Windows.Forms.Label();
            this.boxEntradaDatos = new System.Windows.Forms.TextBox();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.buttonGuardarPila = new System.Windows.Forms.Button();
            this.buttonOrdenarPila = new System.Windows.Forms.Button();
            this.buttonEliminarPila = new System.Windows.Forms.Button();
            this.buttonEditarPila = new System.Windows.Forms.Button();
            this.buttonMostrarPila = new System.Windows.Forms.Button();
            this.buttonBuscarPila = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.titulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titulo.Location = new System.Drawing.Point(362, 38);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(71, 37);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Pilas";
            // 
            // boxEntradaDatos
            // 
            this.boxEntradaDatos.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.boxEntradaDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxEntradaDatos.Location = new System.Drawing.Point(331, 109);
            this.boxEntradaDatos.Name = "boxEntradaDatos";
            this.boxEntradaDatos.PlaceholderText = "Nombre de la pelicula";
            this.boxEntradaDatos.Size = new System.Drawing.Size(141, 16);
            this.boxEntradaDatos.TabIndex = 1;
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Location = new System.Drawing.Point(696, 415);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(75, 23);
            this.buttonRegresar.TabIndex = 8;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // buttonGuardarPila
            // 
            this.buttonGuardarPila.Location = new System.Drawing.Point(293, 193);
            this.buttonGuardarPila.Name = "buttonGuardarPila";
            this.buttonGuardarPila.Size = new System.Drawing.Size(82, 23);
            this.buttonGuardarPila.TabIndex = 2;
            this.buttonGuardarPila.Text = "Guardar";
            this.buttonGuardarPila.UseVisualStyleBackColor = true;
            this.buttonGuardarPila.Click += new System.EventHandler(this.buttonGuardarPila_Click);
            // 
            // buttonOrdenarPila
            // 
            this.buttonOrdenarPila.Location = new System.Drawing.Point(293, 315);
            this.buttonOrdenarPila.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOrdenarPila.Name = "buttonOrdenarPila";
            this.buttonOrdenarPila.Size = new System.Drawing.Size(82, 22);
            this.buttonOrdenarPila.TabIndex = 6;
            this.buttonOrdenarPila.Text = "Ordenar";
            this.buttonOrdenarPila.UseVisualStyleBackColor = true;
            // 
            // buttonEliminarPila
            // 
            this.buttonEliminarPila.Location = new System.Drawing.Point(430, 194);
            this.buttonEliminarPila.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEliminarPila.Name = "buttonEliminarPila";
            this.buttonEliminarPila.Size = new System.Drawing.Size(82, 22);
            this.buttonEliminarPila.TabIndex = 3;
            this.buttonEliminarPila.Text = "Eliminar";
            this.buttonEliminarPila.UseVisualStyleBackColor = true;
            // 
            // buttonEditarPila
            // 
            this.buttonEditarPila.Location = new System.Drawing.Point(293, 256);
            this.buttonEditarPila.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditarPila.Name = "buttonEditarPila";
            this.buttonEditarPila.Size = new System.Drawing.Size(82, 22);
            this.buttonEditarPila.TabIndex = 4;
            this.buttonEditarPila.Text = "Editar";
            this.buttonEditarPila.UseVisualStyleBackColor = true;
            // 
            // buttonMostrarPila
            // 
            this.buttonMostrarPila.Location = new System.Drawing.Point(430, 256);
            this.buttonMostrarPila.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMostrarPila.Name = "buttonMostrarPila";
            this.buttonMostrarPila.Size = new System.Drawing.Size(82, 22);
            this.buttonMostrarPila.TabIndex = 5;
            this.buttonMostrarPila.Text = "Mostrar";
            this.buttonMostrarPila.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarPila
            // 
            this.buttonBuscarPila.Location = new System.Drawing.Point(430, 315);
            this.buttonBuscarPila.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarPila.Name = "buttonBuscarPila";
            this.buttonBuscarPila.Size = new System.Drawing.Size(82, 22);
            this.buttonBuscarPila.TabIndex = 7;
            this.buttonBuscarPila.Text = "Buscar";
            this.buttonBuscarPila.UseVisualStyleBackColor = true;
            // 
            // FormPilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOrdenarPila);
            this.Controls.Add(this.buttonBuscarPila);
            this.Controls.Add(this.buttonMostrarPila);
            this.Controls.Add(this.buttonEditarPila);
            this.Controls.Add(this.buttonEliminarPila);
            this.Controls.Add(this.buttonGuardarPila);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.boxEntradaDatos);
            this.Controls.Add(this.titulo);
            this.Name = "FormPilas";
            this.Text = "FormPilas";
            this.ResumeLayout(false);
            this.PerformLayout();

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