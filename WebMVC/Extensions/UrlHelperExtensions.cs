using Microsoft.AspNetCore.Mvc;
using WebMVC.Controllers;

namespace WebMVC.Extensions
{
    public static class UrlHelperExtensions
    {
        public static string EmailConfirmationLink<T>(this IUrlHelper urlHelper, T userId, string code, string scheme)
        {
            return urlHelper.Action(
                action: nameof(AccountController.ConfirmEmail),
                controller: "Account",
                values: new { userId, code },
                protocol: scheme);
        }

        public static string ResetPasswordCallbackLink<T>(this IUrlHelper urlHelper, T userId, string code, string scheme)
        {
            return urlHelper.Action(
                action: nameof(AccountController.ResetPassword),
                controller: "Account",
                values: new { userId, code },
                protocol: scheme);
        }
    }
}
