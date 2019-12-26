using System;
using FluentAssertions.Common;

namespace FluentAssertionsNUnitXamarin.IntegrationTests.Suporte
{
	public class NullConfigurationStore : IConfigurationStore
	{
		public string GetSetting(string name)
		{
			return null;
		}
	}
}
