using System;
using FluentAssertions.Common;
using NUnit.Framework;

namespace FluentAssertionsNUnitXamarin.IntegrationTests.Suporte
{
    public class TesteBase
    {
        [SetUp]
        public void SetUp()
        {
            Services.ConfigurationStore = new NullConfigurationStore();
        }
    }
}
