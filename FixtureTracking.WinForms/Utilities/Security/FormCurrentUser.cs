using FixtureTracking.Core.Entities.Concrete;
using FixtureTracking.Entities.Concrete;
using System;

namespace FixtureTracking.WinForms.Utilities.Security
{
    public static class FormCurrentUser
    {
        public static Guid UserId { get; set; }
        public static string FullName { get; set; }
        public static string Username { get; set; }
        public static string Email { get; set; }
        public static int DepartmentId { get; set; }
        public static string DepartmentName { get; set; }

        public static void SetUserValues(User user)
        {
            UserId = user.Id;
            FullName = $"{user.FirstName} {user.LastName}";
            Username = user.FirstName;
            Email = user.Email;
            DepartmentId = user.DepartmentId;
        }

        public static void SetDepartmentValues(Department department)
        {
            DepartmentName = department.Name;
        }
    }
}
