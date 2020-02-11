using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

namespace ChurchSuiteSharp.Tests
{
    [Collection("Configuration")]
    public class JsonApiTests
    {
        Configuration configuration;

        public JsonApiTests(ConfigurationFixture fixture)
        {
            this.configuration = fixture.Configuration;
        }
        [Fact]
        public async System.Threading.Tasks.Task CalanderJsonFeedAsync()
        {
            var httpClient = new HttpClient();
            var result = await httpClient.GetAsync($"https://{configuration.Account}.churchsuite.co.uk/embed/calendar/json");
            var resultString = await result.Content.ReadAsStringAsync();

            var settings = new JsonSerializerSettings()
            {
                MissingMemberHandling = MissingMemberHandling.Error
            };
            var cleanedResultString = JsonManager.EmptyArraysToNull(resultString);
            var calander = JsonConvert.DeserializeObject<List<Models.Calendar>>(cleanedResultString, settings);
        }

        [Fact]
        public async System.Threading.Tasks.Task SmallGroupsJsonFeedAsync()
        {
            var subDomain = configuration.Account;
            var httpClient = new HttpClient();
            var result = await httpClient.GetAsync($"https://{configuration.Account}.churchsuite.co.uk/embed/smallgroups/json");
            var resultString = await result.Content.ReadAsStringAsync();

            var settings = new JsonSerializerSettings()
            {
                MissingMemberHandling = MissingMemberHandling.Error
            };
            var cleanedResultString = JsonManager.EmptyArraysToNull(resultString);
            var calander = JsonConvert.DeserializeObject<List<Models.SmallGroup>>(cleanedResultString, settings);


        }

    }
}
