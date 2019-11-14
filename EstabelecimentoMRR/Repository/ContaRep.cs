using System;
using EstabelecimentoMRR.Model;

namespace EstabelecimentoMRR.Repository
{
    public class ContaRep : RepositorioBase
    {
        public void Inserir(Conta obj)
        {
            try
            {
                Inserir(obj);
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public void Update(Conta obj)
        {
            try
            {
                Update(obj);
            }
            catch (Exception x)
            {
                throw x;
            }
        }
    }
}
