using System;
using System.IdentityModel.Tokens;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EastFive.Security.LoginProvider
{
    public interface IProvideLogin
    {
        Task<TResult> ValidateToken<TResult>(string idToken,
            Func<SecurityToken, ClaimsPrincipal, TResult> onSuccess,
            Func<string, TResult> onFailed);

        Task<TResult> CreateLoginAsync<TResult>(Guid loginId,
            string userId, bool isEmail, string secret, bool forceChange,
            Func<Guid, TResult> onSuccess,
            Func<string, TResult> onFail);
    }
}
