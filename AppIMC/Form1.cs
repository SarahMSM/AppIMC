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
    }
}
