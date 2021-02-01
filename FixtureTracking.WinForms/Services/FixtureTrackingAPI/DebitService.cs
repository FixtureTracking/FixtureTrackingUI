using FixtureTracking.Core.Utilities.Middlewares.Exception;
using FixtureTracking.Core.Utilities.Results;
using FixtureTracking.Entities.Concrete;
using FixtureTracking.Entities.Dtos.Debit;
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
    public class DebitService
    {
        public static async Task<Debit> GetById(Guid debitId)
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.DebitService}/{debitId}";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
                return response.Content.ReadFromJsonAsync<DataResult<Debit>>().Result.Data;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new HttpFailureException(errorContent);
        }

        public static async Task<List<Debit>> GetList()
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.DebitService}";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
                return response.Content.ReadFromJsonAsync<DataResult<List<Debit>>>().Result.Data;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new HttpFailureException(errorContent);
        }

        public static async Task<Uri> Add(DebitForAddDto debitForAddDto)
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.DebitService}";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.PostAsJsonAsync(uri, debitForAddDto);

            if (response.IsSuccessStatusCode)
                return response.Headers.Location;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new HttpFailureException(errorContent);
        }

        public static async Task Update(DebitForUpdateDto debitForUpdateDto)
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.DebitService}/{debitForUpdateDto.Id}";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.PutAsJsonAsync(uri, debitForUpdateDto);

            if (response.IsSuccessStatusCode)
                return;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new HttpFailureException(errorContent);
        }

        public static async Task Delete(Guid debitId)
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.DebitService}/{debitId}";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.DeleteAsync(uri);

            if (response.IsSuccessStatusCode)
                return;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new HttpFailureException(errorContent);
        }
    }
}
