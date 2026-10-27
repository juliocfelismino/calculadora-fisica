using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Forca;

namespace Crud
{
    public partial class FormForcaAtrit : Form
    {
        public FormForcaAtrit()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                ForcaAtrito fa = new ForcaAtrito
                {
                    CoeficienteAtrito = Convert.ToDouble(txtCoeficiente.Text),
                    ForcaNormal = Convert.ToDouble(txtNormal.Text)
                };
                lblResultado.Text = $"Resultado: {fa.Calcular():F2} N";
            }
            catch (Exception)
            {
                MessageBox.Show("Insira valores válidos.");
            }
    }
}
