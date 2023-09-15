using Product;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2Fornecedores novoForm = new Form2Fornecedores();
            novoForm.Show();
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            DialogResult retorno = MessageBox.Show("Tem certeza que deseja sair ?",
                "Estoque", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (retorno == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button_adicionar_Click(object sender, EventArgs e)
        {

            try
            {
                product produto = new product(text_nome.Text, text_descrição.Text,
                     Convert.ToInt32(text_quantidade.Text), Convert.ToDecimal(textValor_unit.Text), DateTime.Parse(dateTime_data.Text));

                DialogResult retorno = MessageBox.Show("Produto cadastrado com sucesso!", "Estoque"
                    , MessageBoxButtons.OK);


            }
            catch (Exception ex)
            {
                DialogResult retorno = MessageBox.Show(ex.Message, "Estoque",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void button_lista_produtos_Click(object sender, EventArgs e)
        {
            FormLiSTAProdutos novoform = new FormLiSTAProdutos();
            novoform.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_vendas_Click(object sender, EventArgs e)
        {
            FormVendas novoForm = new FormVendas();

            novoForm.Show();
        }
    }
}