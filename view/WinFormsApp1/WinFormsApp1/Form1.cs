using Product;
using Connection;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        static string DataSource = "DESKTOP-132MB6V\\DAVISQL";
        static string InitialCatalog = "Estoque";
        static string IntegratedSecurity = "True";
        //abrindo a conexão
        connection conn = new connection(DataSource, InitialCatalog, IntegratedSecurity);



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


                if (conn.OpenCon())
                {
                    //comando sql
                    string sql = "INSERT INTO Produtos(nome, descricao,quantidade," +
                   "ultima_data_entrada," +
                   " preco_unit) VALUES(@nome, @descricao, @quantidade," +
                   "@ultima_data_entrada, @preco_unit)";
                    //validando os comando para realizar no banco de dados;
                    SqlCommand command = new SqlCommand(sql, conn.GetCon());

                    command.Parameters.Add(new SqlParameter("@nome", produto.name));
                    command.Parameters.Add(new SqlParameter("@descricao", produto.description));
                    command.Parameters.Add(new SqlParameter("@quantidade", produto.quantity));
                    command.Parameters.Add(new SqlParameter("@ultima_data_entrada", produto.last_Delivery_date));
                    command.Parameters.Add(new SqlParameter("@preco_unit", produto.UnityValue));


                    command.ExecuteNonQuery();

                }

                DialogResult retorno = MessageBox.Show("Produto cadastrado com sucesso!", "Estoque"
                    , MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                DialogResult retorno = MessageBox.Show(ex.Message, "Estoque",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                conn.CloseCon();
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

        private void label_nome_Click(object sender, EventArgs e)
        {

        }
    }
}