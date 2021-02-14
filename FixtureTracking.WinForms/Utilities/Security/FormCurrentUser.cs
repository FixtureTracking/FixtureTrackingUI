using FixtureTracking.Entities.Dtos.User;
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

        public static void SetValues(UserForDetailDto userForDetailDto)
        {
            UserId = userForDetailDto.User.Id;
            FullName = userForDetailDto.FullName;
            Username = userForDetailDto.User.Username;
            Email = userForDetailDto.User.Email;
            DepartmentId = userForDetailDto.User.DepartmentId;
            DepartmentName = userForDetailDto.DepartmentName;
        }
    }
}
