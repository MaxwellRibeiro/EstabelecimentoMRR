using System.Configuration;
using EstabelecimentoMRR.Model;
using MySql.Data.MySqlClient;

namespace EstabelecimentoMRR.Repository
{
    public class UsuarioRep
    {
        public bool Login(string email, string senha)
        {
            bool acesso = false;

            var sql = "SELECT COUNT(*) AS Acesso FROM usuario AS u WHERE u.Email = '" + email + "' AND senha = '" + senha + "'";

            MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["local"].ConnectionString);
            MySqlCommand command = new MySqlCommand(sql, con);
            con.Open();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                acesso = reader.GetInt32(reader.GetOrdinal("Acesso")) > 0;
            }
            con.Dispose();
            con.Close();

            return acesso;
        }

        public bool Inserir(Usuario usuario)
        {
            var sql = "insert into usuario(Nome, Email, Senha) " + "values('" + usuario.Nome + "', '" + usuario.Email + "', '" + usuario.Senha + "'); SELECT LAST_INSERT_ID();";

            MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["local"].ConnectionString);
            MySqlCommand command = new MySqlCommand(sql, con);
            con.Open();

            usuario.Id = command.ExecuteScalar().GetHashCode();

            con.Dispose();
            con.Close();

            return usuario.Id > 0;
        }
    }
}
