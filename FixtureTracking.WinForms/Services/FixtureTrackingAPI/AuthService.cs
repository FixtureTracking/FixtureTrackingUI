using FixtureTracking.Core.Utilities.Middlewares.Exception;
using FixtureTracking.Core.Utilities.Security.Tokens;
using FixtureTracking.Entities.Dtos.User;
using FixtureTracking.WinForms.Utilities.Constants;
using FixtureTracking.WinForms.Utilities.CustomExceptions;
using FixtureTracking.WinForms.Utilities.Security;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace FixtureTracking.WinForms.Services.FixtureTrackingAPI
{
    public class AuthService
    {
        public static async Task Login(UserForLoginDto userForLoginDto)
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.AuthService}/login";
            var response = await client.PostAsJsonAsync(uri, userForLoginDto);

            if (response.IsSuccessStatusCode)
            {
                var accessToken = response.Content.ReadFromJsonAsync<AccessToken>().Result;

                FormAccessToken.Token = accessToken.Token;
                FormAccessToken.Expiration = accessToken.Expiration;

                return;
            }
            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new HttpFailureException(errorContent);
        }

        public static async Task<Uri> Register(UserForRegisterDto userForRegisterDto)
        {
            using var client = new HttpClient();
            var uri = $"{APIAddresses.AuthService}/register";
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", FormAccessToken.Token);
            var response = await client.PostAsJsonAsync(uri, userForRegisterDto);

            if (response.IsSuccessStatusCode)
                return response.Headers.Location;

            var errorContent = response.Content.ReadFromJsonAsync<ErrorDetail>().Result;
            throw new HttpFailureException(errorContent);
        }
    }
}
