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
			SuspendLayout();
			// 
			// titulo
			// 
			titulo.AutoSize = true;
			titulo.BackColor = SystemColors.ActiveCaption;
			titulo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			titulo.ForeColor = SystemColors.ControlLightLight;
			titulo.Location = new Point(362, 38);
			titulo.Name = "titulo";
			titulo.Size = new Size(71, 37);
			titulo.TabIndex = 0;
			titulo.Text = "Pilas";
			titulo.Click += label1_Click;
			// 
			// boxEntradaDatos
			// 
			boxEntradaDatos.BackColor = SystemColors.InactiveBorder;
			boxEntradaDatos.BorderStyle = BorderStyle.None;
			boxEntradaDatos.Location = new Point(331, 109);
			boxEntradaDatos.Name = "boxEntradaDatos";
			boxEntradaDatos.PlaceholderText = "Nombre de la pelicula";
			boxEntradaDatos.Size = new Size(141, 16);
			boxEntradaDatos.TabIndex = 1;
			// 
			// buttonRegresar
			// 
			buttonRegresar.Location = new Point(696, 415);
			buttonRegresar.Name = "buttonRegresar";
			buttonRegresar.Size = new Size(75, 23);
			buttonRegresar.TabIndex = 2;
			buttonRegresar.Text = "Regresar";
			buttonRegresar.UseVisualStyleBackColor = true;
			buttonRegresar.Click += btnRegresar_Click;
			// 
			// buttonGuardarPila
			// 
			buttonGuardarPila.Location = new Point(144, 278);
			buttonGuardarPila.Name = "buttonGuardarPila";
			buttonGuardarPila.Size = new Size(75, 23);
			buttonGuardarPila.TabIndex = 3;
			buttonGuardarPila.Text = "Guardar";
			buttonGuardarPila.UseVisualStyleBackColor = true;
			buttonGuardarPila.Click += buttonGuardarPila_Click;
			// 
			// FormPilas
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(800, 450);
			Controls.Add(buttonGuardarPila);
			Controls.Add(buttonRegresar);
			Controls.Add(boxEntradaDatos);
			Controls.Add(titulo);
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
	}
}