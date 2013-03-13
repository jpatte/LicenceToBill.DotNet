namespace LicenceToBill.Web.DemoRest
{
    public class ApiEnableTrial : ApiCall
    {
        /// <summary>
        /// True if enabling succeeded
        /// </summary>
        public bool? Succeeded { get; set; }
        /// <summary>
        /// Offer key
        /// </summary>
        public string KeyOffer  { get; set; }
    }
}