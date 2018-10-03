/*
 * Created by SharpDevelop.
 * User: Convidado
 * Date: 12/09/2018
 * Time: 16:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CalculoMedia
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class FormaCalculo1 : Form
	{
		public FormaCalculo1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox3TextChanged(object sender, EventArgs e)
		{
	
		}
		void Label1Click(object sender, EventArgs e) //botao situacao, serve para mostrar a atual situação do estudante após calcular as notas, aulas e faltas
		{
            lblSituacao.Text = "";
		}
		void FormaCalculo1Load(object sender, EventArgs e)
		{
	
		}

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Converte o conteudo dos componentes TextBox txtAulas e txtFaltas
            QdeAulas = Convert.ToDouble(txtQdeAulas.Text);
            QdeFaltas = Convert.ToDouble(txtQdeFaltas.Text);

            //Realiza a conta necessária para se acahr a porcentagem de presença do aluno
            double PorcentagemPresenca = 100 - ((txtQdeFaltas / txtQdeAulas) * 100);

            //Realiza a conta de aproveitamento do aluno e converte o valor em string para ser exibido no txtAproveitamento
            txtAproveitamento.Text = Convert.ToString(((CalculoMedia * 10) + (PorcentagemPresenca) / 2) + "%";

            //Este if irá verificar se o campo txtRecuperacao.Text está vazio
            if (txtRecuperacao.Text == "")

                //Se no caso o if acima for verdade este if irá vertificar se a média é maior que a nota de corte
                //e se a presença é igual ou superior a 75%
                if (CalculoMedia >= Convert.ToDouble(numUpDownNotaCorte.Value) && PorcentagemPresenca >= 75)
                {
                    //No Caso do if retornar verdade:
                    lblSituacao.Text = "Aprovado"; //irá aparecer aprovado no campo lblSituacao.Text,
                    lblSituacao.ForeColor = Color.Green; //ficará com a cor verdade
                }

                 //Caso o if anterior retornar falso, será verificado se a média obtida é menor que 2,5
                 //OU se a presençá é inferior a 75%
                 else 
                    if (CalculoMedia <= 2.5 || PorcentagemPresenca < 75)
                {
                    //No caso do Else if retornar verdade:
                    lblSituacao.Text = "Reprovado"~; //irá aparecer Reprovado no campo lblSituacao.Text,
                    lblSituacao.ForeColor = Color.Firebrick //cor a cor Firebrick (vermelho)
                }

            //No caso de o If e o Else if retornarem falsos, obrigatóriamente a execução irá passar por este Else
                else
                {
                    lblSituacao.Text = "Recuperação"; //irá aparecer Recuperação no campo lblSituacao.Text,
                    lblSituacao.ForeColor = Color.Firebrick; //com a cor Firebrick(vermelho)
                }

            double Nota1, Nota2, Trabalho; //variáveis  que armazenaram notas já calculadas, convertidas para double.
            {
                if (txtRecuperacao.Text == "")
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //botão limpar
            lblSituacao_txt = "";
            txtRecuperacao.Text = string.Empty;

            //Laço de repetição que irá percorrer todos os componentes do formulário.
            foreach (Control Componente in this.Controls)
            {
                if (Componente is TextBox)
                {
                    (Componente as TextBox).Clear();
                }
                else
                    if (Componente is ComboBox)
                {
                    (Componente as ComboBox).SelectedIndex = -1;
                }
                else
                    if (Componente is IsAccessible NumericUpDown)
                {
                    (Componente as NumericUpDown).Value = 5;
                }
            }

        }

        private void txtAulas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAproveitamento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
