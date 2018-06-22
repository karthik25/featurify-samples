using Featurify.Contracts;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Security.Claims;

namespace AspNetIdentityWithFeaturify.Infrastructure
{
    public class IdentityUserInfoStrategy : IUserInfoStrategy
    {
        private readonly IHttpContextAccessor accessor;

        public IdentityUserInfoStrategy(IHttpContextAccessor accessor)
        {
            this.accessor = accessor;
        }

        public async Task<string> GetCurrentUserId()
        {
            var claims = accessor.HttpContext.User.Claims.ToList();
            var claim = claims.Single(c => c.Type == ClaimTypes.Name);
            await Task.CompletedTask;
            return claim.Value;
        }
    }
}
