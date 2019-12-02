using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using EstabelecimentoMRR.Enum;
using EstabelecimentoMRR.Model;
using MySql.Data.MySqlClient;

namespace EstabelecimentoMRR.Repository
{
    public class GeralRep /*: RepositorioBase*/
    {
        //------------Opções para fazer consultar/inserir, etc.. no banco -----//


        //Opcao 1
        public List<Conta> BuscarContarPorNomeRUIM(string nome)
        {
            List<Conta> contas = new List<Conta>();

            var sql = "select * from conta where nome = " + nome;

            MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["local"].ConnectionString);
            MySqlCommand command = new MySqlCommand(sql, con);
            con.Open();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                var c = reader.GetInt32(reader.GetOrdinal("TipoConta"));
                var s = reader.GetInt32(reader.GetOrdinal("Status"));
                TipoConta e;
                if (c == 1)               
                    e = TipoConta.Despesa;                
                else if (c == 2)                
                    e = TipoConta.Receita;                
                else
                    throw new Exception("Erro");

                Status x;
                if (s == 1)                
                    x = Status.Pendente;                
                else if (c == 2)                
                    x = Status.Quitada;                
                else
                    x = Status.Recebido;
                contas.Add(new Conta()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Nome = reader.GetString(reader.GetOrdinal("Nome")),
                    TipoConta = e,
                    DataLancamento = reader.GetDateTime(reader.GetOrdinal("DataLancamento")),
                    DataVencimento = reader.GetDateTime(reader.GetOrdinal("DataVencimento")),
                    Valor = reader.GetDecimal(reader.GetOrdinal("Valor")),
                    Status = x,
                    Descricao = reader.GetString(reader.GetOrdinal("Descricao"))
                });

            }
            con.Dispose();
            con.Close();

            return contas;
        }


        public List<Conta> BuscarContarPorNomeMELHORIA(string nome)
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

        ////Opcao 2
        //public List<Conta> BuscarTodas()
        //{
        //    try
        //    {
        //        return Query<Conta>("select * from conta").ToList();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        throw;
        //    }
        //}

        //public Conta Salvar(Conta obj)
        //{
        //    try
        //    {
        //        obj.Id = Insert(obj);
        //        return obj;
        //    }
        //    catch (Exception x)
        //    {
        //        throw x;
        //    }
        //}

        //public bool Atualizar(Conta obj)
        //{
        //    try
        //    {
        //        return Update(obj);
        //    }
        //    catch (Exception x)
        //    {
        //        throw x;
        //    }
        //}

        
    }
}
