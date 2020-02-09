using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace ChurchSuiteSharp.Tests
{
    public class Configuration
    {
        public string Account { get; set; }
    }


    public class ConfigurationFixture
    {
        public ConfigurationFixture()
        {
            var requestStream = typeof(ConfigurationFixture).Assembly.GetManifestResourceStream("ChurchSuiteSharp.Tests.Configuration.json");
            var requestBody = new StreamReader(requestStream).ReadToEnd();
            Configuration = JsonConvert.DeserializeObject<Configuration>(requestBody);
        }
        public Configuration Configuration { get; }
    }
    [CollectionDefinition("Configuration")]
    public class ConfigurationCollectionFixture : ICollectionFixture<ConfigurationFixture>
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }

}
