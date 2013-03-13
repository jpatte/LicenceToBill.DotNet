using LicenceToBill.Api;

namespace LicenceToBill.Web.DemoRest
{
    public class ApiListFeatures : ApiCall
    {
        public FeatureV2[] Features { get; set; }
    }
}