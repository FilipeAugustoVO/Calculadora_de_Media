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

        int selectedIndex;

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



        private void cboxAvaliacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxAvaliacao.SelectedItem.ToString() == "1 Avaliação + Trabalho")
            {
                txtPrimeiraNota.Text = "Primeira Nota Funcionando";
                txtSegundaNota.Text = "Segunda Nota Funcionando";
                lblSegundaNota.Text = "Trabalho";
                gboxTerceiraNota.Visible = false;
                gboxQuartaNota.Visible = false;
            }

            if(cboxAvaliacao.SelectedItem.ToString() == "2 Avaliações")
            {
                txtPrimeiraNota.Text = "Primeira Nota Funcionando";
                txtSegundaNota.Text = "Segunda Nota Funcionando";
                lblSegundaNota.Text = "Segunda Nota";
                gboxTerceiraNota.Visible = false;
                gboxQuartaNota.Visible = false;
            }

            if (cboxAvaliacao.SelectedItem.ToString() == "2 Avaliações + Trabalho")
            {
                txtPrimeiraNota.Text = "Primeira Nota Funcionando";
                txtSegundaNota.Text = "Segunda Nota Funcionando";
                txtTerceiraNota.Text = "Terceira Nota Funcionando";
                lblTerceiraNota.Text = "Trabalho";
                gboxTerceiraNota.Visible = true;                 
                gboxQuartaNota.Visible = false;
            }

            
            if (cboxAvaliacao.SelectedItem.ToString() == "3 Avaliações")
            {
                txtPrimeiraNota.Text = "Primeira Nota Funcionando";
                txtSegundaNota.Text = "Segunda Nota Funcionando";
                txtTerceiraNota.Text = "Terceira Nota Funcionando";
                lblTerceiraNota.Text = "Terceira Nota";
                gboxTerceiraNota.Visible = true;
                gboxQuartaNota.Visible = false;
            }

            
            if (cboxAvaliacao.SelectedItem.ToString() == "3 Avaliações + Trabalho")
            {
                txtPrimeiraNota.Text = "Primeira Nota Funcionando";
                txtSegundaNota.Text = "Segunda Nota Funcionando";
                txtTerceiraNota.Text = "Terceira Nota Funcionando";
                txtQuartaNota.Text = "Quarta Nota Funcionando";
                lblQuartaNota.Text = "Trabalho";
                gboxTerceiraNota.Visible = true;
                gboxQuartaNota.Visible = true;
            }

            if (cboxAvaliacao.SelectedItem.ToString() == "4 Avaliações")
            {
                txtPrimeiraNota.Text = "Primeira Nota Funcionando";
                txtSegundaNota.Text = "Segunda Nota Funcionando";
                txtTerceiraNota.Text = "Terceira Nota Funcionando";
                txtQuartaNota.Text = "Quarta Nota Funcionando";
                lblQuartaNota.Text = "Quarta Nota";
                gboxTerceiraNota.Visible = true;
                gboxQuartaNota.Visible = true;
            } 
        }

        private void txtSegundaNota_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboxPrimeiraNota_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gpbxRecuperacao_Enter(object sender, EventArgs e)
        {

        }
    }
}
