using FixtureTracking.Entities.Dtos.User;
using System;

namespace FixtureTracking.WinForms.Utilities.Security
{
    public static class FormAccessToken
    {
        public static string Token { get; set; }
        public static DateTime Expiration { get; set; }
        public static Guid UserId { get; set; }
        public static UserForDetailDto CurrentUser { get; set; }
    }
}
