using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using Dapper;
using MySql.Data.MySqlClient;

namespace EstabelecimentoMRR.Repository
{
    public class FluxoCaixaRep
    {
        public int Execute(string sql)
        {
            IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["local"].ConnectionString);
            db.Open();
            try
            {
                //Retorno: O número inteiro representa o número de linhas que foram afetadas pela sua consulta.
                return db.Execute(sql);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                return 0;
            }
            finally
            {
                db.Close();
            }
        }
    }
}
