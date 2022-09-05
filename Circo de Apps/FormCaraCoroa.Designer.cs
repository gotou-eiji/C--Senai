
namespace CircoApps
{
    partial class FormCaraCoroa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCaraCoroa));
            this.btJogar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.pbxResultado = new System.Windows.Forms.PictureBox();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // btJogar
            // 
            this.btJogar.BackColor = System.Drawing.Color.Chartreuse;
            this.btJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btJogar.Location = new System.Drawing.Point(437, 25);
            this.btJogar.Name = "btJogar";
            this.btJogar.Size = new System.Drawing.Size(201, 109);
            this.btJogar.TabIndex = 0;
            this.btJogar.Text = "Jogar";
            this.btJogar.UseVisualStyleBackColor = false;
            this.btJogar.Click += new System.EventHandler(this.btJogar_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ForeColor = System.Drawing.Color.White;
            this.btSair.Location = new System.Drawing.Point(437, 187);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(201, 109);
            this.btSair.TabIndex = 1;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // pbxResultado
            // 
            this.pbxResultado.Location = new System.Drawing.Point(24, 25);
            this.pbxResultado.Name = "pbxResultado";
            this.pbxResultado.Size = new System.Drawing.Size(315, 271);
            this.pbxResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxResultado.TabIndex = 2;
            this.pbxResultado.TabStop = false;
            this.pbxResultado.Click += new System.EventHandler(this.pbxResultado_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(30, 316);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 31);
            this.lblResultado.TabIndex = 3;
            // 
            // FormCaraCoroa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(709, 498);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.pbxResultado);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btJogar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCaraCoroa";
            this.Text = "Jogue a moeda";
            this.Load += new System.EventHandler(this.FormCaraCoroa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btJogar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.PictureBox pbxResultado;
        private System.Windows.Forms.Label lblResultado;
    }
}