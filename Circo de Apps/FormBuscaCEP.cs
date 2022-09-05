using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; //Expressões regulares
using System.Net;
using System.IO;

namespace CircoApps
{
    public partial class FormBuscaCEP : Form
    {
        public FormBuscaCEP()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void FormBuscaCEP_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtCep;
            txtCep.Focus();
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/"+txtCep.Text+"/json");
            request.AllowAutoRedirect = false;
            HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();
            if(ChecaServidor.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("Servidor indisponível.");
                return;
            }
            using(Stream webStream = ChecaServidor.GetResponseStream())
            {
                if (webStream != null)
                {
                    using(StreamReader streamReader = new StreamReader(webStream))
                    {
                        string response = streamReader.ReadToEnd();
                        response = Regex.Replace(response, "[{},]", string.Empty);
                        response = response.Replace("\"", "");
                        String[] substrings = response.Split('\n');
                        int cont = 0;
                        foreach(var substring in substrings)
                        {
                            if(cont == 1)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                if(valor[0] == "erro")
                                {
                                    MessageBox.Show("CEP não encontrado.");
                                    this.ActiveControl = txtCep;
                                    txtCep.Focus();
                                    return;
                                }
                            }
                            if(cont == 2)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                lblEndereco2.Text = valor[1];
                            }
                            if(cont == 3)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                lblComplemento2.Text = valor[1];
                            }
                            if (cont == 4)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                lblBairro2.Text = valor[1];
                            }
                            if (cont == 5)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                lblCidade2.Text = valor[1];
                            }
                            if (cont == 6)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                lblUF2.Text = valor[1];
                            }
                            cont++;
                        }
                    }
                }
            }
        }
    }
}
