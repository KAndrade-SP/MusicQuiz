/*
 * Criado por SharpDevelop.
 * Usuário: Denise
 * Data: 26/11/2020
 * Hora: 15:06
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace JogoQuiz1
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void QuizToolStripMenuItemClick(object sender, EventArgs e) //Exibição do Form de Quiz
		{
			FormQuiz fmrQuiz = new FormQuiz();
			fmrQuiz.Show();
		}
		void CadastroToolStripMenuItemClick(object sender, EventArgs e) //Exibição do Form de Cadastro de questões
		{
			FormCadastro fmrCad = new FormCadastro();
			fmrCad.Show();
		}
		void AjudaToolStripMenuItemClick(object sender, EventArgs e)
		{
			FormAjuda fmrAjuda = new FormAjuda();
			fmrAjuda.Show();
		}
		
	}
}
