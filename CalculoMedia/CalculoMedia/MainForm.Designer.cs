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
		private System.Windows.Forms.ComboBox cboxPrimeiraNota;
		private System.Windows.Forms.TextBox txtSegundaNota;
		private System.Windows.Forms.ComboBox cboxSegundaNota;
		private System.Windows.Forms.TextBox txtTrabalho;
		private System.Windows.Forms.ComboBox cboxTrabalho;
		private System.Windows.Forms.Label lblPrimeiraNota;
		private System.Windows.Forms.Label lblSegundaNota;
		private System.Windows.Forms.Label lblTrabalho;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label lblQuantidadeDeFaltas;
		private System.Windows.Forms.NumericUpDown numUpDownNotaCorte;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label2;
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
            this.cboxPrimeiraNota = new System.Windows.Forms.ComboBox();
            this.lblPrimeiraNota = new System.Windows.Forms.Label();
            this.lblSegundaNota = new System.Windows.Forms.Label();
            this.lblTrabalho = new System.Windows.Forms.Label();
            this.txtSegundaNota = new System.Windows.Forms.TextBox();
            this.cboxSegundaNota = new System.Windows.Forms.ComboBox();
            this.txtTrabalho = new System.Windows.Forms.TextBox();
            this.cboxTrabalho = new System.Windows.Forms.ComboBox();
            this.lblQantidadeDeAulas = new System.Windows.Forms.Label();
            this.lblQuantidadeDeFaltas = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.numUpDownNotaCorte = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpbxRecuperacao = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.txtPrimeiraNota.TabIndex = 2;
            // 
            // cboxPrimeiraNota
            // 
            this.cboxPrimeiraNota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPrimeiraNota.FormattingEnabled = true;
            this.cboxPrimeiraNota.Items.AddRange(new object[] {
            "2",
            "3",
            "5"});
            this.cboxPrimeiraNota.Location = new System.Drawing.Point(16, 181);
            this.cboxPrimeiraNota.Margin = new System.Windows.Forms.Padding(4);
            this.cboxPrimeiraNota.Name = "cboxPrimeiraNota";
            this.cboxPrimeiraNota.Size = new System.Drawing.Size(94, 24);
            this.cboxPrimeiraNota.TabIndex = 3;
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
            // cboxSegundaNota
            // 
            this.cboxSegundaNota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSegundaNota.FormattingEnabled = true;
            this.cboxSegundaNota.Items.AddRange(new object[] {
            "2",
            "3",
            "5"});
            this.cboxSegundaNota.Location = new System.Drawing.Point(137, 181);
            this.cboxSegundaNota.Margin = new System.Windows.Forms.Padding(4);
            this.cboxSegundaNota.Name = "cboxSegundaNota";
            this.cboxSegundaNota.Size = new System.Drawing.Size(94, 24);
            this.cboxSegundaNota.TabIndex = 3;
            // 
            // txtTrabalho
            // 
            this.txtTrabalho.Location = new System.Drawing.Point(263, 149);
            this.txtTrabalho.Margin = new System.Windows.Forms.Padding(4);
            this.txtTrabalho.Name = "txtTrabalho";
            this.txtTrabalho.Size = new System.Drawing.Size(94, 22);
            this.txtTrabalho.TabIndex = 2;
            // 
            // cboxTrabalho
            // 
            this.cboxTrabalho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTrabalho.FormattingEnabled = true;
            this.cboxTrabalho.Items.AddRange(new object[] {
            "2",
            "3",
            "5"});
            this.cboxTrabalho.Location = new System.Drawing.Point(263, 181);
            this.cboxTrabalho.Margin = new System.Windows.Forms.Padding(4);
            this.cboxTrabalho.Name = "cboxTrabalho";
            this.cboxTrabalho.Size = new System.Drawing.Size(94, 24);
            this.cboxTrabalho.TabIndex = 3;
            // 
            // lblQantidadeDeAulas
            // 
            this.lblQantidadeDeAulas.Location = new System.Drawing.Point(10, 221);
            this.lblQantidadeDeAulas.Name = "lblQantidadeDeAulas";
            this.lblQantidadeDeAulas.Size = new System.Drawing.Size(72, 23);
            this.lblQantidadeDeAulas.TabIndex = 5;
            this.lblQantidadeDeAulas.Text = "Qde Aulas";
            // 
            // lblQuantidadeDeFaltas
            // 
            this.lblQuantidadeDeFaltas.Location = new System.Drawing.Point(10, 254);
            this.lblQuantidadeDeFaltas.Name = "lblQuantidadeDeFaltas";
            this.lblQuantidadeDeFaltas.Size = new System.Drawing.Size(83, 23);
            this.lblQuantidadeDeFaltas.TabIndex = 5;
            this.lblQuantidadeDeFaltas.Text = "Qde Faltas";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(88, 218);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(88, 251);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 6;
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
            this.numUpDownNotaCorte.TabIndex = 7;
            this.numUpDownNotaCorte.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(263, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nota de Corte";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(108, 382);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(94, 52);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular Média";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(213, 382);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(112, 52);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(108, 335);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(94, 22);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 310);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Média Final";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.Label1Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(210, 335);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 22);
            this.textBox3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 310);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aproveitamento";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.Label1Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(192, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "Média do Aluno (temporário)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox1.Location = new System.Drawing.Point(462, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recuperação";
            // 
            // gpbxRecuperacao
            // 
            this.gpbxRecuperacao.Controls.Add(this.label8);
            this.gpbxRecuperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbxRecuperacao.Location = new System.Drawing.Point(462, 310);
            this.gpbxRecuperacao.Name = "gpbxRecuperacao";
            this.gpbxRecuperacao.Size = new System.Drawing.Size(134, 100);
            this.gpbxRecuperacao.TabIndex = 11;
            this.gpbxRecuperacao.TabStop = false;
            this.gpbxRecuperacao.Text = "Situação";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "label7";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 26);
            this.textBox1.TabIndex = 2;
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
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numUpDownNotaCorte);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.lblQuantidadeDeFaltas);
            this.Controls.Add(this.lblQantidadeDeAulas);
            this.Controls.Add(this.lblTrabalho);
            this.Controls.Add(this.lblSegundaNota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrimeiraNota);
            this.Controls.Add(this.cboxTrabalho);
            this.Controls.Add(this.cboxSegundaNota);
            this.Controls.Add(this.cboxPrimeiraNota);
            this.Controls.Add(this.txtTrabalho);
            this.Controls.Add(this.txtSegundaNota);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
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
            this.gpbxRecuperacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblQantidadeDeAulas;
    }
}
