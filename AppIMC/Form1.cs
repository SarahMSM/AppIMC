using static System.Windows.Forms.DataFormats;

namespace AppIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalc_Click(object sender, EventArgs e)
        {
            double alt, peso, imc;
            alt = (double)nudAltura.Value;
            peso = (double)nudPeso.Value;
            imc = peso / Math.Pow(alt, 2);
            lblIMC.Text = $"IMC: {imc:F2} kg/m²";
            lblClassific.Text = Classificar(imc);
        }
        string Classificar(double imc)
        {
            if (imc < 18.5)
            {
                return "Abaixo do Peso";
            }
            if (imc < 25)
            {
                return "Normal";
            }
            if (imc < 30)
            {
                return "Obesidade I";
            }
            if (imc < 35)
            {
                return "Obesidade II";
            }
            if (imc < 40)
            {
                return "Obesidade III";
            }
            return "Obesidade Mórbida";
        }
        private void nudAltura_ValueChanged(object sender, EventArgs e)
        {
            double a = (double)nudAltura.Value;
            btCalc.Enabled = (a != 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void nudPeso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem-vindo à calculadora de IMC :3");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Deseja mesmo fechar?",
                             "Calculadora de IMC",
                             MessageBoxButtons.YesNo);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btProximo_Click_Click(object sender, EventArgs e)
        {
            // 1. Instanciar o novo formulário
            FrmOutro novoForm = new FrmOutro();

            // 2. Mostrar o novo formulário
            novoForm.Show();

            // 3. Esconder o formulário atual
            this.Hide();
        }
    }
}
