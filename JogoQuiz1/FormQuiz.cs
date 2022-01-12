/*
 * Criado por SharpDevelop.
 * Usuário: Denise
 * Data: 26/11/2020
 * Hora: 15:31
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JogoQuiz1
{
	public partial class FormQuiz : Form
	{
		public FormQuiz()
		{
			InitializeComponent();
		}
		void FormQuizLoad(object sender, EventArgs e)
		{
			try
			{
				richTextBox1.LoadFile("arquivo.txt", RichTextBoxStreamType.PlainText);
			}
			catch (Exception exc)
			{
				MessageBox.Show("Ocorreu um erro ao executar o Quiz.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
			lblPergunta.Visible = false;
			buttonA.Visible = false;
			buttonB.Visible = false;
			buttonC.Visible = false;
			buttonD.Visible = false;
			labelA.Visible = false;
			labelB.Visible = false;
			labelC.Visible = false;
			labelD.Visible = false;
			buttonQuest.Text = "Iniciar Quiz";
		}
		
		int contAcertos = 0;
		int contErros = 0;
		int cont = 1;
		int contQuest = 2;
		
		void ProxQuest()
		{
			lblPergunta.Visible = true;
			buttonA.Visible = true;
			buttonB.Visible = true;
			buttonC.Visible = true;
			buttonD.Visible = true;
			labelA.Visible = true;
			labelB.Visible = true;
			labelC.Visible = true;
			labelD.Visible = true;
			
			buttonA.BackColor = Color.White;
			buttonB.BackColor = Color.White;
			buttonC.BackColor = Color.White;
			buttonD.BackColor = Color.White;
			
			panelButtons.Enabled = true;
			
			buttonQuest.Text = "Questão " +contQuest + " >>";
			
			Random rnd = new Random();
			int numLinha = rnd.Next(1,richTextBox1.Lines.Length-1);
			
			lblNumReg.Text = numLinha.ToString();
			
			string linha = richTextBox1.Lines[numLinha]; //Armazena a linha atual em uma string
			
			//Corta os "|" da string e tranforma em um vetor cada dado separadamente
			string[] dados = linha.Split('|');
			
			if (dados[6] == "A") //Checa se o último dado é igual a "A" de "Adicionado"
			{
				//Transmite cada dado em seu respectivo lugar nos TextBoxes
				lblPergunta.Text = cont + " - " + dados[0];
				labelA.Text = dados[1];
				labelB.Text = dados[2];
				labelC.Text = dados[3];
				labelD.Text = dados[4];
			}
			else //Se a letra no final não for A, significa que foi deletada, ou seja "A" virou "D", resultando em...
			{
				//Optei por inserir uma pergunta reserva no lugar daquela que foi deletada
				int numLinhaD = 51;
				lblNumReg.Text = numLinhaD.ToString();
				
				string linhaD = richTextBox1.Lines[numLinhaD]; //Armazena a linha atual em uma string
			
				//Corta os "|" da string e tranforma em um vetor cada dado separadamente
				string[] dadosD = linhaD.Split('|');
				
				//Transmite cada dado em seu respectivo lugar nos TextBoxes
				lblPergunta.Text = cont + " - " + dados[0];
				labelA.Text = dados[1];
				labelB.Text = dados[2];
				labelC.Text = dados[3];
				labelD.Text = dados[4];
			}
			cont ++;
			contQuest++;
			
			if (contQuest > 11)
			{
				buttonQuest.Text = "Finalizar Quiz...";
			}
		}
		
		void ButtonQuestClick(object sender, EventArgs e)
		{
			ProxQuest();
			buttonQuest.Enabled = false;
			
			if (cont > 11)
			{
				panelButtons.Visible = false;
				lblPergunta.Visible = false;
				labelA.Visible = false;
				labelB.Visible = false;
				labelC.Visible = false;
				labelD.Visible = false;
				buttonQuest.Visible = false;
				btnLeave.Visible = true;
				btnRestart.Visible = true;
				
				lblAcertos.Visible = true;
				lblErros.Visible = true;
				lblNumAcertos.Visible = true;
				lblNumErros.Visible = true;
				
				lblNumAcertos.Text = contAcertos.ToString();
				lblNumErros.Text = contErros.ToString();
				
				if (contAcertos > contErros)
				{
					labelMsg.Visible = true;
					labelMsg.ForeColor = Color.Green;
					labelMsg.Text = "Parabéns! Acertou a maioria das questões!";
				}
				else if (contAcertos < contErros)
				{
					labelMsg.Visible = true;
					labelMsg.ForeColor = Color.Red;
					labelMsg.Text = "Sinto muito... Errou a maioria das questões!";
				}
				else
				{
					labelMsg.Visible = true;
					labelMsg.ForeColor = Color.Yellow;
					labelMsg.Text = "Seus erros e acertos foram iguais!";
				}
			}
		}
		
		void ButtonAClick(object sender, EventArgs e)
		{
			int numLinha = int.Parse(lblNumReg.Text);
			
			string linha = richTextBox1.Lines[numLinha]; //Armazena a linha atual em uma string
				
			//Corta os "|" da string e tranforma em um vetor cada dado separadamente
			string[] dados = linha.Split('|');
			
			if (dados[5] == (sender as Button).Text)
			{
				(sender as Button).BackColor = Color.Green;
                panelButtons.Enabled = false;
                contAcertos ++;
			}
			else
			{
				(sender as Button).BackColor = Color.Red;
                panelButtons.Enabled = false;
                contErros ++;
			}
			
			buttonQuest.Enabled = true;
		}
		void BtnRestartClick(object sender, EventArgs e)
		{
			cont = 1;
			contAcertos = 0;
			contErros = 0;
			contQuest = 2;
			
			panelButtons.Visible = true;
			buttonQuest.Visible = true;
			
			labelMsg.Visible = false;
			lblAcertos.Visible = false;
			lblErros.Visible = false;
			lblNumAcertos.Visible = false;
			lblNumErros.Visible = false;
			
			btnRestart.Visible = false;
			btnLeave.Visible = false;
			
			ProxQuest();
		}
		void BtnLeaveClick(object sender, EventArgs e)
		{
			this.Close(); //Fecha o Form Atual
		}
	}
}
