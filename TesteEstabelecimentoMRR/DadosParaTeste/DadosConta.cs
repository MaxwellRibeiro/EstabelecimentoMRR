using System;
using System.Collections.Generic;
using EstabelecimentoMRR.Enum;
using EstabelecimentoMRR.Model;

namespace TesteEstabelecimentoMRR.DadosParaTeste
{
    public static class DadosConta
    {
        public static readonly List<Conta> BaseDados1 = new List<Conta>
        {
            new Conta
            {
                Id = 1, 
                Nome = "Salario", 
                TipoConta = TipoConta.Receita, 
                DataLancamento = new DateTime(2019,01,01), 
                DataVencimento = new DateTime(2019,01,01), 
                Valor = 1250, 
                Status = Status.Quitada, 
                Descricao = "Ref. mês 01."
            },
            new Conta
            {
                Id = 2,
                Nome = "Luz",
                TipoConta = TipoConta.Dispesa,
                DataLancamento = new DateTime(2019,01,01),
                DataVencimento = new DateTime(2019,02,05),
                Valor = 150,
                Status = Status.Pendente,
                Descricao = "Ref. mês 02."
            },
            new Conta
            {
                Id = 3,
                Nome = "Concerto notebook",
                TipoConta = TipoConta.Receita,
                DataLancamento = new DateTime(2019,03,01),
                Valor = 100,
                Status = Status.Pendente,
                Descricao = ""
            },
            new Conta
            {
                Id = 4,
                Nome = "Conta Luz",
                TipoConta = TipoConta.Dispesa,
                DataLancamento = new DateTime(2019,02,01),
                DataVencimento =  new DateTime(2019,03,01),
                Valor = 90,
                Status = Status.Quitada,
                Descricao = "Ref. mês 03"
            },
            new Conta
            {
                Id = 5,
                Nome = "Manuntenção carro",
                TipoConta = TipoConta.Dispesa,
                DataLancamento = new DateTime(2019,02,01),
                DataVencimento = new DateTime(2019,02,01),
                Valor = 180,
                Status = Status.Quitada,
                Descricao = "Troca óleo"
            }
        };
    }
}

