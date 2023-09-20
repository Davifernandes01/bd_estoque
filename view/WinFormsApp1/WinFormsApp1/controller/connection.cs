using System.Data;
using System.Data.SqlClient;
namespace Connection { 
     class connection
    {
        private string StringCon;
        private SqlConnection con;

        //passando a string de conexao com o banco de dados no construtor
        public connection(string dataSource, string InitialCatalog, string IntegratedSecurity )
        {
            this.StringCon = $"Data Source={dataSource};Initial Catalog={InitialCatalog};Integrated Security={IntegratedSecurity}";
            //criando a conexao com a string
            con = new SqlConnection(StringCon);
        }

        public bool OpenCon()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                return true;
            }catch(Exception ex)
            {
                Console.WriteLine($"erro ao abrir conexão, {ex.Message}");
                return false;
            }
        }

        public bool CloseCon()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();

            }
            return true;
        }

        public SqlConnection GetCon()
        {
            return con;
        }
    }
}
