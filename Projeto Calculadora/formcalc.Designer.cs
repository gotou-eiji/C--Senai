
namespace calculadora
{
    partial class Calculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btMais = new System.Windows.Forms.Button();
            this.btMenos = new System.Windows.Forms.Button();
            this.btVezes = new System.Windows.Forms.Button();
            this.btDivisao = new System.Windows.Forms.Button();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btMais
            // 
            this.btMais.Location = new System.Drawing.Point(434, 97);
            this.btMais.Name = "btMais";
            this.btMais.Size = new System.Drawing.Size(75, 23);
            this.btMais.TabIndex = 0;
            this.btMais.Text = "+";
            this.btMais.UseVisualStyleBackColor = true;
            this.btMais.Click += new System.EventHandler(this.buttonMais_Click);
            // 
            // btMenos
            // 
            this.btMenos.Location = new System.Drawing.Point(515, 97);
            this.btMenos.Name = "btMenos";
            this.btMenos.Size = new System.Drawing.Size(75, 23);
            this.btMenos.TabIndex = 1;
            this.btMenos.Text = "-";
            this.btMenos.UseVisualStyleBackColor = true;
            this.btMenos.Click += new System.EventHandler(this.buttonMenos_Click);
            // 
            // btVezes
            // 
            this.btVezes.Location = new System.Drawing.Point(434, 126);
            this.btVezes.Name = "btVezes";
            this.btVezes.Size = new System.Drawing.Size(75, 23);
            this.btVezes.TabIndex = 2;
            this.btVezes.Text = "x";
            this.btVezes.UseVisualStyleBackColor = true;
            this.btVezes.Click += new System.EventHandler(this.btVezes_Click);
            // 
            // btDivisao
            // 
            this.btDivisao.Location = new System.Drawing.Point(515, 126);
            this.btDivisao.Name = "btDivisao";
            this.btDivisao.Size = new System.Drawing.Size(75, 23);
            this.btDivisao.TabIndex = 3;
            this.btDivisao.Text = "/";
            this.btDivisao.UseVisualStyleBackColor = true;
            this.btDivisao.Click += new System.EventHandler(this.btDivisao_Click);
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(79, 95);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 20);
            this.txtValor1.TabIndex = 4;
            this.txtValor1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(205, 95);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 20);
            this.txtValor2.TabIndex = 5;
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(76, 81);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(28, 13);
            this.lblNum1.TabIndex = 6;
            this.lblNum1.Text = "Nº 1";
            this.lblNum1.Click += new System.EventHandler(this.lblNum1_Click);
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(202, 81);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(28, 13);
            this.lblNum2.TabIndex = 7;
            this.lblNum2.Text = "Nº 2";
            this.lblNum2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(76, 181);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(58, 13);
            this.labelResultado.TabIndex = 8;
            this.labelResultado.Text = "Resultado:";
            this.labelResultado.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(76, 199);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 9;
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.Color.Red;
            this.btFechar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btFechar.Location = new System.Drawing.Point(434, 181);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(156, 49);
            this.btFechar.TabIndex = 10;
            this.btFechar.Text = "FECHAR";
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 378);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.btDivisao);
            this.Controls.Add(this.btVezes);
            this.Controls.Add(this.btMenos);
            this.Controls.Add(this.btMais);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMais;
        private System.Windows.Forms.Button btMenos;
        private System.Windows.Forms.Button btVezes;
        private System.Windows.Forms.Button btDivisao;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btFechar;
    }
}

