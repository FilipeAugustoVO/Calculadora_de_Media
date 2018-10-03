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
		void Label1Click(object sender, EventArgs e)
		{
	
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


            double Nota1, Nota2, Trabalho; //variáveis  que armazenaram notas já calculadas, convertidas para double.
            {
                if (txtRecuperacao.Text == "")
            }
            {
                if (Media >= Convert.ToDouble(numUpDownNotaCorte.Value) && PorcentagemPresenca >= 75)
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
