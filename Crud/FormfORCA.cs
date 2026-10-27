using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Crud
{
    public partial class FormfORCA : Form
    {
        public FormfORCA()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Forca f = new Forca
                {
                    Massa = Convert.ToDouble(txtMassa.Text),
                    AceleracaoCorpo = Convert.ToDouble(txtAceleracao.Text)
                };
                lblResultado.Text = $"Resultado: {f.Calcular():F2} N";
            }
            catch (Exception) { MessageBox.Show("Insira valores válidos."); }
        }
    }
}
