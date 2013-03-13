///////////////////////////////////////////////////////////////
// LicenceToBill - brought to you by Mose - 2012
///////////////////////////////////////////////////////////////
using LicenceToBill.Api.Tools;

namespace LicenceToBill.Api
{
    /// <summary>
    /// LicenceManager
    /// Uses JSON
    /// 
    /// Common tools
    /// </summary>
    public static partial class LicenceManager
    {
        #region Static constructor

        /// <summary>
        /// Static constructor, used for global configuration
        /// </summary>
        static LicenceManager()
        {
            // set the default content type for all further requests
            RequestFluent.SetDefaultContentType("application/json");
            // set the basic authentication
            RequestFluent.SetDefaultBasicAuthentication(LtbConstants.KeyBusiness, LtbConstants.KeyApi);
        }

        #endregion
    }
}