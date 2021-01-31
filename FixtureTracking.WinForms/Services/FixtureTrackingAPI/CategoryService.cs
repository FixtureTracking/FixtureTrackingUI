using FixtureTracking.Core.Utilities.Middlewares.Exception;
using FixtureTracking.Core.Utilities.Results;
using FixtureTracking.Entities.Concrete;
using FixtureTracking.Entities.Dtos.Category;
using FixtureTracking.WinForms.Utils.Constants;
using FixtureTracking.WinForms.Utils.Security;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace FixtureTracking.WinForms.Services.FixtureTrackingAPI
{
    public class CategoryService
    {
        public static async Task<Category> GetById(short categoryId)
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.CategoryService}/{categoryId}";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
                return response.Content.ReadFromJsonAsync<DataResult<Category>>().Result.Data;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new Exception(response.StatusCode.ToString() + "\r\n" + errorContent.Message.Replace("~", "\r\n"));
        }

        public static async Task<List<Category>> GetList()
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.CategoryService}";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
                return response.Content.ReadFromJsonAsync<DataResult<List<Category>>>().Result.Data;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new Exception(response.StatusCode.ToString() + "\r\n" + errorContent.Message.Replace("~", "\r\n"));
        }

        public static async Task<List<Fixture>> GetFixtures(short categoryId)
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.CategoryService}/{categoryId}/fixtures";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
                return response.Content.ReadFromJsonAsync<DataResult<List<Fixture>>>().Result.Data;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new Exception(response.StatusCode.ToString() + "\r\n" + errorContent.Message.Replace("~", "\r\n"));
        }

        public static async Task<Uri> Add(CategoryForAddDto categoryForAddDto)
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.CategoryService}";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.PostAsJsonAsync(uri, categoryForAddDto);

            if (response.IsSuccessStatusCode)
                return response.Headers.Location;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new Exception(response.StatusCode.ToString() + "\r\n" + errorContent.Message.Replace("~", "\r\n"));
        }

        public static async Task Update(CategoryForUpdateDto categoryForUpdateDto)
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.CategoryService}/{categoryForUpdateDto.Id}";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.PutAsJsonAsync(uri, categoryForUpdateDto);

            if (response.IsSuccessStatusCode)
                return;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new Exception(response.StatusCode.ToString() + "\r\n" + errorContent.Message.Replace("~", "\r\n"));
        }

        public static async Task Delete(short categoryId)
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.CategoryService}/{categoryId}";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.DeleteAsync(uri);

            if (response.IsSuccessStatusCode)
                return;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new Exception(response.StatusCode.ToString() + "\r\n" + errorContent.Message.Replace("~", "\r\n"));
        }

    }
}
