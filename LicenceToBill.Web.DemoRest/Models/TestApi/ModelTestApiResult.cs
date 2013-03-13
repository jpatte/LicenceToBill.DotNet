using System.Collections.Generic;
using System.Net;

using LicenceToBill.Api;

namespace LicenceToBill.Web.DemoRest
{
    /// <summary>
    /// Generic result of an API call
    /// </summary>
    public class ModelTestApiResult
    {
        /// <summary>
        /// Returned status code
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }
        /// <summary>
        /// API call message
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// API call elapsed time
        /// </summary>
        public long? ElapsedMilliseconds { get; set; }
        /// <summary>
        /// Response body as a string
        /// </summary>
        public string ResponseBody { get; set; }

        /// <summary>
        /// If the result is a single user
        /// </summary>
        public UserV2 User {get;set;}

        /// <summary>
        /// If the result is a list of users
        /// </summary>
        public List<UserV2> Users {get;set;}

        /// <summary>
        /// If the result is a single feature
        /// </summary>
        public FeatureV2 Feature {get;set;}

        /// <summary>
        /// If the result is a list of features
        /// </summary>
        public List<FeatureV2> Features {get;set;}

        /// <summary>
        /// If the result is a list of offers
        /// </summary>
        public List<OfferV2> Offers {get;set;}

        /// <summary>
        /// If the result is a list of deals
        /// </summary>
        public List<DealV2> Deals {get;set;}
    }
}