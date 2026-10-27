using static Forca;

namespace Crud
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAceleracao_Click(object sender, EventArgs e)
        {
            new FormAceleracao().ShowDialog();

        }

        private void buttonForca_Click(object sender, EventArgs e)
        {
            new FormForca().ShowDialog();

        }

        private void buttonForcaAtrito_Click(object sender, EventArgs e)
        {
            new FormAtrito().ShowDialog();

        }

        private void buttonPeso_Click(object sender, EventArgs e)
        {
            new FormPeso().ShowDialog();

        }
    }
}
