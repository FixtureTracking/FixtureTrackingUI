using FixtureTracking.Core.Entities.Concrete;
using FixtureTracking.Core.Utilities.Middlewares.Exception;
using FixtureTracking.Core.Utilities.Results;
using FixtureTracking.Entities.Concrete;
using FixtureTracking.WinForms.Utilities.Constants;
using FixtureTracking.WinForms.Utilities.CustomExceptions;
using FixtureTracking.WinForms.Utilities.Security;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace FixtureTracking.WinForms.Services.FixtureTrackingAPI
{
    public class UserService
    {
        public static async Task<User> GetById(Guid userId)
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.UserService}/{userId}";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
                return response.Content.ReadFromJsonAsync<DataResult<User>>().Result.Data;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new HttpFailureException(errorContent);
        }

        public static async Task<List<User>> GetList()
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.UserService}";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
                return response.Content.ReadFromJsonAsync<DataResult<List<User>>>().Result.Data;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new HttpFailureException(errorContent);
        }

        public static async Task<List<Debit>> GetDebits(Guid userId)
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.UserService}/{userId}/debits";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
                return response.Content.ReadFromJsonAsync<DataResult<List<Debit>>>().Result.Data;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new HttpFailureException(errorContent);
        }

        public static async Task Delete(Guid userId)
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.UserService}/{userId}";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.DeleteAsync(uri);

            if (response.IsSuccessStatusCode)
                return;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new HttpFailureException(errorContent);
        }
    }
}
