namespace ProyectoFinal_ED
{
	partial class FormMatrices
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
			buttonGuardarMatrices = new Button();
			buttonEliminarMatrices = new Button();
			buttonEditarMatrices = new Button();
			buttonMostrarMatrices = new Button();
			buttonBuscarMatrices = new Button();
			buttonOrdenarMatrices = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.ControlLightLight;
			label1.Location = new Point(386, 48);
			label1.Name = "label1";
			label1.Size = new Size(148, 46);
			label1.TabIndex = 0;
			label1.Text = "Matrices";
			// 
			// buttonGuardarMatrices
			// 
			buttonGuardarMatrices.Location = new Point(338, 289);
			buttonGuardarMatrices.Name = "buttonGuardarMatrices";
			buttonGuardarMatrices.Size = new Size(94, 29);
			buttonGuardarMatrices.TabIndex = 1;
			buttonGuardarMatrices.Text = "Guardar";
			buttonGuardarMatrices.UseVisualStyleBackColor = true;
			// 
			// buttonEliminarMatrices
			// 
			buttonEliminarMatrices.Location = new Point(495, 289);
			buttonEliminarMatrices.Name = "buttonEliminarMatrices";
			buttonEliminarMatrices.Size = new Size(94, 29);
			buttonEliminarMatrices.TabIndex = 2;
			buttonEliminarMatrices.Text = "Eliminar";
			buttonEliminarMatrices.UseVisualStyleBackColor = true;
			// 
			// buttonEditarMatrices
			// 
			buttonEditarMatrices.Location = new Point(338, 372);
			buttonEditarMatrices.Name = "buttonEditarMatrices";
			buttonEditarMatrices.Size = new Size(94, 29);
			buttonEditarMatrices.TabIndex = 3;
			buttonEditarMatrices.Text = "Editar";
			buttonEditarMatrices.UseVisualStyleBackColor = true;
			// 
			// buttonMostrarMatrices
			// 
			buttonMostrarMatrices.Location = new Point(495, 372);
			buttonMostrarMatrices.Name = "buttonMostrarMatrices";
			buttonMostrarMatrices.Size = new Size(94, 29);
			buttonMostrarMatrices.TabIndex = 4;
			buttonMostrarMatrices.Text = "Mostrar";
			buttonMostrarMatrices.UseVisualStyleBackColor = true;
			// 
			// buttonBuscarMatrices
			// 
			buttonBuscarMatrices.Location = new Point(495, 451);
			buttonBuscarMatrices.Name = "buttonBuscarMatrices";
			buttonBuscarMatrices.Size = new Size(94, 29);
			buttonBuscarMatrices.TabIndex = 6;
			buttonBuscarMatrices.Text = "Buscar";
			buttonBuscarMatrices.UseVisualStyleBackColor = true;
			// 
			// buttonOrdenarMatrices
			// 
			buttonOrdenarMatrices.Location = new Point(338, 451);
			buttonOrdenarMatrices.Name = "buttonOrdenarMatrices";
			buttonOrdenarMatrices.Size = new Size(94, 29);
			buttonOrdenarMatrices.TabIndex = 5;
			buttonOrdenarMatrices.Text = "Ordenar";
			buttonOrdenarMatrices.UseVisualStyleBackColor = true;
			// 
			// FormMatrices
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(914, 600);
			Controls.Add(buttonOrdenarMatrices);
			Controls.Add(buttonBuscarMatrices);
			Controls.Add(buttonMostrarMatrices);
			Controls.Add(buttonEditarMatrices);
			Controls.Add(buttonEliminarMatrices);
			Controls.Add(buttonGuardarMatrices);
			Controls.Add(label1);
			Margin = new Padding(3, 4, 3, 4);
			Name = "FormMatrices";
			Text = "FormMatrices";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Button buttonGuardarMatrices;
		private Button buttonEliminarMatrices;
		private Button buttonEditarMatrices;
		private Button buttonMostrarMatrices;
		private Button buttonBuscarMatrices;
		private Button buttonOrdenarMatrices;
	}
}