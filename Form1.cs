using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
    public partial class FormNavegador : Form
    {
        List<string> Favoritos = new List<string>();
        public FormNavegador()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com.do");
            txtLink.Text = "www.google.com.do";

        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtLink.Text);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
        
        private void btnFavorito_Click(object sender, EventArgs e)
        {
            Favoritos.Add(webBrowser1.Url.ToString());
            actualizarCmbFavorito();
        }

        private void actualizarCmbFavorito()
        {
            cmbFavorito.Items.Clear();
            foreach(string direccion in Favoritos)
            {
                cmbFavorito.Items.Add(direccion);
            }

        }

        private void cmbFavorito_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate(cmbFavorito.SelectedItem.ToString());
        }
    }
}
