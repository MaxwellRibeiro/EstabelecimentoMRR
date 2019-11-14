using System;
using System.Collections.Generic;
using System.Linq;
using EstabelecimentoMRR.Model;

namespace EstabelecimentoMRR.Repository
{
    public class ContaRep : RepositorioBase
    {
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
