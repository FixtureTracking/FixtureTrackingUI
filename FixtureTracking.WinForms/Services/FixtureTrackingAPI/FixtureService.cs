using FixtureTracking.Core.Utilities.Middlewares.Exception;
using FixtureTracking.Core.Utilities.Results;
using FixtureTracking.Entities.Concrete;
using FixtureTracking.Entities.Dtos.Fixture;
using FixtureTracking.WinForms.Utils.Constants;
using FixtureTracking.WinForms.Utils.CustomExceptions;
using FixtureTracking.WinForms.Utils.Security;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace FixtureTracking.WinForms.Services.FixtureTrackingAPI
{
    public class FixtureService
    {
        public static async Task<Fixture> GetById(Guid fixtureId)
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.FixtureService}/{fixtureId}";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
                return response.Content.ReadFromJsonAsync<DataResult<Fixture>>().Result.Data;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new HttpFailureException(errorContent);
        }

        public static async Task<List<Fixture>> GetList()
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.FixtureService}";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
                return response.Content.ReadFromJsonAsync<DataResult<List<Fixture>>>().Result.Data;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new HttpFailureException(errorContent);
        }

        public static async Task<List<Debit>> GetDebits(Guid fixtureId)
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.FixtureService}/{fixtureId}/debits";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
                return response.Content.ReadFromJsonAsync<DataResult<List<Debit>>>().Result.Data;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new HttpFailureException(errorContent);
        }

        public static async Task<Uri> Add(FixtureForAddDto fixtureForAddDto)
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.FixtureService}";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.PostAsJsonAsync(uri, fixtureForAddDto);

            if (response.IsSuccessStatusCode)
                return response.Headers.Location;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new HttpFailureException(errorContent);
        }

        public static async Task Update(FixtureForUpdateDto fixtureForUpdateDto)
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.FixtureService}/{fixtureForUpdateDto.Id}";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.PutAsJsonAsync(uri, fixtureForUpdateDto);

            if (response.IsSuccessStatusCode)
                return;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new HttpFailureException(errorContent);
        }

        public static async Task Delete(Guid fixtureId)
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.FixtureService}/{fixtureId}";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.DeleteAsync(uri);

            if (response.IsSuccessStatusCode)
                return;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new HttpFailureException(errorContent);
        }
    }
}
