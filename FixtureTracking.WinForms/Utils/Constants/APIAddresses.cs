namespace FixtureTracking.WinForms.Utils.Constants
{
    public static class APIAddresses
    {
        private static readonly string baseUrl = "https://fixture-tracking.herokuapp.com/api";

        public static string AuthService => $"{baseUrl}/auth";
        public static string CategoryService => $"{baseUrl}/categories";
    }
}
