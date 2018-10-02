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
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown numUpDownNotaCorte;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button button2;
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.lblPrimeiraNota = new System.Windows.Forms.Label();
			this.lblSegundaNota = new System.Windows.Forms.Label();
			this.lblTrabalho = new System.Windows.Forms.Label();
			this.txtSegundaNota = new System.Windows.Forms.TextBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.numUpDownNotaCorte = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.gpbxRecuperacao = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDownNotaCorte)).BeginInit();
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
			this.comboBox1.TabIndex = 3;
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
			this.textBox4.TabIndex = 2;
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
			this.comboBox3.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(10, 221);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Qde Aulas";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(10, 254);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 23);
			this.label5.TabIndex = 5;
			this.label5.Text = "Qde Faltas";
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
			this.btnCalcular.Location = new System.Drawing.Point(74, 382);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(112, 52);
			this.btnCalcular.TabIndex = 9;
			this.btnCalcular.Text = "button1";
			this.btnCalcular.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(192, 382);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(112, 52);
			this.button2.TabIndex = 9;
			this.button2.Text = "button1";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(88, 335);
			this.textBox2.Margin = new System.Windows.Forms.Padding(4);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(94, 22);
			this.textBox2.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(88, 310);
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
			this.gpbxRecuperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpbxRecuperacao.Location = new System.Drawing.Point(462, 310);
			this.gpbxRecuperacao.Name = "gpbxRecuperacao";
			this.gpbxRecuperacao.Size = new System.Drawing.Size(134, 100);
			this.gpbxRecuperacao.TabIndex = 11;
			this.gpbxRecuperacao.TabStop = false;
			this.gpbxRecuperacao.Text = "Situação";
			// 
			// FormaCalculo1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(645, 446);
			this.Controls.Add(this.gpbxRecuperacao);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.numUpDownNotaCorte);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblTrabalho);
			this.Controls.Add(this.lblSegundaNota);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblPrimeiraNota);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.textBox4);
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
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
