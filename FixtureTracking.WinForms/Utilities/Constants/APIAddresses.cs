﻿namespace FixtureTracking.WinForms.Utilities.Constants
{
    public static class APIAddresses
    {
        private static readonly string baseUrl = "https://fixture-tracking.herokuapp.com/api";

        public static string AuthService => $"{baseUrl}/auth";
        public static string CategoryService => $"{baseUrl}/categories";
        public static string DebitService => $"{baseUrl}/debits";
        public static string DepartmentService => $"{baseUrl}/departments";
        public static string FixtureService => $"{baseUrl}/fixtures";
        public static string SupplierService => $"{baseUrl}/suppliers";
        public static string UserService => $"{baseUrl}/users";
    }
}
