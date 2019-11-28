using System;
using System.Collections.Generic;
using System.Linq;
using EstabelecimentoMRR.Enum;
using EstabelecimentoMRR.Model;

namespace EstabelecimentoMRR.BusinessLogic
{
    public static class ContaLogic
    {
        public static decimal CalcularSaldo(List<Conta> contas)
        {
            decimal saldo = 0;
            var contasEfetivas = contas.Where(c => c.Status == Status.Quitada).ToList();

            foreach (var conta in contasEfetivas)
            {
                if(conta.TipoConta == TipoConta.Dispesa)
                {
                    saldo -= conta.Valor;
                }
                else if (conta.TipoConta == TipoConta.Receita)
                {
                    saldo += conta.Valor;
                }
            }
            return saldo;
        }

        public static decimal CalcularGastoMedio(List<Conta> contas)
        {
            decimal mediaGasto = 0;

            var despesasPagas = contas.Where(c => c.TipoConta == TipoConta.Dispesa).ToList();

            decimal totalGasto = despesasPagas.Sum(d=> d.Valor);
            int totalDespesa = despesasPagas.Count;

            if (totalDespesa > 0)
            {
                mediaGasto = totalGasto / totalDespesa;
            }

            return mediaGasto;
        }

        public static decimal CalcularValorAPagarAtradado(DateTime data, List<Conta> contas)
        {
            decimal totalValorAPagarAtradado = 0;
            foreach (var conta in contas)
            {
                if (data.Date        > conta.DataVencimento.Date &&
                    conta.TipoConta == TipoConta.Dispesa         &&
                    conta.Status    == Status.Pendente)
                {
                    totalValorAPagarAtradado += conta.Valor;
                }
            }

            return totalValorAPagarAtradado;
        }

        public static decimal CalcularValorAReceber(List<Conta> contas)
        {
            return contas.Where(c => c.TipoConta == TipoConta.Receita && c.Status == Status.Pendente).Sum(s=> s.Valor);
        }

        public static decimal CalcularValorAPagar(List<Conta> contas)
        {
            return contas.Where(c => c.TipoConta == TipoConta.Dispesa && c.Status == Status.Pendente).Sum(s => s.Valor);
        }
    }
}
