using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;

namespace EstabelecimentoMRR.Repository
{
    public class RepositorioBase
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

        public IEnumerable<T> Query<T>(string query)
        {
            IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["local"].ConnectionString);
            db.Open();
            try
            {
                var obj = db.Query<T>(query);
                return obj;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                return null;
            }
            finally
            {
                db.Close();
            }
        }

        public long Insert<T>(T model) where T : class
        {
            IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["local"].ConnectionString);
            db.Open();
            try
            {
                return db.Insert(model);
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

        public bool Update<T>(T model) where T : class
        {
            IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["local"].ConnectionString);
            db.Open();
            try
            {
                return db.Update(model);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                return false;
            }
            finally
            {
                db.Close();
            }
        }

        public bool Delete<T>(T model) where T : class
        {
            IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["local"].ConnectionString);
            db.Open();
            try
            {
                return db.Delete(model);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                return false;
            }
            finally
            {
                db.Close();
            }
        }
    }
}
