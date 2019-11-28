using System;
using System.Collections.Generic;
using EstabelecimentoMRR.BusinessLogic;
using EstabelecimentoMRR.Model;
using TesteEstabelecimentoMRR.ClassData_Theory;
using TesteEstabelecimentoMRR.DadosParaTeste;
using Xunit;

namespace TesteEstabelecimentoMRR.Classe
{
    public class ContaTeste
    {
        //Teste usando Fact
        [Fact]
        public void TestarCalculoSaldo()
        {
            List<Conta> contas = DadosConta.BaseDados1;

            Assert.Equal(980, ContaLogic.CalcularSaldo(contas));
        }

        [Fact]
        public void TestarCalculoValorARecebero()
        {
            List<Conta> contas = DadosConta.BaseDados1;

            Assert.Equal(100, ContaLogic.CalcularValorAReceber(contas));
        }

        [Fact]
        public void TestarCalculoValorAPagar()
        {
            List<Conta> contas = DadosConta.BaseDados1;

            Assert.Equal(150, ContaLogic.CalcularValorAPagar(contas));
        }
        //---------------------------------------------------------------------------------------------------------------//

        //Teste usando Theory e MemberData
        [Theory]
        [ClassData(typeof(CalculoValorAPagarAtradadoData))]
        public void TestarCalculoValorAPagarAtradado(DateTime data, List<Conta> contas, int expected)
        {
            Assert.Equal(expected, ContaLogic.CalcularValorAPagarAtradado(data, contas));
        }
        //---------------------------------------------------------------------------------------------------------------//

        //Teste usando Theory e MemberData
        [Theory]
        [MemberData(nameof(Data))]
        public void TestarCalculoGastoMedio(List<Conta> contas, int expected)
        {
            Assert.Equal(expected, ContaLogic.CalcularGastoMedio(contas));
        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] { DadosConta.BaseDados1, 135 }
            };
        //---------------------------------------------------------------------------------------------------------------//
    }
}