using LicenceToBill.Api;

namespace LicenceToBill.Web.DemoRest
{
    public class ApiListUsers : ApiCall
    {
        public UserV2[] Users { get; set; }
    }
}