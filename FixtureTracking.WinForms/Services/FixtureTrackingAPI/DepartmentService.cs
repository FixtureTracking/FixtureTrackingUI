using FixtureTracking.Core.Entities.Concrete;
using FixtureTracking.Core.Utilities.Middlewares.Exception;
using FixtureTracking.Core.Utilities.Results;
using FixtureTracking.Entities.Concrete;
using FixtureTracking.Entities.Dtos.Department;
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
    public class DepartmentService
    {
        public static async Task<Department> GetById(int departmentId)
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.DepartmentService}/{departmentId}";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
                return response.Content.ReadFromJsonAsync<DataResult<Department>>().Result.Data;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new Exception(response.StatusCode.ToString() + "\r\n" + errorContent.Message.Replace("~", "\r\n"));
        }

        public static async Task<List<Department>> GetList()
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.DepartmentService}";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
                return response.Content.ReadFromJsonAsync<DataResult<List<Department>>>().Result.Data;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new Exception(response.StatusCode.ToString() + "\r\n" + errorContent.Message.Replace("~", "\r\n"));
        }

        public static async Task<List<User>> GetUsers(int departmentId)
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.DepartmentService}/{departmentId}/fixtures";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
                return response.Content.ReadFromJsonAsync<DataResult<List<User>>>().Result.Data;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new Exception(response.StatusCode.ToString() + "\r\n" + errorContent.Message.Replace("~", "\r\n"));
        }

        public static async Task<Uri> Add(DepartmentForAddDto departmentForAddDto)
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.DepartmentService}";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.PostAsJsonAsync(uri, departmentForAddDto);

            if (response.IsSuccessStatusCode)
                return response.Headers.Location;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new Exception(response.StatusCode.ToString() + "\r\n" + errorContent.Message.Replace("~", "\r\n"));
        }

        public static async Task Update(DepartmentForUpdateDto departmentForUpdateDto)
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.DepartmentService}/{departmentForUpdateDto.Id}";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.PutAsJsonAsync(uri, departmentForUpdateDto);

            if (response.IsSuccessStatusCode)
                return;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new Exception(response.StatusCode.ToString() + "\r\n" + errorContent.Message.Replace("~", "\r\n"));
        }

        public static async Task Delete(int departmentId)
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.DepartmentService}/{departmentId}";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.DeleteAsync(uri);

            if (response.IsSuccessStatusCode)
                return;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new Exception(response.StatusCode.ToString() + "\r\n" + errorContent.Message.Replace("~", "\r\n"));
        }
    }
}
