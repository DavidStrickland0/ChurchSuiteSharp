using ChurchSuiteSharp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ChurchSuiteSharp
{
    public class SmallGroupService
    {
        public static async Task<IList<SmallGroup>> RetrieveSmallGroups(string subDomain,HttpClient client)
        {
            var result = await client.GetAsync($"https://{subDomain}.churchsuite.co.uk/embed/smallgroups/json");
            var resultString = await result.Content.ReadAsStringAsync();

            var settings = new JsonSerializerSettings()
            {
                MissingMemberHandling = MissingMemberHandling.Error
            };
            return JsonConvert.DeserializeObject<List<SmallGroup>>(resultString, settings);
        }
    }
}
