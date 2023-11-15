namespace ProyectoFinal_ED
{
	partial class FormListas
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
			label1 = new Label();
			buttonOrdenarListas = new Button();
			buttonBuscarListas = new Button();
			buttonMostrarListas = new Button();
			buttonEditarListas = new Button();
			buttonEliminarListas = new Button();
			buttonGuardarListas = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.ControlLightLight;
			label1.Location = new Point(413, 61);
			label1.Name = "label1";
			label1.Size = new Size(101, 46);
			label1.TabIndex = 0;
			label1.Text = "Listas";
			label1.Click += label1_Click;
			// 
			// buttonOrdenarListas
			// 
			buttonOrdenarListas.Location = new Point(335, 500);
			buttonOrdenarListas.Name = "buttonOrdenarListas";
			buttonOrdenarListas.Size = new Size(94, 29);
			buttonOrdenarListas.TabIndex = 17;
			buttonOrdenarListas.Text = "Ordenar";
			buttonOrdenarListas.UseVisualStyleBackColor = true;
			// 
			// buttonBuscarListas
			// 
			buttonBuscarListas.Location = new Point(492, 500);
			buttonBuscarListas.Name = "buttonBuscarListas";
			buttonBuscarListas.Size = new Size(94, 29);
			buttonBuscarListas.TabIndex = 18;
			buttonBuscarListas.Text = "Buscar";
			buttonBuscarListas.UseVisualStyleBackColor = true;
			// 
			// buttonMostrarListas
			// 
			buttonMostrarListas.Location = new Point(492, 421);
			buttonMostrarListas.Name = "buttonMostrarListas";
			buttonMostrarListas.Size = new Size(94, 29);
			buttonMostrarListas.TabIndex = 16;
			buttonMostrarListas.Text = "Mostrar";
			buttonMostrarListas.UseVisualStyleBackColor = true;
			// 
			// buttonEditarListas
			// 
			buttonEditarListas.Location = new Point(335, 421);
			buttonEditarListas.Name = "buttonEditarListas";
			buttonEditarListas.Size = new Size(94, 29);
			buttonEditarListas.TabIndex = 15;
			buttonEditarListas.Text = "Editar";
			buttonEditarListas.UseVisualStyleBackColor = true;
			// 
			// buttonEliminarListas
			// 
			buttonEliminarListas.Location = new Point(492, 338);
			buttonEliminarListas.Name = "buttonEliminarListas";
			buttonEliminarListas.Size = new Size(94, 29);
			buttonEliminarListas.TabIndex = 14;
			buttonEliminarListas.Text = "Eliminar";
			buttonEliminarListas.UseVisualStyleBackColor = true;
			// 
			// buttonGuardarListas
			// 
			buttonGuardarListas.Location = new Point(335, 338);
			buttonGuardarListas.Name = "buttonGuardarListas";
			buttonGuardarListas.Size = new Size(94, 29);
			buttonGuardarListas.TabIndex = 13;
			buttonGuardarListas.Text = "Guardar";
			buttonGuardarListas.UseVisualStyleBackColor = true;
			// 
			// FormListas
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(914, 600);
			Controls.Add(buttonOrdenarListas);
			Controls.Add(buttonBuscarListas);
			Controls.Add(buttonMostrarListas);
			Controls.Add(buttonEditarListas);
			Controls.Add(buttonEliminarListas);
			Controls.Add(buttonGuardarListas);
			Controls.Add(label1);
			Margin = new Padding(3, 4, 3, 4);
			Name = "FormListas";
			Text = "FormListas";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Button buttonOrdenarListas;
		private Button buttonBuscarListas;
		private Button buttonMostrarListas;
		private Button buttonEditarListas;
		private Button buttonEliminarListas;
		private Button buttonGuardarListas;
	}
}