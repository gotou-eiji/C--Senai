
namespace CircoApps
{
    partial class FormConversorMoeda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConversorMoeda));
            this.lblValor = new System.Windows.Forms.Label();
            this.btnConverter = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblDolar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblYen = new System.Windows.Forms.Label();
            this.lblDolar2 = new System.Windows.Forms.Label();
            this.lblLibra2 = new System.Windows.Forms.Label();
            this.lblEuro2 = new System.Windows.Forms.Label();
            this.lblYen2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(43, 31);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(145, 16);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Digite um valor (R$)";
            // 
            // btnConverter
            // 
            this.btnConverter.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.Location = new System.Drawing.Point(378, 31);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(130, 54);
            this.btnConverter.TabIndex = 1;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = false;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Red;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(378, 111);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(130, 54);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(46, 49);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(170, 20);
            this.txtValor.TabIndex = 3;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar.Location = new System.Drawing.Point(43, 152);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(146, 16);
            this.lblDolar.TabIndex = 4;
            this.lblDolar.Text = "Dólar Americano ($)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Libra Britânica (£)";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro.Location = new System.Drawing.Point(43, 235);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(124, 16);
            this.lblEuro.TabIndex = 6;
            this.lblEuro.Text = "Euro Europeu (€)";
            this.lblEuro.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblYen
            // 
            this.lblYen.AutoSize = true;
            this.lblYen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYen.Location = new System.Drawing.Point(43, 277);
            this.lblYen.Name = "lblYen";
            this.lblYen.Size = new System.Drawing.Size(124, 16);
            this.lblYen.TabIndex = 7;
            this.lblYen.Text = "Iene Japonês (¥)";
            // 
            // lblDolar2
            // 
            this.lblDolar2.AutoSize = true;
            this.lblDolar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar2.Location = new System.Drawing.Point(219, 152);
            this.lblDolar2.Name = "lblDolar2";
            this.lblDolar2.Size = new System.Drawing.Size(0, 16);
            this.lblDolar2.TabIndex = 8;
            // 
            // lblLibra2
            // 
            this.lblLibra2.AutoSize = true;
            this.lblLibra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibra2.Location = new System.Drawing.Point(219, 194);
            this.lblLibra2.Name = "lblLibra2";
            this.lblLibra2.Size = new System.Drawing.Size(0, 16);
            this.lblLibra2.TabIndex = 9;
            // 
            // lblEuro2
            // 
            this.lblEuro2.AutoSize = true;
            this.lblEuro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro2.Location = new System.Drawing.Point(219, 235);
            this.lblEuro2.Name = "lblEuro2";
            this.lblEuro2.Size = new System.Drawing.Size(0, 16);
            this.lblEuro2.TabIndex = 10;
            // 
            // lblYen2
            // 
            this.lblYen2.AutoSize = true;
            this.lblYen2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYen2.Location = new System.Drawing.Point(219, 277);
            this.lblYen2.Name = "lblYen2";
            this.lblYen2.Size = new System.Drawing.Size(0, 16);
            this.lblYen2.TabIndex = 11;
            // 
            // FormConversorMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(570, 387);
            this.Controls.Add(this.lblYen2);
            this.Controls.Add(this.lblEuro2);
            this.Controls.Add(this.lblLibra2);
            this.Controls.Add(this.lblDolar2);
            this.Controls.Add(this.lblYen);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.lblValor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConversorMoeda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Moeda";
            this.Load += new System.EventHandler(this.FormConversorMoeda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblYen;
        private System.Windows.Forms.Label lblDolar2;
        private System.Windows.Forms.Label lblLibra2;
        private System.Windows.Forms.Label lblEuro2;
        private System.Windows.Forms.Label lblYen2;
    }
}