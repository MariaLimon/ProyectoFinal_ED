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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGuardarMatrices = new System.Windows.Forms.Button();
            this.buttonEliminarMatrices = new System.Windows.Forms.Button();
            this.buttonEditarMatrices = new System.Windows.Forms.Button();
            this.buttonMostrarMatrices = new System.Windows.Forms.Button();
            this.buttonBuscarMatrices = new System.Windows.Forms.Button();
            this.buttonOrdenarMatrices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(338, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrices";
            // 
            // buttonGuardarMatrices
            // 
            this.buttonGuardarMatrices.Location = new System.Drawing.Point(296, 217);
            this.buttonGuardarMatrices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGuardarMatrices.Name = "buttonGuardarMatrices";
            this.buttonGuardarMatrices.Size = new System.Drawing.Size(82, 22);
            this.buttonGuardarMatrices.TabIndex = 1;
            this.buttonGuardarMatrices.Text = "Guardar";
            this.buttonGuardarMatrices.UseVisualStyleBackColor = true;
            this.buttonGuardarMatrices.Click += new System.EventHandler(this.buttonGuardarMatrices_Click);
            // 
            // buttonEliminarMatrices
            // 
            this.buttonEliminarMatrices.Location = new System.Drawing.Point(433, 217);
            this.buttonEliminarMatrices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEliminarMatrices.Name = "buttonEliminarMatrices";
            this.buttonEliminarMatrices.Size = new System.Drawing.Size(82, 22);
            this.buttonEliminarMatrices.TabIndex = 2;
            this.buttonEliminarMatrices.Text = "Eliminar";
            this.buttonEliminarMatrices.UseVisualStyleBackColor = true;
            // 
            // buttonEditarMatrices
            // 
            this.buttonEditarMatrices.Location = new System.Drawing.Point(296, 279);
            this.buttonEditarMatrices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditarMatrices.Name = "buttonEditarMatrices";
            this.buttonEditarMatrices.Size = new System.Drawing.Size(82, 22);
            this.buttonEditarMatrices.TabIndex = 3;
            this.buttonEditarMatrices.Text = "Editar";
            this.buttonEditarMatrices.UseVisualStyleBackColor = true;
            // 
            // buttonMostrarMatrices
            // 
            this.buttonMostrarMatrices.Location = new System.Drawing.Point(433, 279);
            this.buttonMostrarMatrices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMostrarMatrices.Name = "buttonMostrarMatrices";
            this.buttonMostrarMatrices.Size = new System.Drawing.Size(82, 22);
            this.buttonMostrarMatrices.TabIndex = 4;
            this.buttonMostrarMatrices.Text = "Mostrar";
            this.buttonMostrarMatrices.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarMatrices
            // 
            this.buttonBuscarMatrices.Location = new System.Drawing.Point(433, 338);
            this.buttonBuscarMatrices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarMatrices.Name = "buttonBuscarMatrices";
            this.buttonBuscarMatrices.Size = new System.Drawing.Size(82, 22);
            this.buttonBuscarMatrices.TabIndex = 6;
            this.buttonBuscarMatrices.Text = "Buscar";
            this.buttonBuscarMatrices.UseVisualStyleBackColor = true;
            // 
            // buttonOrdenarMatrices
            // 
            this.buttonOrdenarMatrices.Location = new System.Drawing.Point(296, 338);
            this.buttonOrdenarMatrices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOrdenarMatrices.Name = "buttonOrdenarMatrices";
            this.buttonOrdenarMatrices.Size = new System.Drawing.Size(82, 22);
            this.buttonOrdenarMatrices.TabIndex = 5;
            this.buttonOrdenarMatrices.Text = "Ordenar";
            this.buttonOrdenarMatrices.UseVisualStyleBackColor = true;
           
            // 
            // FormMatrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOrdenarMatrices);
            this.Controls.Add(this.buttonBuscarMatrices);
            this.Controls.Add(this.buttonMostrarMatrices);
            this.Controls.Add(this.buttonEditarMatrices);
            this.Controls.Add(this.buttonEliminarMatrices);
            this.Controls.Add(this.buttonGuardarMatrices);
            this.Controls.Add(this.label1);
            this.Name = "FormMatrices";
            this.Text = "FormMatrices";
            this.ResumeLayout(false);
            this.PerformLayout();

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