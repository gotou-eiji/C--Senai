
namespace CircoApps
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.lblCaraCoroa = new System.Windows.Forms.Label();
            this.pbxCaraCoroa = new System.Windows.Forms.PictureBox();
            this.pbxConversorMoeda = new System.Windows.Forms.PictureBox();
            this.lblConversorMoeda = new System.Windows.Forms.Label();
            this.pbxBuscaCEP = new System.Windows.Forms.PictureBox();
            this.lblBuscaCEP = new System.Windows.Forms.Label();
            this.pbxSair = new System.Windows.Forms.PictureBox();
            this.lblSair = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCaraCoroa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxConversorMoeda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBuscaCEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCaraCoroa
            // 
            this.lblCaraCoroa.AutoSize = true;
            this.lblCaraCoroa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaraCoroa.Location = new System.Drawing.Point(106, 272);
            this.lblCaraCoroa.Name = "lblCaraCoroa";
            this.lblCaraCoroa.Size = new System.Drawing.Size(145, 24);
            this.lblCaraCoroa.TabIndex = 0;
            this.lblCaraCoroa.Text = "Cara ou Coroa";
            this.lblCaraCoroa.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbxCaraCoroa
            // 
            this.pbxCaraCoroa.Image = global::CircoApps.Properties.Resources.logo;
            this.pbxCaraCoroa.Location = new System.Drawing.Point(50, 50);
            this.pbxCaraCoroa.Name = "pbxCaraCoroa";
            this.pbxCaraCoroa.Size = new System.Drawing.Size(256, 219);
            this.pbxCaraCoroa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCaraCoroa.TabIndex = 1;
            this.pbxCaraCoroa.TabStop = false;
            this.pbxCaraCoroa.Click += new System.EventHandler(this.pbxCaraCoroa_Click);
            // 
            // pbxConversorMoeda
            // 
            this.pbxConversorMoeda.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbxConversorMoeda.Image = global::CircoApps.Properties.Resources.moeda;
            this.pbxConversorMoeda.Location = new System.Drawing.Point(379, 50);
            this.pbxConversorMoeda.Name = "pbxConversorMoeda";
            this.pbxConversorMoeda.Size = new System.Drawing.Size(256, 219);
            this.pbxConversorMoeda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxConversorMoeda.TabIndex = 3;
            this.pbxConversorMoeda.TabStop = false;
            this.pbxConversorMoeda.Click += new System.EventHandler(this.pbxConversorMoeda_Click);
            // 
            // lblConversorMoeda
            // 
            this.lblConversorMoeda.AutoSize = true;
            this.lblConversorMoeda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversorMoeda.Location = new System.Drawing.Point(405, 272);
            this.lblConversorMoeda.Name = "lblConversorMoeda";
            this.lblConversorMoeda.Size = new System.Drawing.Size(206, 24);
            this.lblConversorMoeda.TabIndex = 2;
            this.lblConversorMoeda.Text = "Conversor de Moeda";
            // 
            // pbxBuscaCEP
            // 
            this.pbxBuscaCEP.Image = global::CircoApps.Properties.Resources.cep;
            this.pbxBuscaCEP.Location = new System.Drawing.Point(50, 341);
            this.pbxBuscaCEP.Name = "pbxBuscaCEP";
            this.pbxBuscaCEP.Size = new System.Drawing.Size(256, 219);
            this.pbxBuscaCEP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBuscaCEP.TabIndex = 5;
            this.pbxBuscaCEP.TabStop = false;
            this.pbxBuscaCEP.Click += new System.EventHandler(this.pbxBuscaCEP_Click);
            // 
            // lblBuscaCEP
            // 
            this.lblBuscaCEP.AutoSize = true;
            this.lblBuscaCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaCEP.Location = new System.Drawing.Point(120, 563);
            this.lblBuscaCEP.Name = "lblBuscaCEP";
            this.lblBuscaCEP.Size = new System.Drawing.Size(114, 24);
            this.lblBuscaCEP.TabIndex = 4;
            this.lblBuscaCEP.Text = "Busca CEP";
            // 
            // pbxSair
            // 
            this.pbxSair.Image = global::CircoApps.Properties.Resources.sair;
            this.pbxSair.Location = new System.Drawing.Point(379, 341);
            this.pbxSair.Name = "pbxSair";
            this.pbxSair.Size = new System.Drawing.Size(256, 219);
            this.pbxSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSair.TabIndex = 7;
            this.pbxSair.TabStop = false;
            this.pbxSair.Click += new System.EventHandler(this.pbxSair_Click);
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSair.Location = new System.Drawing.Point(485, 563);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(46, 24);
            this.lblSair.TabIndex = 6;
            this.lblSair.Text = "Sair";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(693, 624);
            this.Controls.Add(this.pbxSair);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.pbxBuscaCEP);
            this.Controls.Add(this.lblBuscaCEP);
            this.Controls.Add(this.pbxConversorMoeda);
            this.Controls.Add(this.lblConversorMoeda);
            this.Controls.Add(this.pbxCaraCoroa);
            this.Controls.Add(this.lblCaraCoroa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circo de Apps";
            ((System.ComponentModel.ISupportInitialize)(this.pbxCaraCoroa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxConversorMoeda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBuscaCEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaraCoroa;
        private System.Windows.Forms.PictureBox pbxCaraCoroa;
        private System.Windows.Forms.PictureBox pbxConversorMoeda;
        private System.Windows.Forms.Label lblConversorMoeda;
        private System.Windows.Forms.PictureBox pbxBuscaCEP;
        private System.Windows.Forms.Label lblBuscaCEP;
        private System.Windows.Forms.PictureBox pbxSair;
        private System.Windows.Forms.Label lblSair;
    }
}

