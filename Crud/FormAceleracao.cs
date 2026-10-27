using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Crud
{
    public partial class FormAceleracao : Form
    {
        public FormAceleracao()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Aceleracao ac = new Aceleracao
                {
                    VariacaoVelocidade = Convert.ToDouble(txtVelocidade.Text),
                    VariacaoTempo = Convert.ToDouble(txtTempo.Text)
                };
                lblResultado.Text = $"Resultado: {ac.Calcular():F2} m/s²";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
}
