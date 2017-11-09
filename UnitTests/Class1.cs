using Xunit;
using System;
using Microsoft.Extensions.Configuration;

namespace UnitTests
{
    public class Class1
    {
        [Fact]
        public void PassingTest()
        {
            var testConfiguration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("testsettings.json")
                .Build();
        }
    }
}
