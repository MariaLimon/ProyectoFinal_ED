﻿namespace ProyectoFinal_ED
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
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.ControlLightLight;
			label1.Location = new Point(346, 36);
			label1.Name = "label1";
			label1.Size = new Size(117, 37);
			label1.TabIndex = 0;
			label1.Text = "Matrices";
			// 
			// FormMatrices
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(800, 450);
			Controls.Add(label1);
			Name = "FormMatrices";
			Text = "FormMatrices";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
	}
}