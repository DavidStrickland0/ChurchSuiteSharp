using ChurchSuiteSharp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ChurchSuiteSharp;

public class CalanderService
{
    public static async Task<IList<Calendar>> RetrieveCalanderAsync(string account, HttpClient httpClient)
    {
        var result = await httpClient.GetAsync($"https://{account}.churchsuite.co.uk/embed/calendar/json");
        var resultString = await result.Content.ReadAsStringAsync();
        var cleanedResultString = JsonManager.EmptyArraysToNull(resultString);
        return JsonConvert.DeserializeObject<List<Calendar>>(cleanedResultString);
    }
}
