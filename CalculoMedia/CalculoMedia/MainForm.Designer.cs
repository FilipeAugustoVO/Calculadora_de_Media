/*
 * Created by SharpDevelop.
 * User: Convidado
 * Date: 12/09/2018
 * Time: 16:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CalculoMedia
{
	partial class FormaCalculo1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtPrimeiraNota;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox txtSegundaNota;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Label lblPrimeiraNota;
		private System.Windows.Forms.Label lblSegundaNota;
		private System.Windows.Forms.Label lblTrabalho;
		private System.Windows.Forms.TextBox txtQdeAulas;
		private System.Windows.Forms.TextBox txtQdeFaltas;
		private System.Windows.Forms.Label lblAulas;
		private System.Windows.Forms.Label lblFaltas;
		private System.Windows.Forms.NumericUpDown numUpDownNotaCorte;
		private System.Windows.Forms.Label lblNotaCorte;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.TextBox txtMediaFinal;
		private System.Windows.Forms.Label lblMediaFinal;
		private System.Windows.Forms.TextBox txtAproveitamento;
		private System.Windows.Forms.Label lblAproveitamento;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox gpbxRecuperacao;
		
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPrimeiraNota = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblPrimeiraNota = new System.Windows.Forms.Label();
            this.lblSegundaNota = new System.Windows.Forms.Label();
            this.lblTrabalho = new System.Windows.Forms.Label();
            this.txtSegundaNota = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lblAulas = new System.Windows.Forms.Label();
            this.lblFaltas = new System.Windows.Forms.Label();
            this.txtQdeAulas = new System.Windows.Forms.TextBox();
            this.txtQdeFaltas = new System.Windows.Forms.TextBox();
            this.numUpDownNotaCorte = new System.Windows.Forms.NumericUpDown();
            this.lblNotaCorte = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtMediaFinal = new System.Windows.Forms.TextBox();
            this.lblMediaFinal = new System.Windows.Forms.Label();
            this.txtAproveitamento = new System.Windows.Forms.TextBox();
            this.lblAproveitamento = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRecuperacao = new System.Windows.Forms.TextBox();
            this.gpbxRecuperacao = new System.Windows.Forms.GroupBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNotaCorte)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gpbxRecuperacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(93, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(471, 63);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtPrimeiraNota
            // 
            this.txtPrimeiraNota.Location = new System.Drawing.Point(16, 149);
            this.txtPrimeiraNota.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrimeiraNota.Name = "txtPrimeiraNota";
            this.txtPrimeiraNota.Size = new System.Drawing.Size(94, 22);
            this.txtPrimeiraNota.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "3",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(16, 181);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(94, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // lblPrimeiraNota
            // 
            this.lblPrimeiraNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimeiraNota.Location = new System.Drawing.Point(16, 124);
            this.lblPrimeiraNota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrimeiraNota.Name = "lblPrimeiraNota";
            this.lblPrimeiraNota.Size = new System.Drawing.Size(94, 21);
            this.lblPrimeiraNota.TabIndex = 4;
            this.lblPrimeiraNota.Text = "Primeira Nota";
            this.lblPrimeiraNota.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPrimeiraNota.Click += new System.EventHandler(this.Label1Click);
            // 
            // lblSegundaNota
            // 
            this.lblSegundaNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundaNota.Location = new System.Drawing.Point(128, 124);
            this.lblSegundaNota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSegundaNota.Name = "lblSegundaNota";
            this.lblSegundaNota.Size = new System.Drawing.Size(114, 21);
            this.lblSegundaNota.TabIndex = 4;
            this.lblSegundaNota.Text = "Segunda Nota";
            this.lblSegundaNota.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSegundaNota.Click += new System.EventHandler(this.Label1Click);
            // 
            // lblTrabalho
            // 
            this.lblTrabalho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrabalho.Location = new System.Drawing.Point(263, 124);
            this.lblTrabalho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrabalho.Name = "lblTrabalho";
            this.lblTrabalho.Size = new System.Drawing.Size(94, 21);
            this.lblTrabalho.TabIndex = 4;
            this.lblTrabalho.Text = "Trabalho";
            this.lblTrabalho.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTrabalho.Click += new System.EventHandler(this.Label1Click);
            // 
            // txtSegundaNota
            // 
            this.txtSegundaNota.Location = new System.Drawing.Point(137, 149);
            this.txtSegundaNota.Margin = new System.Windows.Forms.Padding(4);
            this.txtSegundaNota.Name = "txtSegundaNota";
            this.txtSegundaNota.Size = new System.Drawing.Size(94, 22);
            this.txtSegundaNota.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2",
            "3",
            "5"});
            this.comboBox2.Location = new System.Drawing.Point(137, 181);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(94, 24);
            this.comboBox2.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(263, 149);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(94, 22);
            this.textBox4.TabIndex = 4;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "2",
            "3",
            "5"});
            this.comboBox3.Location = new System.Drawing.Point(263, 181);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(94, 24);
            this.comboBox3.TabIndex = 5;
            // 
            // lblAulas
            // 
            this.lblAulas.Location = new System.Drawing.Point(10, 221);
            this.lblAulas.Name = "lblAulas";
            this.lblAulas.Size = new System.Drawing.Size(72, 23);
            this.lblAulas.TabIndex = 5;
            this.lblAulas.Text = "Qde Aulas";
            // 
            // lblFaltas
            // 
            this.lblFaltas.Location = new System.Drawing.Point(10, 254);
            this.lblFaltas.Name = "lblFaltas";
            this.lblFaltas.Size = new System.Drawing.Size(83, 23);
            this.lblFaltas.TabIndex = 5;
            this.lblFaltas.Text = "Qde Faltas";
            // 
            // txtQdeAulas
            // 
            this.txtQdeAulas.Location = new System.Drawing.Point(88, 218);
            this.txtQdeAulas.Name = "txtQdeAulas";
            this.txtQdeAulas.Size = new System.Drawing.Size(100, 22);
            this.txtQdeAulas.TabIndex = 6;
            this.txtQdeAulas.TextChanged += new System.EventHandler(this.txtAulas_TextChanged);
            // 
            // txtQdeFaltas
            // 
            this.txtQdeFaltas.Location = new System.Drawing.Point(88, 251);
            this.txtQdeFaltas.Name = "txtQdeFaltas";
            this.txtQdeFaltas.Size = new System.Drawing.Size(100, 22);
            this.txtQdeFaltas.TabIndex = 7;
            // 
            // numUpDownNotaCorte
            // 
            this.numUpDownNotaCorte.Location = new System.Drawing.Point(263, 251);
            this.numUpDownNotaCorte.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numUpDownNotaCorte.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDownNotaCorte.Name = "numUpDownNotaCorte";
            this.numUpDownNotaCorte.Size = new System.Drawing.Size(120, 22);
            this.numUpDownNotaCorte.TabIndex = 8;
            this.numUpDownNotaCorte.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblNotaCorte
            // 
            this.lblNotaCorte.Location = new System.Drawing.Point(263, 225);
            this.lblNotaCorte.Name = "lblNotaCorte";
            this.lblNotaCorte.Size = new System.Drawing.Size(100, 23);
            this.lblNotaCorte.TabIndex = 8;
            this.lblNotaCorte.Text = "Nota de Corte";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(76, 382);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(112, 52);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(266, 382);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(112, 52);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtMediaFinal
            // 
            this.txtMediaFinal.Location = new System.Drawing.Point(88, 335);
            this.txtMediaFinal.Margin = new System.Windows.Forms.Padding(4);
            this.txtMediaFinal.Name = "txtMediaFinal";
            this.txtMediaFinal.Size = new System.Drawing.Size(94, 22);
            this.txtMediaFinal.TabIndex = 2;
            // 
            // lblMediaFinal
            // 
            this.lblMediaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaFinal.Location = new System.Drawing.Point(88, 310);
            this.lblMediaFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMediaFinal.Name = "lblMediaFinal";
            this.lblMediaFinal.Size = new System.Drawing.Size(94, 21);
            this.lblMediaFinal.TabIndex = 4;
            this.lblMediaFinal.Text = "Média Final";
            this.lblMediaFinal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMediaFinal.Click += new System.EventHandler(this.Label1Click);
            // 
            // txtAproveitamento
            // 
            this.txtAproveitamento.Location = new System.Drawing.Point(263, 335);
            this.txtAproveitamento.Margin = new System.Windows.Forms.Padding(4);
            this.txtAproveitamento.Name = "txtAproveitamento";
            this.txtAproveitamento.Size = new System.Drawing.Size(120, 22);
            this.txtAproveitamento.TabIndex = 2;
            this.txtAproveitamento.TextChanged += new System.EventHandler(this.txtAproveitamento_TextChanged);
            // 
            // lblAproveitamento
            // 
            this.lblAproveitamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAproveitamento.Location = new System.Drawing.Point(263, 310);
            this.lblAproveitamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAproveitamento.Name = "lblAproveitamento";
            this.lblAproveitamento.Size = new System.Drawing.Size(120, 21);
            this.lblAproveitamento.TabIndex = 4;
            this.lblAproveitamento.Text = "Aproveitamento";
            this.lblAproveitamento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAproveitamento.Click += new System.EventHandler(this.Label1Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(208, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "Média do Aluno (temporário)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRecuperacao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox1.Location = new System.Drawing.Point(462, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recuperação";
            // 
            // txtRecuperacao
            // 
            this.txtRecuperacao.Location = new System.Drawing.Point(21, 45);
            this.txtRecuperacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtRecuperacao.Name = "txtRecuperacao";
            this.txtRecuperacao.Size = new System.Drawing.Size(94, 26);
            this.txtRecuperacao.TabIndex = 2;
            this.txtRecuperacao.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // gpbxRecuperacao
            // 
            this.gpbxRecuperacao.Controls.Add(this.lblSituacao);
            this.gpbxRecuperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbxRecuperacao.Location = new System.Drawing.Point(462, 310);
            this.gpbxRecuperacao.Name = "gpbxRecuperacao";
            this.gpbxRecuperacao.Size = new System.Drawing.Size(134, 100);
            this.gpbxRecuperacao.TabIndex = 11;
            this.gpbxRecuperacao.TabStop = false;
            this.gpbxRecuperacao.Text = "Situação";
            // 
            // lblSituacao
            // 
            this.lblSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.Location = new System.Drawing.Point(21, 47);
            this.lblSituacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(94, 21);
            this.lblSituacao.TabIndex = 4;
            this.lblSituacao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSituacao.Click += new System.EventHandler(this.Label1Click);
            // 
            // FormaCalculo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 446);
            this.Controls.Add(this.gpbxRecuperacao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblNotaCorte);
            this.Controls.Add(this.numUpDownNotaCorte);
            this.Controls.Add(this.txtQdeFaltas);
            this.Controls.Add(this.txtQdeAulas);
            this.Controls.Add(this.lblFaltas);
            this.Controls.Add(this.lblAulas);
            this.Controls.Add(this.lblTrabalho);
            this.Controls.Add(this.lblSegundaNota);
            this.Controls.Add(this.lblAproveitamento);
            this.Controls.Add(this.lblMediaFinal);
            this.Controls.Add(this.lblPrimeiraNota);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtSegundaNota);
            this.Controls.Add(this.txtAproveitamento);
            this.Controls.Add(this.txtMediaFinal);
            this.Controls.Add(this.txtPrimeiraNota);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormaCalculo1";
            this.Text = "CalculoMedia";
            this.Load += new System.EventHandler(this.FormaCalculo1Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNotaCorte)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbxRecuperacao.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.TextBox txtRecuperacao;
        private System.Windows.Forms.Label lblSituacao;
    }
}
