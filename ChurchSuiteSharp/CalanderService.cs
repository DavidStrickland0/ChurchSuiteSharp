using ChurchSuiteSharp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

public class CalanderService
{
    public static async Task<IList<Calendar>> RetrieveCalanderAsync(HttpClient httpClient, string account)
    {
        var result = await httpClient.GetAsync($"https://{account}.churchsuite.co.uk/embed/calendar/json");
        var resultString = await result.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<List<Calendar>>(resultString);
    }
}
