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


        private void txtTrabalho_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboxTrabalho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /* 
         Lembre de opções na ComboBox Avaliações:
            1 Avaliação + Trabalho
            2 Avaliações
            2 Avaliações + Trabalho
            3 Avaliações
            3 Avaliações + Trabalho
            4 Avaliações
        */
        public double divisor = 0;
        public string SomaNotas;
        public string MediaFinal;
        public string PrimeiraNota;
        public string SegundaNota;
        public string TerceiraNota;
        public string QuartaNota;

        private void cboxAvaliacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxAvaliacao.SelectedItem.ToString() == "1 Avaliação + Trabalho")
            {
                lblSegundaNota.Text = "Trabalho";
                gboxTerceiraNota.Visible = false;
                gboxQuartaNota.Visible = false;
                /*double divisor = 2;*/
            }
            else

            if(cboxAvaliacao.SelectedItem.ToString() == "2 Avaliações")
            {
                lblSegundaNota.Text = "Segunda Nota";
                gboxTerceiraNota.Visible = false;
                gboxQuartaNota.Visible = false;
                /*double divisor = 2;*/
            }
            else

            if (cboxAvaliacao.SelectedItem.ToString() == "2 Avaliações + Trabalho")
            {
                lblTerceiraNota.Text = "Trabalho";
                gboxTerceiraNota.Visible = true;                 
                gboxQuartaNota.Visible = false;
                /*double divisor = 3;*/
            }
            else

            if (cboxAvaliacao.SelectedItem.ToString() == "3 Avaliações")
            {
                lblTerceiraNota.Text = "Terceira Nota";
                gboxTerceiraNota.Visible = true;
                gboxQuartaNota.Visible = false;
                /*double divisor = 3;*/
            }
            else

            if (cboxAvaliacao.SelectedItem.ToString() == "3 Avaliações + Trabalho")
            {               
                lblQuartaNota.Text = "Trabalho";
                gboxTerceiraNota.Visible = true;
                gboxQuartaNota.Visible = true;
                /*double divisor = 4;*/
            }
            else

            if (cboxAvaliacao.SelectedItem.ToString() == "4 Avaliações")
            {
                lblQuartaNota.Text = "Quarta Nota";
                gboxTerceiraNota.Visible = true;
                gboxQuartaNota.Visible = true;
                /*double divisor = 4;*/
            } 
        }

        /*
         Multiplicadores das notas:
         2
         3
         5
         */

        private void txtSegundaNota_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboxPrimeiraNota_SelectedIndexChanged(object sender, EventArgs e)
        {
            //multiplicadores da Primeira Nota
            if (cboxPrimeiraNota.SelectedItem.ToString() == "2")
            {
                double nota1, PrimeiraNota;
                nota1 = double.Parse(txtPrimeiraNota.Text);
                PrimeiraNota = nota1 * 2;
            }
            else

            if (cboxPrimeiraNota.SelectedItem.ToString() == "3")
            {
                double nota1, PrimeiraNota;
                nota1 = double.Parse(txtPrimeiraNota.Text);
                PrimeiraNota = nota1 * 3;
            }
            else

            if (cboxPrimeiraNota.SelectedItem.ToString() == "5")
            {
                double nota1, PrimeiraNota;
                nota1 = double.Parse(txtPrimeiraNota.Text);
                PrimeiraNota = nota1 * 5;
            }
        }
        

        private void cboxSegundaNOta_SelectedIndexChanged(object sender, EventArgs e)
        {
            //multiplicadores da Segunda Nota
            if (cboxSegundaNota.SelectedItem.ToString() == "2")
            {
                double nota2, SegundaNota;
                nota2 = double.Parse(txtSegundaNota.Text);
                SegundaNota = nota2 * 2;
            }
            else

            if (cboxSegundaNota.SelectedItem.ToString() == "3")
            {
                double nota2, SegundaNota;
                nota2 = double.Parse(txtSegundaNota.Text);
                SegundaNota = nota2 * 3;
            }
            else

            if (cboxSegundaNota.SelectedItem.ToString() == "5")
            {
                double nota2, SegundaNota;
                nota2 = double.Parse(txtSegundaNota.Text);
                SegundaNota = nota2 * 5;
            }
        }

        private void cboxTerceiraNota_SelectedIndexChanged(object sender, EventArgs e)
        {
            //multiplicadores da Terceira Nota
            if (cboxTerceiraNota.SelectedItem.ToString() == "2")
            {
                double nota3, TerceiraNota;
                nota3 = double.Parse(txtTerceiraNota.Text);
                TerceiraNota = nota3 * 2;
            }
            else

            if (cboxTerceiraNota.SelectedItem.ToString() == "3")
            {
                double nota3, TerceiraNota;
                nota3 = double.Parse(txtTerceiraNota.Text);
                TerceiraNota = nota3 * 3;
            }
            else

            if (cboxTerceiraNota.SelectedItem.ToString() == "5")
            {
                double nota3, TerceiraNota;
                nota3 = double.Parse(txtTerceiraNota.Text);
                TerceiraNota = nota3 * 5;
            }


        }

        private void cboxQuartaNota_SelectedIndexChanged(object sender, EventArgs e)
        {
            //multiplicadores da Quarta Nota
            if (cboxQuartaNota.SelectedItem.ToString() == "2")
            {
                double nota4, QuartaNota;
                nota4 = double.Parse(txtQuartaNota.Text);
                QuartaNota = nota4 * 2;
            }
            else

            if (cboxQuartaNota.SelectedItem.ToString() == "3")
            {
                double nota4, QuartaNota;
                nota4 = double.Parse(txtQuartaNota.Text);
                QuartaNota = nota4 * 3;
            }
            else

            if (cboxQuartaNota.SelectedItem.ToString() == "5")
            {
                double nota4, QuartaNota;
                nota4 = double.Parse(txtQuartaNota.Text);
                QuartaNota = nota4 * 5;

            }
                        
        }

        /*public double Somar(int PrimeiraNota, int SegundaNota, int TerceiraNota, int QuartaNota)
        {
            double SomaNotas = PrimeiraNota + SegundaNota + TerceiraNota + QuartaNota;
            
            return SomaNotas;
        }*/

        

        private void txtPrimeiraNota_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblQantidadeDeAulas_Click(object sender, EventArgs e)
        {

        }

        private void lblQuantidadeDeFaltas_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void numUpDownNotaCorte_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Soma de todas as notas
            try
            {
                double MediaFinal /*, divisor*/ ;
                SomaNotas = PrimeiraNota + SegundaNota + TerceiraNota + QuartaNota;

                /*SomaNotas = Convert.ToDouble(PrimeiraNota + SegundaNota + TerceiraNota + QuartaNota);*/
                txtMediaFinal.Text = Convert.ToString(MediaFinal = Convert.ToDouble(SomaNotas));
                txtMediaFinal.Text = Convert.ToString(MediaFinal);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro no calculo da Média");
            }

                       
        }

        //Evento do botão btnLimpar, o qual serve para limpar todos os componentes no formulário
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblSituacao.Text = "";
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
                    if (Componente is NumericUpDown)
                    {
                    (Componente as NumericUpDown).Value = 5;
                    }

            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gpbxRecuperacao_Enter(object sender, EventArgs e)
        {

        }

        private void lblSituacao_Click(object sender, EventArgs e) // label em branco, diz a situação do aluno (Aprovado/Reprovado) 
        {

        }
    }
}
