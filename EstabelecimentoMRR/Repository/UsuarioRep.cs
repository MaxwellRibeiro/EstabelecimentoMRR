using System;
using System.Configuration;
using System.Data;
using EstabelecimentoMRR.Model;
using MySql.Data.MySqlClient;

namespace EstabelecimentoMRR.Repository
{
    public class UsuarioRep
    {
        public Usuario Login(string email, string senha)
        {
            Usuario usuario = null;

                      var sql = "SELECT * FROM usuario AS u WHERE u.Email = '" + email + "' AND senha = '" + senha + "'";
            //var sql = "SELECT * FROM usuario AS u WHERE u.Email = " + email + " AND senha = " + senha;
            MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["local"].ConnectionString);
            MySqlCommand command = new MySqlCommand(sql, con);
            con.Open();

            MySqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                usuario = new Usuario
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Nome = reader.GetString(reader.GetOrdinal("Nome")),
                    Email = reader.GetString(reader.GetOrdinal("Email"))
                };
                break;

            }
            con.Dispose();
            con.Close();

            return usuario;
        }

        public Usuario LoginSeguro(string email, string senha)
        {
            Usuario usuario = null;

            var sql = "SELECT * FROM usuario AS u WHERE u.Email = @email AND senha = @senha";
            MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["local"].ConnectionString);
            MySqlCommand command = new MySqlCommand(sql, con);
            command.Parameters.Add("@email", MySqlDbType.VarChar);
            command.Parameters.Add("@senha", MySqlDbType.VarChar);

            command.Parameters["@email"].Value = email;
            command.Parameters["@senha"].Value = senha;
            con.Open();


            MySqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                usuario = new Usuario
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Nome = reader.GetString(reader.GetOrdinal("Nome")),
                    Email = reader.GetString(reader.GetOrdinal("Email"))
                };
                break;

            }
            con.Dispose();
            con.Close();

            return usuario;
        }

        public bool Inserir(Usuario usuario)
        {
            var sql = "insert into usuario(Nome, Email, Senha) " + "values('" + usuario.Nome + "', '" + usuario.Email + "', '" + usuario.Senha + "'); SELECT LAST_INSERT_ID();";

            MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["local"].ConnectionString);
            MySqlCommand command = new MySqlCommand(sql, con);
            con.Open();

            usuario.Id = Convert.ToInt32(command.ExecuteScalar());

            con.Dispose();
            con.Close();

            return usuario.Id > 0;
        }
    }
}
