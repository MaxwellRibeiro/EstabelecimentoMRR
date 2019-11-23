using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using EstabelecimentoMRR.Model;
using MySql.Data.MySqlClient;

namespace EstabelecimentoMRR.Repository
{
    public class ContaRep : RepositorioBase
    {
        //------------Opções para fazer consultar/inserir, etc.. no banco -----//


        //Opcao 1
        public List<Conta> BuscarContarPorNome(string nome)
        {
            List<Conta> contas = new List<Conta>();

            var sql = "select * from conta where nome = @nome";

            MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["local"].ConnectionString);
            MySqlCommand command = new MySqlCommand(sql, con);
            command.Parameters.Add("@nome", MySqlDbType.VarChar, 1).Value = nome;
            con.Open();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                contas.Add(new Conta()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Nome = reader.GetString(reader.GetOrdinal("Nome"))
                });

            }
            con.Dispose();
            con.Close();

            return contas;
        }

        //Opcao 2
        public List<Conta> BuscarTodas()
        {
            try
            {
                return Query<Conta>("select * from conta").ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public Conta Salvar(Conta obj)
        {
            try
            {
                obj.Id = Insert(obj);
                return obj;
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public bool Atualizar(Conta obj)
        {
            try
            {
                return Update(obj);
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        
    }
}
