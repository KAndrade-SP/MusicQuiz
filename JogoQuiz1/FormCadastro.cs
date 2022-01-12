/*
 * Criado por SharpDevelop.
 * Usuário: Denise
 * Data: 26/11/2020
 * Hora: 15:28
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JogoQuiz1
{
	public partial class FormCadastro : Form
	{
		public FormCadastro()
		{
			InitializeComponent();
		}
		void FormCadastroLoad(object sender, EventArgs e)
		{
			try
			{
				richTextBox1.LoadFile("arquivo.txt", RichTextBoxStreamType.PlainText);
			}
			catch (Exception exc)
			{
				richTextBox1.Text = "\n";
				richTextBox1.SaveFile("arquivo.txt", RichTextBoxStreamType.PlainText);
			}
			
			Novo(); //Caso o programa não ache o arquivo, ele irá chamar o método "Novo".
			
			//O botão ficará inválido, pois será preciso que o usuário clique no botão "Novo" para cadastrar perguntas.
			GravarButton.Enabled = false; 
		}
		
		void Novo() //Criei um método chamado método que será usado com frequência no programa.
		{
			//Limpar todos os campos de texto e mover o cursor para o primeiro TextBox de Pergunta.
			textBoxPerg.Clear();
			textBoxAlterA.Clear();
			textBoxAlterB.Clear();
			textBoxAlterC.Clear();
			textBoxAlterD.Clear();
			textBoxAltCorreta.Clear();
			textBoxPerg.Focus();
			
			//Movi a posição da linha do RTB para o label.
			lblNumRegistro.Text = (richTextBox1.Lines.Length - 1).ToString(); 
			
			GravarButton.Enabled = true; //Deixei o botão "Gravar" liberado.
		}
		
		void NovoButtonClick(object sender, EventArgs e) //Botão "Novo" que irá chamar o método "Novo"
		{
			Novo();
		}
		
		void GravarButtonClick(object sender, EventArgs e)
		{
			//Cria uma string que irá receber os dados digitados pelo usuário nos campos
			string linha = textBoxPerg.Text + "|" + textBoxAlterA.Text + "|" + textBoxAlterB.Text + "|"
						   + textBoxAlterC.Text + "|" + textBoxAlterD.Text + "|" + textBoxAltCorreta.Text + "|" + "A";
			
			//Concatena a string com uma quebra de linha para que o próximo dado digitado fique na linha de baixo
			richTextBox1.Text += linha + "\n";
			
			richTextBox1.SaveFile("arquivo.txt", RichTextBoxStreamType.PlainText); //Salva o arquivo
			
			MessageBox.Show("Questão gravada com sucesso!", "Aviso"); //Mensagem de aviso após o salvamento
			
			Novo(); //Chama o método novo
		}
		
		void ConsultButtonClick(object sender, EventArgs e) //Evento ao clicar no botão "Consultar"
		{
			int numLinha = int.Parse(textBoxConsult.Text); //Armazena o valor digitado pelo usuário em uma variável
			
			//Checa se o número digitado é um número de fato ou se existe no registro olhando pelo número de linhas
			if (numLinha>0 && numLinha<richTextBox1.Lines.Length-1) 
			{
				//Label de registro recebe o valor que o usuário desejou consultar
				lblNumRegistro.Text = numLinha.ToString(); 
				
				string linha = richTextBox1.Lines[numLinha]; //Armazena a linha atual em uma string
				
				//Corta os "|" da string e tranforma em um vetor cada dado separadamente
				string[] dados = linha.Split('|'); 
				
				if (dados[6] == "A") //Checa se o último dado é igual a "A" de "Adicionado"
				{
					//Transmite cada dado em seu respectivo lugar nos TextBoxes
					textBoxPerg.Text = dados[0];
					textBoxAlterA.Text = dados[1];
					textBoxAlterB.Text = dados[2];
					textBoxAlterC.Text = dados[3];
					textBoxAlterD.Text = dados[4];
					textBoxAltCorreta.Text = dados[5];
				}
				else //Se a letra no final não for A, significa que foi deletada, ou seja "A" virou "D", resultando em...
				{
					lblNumRegistro.Visible = false;
					MessageBox.Show("A questão requisitada foi excluída do registro", "Aviso");
					Novo();
					GravarButton.Enabled = false;
				}                             
			}
			else //Caso o valor não exista no RTB
			{
				Novo();
				MessageBox.Show("Questão não encontrada", "Aviso");
			}
			textBoxConsult.Clear();
			GravarButton.Enabled = false;
		}
		
		void AlterarButtonClick(object sender, EventArgs e)
		{
			try
			{
				int numLinha = int.Parse(lblNumRegistro.Text);
				
				string linhaAntiga = richTextBox1.Lines[numLinha];
				string linhaNova = textBoxPerg.Text + "|" + textBoxAlterA.Text + "|" + textBoxAlterB.Text + "|"
						  		   + textBoxAlterC.Text + "|" + textBoxAlterD.Text + "|" + textBoxAltCorreta.Text + "|" + "A";
				
				richTextBox1.Text = richTextBox1.Text.Replace(linhaAntiga, linhaNova);
				
				richTextBox1.SaveFile("arquivo.txt", RichTextBoxStreamType.PlainText);
				
				MessageBox.Show("Questão alterada com sucesso!", "Aviso");
				GravarButton.Enabled = false;
			}
			catch (Exception exc)
			{
				MessageBox.Show("Não foi possível realizar a operação", "Aviso");
			}
		}
		
		void ExcButtonClick(object sender, EventArgs e)
		{
			int numLinha = int.Parse(lblNumRegistro.Text);
			
			string linhaAntiga = richTextBox1.Lines[numLinha];
			string linhaNova = textBoxPerg.Text + "|" + textBoxAlterA.Text + "|" + textBoxAlterB.Text + "|"
						  	   + textBoxAlterC.Text + "|" + textBoxAlterD.Text + "|" + textBoxAltCorreta.Text + "|" + "D";
			
			if (MessageBox.Show("Deseja realmente excluir essa questão?", "Aviso Importante!",
			                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				richTextBox1.Text = richTextBox1.Text.Replace(linhaAntiga, linhaNova);
				richTextBox1.SaveFile("arquivo.txt", RichTextBoxStreamType.PlainText);
				
				Novo();
				GravarButton.Enabled = false;
				MessageBox.Show("Questão excluída com sucesso!", "Aviso");
			}
			else
			{
				MessageBox.Show("Questão mantida!", "Operação Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		
		void SairButtonClick(object sender, EventArgs e)
		{
			this.Close(); //Fecha o Form Atual
		}
		
	}
}
