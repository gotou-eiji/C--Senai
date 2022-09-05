
namespace CircoApps
{
    partial class FormBuscaCEP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscaCEP));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblEndereco2 = new System.Windows.Forms.Label();
            this.lblComplemento2 = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblBairro2 = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCidade2 = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblUF2 = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Aqua;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(444, 41);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(138, 45);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(34, 41);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(96, 16);
            this.lblCep.TabIndex = 1;
            this.lblCep.Text = "Digite o CEP";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(37, 60);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(310, 20);
            this.txtCep.TabIndex = 2;
            this.txtCep.TextChanged += new System.EventHandler(this.txtCep_TextChanged);
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(444, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(34, 131);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(75, 16);
            this.lblEndereco.TabIndex = 4;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblEndereco2
            // 
            this.lblEndereco2.AutoSize = true;
            this.lblEndereco2.Location = new System.Drawing.Point(198, 131);
            this.lblEndereco2.Name = "lblEndereco2";
            this.lblEndereco2.Size = new System.Drawing.Size(0, 13);
            this.lblEndereco2.TabIndex = 5;
            // 
            // lblComplemento2
            // 
            this.lblComplemento2.AutoSize = true;
            this.lblComplemento2.Location = new System.Drawing.Point(198, 161);
            this.lblComplemento2.Name = "lblComplemento2";
            this.lblComplemento2.Size = new System.Drawing.Size(0, 13);
            this.lblComplemento2.TabIndex = 7;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(34, 161);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(103, 16);
            this.lblComplemento.TabIndex = 6;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblBairro2
            // 
            this.lblBairro2.AutoSize = true;
            this.lblBairro2.Location = new System.Drawing.Point(198, 195);
            this.lblBairro2.Name = "lblBairro2";
            this.lblBairro2.Size = new System.Drawing.Size(0, 13);
            this.lblBairro2.TabIndex = 9;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(34, 195);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(50, 16);
            this.lblBairro.TabIndex = 8;
            this.lblBairro.Text = "Bairro";
            // 
            // lblCidade2
            // 
            this.lblCidade2.AutoSize = true;
            this.lblCidade2.Location = new System.Drawing.Point(198, 228);
            this.lblCidade2.Name = "lblCidade2";
            this.lblCidade2.Size = new System.Drawing.Size(0, 13);
            this.lblCidade2.TabIndex = 11;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(34, 228);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(58, 16);
            this.lblCidade.TabIndex = 10;
            this.lblCidade.Text = "Cidade";
            this.lblCidade.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblUF2
            // 
            this.lblUF2.AutoSize = true;
            this.lblUF2.Location = new System.Drawing.Point(198, 259);
            this.lblUF2.Name = "lblUF2";
            this.lblUF2.Size = new System.Drawing.Size(0, 13);
            this.lblUF2.TabIndex = 13;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUF.Location = new System.Drawing.Point(34, 259);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(28, 16);
            this.lblUF.TabIndex = 12;
            this.lblUF.Text = "UF";
            // 
            // FormBuscaCEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(635, 391);
            this.Controls.Add(this.lblUF2);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.lblCidade2);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblBairro2);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblComplemento2);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblEndereco2);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.btnBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBuscaCEP";
            this.Text = "Busca CEP";
            this.Load += new System.EventHandler(this.FormBuscaCEP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblEndereco2;
        private System.Windows.Forms.Label lblComplemento2;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblBairro2;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCidade2;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblUF2;
        private System.Windows.Forms.Label lblUF;
    }
}