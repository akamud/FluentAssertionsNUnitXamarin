using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace FluentAssertionsNUnitXamarin.IntegrationTests.Specs
{
    public class Test
    {
        [Test]
        public void ListaDeveConter42()
        {
            var lista = new List<int> { 1, 42, 100 };

            lista.Should().Contain(42);
        }
    }
}
