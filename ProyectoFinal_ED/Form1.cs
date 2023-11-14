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
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			button4 = new Button();
			SuspendLayout();
			// 
			// button1
			// 
			button1.BackColor = SystemColors.HotTrack;
			button1.ForeColor = Color.White;
			button1.Location = new Point(241, 173);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 0;
			button1.Text = "Pilas";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.BackColor = SystemColors.HotTrack;
			button2.ForeColor = Color.White;
			button2.Location = new Point(450, 173);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 1;
			button2.Text = "Matrices";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.BackColor = SystemColors.HotTrack;
			button3.ForeColor = Color.White;
			button3.Location = new Point(241, 275);
			button3.Name = "button3";
			button3.Size = new Size(94, 29);
			button3.TabIndex = 2;
			button3.Text = "Listas";
			button3.UseVisualStyleBackColor = false;
			// 
			// button4
			// 
			button4.BackColor = SystemColors.HotTrack;
			button4.ForeColor = Color.White;
			button4.Location = new Point(450, 275);
			button4.Name = "button4";
			button4.Size = new Size(94, 29);
			button4.TabIndex = 3;
			button4.Text = "Colas";
			button4.UseVisualStyleBackColor = false;
			button4.Click += button4_Click;
			// 
			// Form1
			// 
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(821, 471);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			ForeColor = Color.Coral;
			Name = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{

		}
	}
}