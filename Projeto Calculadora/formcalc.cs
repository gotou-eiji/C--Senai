using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Calculadora : Form
    {
        public double n1 { get; set; }
        public double n2 { get; set; }
        public double resultado { get; set; }

        public Calculadora()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonMais_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtValor1.Text);
            n2 = Convert.ToDouble(txtValor2.Text);
            resultado = n1 + n2;
            lblResultado.Text = Convert.ToString(resultado);
            txtValor1.Text = "";
            txtValor2.Text = "";
        }

        private void buttonMenos_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtValor1.Text);
            n2 = Convert.ToDouble(txtValor2.Text);
            resultado = n1 - n2;
            lblResultado.Text = Convert.ToString(resultado);
            txtValor1.Text = "";
            txtValor2.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btVezes_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtValor1.Text);
            n2 = Convert.ToDouble(txtValor2.Text);
            resultado = n1 * n2;
            lblResultado.Text = Convert.ToString(resultado);
            txtValor1.Text = "";
            txtValor2.Text = "";
        }

        private void btDivisao_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtValor1.Text);
            n2 = Convert.ToDouble(txtValor2.Text);
            resultado = n1 / n2;
            lblResultado.Text = Convert.ToString(Math.Round(resultado,2));
            txtValor1.Text = "";
            txtValor2.Text = "";
        }

        private void lblNum1_Click(object sender, EventArgs e)
        {

        }
    }
}
