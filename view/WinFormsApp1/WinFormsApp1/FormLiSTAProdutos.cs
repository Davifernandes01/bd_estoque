using Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormLiSTAProdutos : Form
    {
        public FormLiSTAProdutos()
        {
            InitializeComponent();

            list_produtos.View = View.Details;
            list_produtos.LabelEdit = true;
            list_produtos.AllowColumnReorder = true;
            list_produtos.FullRowSelect = true;
            list_produtos.GridLines = true;

            list_produtos.Columns.Add("ID", 30,HorizontalAlignment.Left);
            list_produtos.Columns.Add("NOME", 100, HorizontalAlignment.Left);
            list_produtos.Columns.Add("DESCRIÇÃO", 100, HorizontalAlignment.Left);
            list_produtos.Columns.Add("QUANTIDADE", 100, HorizontalAlignment.Left);
            list_produtos.Columns.Add("DATA_ENTRADA", 100, HorizontalAlignment.Left);
            list_produtos.Columns.Add("DATA_SAIDA", 100, HorizontalAlignment.Left);
            list_produtos.Columns.Add("PRECO_UNIT", 100, HorizontalAlignment.Left);


        }

        static string DataSource = "DESKTOP-132MB6V\\DAVISQL";
        static string InitialCatalog = "Estoque";
        static string IntegratedSecurity = "True";
        //abrindo a conexão
        connection conn = new connection(DataSource, InitialCatalog, IntegratedSecurity);


        private void button_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_listar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.OpenCon())
                {
                    //comando para pegar todos os dados
                     string sql = "select * from Produtos";

                    SqlCommand command = new SqlCommand(sql, conn.GetCon());

                    //salvando os dados na variavel
                  SqlDataReader reader = command.ExecuteReader();

                    //limpando o elemento
                    list_produtos.Items.Clear();

                //enquanto estiver linhas para serem lidas, as informações serão salvas no vetor
                 while(reader.Read())
                    {
                        //separando os valores que não são strings
                        int getId = reader.GetInt32(0);
                        int getQuantidade = reader.GetInt32(3);
                        DateTime getDateEntrada = reader.GetDateTime(4);
                        DateTime? getDateSaida = null; //nulo
                        if (!reader.IsDBNull(5))
                        {
                            getDateSaida = reader.GetDateTime(5); //se não for nulo, adiciona o valor na coluna
                        }

                        decimal getValorUnit = reader.GetDecimal(6);

                        //pagando os valores e transformando eles em string
                        string getIdString = getId.ToString();
                        string getQuantidadeString = getQuantidade.ToString();
                        string getDateEntradaString = getDateEntrada.ToString();
                        //vendo se a coluna é nula ou nao, se for, o valor dela será de N/A, se não, vai pegar a data normal
                        string? getDateSaidaString = getDateSaida.HasValue ? getDateSaida.Value.ToString("dd/MM/yyyy") : "N/A";
                        string getValorUnitString = getValorUnit.ToString();
                        string[] rows ={

                            getIdString,
                            reader.GetString(1),
                            reader.GetString(2),
                            getQuantidadeString,
                            getDateEntradaString,
                            getDateSaidaString,
                            getValorUnitString,
                        };

                        var linha_listviews = new ListViewItem(rows);

                        list_produtos.Items.Add(linha_listviews);
                    }


                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine($"erro ao receber dados, {ex.Message}");
            }
            finally
            {
                conn.CloseCon();
            }
        }
    }
}
