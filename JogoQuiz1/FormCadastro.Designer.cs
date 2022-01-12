/*
 * Criado por SharpDevelop.
 * Usuário: Denise
 * Data: 26/11/2020
 * Hora: 15:28
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace JogoQuiz1
{
	partial class FormCadastro
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panelButtons;
		private System.Windows.Forms.Button SairButton;
		private System.Windows.Forms.Button ConsultButton;
		private System.Windows.Forms.Button ExcButton;
		private System.Windows.Forms.Button AlterarButton;
		private System.Windows.Forms.Button GravarButton;
		private System.Windows.Forms.Button NovoButton;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label lblRegistro;
		private System.Windows.Forms.Label lblNumRegistro;
		private System.Windows.Forms.Label lblPergunta;
		private System.Windows.Forms.TextBox textBoxPerg;
		private System.Windows.Forms.Label lblAlternativaA;
		private System.Windows.Forms.TextBox textBoxAlterA;
		private System.Windows.Forms.Label lblAlternativaB;
		private System.Windows.Forms.TextBox textBoxAlterB;
		private System.Windows.Forms.Label lblAlternativaC;
		private System.Windows.Forms.TextBox textBoxAlterC;
		private System.Windows.Forms.Label lblAlternativaD;
		private System.Windows.Forms.TextBox textBoxAlterD;
		private System.Windows.Forms.Label lblAlterCorreta;
		private System.Windows.Forms.TextBox textBoxAltCorreta;
		private System.Windows.Forms.TextBox textBoxConsult;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
			this.panelButtons = new System.Windows.Forms.Panel();
			this.SairButton = new System.Windows.Forms.Button();
			this.ExcButton = new System.Windows.Forms.Button();
			this.AlterarButton = new System.Windows.Forms.Button();
			this.GravarButton = new System.Windows.Forms.Button();
			this.NovoButton = new System.Windows.Forms.Button();
			this.ConsultButton = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.lblRegistro = new System.Windows.Forms.Label();
			this.lblNumRegistro = new System.Windows.Forms.Label();
			this.lblPergunta = new System.Windows.Forms.Label();
			this.textBoxPerg = new System.Windows.Forms.TextBox();
			this.lblAlternativaA = new System.Windows.Forms.Label();
			this.textBoxAlterA = new System.Windows.Forms.TextBox();
			this.lblAlternativaB = new System.Windows.Forms.Label();
			this.textBoxAlterB = new System.Windows.Forms.TextBox();
			this.lblAlternativaC = new System.Windows.Forms.Label();
			this.textBoxAlterC = new System.Windows.Forms.TextBox();
			this.lblAlternativaD = new System.Windows.Forms.Label();
			this.textBoxAlterD = new System.Windows.Forms.TextBox();
			this.lblAlterCorreta = new System.Windows.Forms.Label();
			this.textBoxAltCorreta = new System.Windows.Forms.TextBox();
			this.textBoxConsult = new System.Windows.Forms.TextBox();
			this.panelButtons.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelButtons
			// 
			this.panelButtons.BackColor = System.Drawing.Color.Transparent;
			this.panelButtons.Controls.Add(this.SairButton);
			this.panelButtons.Controls.Add(this.ExcButton);
			this.panelButtons.Controls.Add(this.AlterarButton);
			this.panelButtons.Controls.Add(this.GravarButton);
			this.panelButtons.Controls.Add(this.NovoButton);
			this.panelButtons.Location = new System.Drawing.Point(18, 12);
			this.panelButtons.Name = "panelButtons";
			this.panelButtons.Size = new System.Drawing.Size(483, 53);
			this.panelButtons.TabIndex = 0;
			// 
			// SairButton
			// 
			this.SairButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SairButton.Location = new System.Drawing.Point(394, 9);
			this.SairButton.Name = "SairButton";
			this.SairButton.Size = new System.Drawing.Size(75, 36);
			this.SairButton.TabIndex = 1;
			this.SairButton.Text = "Sair";
			this.SairButton.UseVisualStyleBackColor = true;
			this.SairButton.Click += new System.EventHandler(this.SairButtonClick);
			// 
			// ExcButton
			// 
			this.ExcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExcButton.Location = new System.Drawing.Point(298, 9);
			this.ExcButton.Name = "ExcButton";
			this.ExcButton.Size = new System.Drawing.Size(75, 36);
			this.ExcButton.TabIndex = 3;
			this.ExcButton.Text = "Excluir";
			this.ExcButton.UseVisualStyleBackColor = true;
			this.ExcButton.Click += new System.EventHandler(this.ExcButtonClick);
			// 
			// AlterarButton
			// 
			this.AlterarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AlterarButton.Location = new System.Drawing.Point(201, 9);
			this.AlterarButton.Name = "AlterarButton";
			this.AlterarButton.Size = new System.Drawing.Size(75, 36);
			this.AlterarButton.TabIndex = 2;
			this.AlterarButton.Text = "Alterar";
			this.AlterarButton.UseVisualStyleBackColor = true;
			this.AlterarButton.Click += new System.EventHandler(this.AlterarButtonClick);
			// 
			// GravarButton
			// 
			this.GravarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GravarButton.Location = new System.Drawing.Point(106, 9);
			this.GravarButton.Name = "GravarButton";
			this.GravarButton.Size = new System.Drawing.Size(75, 36);
			this.GravarButton.TabIndex = 1;
			this.GravarButton.Text = "Gravar";
			this.GravarButton.UseVisualStyleBackColor = true;
			this.GravarButton.Click += new System.EventHandler(this.GravarButtonClick);
			// 
			// NovoButton
			// 
			this.NovoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NovoButton.Location = new System.Drawing.Point(13, 9);
			this.NovoButton.Name = "NovoButton";
			this.NovoButton.Size = new System.Drawing.Size(75, 36);
			this.NovoButton.TabIndex = 0;
			this.NovoButton.Text = "Novo";
			this.NovoButton.UseVisualStyleBackColor = true;
			this.NovoButton.Click += new System.EventHandler(this.NovoButtonClick);
			// 
			// ConsultButton
			// 
			this.ConsultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ConsultButton.Location = new System.Drawing.Point(507, 38);
			this.ConsultButton.Name = "ConsultButton";
			this.ConsultButton.Size = new System.Drawing.Size(97, 27);
			this.ConsultButton.TabIndex = 1;
			this.ConsultButton.Text = "Consultar";
			this.ConsultButton.UseVisualStyleBackColor = true;
			this.ConsultButton.Click += new System.EventHandler(this.ConsultButtonClick);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(612, 12);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(249, 309);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			// 
			// lblRegistro
			// 
			this.lblRegistro.BackColor = System.Drawing.Color.Transparent;
			this.lblRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRegistro.ForeColor = System.Drawing.Color.White;
			this.lblRegistro.Location = new System.Drawing.Point(18, 77);
			this.lblRegistro.Name = "lblRegistro";
			this.lblRegistro.Size = new System.Drawing.Size(62, 23);
			this.lblRegistro.TabIndex = 2;
			this.lblRegistro.Text = "Registro: ";
			// 
			// lblNumRegistro
			// 
			this.lblNumRegistro.BackColor = System.Drawing.Color.Transparent;
			this.lblNumRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumRegistro.ForeColor = System.Drawing.Color.White;
			this.lblNumRegistro.Location = new System.Drawing.Point(83, 77);
			this.lblNumRegistro.Name = "lblNumRegistro";
			this.lblNumRegistro.Size = new System.Drawing.Size(116, 23);
			this.lblNumRegistro.TabIndex = 3;
			// 
			// lblPergunta
			// 
			this.lblPergunta.BackColor = System.Drawing.Color.Transparent;
			this.lblPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPergunta.ForeColor = System.Drawing.Color.White;
			this.lblPergunta.Location = new System.Drawing.Point(18, 100);
			this.lblPergunta.Name = "lblPergunta";
			this.lblPergunta.Size = new System.Drawing.Size(88, 23);
			this.lblPergunta.TabIndex = 4;
			this.lblPergunta.Text = "Pergunta:";
			// 
			// textBoxPerg
			// 
			this.textBoxPerg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPerg.Location = new System.Drawing.Point(18, 123);
			this.textBoxPerg.Name = "textBoxPerg";
			this.textBoxPerg.Size = new System.Drawing.Size(586, 22);
			this.textBoxPerg.TabIndex = 5;
			// 
			// lblAlternativaA
			// 
			this.lblAlternativaA.BackColor = System.Drawing.Color.Transparent;
			this.lblAlternativaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAlternativaA.ForeColor = System.Drawing.Color.White;
			this.lblAlternativaA.Location = new System.Drawing.Point(18, 154);
			this.lblAlternativaA.Name = "lblAlternativaA";
			this.lblAlternativaA.Size = new System.Drawing.Size(88, 23);
			this.lblAlternativaA.TabIndex = 6;
			this.lblAlternativaA.Text = "Alternativa A:";
			// 
			// textBoxAlterA
			// 
			this.textBoxAlterA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxAlterA.Location = new System.Drawing.Point(18, 180);
			this.textBoxAlterA.Name = "textBoxAlterA";
			this.textBoxAlterA.Size = new System.Drawing.Size(586, 22);
			this.textBoxAlterA.TabIndex = 7;
			// 
			// lblAlternativaB
			// 
			this.lblAlternativaB.BackColor = System.Drawing.Color.Transparent;
			this.lblAlternativaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAlternativaB.ForeColor = System.Drawing.Color.White;
			this.lblAlternativaB.Location = new System.Drawing.Point(18, 213);
			this.lblAlternativaB.Name = "lblAlternativaB";
			this.lblAlternativaB.Size = new System.Drawing.Size(88, 23);
			this.lblAlternativaB.TabIndex = 8;
			this.lblAlternativaB.Text = "Alternativa B:";
			// 
			// textBoxAlterB
			// 
			this.textBoxAlterB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxAlterB.Location = new System.Drawing.Point(18, 239);
			this.textBoxAlterB.Name = "textBoxAlterB";
			this.textBoxAlterB.Size = new System.Drawing.Size(586, 22);
			this.textBoxAlterB.TabIndex = 9;
			// 
			// lblAlternativaC
			// 
			this.lblAlternativaC.BackColor = System.Drawing.Color.Transparent;
			this.lblAlternativaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAlternativaC.ForeColor = System.Drawing.Color.Transparent;
			this.lblAlternativaC.Location = new System.Drawing.Point(18, 273);
			this.lblAlternativaC.Name = "lblAlternativaC";
			this.lblAlternativaC.Size = new System.Drawing.Size(88, 23);
			this.lblAlternativaC.TabIndex = 10;
			this.lblAlternativaC.Text = "Alternativa C:";
			// 
			// textBoxAlterC
			// 
			this.textBoxAlterC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxAlterC.Location = new System.Drawing.Point(18, 299);
			this.textBoxAlterC.Name = "textBoxAlterC";
			this.textBoxAlterC.Size = new System.Drawing.Size(586, 22);
			this.textBoxAlterC.TabIndex = 11;
			// 
			// lblAlternativaD
			// 
			this.lblAlternativaD.BackColor = System.Drawing.Color.Transparent;
			this.lblAlternativaD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAlternativaD.ForeColor = System.Drawing.Color.White;
			this.lblAlternativaD.Location = new System.Drawing.Point(18, 330);
			this.lblAlternativaD.Name = "lblAlternativaD";
			this.lblAlternativaD.Size = new System.Drawing.Size(88, 23);
			this.lblAlternativaD.TabIndex = 12;
			this.lblAlternativaD.Text = "Alternativa D:";
			// 
			// textBoxAlterD
			// 
			this.textBoxAlterD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxAlterD.Location = new System.Drawing.Point(18, 356);
			this.textBoxAlterD.Name = "textBoxAlterD";
			this.textBoxAlterD.Size = new System.Drawing.Size(586, 22);
			this.textBoxAlterD.TabIndex = 13;
			// 
			// lblAlterCorreta
			// 
			this.lblAlterCorreta.BackColor = System.Drawing.Color.Transparent;
			this.lblAlterCorreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAlterCorreta.ForeColor = System.Drawing.Color.White;
			this.lblAlterCorreta.Location = new System.Drawing.Point(610, 358);
			this.lblAlterCorreta.Name = "lblAlterCorreta";
			this.lblAlterCorreta.Size = new System.Drawing.Size(124, 23);
			this.lblAlterCorreta.TabIndex = 14;
			this.lblAlterCorreta.Text = "Alternativa Correta:";
			// 
			// textBoxAltCorreta
			// 
			this.textBoxAltCorreta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.textBoxAltCorreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxAltCorreta.Location = new System.Drawing.Point(732, 355);
			this.textBoxAltCorreta.Name = "textBoxAltCorreta";
			this.textBoxAltCorreta.Size = new System.Drawing.Size(127, 22);
			this.textBoxAltCorreta.TabIndex = 15;
			// 
			// textBoxConsult
			// 
			this.textBoxConsult.Location = new System.Drawing.Point(539, 12);
			this.textBoxConsult.Name = "textBoxConsult";
			this.textBoxConsult.Size = new System.Drawing.Size(34, 20);
			this.textBoxConsult.TabIndex = 4;
			// 
			// FormCadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(871, 392);
			this.Controls.Add(this.textBoxConsult);
			this.Controls.Add(this.textBoxAltCorreta);
			this.Controls.Add(this.lblAlterCorreta);
			this.Controls.Add(this.ConsultButton);
			this.Controls.Add(this.textBoxAlterD);
			this.Controls.Add(this.lblAlternativaD);
			this.Controls.Add(this.textBoxAlterC);
			this.Controls.Add(this.lblAlternativaC);
			this.Controls.Add(this.textBoxAlterB);
			this.Controls.Add(this.lblAlternativaB);
			this.Controls.Add(this.textBoxAlterA);
			this.Controls.Add(this.lblAlternativaA);
			this.Controls.Add(this.textBoxPerg);
			this.Controls.Add(this.lblPergunta);
			this.Controls.Add(this.lblNumRegistro);
			this.Controls.Add(this.lblRegistro);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.panelButtons);
			this.MaximizeBox = false;
			this.Name = "FormCadastro";
			this.Text = "FormCadastro";
			this.Load += new System.EventHandler(this.FormCadastroLoad);
			this.panelButtons.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
