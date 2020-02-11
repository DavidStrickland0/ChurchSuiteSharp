using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Xunit;

namespace ChurchSuiteSharp.Tests
{
    [Collection("Configuration")]
    public class SmallGroupServiceUnitTests
    {
        Configuration configuration;

        public SmallGroupServiceUnitTests(ConfigurationFixture fixture)
        {
            this.configuration = fixture.Configuration;
        }
        [Fact]
        public async void GetSmallGroupsfromSmallGroupService()
        {
            var httpClient = new HttpClient();
            var result = await SmallGroupService.RetrieveSmallGroups(configuration.Account, httpClient);
            Assert.NotEmpty(result);
        }
    }


}
