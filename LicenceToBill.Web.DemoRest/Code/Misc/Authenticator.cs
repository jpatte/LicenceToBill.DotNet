///////////////////////////////////////////////////////////////
// LicenceToBill - brought to you by Mose - 2012
///////////////////////////////////////////////////////////////
using System.Web;
using System.Web.Security;
using System.Threading;
using System.Collections.Generic;

namespace LicenceToBill.Web.DemoRest
{
    /// <summary>
    /// Manages authentication
    /// </summary>
    public class Authenticator
    {
        #region Identities

        /// <summary>
        /// Static constructor
        /// </summary>
        static Authenticator()
        {
            // create teh global dictionary
            Identities = new Dictionary<string, string>();

            // fill it
            Identities.Add("alfred@monreseaupro.com", "123");
            Identities.Add("beatrice@monreseaupro.com", "124");
            Identities.Add("charles@monreseaupro.com", "125");
            Identities.Add("dorothy@monreseaupro.com", "126");
            Identities.Add("eric@monreseaupro.com", "127");
            Identities.Add("florient@monreseaupro.com", "128");
            Identities.Add("gaius@monreseaupro.com", "129");
            Identities.Add("henry@monreseaupro.com", "130");
            Identities.Add("igor@monreseaupro.com", "131");
            Identities.Add("jean@monreseaupro.com", "132");
            Identities.Add("karl@monreseaupro.com", "133");
        }
        /// <summary>
        /// Identities cache
        /// </summary>
        public static readonly Dictionary<string, string> Identities;

        #endregion

        #region Authentication

        /// <summary>
        /// Autehnticate given request
        /// </summary>
        public static bool CheckAuthentication(HttpRequest request)
        {
            bool result = false;

            // Get the ASP.NET authentication cookie
            var cookie = request.Cookies[FormsAuthentication.FormsCookieName];

            // Check wether the cookie was found
            if (cookie != null)
            {
                // decrypt the cookie
                var ticket = FormsAuthentication.Decrypt(cookie.Value);
                // if not expired
                if (!ticket.Expired)
                {
                    // if we got anything in the ticket
                    if (!string.IsNullOrEmpty(ticket.Name))
                    {
                        // if valid
                        string keyUser;
                        if (Identities.TryGetValue(ticket.Name, out keyUser))
                        {
                            // create a principal
                            var principal = new CustomPrincipal(keyUser, ticket.Name);

                            // set working principal into the working thread
                            Thread.CurrentPrincipal = principal;

                            // success
                            result = true;
                        }
                    }

                    // if authentication failed
                    if (!result)
                    {
                        // clear the ticket
                        FormsAuthentication.SignOut();
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// Authenticate given request
        /// </summary>
        public static bool Authenticate(string login)
        {
            bool result = false;

            // if we got anything in the ticket
            if (!string.IsNullOrEmpty(login))
            {
                // if valid
                string keyUser;
                if (Identities.TryGetValue(login, out keyUser))
                {
                    // create a principal
                    var principal = new CustomPrincipal(keyUser, login);

                    // set working principal into the working thread
                    Thread.CurrentPrincipal = principal;

                    // set the cookie
                    FormsAuthentication.SetAuthCookie(login, true);

                    // success
                    result = true;
                }
            }

            // if authentication failed
            if (!result)
            {
                // clear the ticket
                FormsAuthentication.SignOut();
            }
            return result;
        }
        /// <summary>
        /// Sign out
        /// </summary>
        public static void SignOut()
        {
            // sign out
            FormsAuthentication.SignOut();
        }

        #endregion
    }
}