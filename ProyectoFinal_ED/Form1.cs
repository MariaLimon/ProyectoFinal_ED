namespace ProyectoFinal_ED
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
            this.buttonPilas = new System.Windows.Forms.Button();
            this.buttonMatrices = new System.Windows.Forms.Button();
            this.buttonListas = new System.Windows.Forms.Button();
            this.buttonColas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPilas
            // 
            this.buttonPilas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonPilas.ForeColor = System.Drawing.Color.White;
            this.buttonPilas.Location = new System.Drawing.Point(450, 275);
            this.buttonPilas.Name = "buttonPilas";
            this.buttonPilas.Size = new System.Drawing.Size(94, 29);
            this.buttonPilas.TabIndex = 0;
            this.buttonPilas.Text = "Pilas";
            this.buttonPilas.UseVisualStyleBackColor = false;
            this.buttonPilas.Click += new System.EventHandler(this.buttonPilas_Click);
            // 
            // buttonMatrices
            // 
            this.buttonMatrices.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonMatrices.ForeColor = System.Drawing.Color.White;
            this.buttonMatrices.Location = new System.Drawing.Point(241, 275);
            this.buttonMatrices.Name = "buttonMatrices";
            this.buttonMatrices.Size = new System.Drawing.Size(94, 29);
            this.buttonMatrices.TabIndex = 1;
            this.buttonMatrices.Text = "Matrices";
            this.buttonMatrices.UseVisualStyleBackColor = false;
            this.buttonMatrices.Click += new System.EventHandler(this.buttonMatrices_Click);
            // 
            // buttonListas
            // 
            this.buttonListas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonListas.ForeColor = System.Drawing.Color.White;
            this.buttonListas.Location = new System.Drawing.Point(450, 173);
            this.buttonListas.Name = "buttonListas";
            this.buttonListas.Size = new System.Drawing.Size(94, 29);
            this.buttonListas.TabIndex = 2;
            this.buttonListas.Text = "Listas";
            this.buttonListas.UseVisualStyleBackColor = false;
            this.buttonListas.Click += new System.EventHandler(this.buttonListas_Click);
            // 
            // buttonColas
            // 
            this.buttonColas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonColas.ForeColor = System.Drawing.Color.White;
            this.buttonColas.Location = new System.Drawing.Point(241, 173);
            this.buttonColas.Name = "buttonColas";
            this.buttonColas.Size = new System.Drawing.Size(94, 29);
            this.buttonColas.TabIndex = 3;
            this.buttonColas.Text = "Colas";
            this.buttonColas.UseVisualStyleBackColor = false;
            this.buttonColas.Click += new System.EventHandler(this.buttonColas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(194, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Proyecto final estructura de datos";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(821, 471);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonColas);
            this.Controls.Add(this.buttonListas);
            this.Controls.Add(this.buttonMatrices);
            this.Controls.Add(this.buttonPilas);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		
		private void button1_Click(object sender, EventArgs e)
		{
			
		}

		

		//boton de colas
		private void buttonColas_Click(object sender, EventArgs e)
		{
			FormColas colas = new FormColas();
			//mostrar formulario de colas
			colas.Show();
		}

		//boton  de listas
		private void buttonListas_Click(object sender, EventArgs e)
		{
			FormListas listas = new FormListas();
			//mostrar formulario de listas
			listas.Show();
		}

        //boton de matrices
        private void buttonMatrices_Click(object sender, EventArgs e)
        {
            FormMatrices matrices = new FormMatrices();
            //mostrar el fomulario matrices
            matrices.Show();
        }

        //boton de pilas
        private void buttonPilas_Click(object sender, EventArgs e)
        {
            FormPilas pilas = new FormPilas();
            //mostrar formulario de pilas
            pilas.Show();
            
        }

       

        

    }
}