namespace CalculaJuros
{
    public partial class Form1 : Form
    {
        private int periodoAnos = 0, periodoMeses = 0;
        private double taxaJuros = 0.0, valorAplicado = 0.0, result = 0.0;



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                periodoAnos = int.Parse(txtPeriodo.Text);
                taxaJuros = double.Parse(txtTaxaJuros.Text);
                valorAplicado = double.Parse(txtValorAplicado.Text);

                periodoMeses = periodoAnos * 12;

                //double valorBase = 1 + taxaJuros;
                //double valorExpoente = Math.Pow(1 + taxaJuros, periodoMeses);

                //result = valorAplicado * valorExpoente;


                result = valorAplicado * Math.Pow(1 + taxaJuros, periodoAnos);

                txtResult.Text = $"R$ {result.ToString("F2")}";
            }
            catch (Exception ex)
            {
                txtResult.Text = ex.Message;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            txtValorAplicado.Text = "";
            txtTaxaJuros.Text = "";
            txtPeriodo.Text = "";
            result = 0;
            periodoMeses = 0;
            periodoAnos = 0;
            valorAplicado = 0;
            taxaJuros = 0;
        }
    }
}