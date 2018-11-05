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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gpbxRecuperacao = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxAvaliacao = new System.Windows.Forms.ComboBox();
            this.lblFormatoAvaliacao = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNotaCorte)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gpbxRecuperacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.txtPrimeiraNota.Location = new System.Drawing.Point(16, 171);
            this.txtPrimeiraNota.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrimeiraNota.Name = "txtPrimeiraNota";
            this.txtPrimeiraNota.Size = new System.Drawing.Size(94, 22);
            this.txtPrimeiraNota.TabIndex = 2;
            this.txtPrimeiraNota.TextChanged += new System.EventHandler(this.txtPrimeiraNota_TextChanged);
            // 
            // cboxPrimeiraNota
            // 
            this.cboxPrimeiraNota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPrimeiraNota.FormattingEnabled = true;
            this.cboxPrimeiraNota.Items.AddRange(new object[] {
            "2",
            "3",
            "5"});
            this.cboxPrimeiraNota.Location = new System.Drawing.Point(16, 203);
            this.cboxPrimeiraNota.Margin = new System.Windows.Forms.Padding(4);
            this.cboxPrimeiraNota.Name = "cboxPrimeiraNota";
            this.cboxPrimeiraNota.Size = new System.Drawing.Size(94, 24);
            this.cboxPrimeiraNota.TabIndex = 3;
            this.cboxPrimeiraNota.SelectedIndexChanged += new System.EventHandler(this.cboxPrimeiraNota_SelectedIndexChanged);
            // 
            // lblPrimeiraNota
            // 
            this.lblPrimeiraNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimeiraNota.Location = new System.Drawing.Point(16, 146);
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
            this.lblSegundaNota.Location = new System.Drawing.Point(128, 146);
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
            this.lblTrabalho.Location = new System.Drawing.Point(378, 146);
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
            this.txtSegundaNota.Location = new System.Drawing.Point(137, 171);
            this.txtSegundaNota.Margin = new System.Windows.Forms.Padding(4);
            this.txtSegundaNota.Name = "txtSegundaNota";
            this.txtSegundaNota.Size = new System.Drawing.Size(94, 22);
            this.txtSegundaNota.TabIndex = 2;
            this.txtSegundaNota.TextChanged += new System.EventHandler(this.txtSegundaNota_TextChanged);
            // 
            // cboxSegundaNota
            // 
            this.cboxSegundaNota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSegundaNota.FormattingEnabled = true;
            this.cboxSegundaNota.Items.AddRange(new object[] {
            "2",
            "3",
            "5"});
            this.cboxSegundaNota.Location = new System.Drawing.Point(137, 203);
            this.cboxSegundaNota.Margin = new System.Windows.Forms.Padding(4);
            this.cboxSegundaNota.Name = "cboxSegundaNota";
            this.cboxSegundaNota.Size = new System.Drawing.Size(94, 24);
            this.cboxSegundaNota.TabIndex = 3;
            this.cboxSegundaNota.SelectedIndexChanged += new System.EventHandler(this.cboxSegundaNota_SelectedIndexChanged);
            // 
            // txtTrabalho
            // 
            this.txtTrabalho.Location = new System.Drawing.Point(378, 171);
            this.txtTrabalho.Margin = new System.Windows.Forms.Padding(4);
            this.txtTrabalho.Name = "txtTrabalho";
            this.txtTrabalho.Size = new System.Drawing.Size(94, 22);
            this.txtTrabalho.TabIndex = 2;
            this.txtTrabalho.TextChanged += new System.EventHandler(this.txtTrabalho_TextChanged);
            // 
            // cboxTrabalho
            // 
            this.cboxTrabalho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTrabalho.FormattingEnabled = true;
            this.cboxTrabalho.Items.AddRange(new object[] {
            "2",
            "3",
            "5"});
            this.cboxTrabalho.Location = new System.Drawing.Point(378, 203);
            this.cboxTrabalho.Margin = new System.Windows.Forms.Padding(4);
            this.cboxTrabalho.Name = "cboxTrabalho";
            this.cboxTrabalho.Size = new System.Drawing.Size(94, 24);
            this.cboxTrabalho.TabIndex = 3;
            this.cboxTrabalho.SelectedIndexChanged += new System.EventHandler(this.cboxTrabalho_SelectedIndexChanged);
            // 
            // lblQantidadeDeAulas
            // 
            this.lblQantidadeDeAulas.Location = new System.Drawing.Point(10, 243);
            this.lblQantidadeDeAulas.Name = "lblQantidadeDeAulas";
            this.lblQantidadeDeAulas.Size = new System.Drawing.Size(72, 23);
            this.lblQantidadeDeAulas.TabIndex = 5;
            this.lblQantidadeDeAulas.Text = "Qde Aulas";
            this.lblQantidadeDeAulas.Click += new System.EventHandler(this.lblQantidadeDeAulas_Click);
            // 
            // lblQuantidadeDeFaltas
            // 
            this.lblQuantidadeDeFaltas.Location = new System.Drawing.Point(10, 276);
            this.lblQuantidadeDeFaltas.Name = "lblQuantidadeDeFaltas";
            this.lblQuantidadeDeFaltas.Size = new System.Drawing.Size(83, 23);
            this.lblQuantidadeDeFaltas.TabIndex = 5;
            this.lblQuantidadeDeFaltas.Text = "Qde Faltas";
            this.lblQuantidadeDeFaltas.Click += new System.EventHandler(this.lblQuantidadeDeFaltas_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(88, 240);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 6;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(88, 273);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 6;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // numUpDownNotaCorte
            // 
            this.numUpDownNotaCorte.Location = new System.Drawing.Point(210, 269);
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
            this.numUpDownNotaCorte.ValueChanged += new System.EventHandler(this.numUpDownNotaCorte_ValueChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(210, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nota de Corte";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(108, 404);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(94, 52);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular Média";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(213, 404);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(112, 52);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(108, 357);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(94, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 332);
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
            this.textBox3.Location = new System.Drawing.Point(210, 357);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 22);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 332);
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
            this.groupBox1.Location = new System.Drawing.Point(479, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recuperação";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 26);
            this.textBox1.TabIndex = 2;
            // 
            // gpbxRecuperacao
            // 
            this.gpbxRecuperacao.Controls.Add(this.label8);
            this.gpbxRecuperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbxRecuperacao.Location = new System.Drawing.Point(479, 332);
            this.gpbxRecuperacao.Name = "gpbxRecuperacao";
            this.gpbxRecuperacao.Size = new System.Drawing.Size(134, 100);
            this.gpbxRecuperacao.TabIndex = 11;
            this.gpbxRecuperacao.TabStop = false;
            this.gpbxRecuperacao.Text = "Situação";
            this.gpbxRecuperacao.Enter += new System.EventHandler(this.gpbxRecuperacao_Enter);
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
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(336, 269);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(336, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "Minimo de Aproveitamento";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cboxAvaliacao
            // 
            this.cboxAvaliacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAvaliacao.FormattingEnabled = true;
            this.cboxAvaliacao.Items.AddRange(new object[] {
            "1 Avaliação + Trabalho",
            "2 Avaliações",
            "2 Avaliações + Trabalho",
            "3 Avaliações",
            "3 Avaliações + Trabalho",
            "4 Avaliações"});
            this.cboxAvaliacao.Location = new System.Drawing.Point(13, 118);
            this.cboxAvaliacao.Margin = new System.Windows.Forms.Padding(4);
            this.cboxAvaliacao.Name = "cboxAvaliacao";
            this.cboxAvaliacao.Size = new System.Drawing.Size(220, 24);
            this.cboxAvaliacao.TabIndex = 3;
            this.cboxAvaliacao.SelectedIndexChanged += new System.EventHandler(this.cboxSegundaNota_SelectedIndexChanged);
            // 
            // lblFormatoAvaliacao
            // 
            this.lblFormatoAvaliacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormatoAvaliacao.Location = new System.Drawing.Point(13, 82);
            this.lblFormatoAvaliacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormatoAvaliacao.Name = "lblFormatoAvaliacao";
            this.lblFormatoAvaliacao.Size = new System.Drawing.Size(220, 21);
            this.lblFormatoAvaliacao.TabIndex = 4;
            this.lblFormatoAvaliacao.Text = "Formato de Avaliação";
            this.lblFormatoAvaliacao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblFormatoAvaliacao.Click += new System.EventHandler(this.Label1Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(262, 171);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(94, 22);
            this.textBox4.TabIndex = 2;
            this.textBox4.TextChanged += new System.EventHandler(this.txtTrabalho_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2",
            "3",
            "5"});
            this.comboBox2.Location = new System.Drawing.Point(262, 203);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(94, 24);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.cboxTrabalho_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(249, 146);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "Terceira Nota";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Click += new System.EventHandler(this.Label1Click);
            // 
            // FormaCalculo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 468);
            this.Controls.Add(this.gpbxRecuperacao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numUpDownNotaCorte);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.lblQuantidadeDeFaltas);
            this.Controls.Add(this.lblQantidadeDeAulas);
            this.Controls.Add(this.lblTrabalho);
            this.Controls.Add(this.lblFormatoAvaliacao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblSegundaNota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrimeiraNota);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.cboxTrabalho);
            this.Controls.Add(this.cboxAvaliacao);
            this.Controls.Add(this.cboxSegundaNota);
            this.Controls.Add(this.cboxPrimeiraNota);
            this.Controls.Add(this.textBox4);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblQantidadeDeAulas;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxAvaliacao;
        private System.Windows.Forms.Label lblFormatoAvaliacao;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label9;
    }
}
