///////////////////////////////////////////////////////////////
// LicenceToBill - brought to you by Mose - 2012
///////////////////////////////////////////////////////////////
using System.Web;
using System.Web.Mvc;

namespace LicenceToBill.Web.DemoRest
{
    /// <summary>
    /// Base class for authentication attribute in the project
    /// </summary>
    public class AuthenticatedAttribute : FilterAttribute, IAuthorizationFilter
    {
        /// <summary>
        /// Check authorization
        /// </summary>
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            // get the identity
            var principal = CustomPrincipal.Current;
            // if not authenticated
            if(!principal.IsAuthenticated)
            {
                // redirect to login
                filterContext.Result = new RedirectResult("/Home/Login?returnUrl=" + HttpUtility.UrlEncode(filterContext.HttpContext.Request.RawUrl));
            }
        }
    }
}