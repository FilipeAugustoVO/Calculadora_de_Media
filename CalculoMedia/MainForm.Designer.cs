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
		private System.Windows.Forms.TextBox txtAulas;
		private System.Windows.Forms.TextBox txtFaltas;
		private System.Windows.Forms.Label lblQuantidadeDeFaltas;
		private System.Windows.Forms.NumericUpDown numUpDownNotaCorte;
		private System.Windows.Forms.Label lblNotaCorte;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.TextBox txtMediaFinal;
		private System.Windows.Forms.Label lblMediaFinal;
		private System.Windows.Forms.TextBox txtAproveitamento;
		private System.Windows.Forms.Label lblAproveitamentoAluno;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox gboxNotaRecuperacao;
		private System.Windows.Forms.GroupBox gboxRecuperacao;
		
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
            this.lblQantidadeDeAulas = new System.Windows.Forms.Label();
            this.lblQuantidadeDeFaltas = new System.Windows.Forms.Label();
            this.txtAulas = new System.Windows.Forms.TextBox();
            this.txtFaltas = new System.Windows.Forms.TextBox();
            this.numUpDownNotaCorte = new System.Windows.Forms.NumericUpDown();
            this.lblNotaCorte = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtMediaFinal = new System.Windows.Forms.TextBox();
            this.lblMediaFinal = new System.Windows.Forms.Label();
            this.txtAproveitamento = new System.Windows.Forms.TextBox();
            this.lblAproveitamentoAluno = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gboxNotaRecuperacao = new System.Windows.Forms.GroupBox();
            this.txtRecuperacao = new System.Windows.Forms.TextBox();
            this.gboxRecuperacao = new System.Windows.Forms.GroupBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.numUpDownAproveitamento = new System.Windows.Forms.NumericUpDown();
            this.lblAproveitamento = new System.Windows.Forms.Label();
            this.cboxAvaliacao = new System.Windows.Forms.ComboBox();
            this.lblFormatoAvaliacao = new System.Windows.Forms.Label();
            this.txtPrimeiraNota = new System.Windows.Forms.TextBox();
            this.cboxPrimeiraNota = new System.Windows.Forms.ComboBox();
            this.lblPrimeiraNota = new System.Windows.Forms.Label();
            this.gboxPrimeiraNota = new System.Windows.Forms.GroupBox();
            this.gboxSegundaNota = new System.Windows.Forms.GroupBox();
            this.lblSegundaNota = new System.Windows.Forms.Label();
            this.cboxSegundaNota = new System.Windows.Forms.ComboBox();
            this.txtSegundaNota = new System.Windows.Forms.TextBox();
            this.gboxTerceiraNota = new System.Windows.Forms.GroupBox();
            this.lblTerceiraNota = new System.Windows.Forms.Label();
            this.cboxTerceiraNota = new System.Windows.Forms.ComboBox();
            this.txtTerceiraNota = new System.Windows.Forms.TextBox();
            this.gboxQuartaNota = new System.Windows.Forms.GroupBox();
            this.lblQuartaNota = new System.Windows.Forms.Label();
            this.cboxQuartaNota = new System.Windows.Forms.ComboBox();
            this.txtQuartaNota = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNotaCorte)).BeginInit();
            this.gboxNotaRecuperacao.SuspendLayout();
            this.gboxRecuperacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAproveitamento)).BeginInit();
            this.gboxPrimeiraNota.SuspendLayout();
            this.gboxSegundaNota.SuspendLayout();
            this.gboxTerceiraNota.SuspendLayout();
            this.gboxQuartaNota.SuspendLayout();
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
            // txtAulas
            // 
            this.txtAulas.Location = new System.Drawing.Point(88, 240);
            this.txtAulas.Name = "txtAulas";
            this.txtAulas.Size = new System.Drawing.Size(100, 22);
            this.txtAulas.TabIndex = 6;
            this.txtAulas.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtFaltas
            // 
            this.txtFaltas.Location = new System.Drawing.Point(88, 273);
            this.txtFaltas.Name = "txtFaltas";
            this.txtFaltas.Size = new System.Drawing.Size(100, 22);
            this.txtFaltas.TabIndex = 6;
            this.txtFaltas.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
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
            // lblNotaCorte
            // 
            this.lblNotaCorte.Location = new System.Drawing.Point(210, 243);
            this.lblNotaCorte.Name = "lblNotaCorte";
            this.lblNotaCorte.Size = new System.Drawing.Size(100, 23);
            this.lblNotaCorte.TabIndex = 8;
            this.lblNotaCorte.Text = "Nota de Corte";
            this.lblNotaCorte.Click += new System.EventHandler(this.label6_Click);
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
            // txtMediaFinal
            // 
            this.txtMediaFinal.Location = new System.Drawing.Point(108, 357);
            this.txtMediaFinal.Margin = new System.Windows.Forms.Padding(4);
            this.txtMediaFinal.Name = "txtMediaFinal";
            this.txtMediaFinal.Size = new System.Drawing.Size(94, 22);
            this.txtMediaFinal.TabIndex = 2;
            this.txtMediaFinal.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblMediaFinal
            // 
            this.lblMediaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaFinal.Location = new System.Drawing.Point(108, 332);
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
            this.txtAproveitamento.Location = new System.Drawing.Point(210, 357);
            this.txtAproveitamento.Margin = new System.Windows.Forms.Padding(4);
            this.txtAproveitamento.Name = "txtAproveitamento";
            this.txtAproveitamento.Size = new System.Drawing.Size(120, 22);
            this.txtAproveitamento.TabIndex = 2;
            this.txtAproveitamento.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblAproveitamentoAluno
            // 
            this.lblAproveitamentoAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAproveitamentoAluno.Location = new System.Drawing.Point(210, 332);
            this.lblAproveitamentoAluno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAproveitamentoAluno.Name = "lblAproveitamentoAluno";
            this.lblAproveitamentoAluno.Size = new System.Drawing.Size(120, 21);
            this.lblAproveitamentoAluno.TabIndex = 4;
            this.lblAproveitamentoAluno.Text = "Aproveitamento";
            this.lblAproveitamentoAluno.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAproveitamentoAluno.Click += new System.EventHandler(this.Label1Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(192, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "Média do Aluno (temporário)";
            // 
            // gboxNotaRecuperacao
            // 
            this.gboxNotaRecuperacao.Controls.Add(this.txtRecuperacao);
            this.gboxNotaRecuperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxNotaRecuperacao.ForeColor = System.Drawing.Color.Firebrick;
            this.gboxNotaRecuperacao.Location = new System.Drawing.Point(499, 146);
            this.gboxNotaRecuperacao.Name = "gboxNotaRecuperacao";
            this.gboxNotaRecuperacao.Size = new System.Drawing.Size(134, 88);
            this.gboxNotaRecuperacao.TabIndex = 11;
            this.gboxNotaRecuperacao.TabStop = false;
            this.gboxNotaRecuperacao.Text = "Recuperação";
            this.gboxNotaRecuperacao.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtRecuperacao
            // 
            this.txtRecuperacao.Location = new System.Drawing.Point(20, 26);
            this.txtRecuperacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtRecuperacao.Name = "txtRecuperacao";
            this.txtRecuperacao.Size = new System.Drawing.Size(94, 26);
            this.txtRecuperacao.TabIndex = 2;
            // 
            // gboxRecuperacao
            // 
            this.gboxRecuperacao.Controls.Add(this.lblSituacao);
            this.gboxRecuperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxRecuperacao.Location = new System.Drawing.Point(479, 332);
            this.gboxRecuperacao.Name = "gboxRecuperacao";
            this.gboxRecuperacao.Size = new System.Drawing.Size(134, 100);
            this.gboxRecuperacao.TabIndex = 11;
            this.gboxRecuperacao.TabStop = false;
            this.gboxRecuperacao.Text = "Situação";
            this.gboxRecuperacao.Enter += new System.EventHandler(this.gpbxRecuperacao_Enter);
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(45, 45);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(0, 20);
            this.lblSituacao.TabIndex = 0;
            this.lblSituacao.Click += new System.EventHandler(this.lblSituacao_Click);
            // 
            // numUpDownAproveitamento
            // 
            this.numUpDownAproveitamento.Location = new System.Drawing.Point(336, 269);
            this.numUpDownAproveitamento.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numUpDownAproveitamento.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDownAproveitamento.Name = "numUpDownAproveitamento";
            this.numUpDownAproveitamento.Size = new System.Drawing.Size(120, 22);
            this.numUpDownAproveitamento.TabIndex = 7;
            this.numUpDownAproveitamento.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDownAproveitamento.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblAproveitamento
            // 
            this.lblAproveitamento.Location = new System.Drawing.Point(336, 231);
            this.lblAproveitamento.Name = "lblAproveitamento";
            this.lblAproveitamento.Size = new System.Drawing.Size(120, 35);
            this.lblAproveitamento.TabIndex = 8;
            this.lblAproveitamento.Text = "Minimo de Aproveitamento";
            this.lblAproveitamento.Click += new System.EventHandler(this.label3_Click);
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
            this.cboxAvaliacao.SelectedIndexChanged += new System.EventHandler(this.cboxAvaliacao_SelectedIndexChanged);
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
            // txtPrimeiraNota
            // 
            this.txtPrimeiraNota.Location = new System.Drawing.Point(11, 25);
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
            this.cboxPrimeiraNota.Location = new System.Drawing.Point(11, 57);
            this.cboxPrimeiraNota.Margin = new System.Windows.Forms.Padding(4);
            this.cboxPrimeiraNota.Name = "cboxPrimeiraNota";
            this.cboxPrimeiraNota.Size = new System.Drawing.Size(94, 24);
            this.cboxPrimeiraNota.TabIndex = 3;
            this.cboxPrimeiraNota.SelectedIndexChanged += new System.EventHandler(this.cboxPrimeiraNota_SelectedIndexChanged);
            // 
            // lblPrimeiraNota
            // 
            this.lblPrimeiraNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimeiraNota.Location = new System.Drawing.Point(12, 0);
            this.lblPrimeiraNota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrimeiraNota.Name = "lblPrimeiraNota";
            this.lblPrimeiraNota.Size = new System.Drawing.Size(94, 21);
            this.lblPrimeiraNota.TabIndex = 4;
            this.lblPrimeiraNota.Text = "Primeira Nota";
            this.lblPrimeiraNota.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPrimeiraNota.Click += new System.EventHandler(this.Label1Click);
            // 
            // gboxPrimeiraNota
            // 
            this.gboxPrimeiraNota.Controls.Add(this.lblPrimeiraNota);
            this.gboxPrimeiraNota.Controls.Add(this.cboxPrimeiraNota);
            this.gboxPrimeiraNota.Controls.Add(this.txtPrimeiraNota);
            this.gboxPrimeiraNota.Location = new System.Drawing.Point(5, 146);
            this.gboxPrimeiraNota.Name = "gboxPrimeiraNota";
            this.gboxPrimeiraNota.Size = new System.Drawing.Size(116, 88);
            this.gboxPrimeiraNota.TabIndex = 12;
            this.gboxPrimeiraNota.TabStop = false;
            // 
            // gboxSegundaNota
            // 
            this.gboxSegundaNota.Controls.Add(this.lblSegundaNota);
            this.gboxSegundaNota.Controls.Add(this.cboxSegundaNota);
            this.gboxSegundaNota.Controls.Add(this.txtSegundaNota);
            this.gboxSegundaNota.Location = new System.Drawing.Point(127, 146);
            this.gboxSegundaNota.Name = "gboxSegundaNota";
            this.gboxSegundaNota.Size = new System.Drawing.Size(116, 88);
            this.gboxSegundaNota.TabIndex = 12;
            this.gboxSegundaNota.TabStop = false;
            // 
            // lblSegundaNota
            // 
            this.lblSegundaNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundaNota.Location = new System.Drawing.Point(7, 0);
            this.lblSegundaNota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSegundaNota.Name = "lblSegundaNota";
            this.lblSegundaNota.Size = new System.Drawing.Size(99, 21);
            this.lblSegundaNota.TabIndex = 4;
            this.lblSegundaNota.Text = "Segunda Nota";
            this.lblSegundaNota.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSegundaNota.Click += new System.EventHandler(this.Label1Click);
            // 
            // cboxSegundaNota
            // 
            this.cboxSegundaNota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSegundaNota.FormattingEnabled = true;
            this.cboxSegundaNota.Items.AddRange(new object[] {
            "2",
            "3",
            "5"});
            this.cboxSegundaNota.Location = new System.Drawing.Point(11, 57);
            this.cboxSegundaNota.Margin = new System.Windows.Forms.Padding(4);
            this.cboxSegundaNota.Name = "cboxSegundaNota";
            this.cboxSegundaNota.Size = new System.Drawing.Size(94, 24);
            this.cboxSegundaNota.TabIndex = 3;
            this.cboxSegundaNota.SelectedIndexChanged += new System.EventHandler(this.cboxPrimeiraNota_SelectedIndexChanged);
            // 
            // txtSegundaNota
            // 
            this.txtSegundaNota.Location = new System.Drawing.Point(11, 25);
            this.txtSegundaNota.Margin = new System.Windows.Forms.Padding(4);
            this.txtSegundaNota.Name = "txtSegundaNota";
            this.txtSegundaNota.Size = new System.Drawing.Size(94, 22);
            this.txtSegundaNota.TabIndex = 2;
            this.txtSegundaNota.TextChanged += new System.EventHandler(this.txtPrimeiraNota_TextChanged);
            // 
            // gboxTerceiraNota
            // 
            this.gboxTerceiraNota.Controls.Add(this.lblTerceiraNota);
            this.gboxTerceiraNota.Controls.Add(this.cboxTerceiraNota);
            this.gboxTerceiraNota.Controls.Add(this.txtTerceiraNota);
            this.gboxTerceiraNota.Location = new System.Drawing.Point(249, 146);
            this.gboxTerceiraNota.Name = "gboxTerceiraNota";
            this.gboxTerceiraNota.Size = new System.Drawing.Size(116, 88);
            this.gboxTerceiraNota.TabIndex = 12;
            this.gboxTerceiraNota.TabStop = false;
            // 
            // lblTerceiraNota
            // 
            this.lblTerceiraNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerceiraNota.Location = new System.Drawing.Point(12, 0);
            this.lblTerceiraNota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTerceiraNota.Name = "lblTerceiraNota";
            this.lblTerceiraNota.Size = new System.Drawing.Size(94, 21);
            this.lblTerceiraNota.TabIndex = 4;
            this.lblTerceiraNota.Text = "Terceira Nota";
            this.lblTerceiraNota.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTerceiraNota.Click += new System.EventHandler(this.Label1Click);
            // 
            // cboxTerceiraNota
            // 
            this.cboxTerceiraNota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTerceiraNota.FormattingEnabled = true;
            this.cboxTerceiraNota.Items.AddRange(new object[] {
            "2",
            "3",
            "5"});
            this.cboxTerceiraNota.Location = new System.Drawing.Point(11, 57);
            this.cboxTerceiraNota.Margin = new System.Windows.Forms.Padding(4);
            this.cboxTerceiraNota.Name = "cboxTerceiraNota";
            this.cboxTerceiraNota.Size = new System.Drawing.Size(94, 24);
            this.cboxTerceiraNota.TabIndex = 3;
            this.cboxTerceiraNota.SelectedIndexChanged += new System.EventHandler(this.cboxPrimeiraNota_SelectedIndexChanged);
            // 
            // txtTerceiraNota
            // 
            this.txtTerceiraNota.Location = new System.Drawing.Point(11, 25);
            this.txtTerceiraNota.Margin = new System.Windows.Forms.Padding(4);
            this.txtTerceiraNota.Name = "txtTerceiraNota";
            this.txtTerceiraNota.Size = new System.Drawing.Size(94, 22);
            this.txtTerceiraNota.TabIndex = 2;
            this.txtTerceiraNota.TextChanged += new System.EventHandler(this.txtPrimeiraNota_TextChanged);
            // 
            // gboxQuartaNota
            // 
            this.gboxQuartaNota.Controls.Add(this.lblQuartaNota);
            this.gboxQuartaNota.Controls.Add(this.cboxQuartaNota);
            this.gboxQuartaNota.Controls.Add(this.txtQuartaNota);
            this.gboxQuartaNota.Location = new System.Drawing.Point(371, 146);
            this.gboxQuartaNota.Name = "gboxQuartaNota";
            this.gboxQuartaNota.Size = new System.Drawing.Size(116, 88);
            this.gboxQuartaNota.TabIndex = 12;
            this.gboxQuartaNota.TabStop = false;
            // 
            // lblQuartaNota
            // 
            this.lblQuartaNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuartaNota.Location = new System.Drawing.Point(11, 0);
            this.lblQuartaNota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuartaNota.Name = "lblQuartaNota";
            this.lblQuartaNota.Size = new System.Drawing.Size(94, 21);
            this.lblQuartaNota.TabIndex = 4;
            this.lblQuartaNota.Text = "Quarta Nota";
            this.lblQuartaNota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuartaNota.Click += new System.EventHandler(this.Label1Click);
            // 
            // cboxQuartaNota
            // 
            this.cboxQuartaNota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxQuartaNota.FormattingEnabled = true;
            this.cboxQuartaNota.Items.AddRange(new object[] {
            "2",
            "3",
            "5"});
            this.cboxQuartaNota.Location = new System.Drawing.Point(11, 57);
            this.cboxQuartaNota.Margin = new System.Windows.Forms.Padding(4);
            this.cboxQuartaNota.Name = "cboxQuartaNota";
            this.cboxQuartaNota.Size = new System.Drawing.Size(94, 24);
            this.cboxQuartaNota.TabIndex = 3;
            this.cboxQuartaNota.SelectedIndexChanged += new System.EventHandler(this.cboxPrimeiraNota_SelectedIndexChanged);
            // 
            // txtQuartaNota
            // 
            this.txtQuartaNota.Location = new System.Drawing.Point(11, 25);
            this.txtQuartaNota.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuartaNota.Name = "txtQuartaNota";
            this.txtQuartaNota.Size = new System.Drawing.Size(94, 22);
            this.txtQuartaNota.TabIndex = 2;
            this.txtQuartaNota.TextChanged += new System.EventHandler(this.txtPrimeiraNota_TextChanged);
            // 
            // FormaCalculo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 468);
            this.Controls.Add(this.gboxQuartaNota);
            this.Controls.Add(this.gboxTerceiraNota);
            this.Controls.Add(this.gboxSegundaNota);
            this.Controls.Add(this.gboxPrimeiraNota);
            this.Controls.Add(this.gboxRecuperacao);
            this.Controls.Add(this.gboxNotaRecuperacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblAproveitamento);
            this.Controls.Add(this.numUpDownAproveitamento);
            this.Controls.Add(this.lblNotaCorte);
            this.Controls.Add(this.numUpDownNotaCorte);
            this.Controls.Add(this.txtFaltas);
            this.Controls.Add(this.txtAulas);
            this.Controls.Add(this.lblQuantidadeDeFaltas);
            this.Controls.Add(this.lblQantidadeDeAulas);
            this.Controls.Add(this.lblFormatoAvaliacao);
            this.Controls.Add(this.lblAproveitamentoAluno);
            this.Controls.Add(this.lblMediaFinal);
            this.Controls.Add(this.cboxAvaliacao);
            this.Controls.Add(this.txtAproveitamento);
            this.Controls.Add(this.txtMediaFinal);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormaCalculo1";
            this.Text = "CalculoMedia";
            this.Load += new System.EventHandler(this.FormaCalculo1Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNotaCorte)).EndInit();
            this.gboxNotaRecuperacao.ResumeLayout(false);
            this.gboxNotaRecuperacao.PerformLayout();
            this.gboxRecuperacao.ResumeLayout(false);
            this.gboxRecuperacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAproveitamento)).EndInit();
            this.gboxPrimeiraNota.ResumeLayout(false);
            this.gboxPrimeiraNota.PerformLayout();
            this.gboxSegundaNota.ResumeLayout(false);
            this.gboxSegundaNota.PerformLayout();
            this.gboxTerceiraNota.ResumeLayout(false);
            this.gboxTerceiraNota.PerformLayout();
            this.gboxQuartaNota.ResumeLayout(false);
            this.gboxQuartaNota.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.TextBox txtRecuperacao;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblQantidadeDeAulas;
        private System.Windows.Forms.NumericUpDown numUpDownAproveitamento;
        private System.Windows.Forms.Label lblAproveitamento;
        private System.Windows.Forms.ComboBox cboxAvaliacao;
        private System.Windows.Forms.Label lblFormatoAvaliacao;
        private System.Windows.Forms.TextBox txtPrimeiraNota;
        private System.Windows.Forms.ComboBox cboxPrimeiraNota;
        private System.Windows.Forms.Label lblPrimeiraNota;
        private System.Windows.Forms.GroupBox gboxPrimeiraNota;
        private System.Windows.Forms.GroupBox gboxSegundaNota;
        private System.Windows.Forms.Label lblSegundaNota;
        private System.Windows.Forms.ComboBox cboxSegundaNota;
        private System.Windows.Forms.TextBox txtSegundaNota;
        private System.Windows.Forms.GroupBox gboxTerceiraNota;
        private System.Windows.Forms.Label lblTerceiraNota;
        private System.Windows.Forms.ComboBox cboxTerceiraNota;
        private System.Windows.Forms.TextBox txtTerceiraNota;
        private System.Windows.Forms.GroupBox gboxQuartaNota;
        private System.Windows.Forms.ComboBox cboxQuartaNota;
        private System.Windows.Forms.TextBox txtQuartaNota;
        private System.Windows.Forms.Label lblQuartaNota;
    }
}
