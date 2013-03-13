///////////////////////////////////////////////////////////////
// LicenceToBill - brought to you by Mose - 2012
///////////////////////////////////////////////////////////////
using System.Configuration;

namespace LicenceToBill.Web.DemoRest
{
    /// <summary>
    /// Constants & appsettings accessors
    /// </summary>
    public class Constants
    {
        /// <summary>
        /// LicenceToBill URL
        /// </summary>
        public static readonly string UrlLicenceToBill = ConfigurationManager.AppSettings["LicenceToBillUrl"];
        /// <summary>
        /// LicenceToBill API URL
        /// </summary>
        public static readonly string UrlApi = ConfigurationManager.AppSettings["LicenceToBillUrlApi"];

        /// <summary>
        /// Demo business
        /// </summary>
        public static readonly string NameBusiness = "MonReseauPro";
        /// <summary>
        /// Demo business
        /// </summary>
        public static readonly string KeyBusiness = ConfigurationManager.AppSettings["LicenceToBillKeyBusiness"];

        /// <summary>
        /// Feature 1 key
        /// </summary>
        public static readonly string KeyFeature1 = ConfigurationManager.AppSettings["LicenceToBillKeyFeature1"];
        /// <summary>
        /// Feature 2 key
        /// </summary>
        public static readonly string KeyFeature2 = ConfigurationManager.AppSettings["LicenceToBillKeyFeature2"];
    }
}