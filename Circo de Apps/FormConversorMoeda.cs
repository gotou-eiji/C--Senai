using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircoApps
{
    public partial class FormConversorMoeda : Form
    {
        public FormConversorMoeda()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormConversorMoeda_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtValor;
            txtValor.Focus();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double valor, dolar, euro, libra, yen;
            valor = Convert.ToDouble(txtValor.Text);
            dolar = valor / 5.16;
            libra = valor / 5.94;
            euro = valor / 5.12;
            yen = valor / 0.037;
            lblDolar2.Text = dolar.ToString("N2");
            lblLibra2.Text = libra.ToString("N2");
            lblEuro2.Text = euro.ToString("N2");
            lblYen2.Text = yen.ToString("N2");
            txtValor.Text = "";
            this.ActiveControl = txtValor;
            txtValor.Focus();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
