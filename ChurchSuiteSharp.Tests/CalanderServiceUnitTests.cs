using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Xunit;

namespace ChurchSuiteSharp.Tests
{
    [Collection("Configuration")]
    public class CalanderServiceUnitTests
    {
        Configuration configuration;

        public CalanderServiceUnitTests(ConfigurationFixture fixture)
        {
            this.configuration = fixture.Configuration;
        }
        [Fact]
        public async void GetCalanderfromCalnderService()
        {
            var httpClient = new HttpClient();
            var result = await CalanderService.RetrieveCalanderAsync(configuration.Account, httpClient);
            Assert.NotEmpty(result);
        }
    }


}
