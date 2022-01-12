/*
 * Criado por SharpDevelop.
 * Usuário: Denise
 * Data: 26/11/2020
 * Hora: 15:31
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace JogoQuiz1
{
	partial class FormQuiz
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label lblPergunta;
		private System.Windows.Forms.Label labelA;
		private System.Windows.Forms.Label labelB;
		private System.Windows.Forms.Label labelC;
		private System.Windows.Forms.Label labelD;
		private System.Windows.Forms.Button buttonQuest;
		private System.Windows.Forms.Label lblNumReg;
		private System.Windows.Forms.Panel panelButtons;
		private System.Windows.Forms.Button buttonD;
		private System.Windows.Forms.Button buttonA;
		private System.Windows.Forms.Button buttonC;
		private System.Windows.Forms.Button buttonB;
		private System.Windows.Forms.Label labelMsg;
		private System.Windows.Forms.Button btnRestart;
		private System.Windows.Forms.Button btnLeave;
		private System.Windows.Forms.Label lblAcertos;
		private System.Windows.Forms.Label lblErros;
		private System.Windows.Forms.Label lblNumAcertos;
		private System.Windows.Forms.Label lblNumErros;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuiz));
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.lblPergunta = new System.Windows.Forms.Label();
			this.labelA = new System.Windows.Forms.Label();
			this.labelB = new System.Windows.Forms.Label();
			this.labelC = new System.Windows.Forms.Label();
			this.labelD = new System.Windows.Forms.Label();
			this.buttonQuest = new System.Windows.Forms.Button();
			this.lblNumReg = new System.Windows.Forms.Label();
			this.panelButtons = new System.Windows.Forms.Panel();
			this.buttonD = new System.Windows.Forms.Button();
			this.buttonA = new System.Windows.Forms.Button();
			this.buttonC = new System.Windows.Forms.Button();
			this.buttonB = new System.Windows.Forms.Button();
			this.labelMsg = new System.Windows.Forms.Label();
			this.btnRestart = new System.Windows.Forms.Button();
			this.btnLeave = new System.Windows.Forms.Button();
			this.lblAcertos = new System.Windows.Forms.Label();
			this.lblErros = new System.Windows.Forms.Label();
			this.lblNumAcertos = new System.Windows.Forms.Label();
			this.lblNumErros = new System.Windows.Forms.Label();
			this.panelButtons.SuspendLayout();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(788, 12);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(91, 284);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// lblPergunta
			// 
			this.lblPergunta.BackColor = System.Drawing.Color.Transparent;
			this.lblPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPergunta.ForeColor = System.Drawing.Color.White;
			this.lblPergunta.Location = new System.Drawing.Point(12, 13);
			this.lblPergunta.Name = "lblPergunta";
			this.lblPergunta.Size = new System.Drawing.Size(770, 23);
			this.lblPergunta.TabIndex = 1;
			this.lblPergunta.Text = "lblPergunta";
			// 
			// labelA
			// 
			this.labelA.BackColor = System.Drawing.Color.Transparent;
			this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelA.ForeColor = System.Drawing.Color.White;
			this.labelA.Location = new System.Drawing.Point(54, 59);
			this.labelA.Name = "labelA";
			this.labelA.Size = new System.Drawing.Size(728, 23);
			this.labelA.TabIndex = 2;
			this.labelA.Text = "labelA";
			// 
			// labelB
			// 
			this.labelB.BackColor = System.Drawing.Color.Transparent;
			this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelB.ForeColor = System.Drawing.Color.White;
			this.labelB.Location = new System.Drawing.Point(54, 119);
			this.labelB.Name = "labelB";
			this.labelB.Size = new System.Drawing.Size(728, 23);
			this.labelB.TabIndex = 7;
			this.labelB.Text = "labelB";
			// 
			// labelC
			// 
			this.labelC.BackColor = System.Drawing.Color.Transparent;
			this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelC.ForeColor = System.Drawing.Color.White;
			this.labelC.Location = new System.Drawing.Point(54, 180);
			this.labelC.Name = "labelC";
			this.labelC.Size = new System.Drawing.Size(728, 23);
			this.labelC.TabIndex = 8;
			this.labelC.Text = "labelC";
			// 
			// labelD
			// 
			this.labelD.BackColor = System.Drawing.Color.Transparent;
			this.labelD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelD.ForeColor = System.Drawing.Color.White;
			this.labelD.Location = new System.Drawing.Point(54, 244);
			this.labelD.Name = "labelD";
			this.labelD.Size = new System.Drawing.Size(728, 23);
			this.labelD.TabIndex = 9;
			this.labelD.Text = "labelD";
			// 
			// buttonQuest
			// 
			this.buttonQuest.BackColor = System.Drawing.Color.White;
			this.buttonQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonQuest.Location = new System.Drawing.Point(273, 300);
			this.buttonQuest.Name = "buttonQuest";
			this.buttonQuest.Size = new System.Drawing.Size(233, 35);
			this.buttonQuest.TabIndex = 10;
			this.buttonQuest.UseVisualStyleBackColor = false;
			this.buttonQuest.Click += new System.EventHandler(this.ButtonQuestClick);
			// 
			// lblNumReg
			// 
			this.lblNumReg.BackColor = System.Drawing.Color.Transparent;
			this.lblNumReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumReg.Location = new System.Drawing.Point(111, 13);
			this.lblNumReg.Name = "lblNumReg";
			this.lblNumReg.Size = new System.Drawing.Size(45, 23);
			this.lblNumReg.TabIndex = 11;
			this.lblNumReg.Visible = false;
			// 
			// panelButtons
			// 
			this.panelButtons.BackColor = System.Drawing.Color.Transparent;
			this.panelButtons.Controls.Add(this.buttonD);
			this.panelButtons.Controls.Add(this.buttonA);
			this.panelButtons.Controls.Add(this.buttonC);
			this.panelButtons.Controls.Add(this.buttonB);
			this.panelButtons.Location = new System.Drawing.Point(12, 50);
			this.panelButtons.Name = "panelButtons";
			this.panelButtons.Size = new System.Drawing.Size(36, 220);
			this.panelButtons.TabIndex = 12;
			// 
			// buttonD
			// 
			this.buttonD.BackColor = System.Drawing.Color.White;
			this.buttonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonD.Location = new System.Drawing.Point(0, 185);
			this.buttonD.Name = "buttonD";
			this.buttonD.Size = new System.Drawing.Size(36, 35);
			this.buttonD.TabIndex = 16;
			this.buttonD.Text = "D";
			this.buttonD.UseVisualStyleBackColor = false;
			this.buttonD.Click += new System.EventHandler(this.ButtonAClick);
			// 
			// buttonA
			// 
			this.buttonA.BackColor = System.Drawing.Color.White;
			this.buttonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonA.Location = new System.Drawing.Point(0, 0);
			this.buttonA.Name = "buttonA";
			this.buttonA.Size = new System.Drawing.Size(36, 35);
			this.buttonA.TabIndex = 13;
			this.buttonA.Text = "A";
			this.buttonA.UseVisualStyleBackColor = false;
			this.buttonA.Click += new System.EventHandler(this.ButtonAClick);
			// 
			// buttonC
			// 
			this.buttonC.BackColor = System.Drawing.Color.White;
			this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonC.Location = new System.Drawing.Point(0, 121);
			this.buttonC.Name = "buttonC";
			this.buttonC.Size = new System.Drawing.Size(36, 35);
			this.buttonC.TabIndex = 15;
			this.buttonC.Text = "C";
			this.buttonC.UseVisualStyleBackColor = false;
			this.buttonC.Click += new System.EventHandler(this.ButtonAClick);
			// 
			// buttonB
			// 
			this.buttonB.BackColor = System.Drawing.Color.White;
			this.buttonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonB.Location = new System.Drawing.Point(0, 60);
			this.buttonB.Name = "buttonB";
			this.buttonB.Size = new System.Drawing.Size(36, 35);
			this.buttonB.TabIndex = 14;
			this.buttonB.Text = "B";
			this.buttonB.UseVisualStyleBackColor = false;
			this.buttonB.Click += new System.EventHandler(this.ButtonAClick);
			// 
			// labelMsg
			// 
			this.labelMsg.BackColor = System.Drawing.Color.Transparent;
			this.labelMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMsg.ForeColor = System.Drawing.Color.White;
			this.labelMsg.Location = new System.Drawing.Point(153, 142);
			this.labelMsg.Name = "labelMsg";
			this.labelMsg.Size = new System.Drawing.Size(481, 23);
			this.labelMsg.TabIndex = 13;
			this.labelMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelMsg.Visible = false;
			// 
			// btnRestart
			// 
			this.btnRestart.BackColor = System.Drawing.Color.White;
			this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRestart.Location = new System.Drawing.Point(12, 300);
			this.btnRestart.Name = "btnRestart";
			this.btnRestart.Size = new System.Drawing.Size(144, 35);
			this.btnRestart.TabIndex = 14;
			this.btnRestart.Text = "Reiniciar";
			this.btnRestart.UseVisualStyleBackColor = false;
			this.btnRestart.Visible = false;
			this.btnRestart.Click += new System.EventHandler(this.BtnRestartClick);
			// 
			// btnLeave
			// 
			this.btnLeave.BackColor = System.Drawing.Color.White;
			this.btnLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLeave.Location = new System.Drawing.Point(632, 300);
			this.btnLeave.Name = "btnLeave";
			this.btnLeave.Size = new System.Drawing.Size(144, 35);
			this.btnLeave.TabIndex = 15;
			this.btnLeave.Text = "Sair";
			this.btnLeave.UseVisualStyleBackColor = false;
			this.btnLeave.Visible = false;
			this.btnLeave.Click += new System.EventHandler(this.BtnLeaveClick);
			// 
			// lblAcertos
			// 
			this.lblAcertos.BackColor = System.Drawing.Color.Transparent;
			this.lblAcertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAcertos.ForeColor = System.Drawing.Color.White;
			this.lblAcertos.Location = new System.Drawing.Point(303, 110);
			this.lblAcertos.Name = "lblAcertos";
			this.lblAcertos.Size = new System.Drawing.Size(60, 23);
			this.lblAcertos.TabIndex = 16;
			this.lblAcertos.Text = "Acertos:";
			this.lblAcertos.Visible = false;
			// 
			// lblErros
			// 
			this.lblErros.BackColor = System.Drawing.Color.Transparent;
			this.lblErros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblErros.ForeColor = System.Drawing.Color.White;
			this.lblErros.Location = new System.Drawing.Point(400, 110);
			this.lblErros.Name = "lblErros";
			this.lblErros.Size = new System.Drawing.Size(45, 23);
			this.lblErros.TabIndex = 17;
			this.lblErros.Text = "Erros:";
			this.lblErros.Visible = false;
			// 
			// lblNumAcertos
			// 
			this.lblNumAcertos.BackColor = System.Drawing.Color.Transparent;
			this.lblNumAcertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumAcertos.ForeColor = System.Drawing.Color.Green;
			this.lblNumAcertos.Location = new System.Drawing.Point(361, 110);
			this.lblNumAcertos.Name = "lblNumAcertos";
			this.lblNumAcertos.Size = new System.Drawing.Size(33, 23);
			this.lblNumAcertos.TabIndex = 18;
			this.lblNumAcertos.Visible = false;
			// 
			// lblNumErros
			// 
			this.lblNumErros.BackColor = System.Drawing.Color.Transparent;
			this.lblNumErros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumErros.ForeColor = System.Drawing.Color.Red;
			this.lblNumErros.Location = new System.Drawing.Point(445, 110);
			this.lblNumErros.Name = "lblNumErros";
			this.lblNumErros.Size = new System.Drawing.Size(33, 23);
			this.lblNumErros.TabIndex = 19;
			this.lblNumErros.Visible = false;
			// 
			// FormQuiz
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(788, 349);
			this.Controls.Add(this.lblNumErros);
			this.Controls.Add(this.lblNumAcertos);
			this.Controls.Add(this.lblErros);
			this.Controls.Add(this.lblAcertos);
			this.Controls.Add(this.btnLeave);
			this.Controls.Add(this.btnRestart);
			this.Controls.Add(this.labelMsg);
			this.Controls.Add(this.lblNumReg);
			this.Controls.Add(this.buttonQuest);
			this.Controls.Add(this.labelD);
			this.Controls.Add(this.labelC);
			this.Controls.Add(this.labelB);
			this.Controls.Add(this.labelA);
			this.Controls.Add(this.lblPergunta);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.panelButtons);
			this.MaximizeBox = false;
			this.Name = "FormQuiz";
			this.Text = "FormQuiz";
			this.Load += new System.EventHandler(this.FormQuizLoad);
			this.panelButtons.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
