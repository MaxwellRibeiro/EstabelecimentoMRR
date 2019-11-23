using System;
using System.Collections;
using System.Collections.Generic;
using TesteEstabelecimentoMRR.DadosParaTeste;

namespace TesteEstabelecimentoMRR.ClassData_Theory
{
    public class CalculoValorAPagarAtradadoData : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] { new DateTime(2020, 01,01), DadosConta.BaseDados1, 150 },
            new object[] { new DateTime(2018, 01,01), DadosConta.BaseDados1, 0 }
        };

        public IEnumerator<object[]> GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
