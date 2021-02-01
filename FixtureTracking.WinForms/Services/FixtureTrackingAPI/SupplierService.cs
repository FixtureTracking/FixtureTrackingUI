using FixtureTracking.Core.Utilities.Middlewares.Exception;
using FixtureTracking.Core.Utilities.Results;
using FixtureTracking.Entities.Concrete;
using FixtureTracking.Entities.Dtos.Supplier;
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
    public class SupplierService
    {
        public static async Task<Supplier> GetById(int supplierId)
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.SupplierService}/{supplierId}";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
                return response.Content.ReadFromJsonAsync<DataResult<Supplier>>().Result.Data;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new HttpFailureException(errorContent);
        }

        public static async Task<List<Supplier>> GetList()
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.SupplierService}";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
                return response.Content.ReadFromJsonAsync<DataResult<List<Supplier>>>().Result.Data;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new HttpFailureException(errorContent);
        }

        public static async Task<List<Fixture>> GetFixtures(int supplierId)
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.SupplierService}/{supplierId}/fixtures";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
                return response.Content.ReadFromJsonAsync<DataResult<List<Fixture>>>().Result.Data;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new HttpFailureException(errorContent);
        }

        public static async Task<Uri> Add(SupplierForAddDto supplierForAddDto)
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.SupplierService}";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.PostAsJsonAsync(uri, supplierForAddDto);

            if (response.IsSuccessStatusCode)
                return response.Headers.Location;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new HttpFailureException(errorContent);
        }

        public static async Task Update(SupplierForUpdateDto supplierForUpdateDto)
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.SupplierService}/{supplierForUpdateDto.Id}";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.PutAsJsonAsync(uri, supplierForUpdateDto);

            if (response.IsSuccessStatusCode)
                return;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new HttpFailureException(errorContent);
        }

        public static async Task Delete(int supplierId)
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.SupplierService}/{supplierId}";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.DeleteAsync(uri);

            if (response.IsSuccessStatusCode)
                return;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new HttpFailureException(errorContent);
        }

    }
}
