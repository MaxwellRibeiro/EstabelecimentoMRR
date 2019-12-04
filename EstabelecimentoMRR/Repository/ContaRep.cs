using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using EstabelecimentoMRR.Model;
using MySql.Data.MySqlClient;
using EstabelecimentoMRR.Enum;

namespace EstabelecimentoMRR.Repository
{
    public class ContaRep
    {
        //Opcao 1


        public bool Insert(Conta _fluxocaixa)
        {        
            var sql = "insert into conta(Nome, TipoConta, DataLancamento, DataVencimento, Valor, Status, idUsuario, Descricao) " +
                "values('"+ _fluxocaixa.Nome + "', " + (int)_fluxocaixa.TipoConta + ", '" + _fluxocaixa.DataLancamento.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + _fluxocaixa.DataVencimento.ToString("yyyy-MM-dd HH:mm:ss") + "'," +
                " " + _fluxocaixa.Valor + ", " + (int)_fluxocaixa.Status + ", " + _fluxocaixa.IdUsuario + ", '" + _fluxocaixa.Descricao + "')";
  


            MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["local"].ConnectionString);
            MySqlCommand command = new MySqlCommand(sql, con);
            con.Open();

            _fluxocaixa.Id = Convert.ToInt32(command.ExecuteScalar());
            
            con.Dispose();
            con.Close();

            return true;
        }

        public bool Update(Conta _fluxocaixa)
        {
            var sql = "update conta set Nome = '" + _fluxocaixa.Nome + "', DataVencimento = '" +
                _fluxocaixa.DataVencimento.ToString("yyyy-MM-dd HH:mm:ss") + "', Descricao= '" +
                _fluxocaixa.Descricao + "' where Id=" + _fluxocaixa.Id;


            MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["local"].ConnectionString);
            MySqlCommand command = new MySqlCommand(sql, con);
            con.Open();

            _fluxocaixa.Id = Convert.ToInt32(command.ExecuteScalar());


            con.Dispose();
            con.Close();

            return true;
        }

        public bool UpdateSeguro(Conta _fluxocaixa)
        {
            var sql = "update conta set Nome = @nome, DataVencimento = '" +
                _fluxocaixa.DataVencimento.ToString("yyyy-MM-dd HH:mm:ss") + "', Descricao= @desc where Id= @id";
                                   
           
            MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["local"].ConnectionString);
            MySqlCommand command = new MySqlCommand(sql, con);
            command.Parameters.Add("@nome", MySqlDbType.VarChar);
            command.Parameters.Add("@desc", MySqlDbType.VarChar);
            command.Parameters.Add("@id", MySqlDbType.Int32);

            command.Parameters["@nome"].Value = _fluxocaixa.Nome;
            command.Parameters["@desc"].Value = _fluxocaixa.Descricao;
            command.Parameters["@id"].Value = _fluxocaixa.Id;
            con.Open();

            _fluxocaixa.Id = Convert.ToInt32(command.ExecuteScalar());


            con.Dispose();
            con.Close();


            return true;
        }
        public bool Efetivar(Conta _fluxocaixa)
        {
            var sql = "update conta  set Status = "+ (int)_fluxocaixa.Status + " where Id = " + _fluxocaixa.Id;


            MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["local"].ConnectionString);
            MySqlCommand command = new MySqlCommand(sql, con);
            con.Open();

            int x = Convert.ToInt32(command.ExecuteScalar());


            con.Dispose();
            con.Close();

            return true;
        }
        public bool Delete(Conta _fluxocaixa)
        {
            var sql = "delete from conta where Id =" + _fluxocaixa.Id;


            MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["local"].ConnectionString);
            MySqlCommand command = new MySqlCommand(sql, con);
            con.Open();

            _fluxocaixa.Id = Convert.ToInt32(command.ExecuteScalar());


            con.Dispose();
            con.Close();

            return true;
        }
        public List<Conta> Select_All()
        {
            List<Conta> contas = new List<Conta>();
            
            var sql = $"select * from conta where IdUsuario = {Session.Instance.IdUsuario}";

            MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["local"].ConnectionString);
            MySqlCommand command = new MySqlCommand(sql, con);
            con.Open();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                var conta = reader.GetInt32(reader.GetOrdinal("TipoConta"));
                var status = reader.GetInt32(reader.GetOrdinal("Status"));
                TipoConta paramTipo;
                if (conta == 1)
                    paramTipo = TipoConta.Despesa;
                else if (conta == 2)
                    paramTipo = TipoConta.Receita;
                else
                    throw new Exception("Erro");

                Status paramStatus;
                if (status == 1)
                    paramStatus = Status.Pendente;
                else if (status == 2)
                    paramStatus = Status.Quitada;
                else
                    paramStatus = Status.Recebido;
                contas.Add(new Conta()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    IdUsuario = reader.GetInt32(reader.GetOrdinal("IdUsuario")),
                    Nome = reader.GetString(reader.GetOrdinal("Nome")),
                    TipoConta = paramTipo,
                    DataLancamento = reader.GetDateTime(reader.GetOrdinal("DataLancamento")),
                    DataVencimento = reader.GetDateTime(reader.GetOrdinal("DataVencimento")),
                    Valor = reader.GetDecimal(reader.GetOrdinal("Valor")),
                    Status = paramStatus,
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
    }
}
