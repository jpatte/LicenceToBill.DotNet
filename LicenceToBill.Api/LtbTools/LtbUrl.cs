///////////////////////////////////////////////////////////////
// LicenceToBill - brought to you by Mose - 2012
///////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;

namespace LicenceToBill.Api.Tools
{
    /// <summary>
    /// Build an url
    /// </summary>
    public static class LtbUrl
    {
        #region Public

        /// <summary>
        /// Build an url
        /// </summary>
        public static string Build(LtbResource resource, params object[] arguments)
        {
            // get he url pattern for that resource
            var result = GetUrlPattern(resource);
            // if any
            if(!string.IsNullOrEmpty(result))
            {
                // format the arguments
                try
                {
                    result = string.Format(result, arguments);
                }
                catch (Exception exc)
                {
                    throw new FormatException("Wrong arguments used to build url for LicenceToBill resource '{0}'", exc);
                }

                // combine to create an absolute url
                result = new Uri(new Uri(LtbConstants.UrlApi), new Uri(result, UriKind.Relative)).ToString();
            }
            return result;
        }
        /// <summary>
        /// Build an url
        /// </summary>
        public static string TryBuild(out string messageError, LtbResource resource, params object[] arguments)
        {
            messageError = null;

            // get the url pattern for that resource
            string result = GetUrlPattern(resource);
            // if any
            if(!string.IsNullOrEmpty(result))
            {
                try
                {
                    // format the arguments
                    result = string.Format(result, arguments);
                }
                catch(Exception exc)
                {
                    // error 
                    messageError = exc.ToString();
                }

                // combine to create an absolute url
                result = new Uri(new Uri(LtbConstants.UrlApi), new Uri(result, UriKind.Relative)).ToString();
            }
            // if no url
            else
                // error
                messageError = "Could not resolve URL pattern for resource " + resource;

            return result;
        }

        #endregion

        #region Inner tools - Url Pattern

        /// <summary>
        /// Cache the resolution of url pattern by resource
        /// </summary>
        private static Dictionary<LtbResource, string> _UrlByRessource = new Dictionary<LtbResource, string>();

        /// <summary>
        /// Get the relative url
        /// </summary>
        public static string GetUrlPattern(LtbResource resource, params object[] arguments)
        {
            // try to to get the url from the cache
            string urlPattern;
            if(!_UrlByRessource.TryGetValue(resource, out urlPattern))
            {
                // if not found, get the attribute
                var ltbAttribute =
                    typeof (LtbResource)
                        .GetMember(resource.ToString())[0]
                        .GetCustomAttributes(typeof (LtbUrlAttribute), false)
                        .Cast<LtbUrlAttribute>()
                        .SingleOrDefault();

                // get the url pattern
                urlPattern = ltbAttribute.UrlPattern;
                // cache it
                _UrlByRessource[resource] = urlPattern;
            }
            return urlPattern;
        }

        #endregion
    }
}