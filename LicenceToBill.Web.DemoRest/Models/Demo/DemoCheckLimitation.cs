namespace LicenceToBill.Web.DemoRest
{
    /// <summary>
    /// Used when checking limitations
    /// </summary>
    public class DemoCheckLimitation
    {
        /// <summary>
        /// Name fo the feature
        /// </summary>
        public string NameFeature { get; set; }

        /// <summary>
        /// Allowance returned by the API
        /// </summary>
        public int? Limitation { get; set; }

        /// <summary>
        /// True if limitation exceeded
        /// </summary>
        public bool? Exceeded { get; set; }
        
        /// <summary>
        /// Url to choose an offer
        /// </summary>
        public string UrlChooseOffer { get; set; }
    }
}