using System.Data;
using System.Data.SqlClient;

namespace CRUD_SistemaFinanceiro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            string sql = "select * from lancamentos";
            DataTable dt = new DataTable();
            dt = bd.executarConsulta(sql);
            dataGridView1.DataSource = dt;

            decimal saldo = 0;
            decimal entrada = 0;
            decimal saida = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                decimal valor = Convert.ToDecimal(row.Cells["valor"].Value);
                string tipo = row.Cells["tipo"].Value.ToString().Trim();

                if (tipo == "entrada")
                {
                    saldo += valor;
                    entrada += valor;
                    lblEntrada.Text = "Total de entradas: " + entrada.ToString();
                }

                else if (tipo == "saida")
                {
                    saldo -= valor;
                    saida += valor;
                    lblSaida.Text = "Total de saídas: " + saida.ToString();
                }

                lblSaldo.Text = "Saldo atual: " + saldo.ToString();
            }
        }


        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Lancamentos lancamentos = new Lancamentos();

            lancamentos.descricao = txbDescricao.Text;
            lancamentos.tipo = txbTipo.Text;
            lancamentos.dataLancamento = dateTimePicker1.Value;
            lancamentos.valor = float.Parse(txbValor.Text);

            bool retorno = lancamentos.gravarLancamento();

            if (retorno)
            {
                MessageBox.Show("Lançamento armazenado com sucesso! ");

            }

            else
            {
                MessageBox.Show("Erro ao cadastrar lançamento");
            }




        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Lancamentos lancamentos = new Lancamentos();
            lancamentos.id = int.Parse(txbID.Text);
            bool retorno = lancamentos.excluirRegistro();



            if (retorno)
            {
                MessageBox.Show("Excluido com sucesso!");

            }
            else
            {
                MessageBox.Show("Erro ao excluir");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            {
                Lancamentos lancamentos = new Lancamentos();
                lancamentos.id = int.Parse(txbIDUP.Text);
                lancamentos.descricao = txbDescricaoUP.Text;
                lancamentos.valor = float.Parse(txbValorUP.Text);

                bool retorno = lancamentos.atualizarLancamento();

                if (retorno)
                {
                    MessageBox.Show(lancamentos.descricao + " atualizado com sucesso!");
                }

                else
                {
                    MessageBox.Show("Erro ao atualizar" + lancamentos.descricao);
                }
            }

        }

        private void btnConsultarUP_Click(object sender, EventArgs e)
        {
            {
                Lancamentos lancamentos = new Lancamentos();
                lancamentos.consultaLancamento(int.Parse(txbIDUP.Text));
                txbIDUP.Enabled = false;
                txbDescricaoUP.Text = lancamentos.descricao;
                txbValorUP.Text = lancamentos.valor.ToString();

            }

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Lancamentos l = new Lancamentos();
            DataTable tabela = l.consultarPorTipo(txbID.Text);
            dataGridView1.DataSource = tabela;
            MessageBox.Show("Filtro realizado");
        }
    }
}

