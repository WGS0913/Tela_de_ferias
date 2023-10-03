using System;
using System.Windows.Forms;

namespace CalculoDeFerias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Evento de clique do botão "Calcular"
        private void buttonCalcular_Click_1(object sender, EventArgs e)
        {
            // Verifica se as entradas são numéricas e válidas
            if (int.TryParse(textBoxMesesTrabalhados.Text, out int mesesTrabalhados) &&
                decimal.TryParse(textBoxSalario.Text, out decimal salario) &&
                decimal.TryParse(textBoxDescontos.Text, out decimal descontos))
            {
                // Variável para outros benefícios
                decimal outrosBeneficios = 0.0m;

                // Calcula o número total de dias de férias
                int diasFerias = mesesTrabalhados * 2;

                // Calcula o salário diário
                decimal salarioDiario = salario / 30;

                // Calcula o salário de Férias
                decimal salarioFerias = (salarioDiario * diasFerias) + (salarioDiario * diasFerias * 1 / 3) + outrosBeneficios;

                // Exibe os resultados nas labels
                labelValorTotal.Text = $"Valor Total a Receber: R${(salario * mesesTrabalhados - descontos):F2}";
                labelDiasFerias.Text = $"Dias Totais de Férias: {diasFerias}";
                labelSalarioFerias.Text = $"Salário de Férias: R${salarioFerias:F2}";
            }
            else
            {
                // Exibe mensagem de erro se as entradas não forem válidas
                MessageBox.Show("Certifique-se de preencher todas as informações corretamente.");
            }
        }

        // Evento de clique do botão "Limpar"
        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            // Limpa os campos de entrada
            textBoxMesesTrabalhados.Text = "";
            textBoxSalario.Text = "";
            textBoxDescontos.Text = "";

            // Limpa os resultados exibidos
            labelValorTotal.Text = "";
            labelDiasFerias.Text = "";
            labelSalarioFerias.Text = "";
        }

        private void dataTabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
