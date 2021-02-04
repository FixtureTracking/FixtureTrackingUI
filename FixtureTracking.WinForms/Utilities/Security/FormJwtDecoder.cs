using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;

namespace FixtureTracking.WinForms.Utilities.Security
{
    public class FormJwtDecoder
    {
        public static void DecodeNameIdendifier()
        {
            var handler = new JwtSecurityTokenHandler();
            var jwt = handler.ReadJwtToken(FormAccessToken.Token);
            var nameIdendifier = jwt.Claims.First(claim => claim.Type == ClaimTypes.NameIdentifier).Value;

            FormAccessToken.UserId = Guid.Parse(nameIdendifier);
        }
    }
}
