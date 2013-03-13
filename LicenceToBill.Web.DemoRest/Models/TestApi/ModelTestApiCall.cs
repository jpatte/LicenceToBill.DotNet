using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LicenceToBill.Web.DemoRest
{
    /// <summary>
    /// Model for page 'test api call'
    /// </summary>
    public class ModelTestApiCall
    {
        /// <summary>
        /// Call allowed methods
        /// Used to restrict available buttons on the page
        /// </summary>
        public List<HttpVerbs> Methods { get; set; }
        /// <summary>
        /// Ressource base url
        /// Used only for display purpose
        /// </summary>
        public string UrlRessource { get; set; }

        /// <summary>
        /// User keys
        /// </summary>
        public List<Tuple<string, string>> KeyUsers { get; set; }
        /// <summary>
        /// Feature keys
        /// </summary>
        public List<Tuple<string, string>> KeyFeatures { get; set; }
        /// <summary>
        /// Offer keys
        /// </summary>
        public List<Tuple<string, string>> KeyOffers { get; set; }

        /// <summary>
        /// Languages
        /// </summary>
        public List<Tuple<string, int>> Lcids { get; set; }

        /// <summary>
        /// Pagination : page
        /// </summary>
        public int? Page { get; set; }
        /// <summary>
        /// Pagination : page size
        /// </summary>
        public int? SizePage { get; set; }
    }
}