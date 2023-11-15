namespace ProyectoFinal_ED
{
	partial class FormColas
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
			buttonOrdenarColas = new Button();
			buttonBuscarColas = new Button();
			buttonMostrarColas = new Button();
			buttonEditarColas = new Button();
			buttonEliminarColas = new Button();
			buttonGuardarColas = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.ControlLightLight;
			label1.Location = new Point(391, 67);
			label1.Name = "label1";
			label1.Size = new Size(100, 46);
			label1.TabIndex = 0;
			label1.Text = "Colas";
			// 
			// buttonOrdenarColas
			// 
			buttonOrdenarColas.Location = new Point(321, 450);
			buttonOrdenarColas.Name = "buttonOrdenarColas";
			buttonOrdenarColas.Size = new Size(94, 29);
			buttonOrdenarColas.TabIndex = 11;
			buttonOrdenarColas.Text = "Ordenar";
			buttonOrdenarColas.UseVisualStyleBackColor = true;
			// 
			// buttonBuscarColas
			// 
			buttonBuscarColas.Location = new Point(478, 450);
			buttonBuscarColas.Name = "buttonBuscarColas";
			buttonBuscarColas.Size = new Size(94, 29);
			buttonBuscarColas.TabIndex = 12;
			buttonBuscarColas.Text = "Buscar";
			buttonBuscarColas.UseVisualStyleBackColor = true;
			// 
			// buttonMostrarColas
			// 
			buttonMostrarColas.Location = new Point(478, 371);
			buttonMostrarColas.Name = "buttonMostrarColas";
			buttonMostrarColas.Size = new Size(94, 29);
			buttonMostrarColas.TabIndex = 10;
			buttonMostrarColas.Text = "Mostrar";
			buttonMostrarColas.UseVisualStyleBackColor = true;
			buttonMostrarColas.Click += buttonMostrarMatrices_Click;
			// 
			// buttonEditarColas
			// 
			buttonEditarColas.Location = new Point(321, 371);
			buttonEditarColas.Name = "buttonEditarColas";
			buttonEditarColas.Size = new Size(94, 29);
			buttonEditarColas.TabIndex = 9;
			buttonEditarColas.Text = "Editar";
			buttonEditarColas.UseVisualStyleBackColor = true;
			// 
			// buttonEliminarColas
			// 
			buttonEliminarColas.Location = new Point(478, 288);
			buttonEliminarColas.Name = "buttonEliminarColas";
			buttonEliminarColas.Size = new Size(94, 29);
			buttonEliminarColas.TabIndex = 8;
			buttonEliminarColas.Text = "Eliminar";
			buttonEliminarColas.UseVisualStyleBackColor = true;
			// 
			// buttonGuardarColas
			// 
			buttonGuardarColas.Location = new Point(321, 288);
			buttonGuardarColas.Name = "buttonGuardarColas";
			buttonGuardarColas.Size = new Size(94, 29);
			buttonGuardarColas.TabIndex = 7;
			buttonGuardarColas.Text = "Guardar";
			buttonGuardarColas.UseVisualStyleBackColor = true;
			// 
			// FormColas
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(914, 600);
			Controls.Add(buttonOrdenarColas);
			Controls.Add(buttonBuscarColas);
			Controls.Add(buttonMostrarColas);
			Controls.Add(buttonEditarColas);
			Controls.Add(buttonEliminarColas);
			Controls.Add(buttonGuardarColas);
			Controls.Add(label1);
			Margin = new Padding(3, 4, 3, 4);
			Name = "FormColas";
			Text = "FormColas";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Button buttonOrdenarColas;
		private Button buttonBuscarColas;
		private Button buttonMostrarColas;
		private Button buttonEditarColas;
		private Button buttonEliminarColas;
		private Button buttonGuardarColas;
	}
}