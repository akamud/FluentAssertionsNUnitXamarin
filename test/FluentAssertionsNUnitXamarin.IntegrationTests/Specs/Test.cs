using System.Collections.Generic;
using FluentAssertions;
using FluentAssertionsNUnitXamarin.IntegrationTests.Suporte;
using NUnit.Framework;

namespace FluentAssertionsNUnitXamarin.IntegrationTests.Specs
{
    public class Test : TesteBase
    {
        [Test]
        public void ListaDeveConter42()
        {
            var lista = new List<int> { 1, 42, 100 };

            // Esse assert está errado de propósito, para mostrar que a mensagem
            // de erro é exibida corretamente.
            lista.Should().Contain(50);
        }
    }
}
