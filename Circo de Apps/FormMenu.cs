using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CircoApps
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            FormSplash splash = new FormSplash();
            splash.Show();
            Application.DoEvents();
            Thread.Sleep(3000);
            splash.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pbxCaraCoroa_Click(object sender, EventArgs e)
        {
            FormCaraCoroa caraCoroa = new FormCaraCoroa();
            caraCoroa.Show();
        }

        private void pbxConversorMoeda_Click(object sender, EventArgs e)
        {
            FormConversorMoeda moeda = new FormConversorMoeda();
            moeda.Show();
        }

        private void pbxBuscaCEP_Click(object sender, EventArgs e)
        {
            FormBuscaCEP buscaCep = new FormBuscaCEP();
            buscaCep.Show();
        }

        private void pbxSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
