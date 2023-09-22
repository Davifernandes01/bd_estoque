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
    public partial class FormVendas : Form
    {
        public FormVendas()
        {
            InitializeComponent();
            ComboBox();
        }

        static string DataSource = "DESKTOP-132MB6V\\DAVISQL";
        static string InitialCatalog = "Estoque";
        static string IntegratedSecurity = "True";
        //abrindo a conexão
        connection conn = new connection(DataSource, InitialCatalog, IntegratedSecurity);


        private void button_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBox()
        {
            try
            {

                if (conn.OpenCon())
                {
                    string sql = "select nome from Produtos";

                    using (SqlCommand command = new SqlCommand(sql, conn.GetCon()))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBox_vendas.Items.Add(reader["nome"].ToString());

                            }


                        }


                    }


                }
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show(ex.Message, "Vendas", MessageBoxButtons.OK);
            }
            finally
            {
                conn.CloseCon();
            }

        }

        private void FormVendas_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_vendas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_vendas_Click(object sender, EventArgs e)
        {
        }
    }
}
