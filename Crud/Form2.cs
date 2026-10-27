using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Crud
{
    public partial class FormVelocidade : Form
    {
        public FormVelocidade()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Velocidade Media vm = new Velocidade Media();

                vm.Distancia = Convert.ToDouble(DISTANCIA.Text);
                vm.Tempo = Convert.ToDouble(TEMPO.Text);

                double resultado = vm.Calcular();

                lblResultado.Text = $"Resultado: {resultado:F2} m/s";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonVelocidade_Click(object sender, EventArgs e)
        {
            FormVelocidade telaVelocidade = new FormVelocidade();

            telaVelocidade.ShowDialog();
        }

    }
}
