///////////////////////////////////////////////////////////////
// LicenceToBill - brought to you by Mose - 2012
///////////////////////////////////////////////////////////////

namespace LicenceToBill.Api.Tools
{
    /// <summary>
    /// Ressources exposed by LicenceToBill API
    /// </summary>
    public enum LtbResource
    {
        /// <summary>
        /// Users list
        /// GET
        /// </summary>
        [LtbUrl("/v2/users")]
        Users,

        /// <summary>
        /// Single User
        /// GET, POST
        /// {0} : KeyUser
        /// </summary>
        [LtbUrl("/v2/users/{0}")]
        UserByKey,

        /// <summary>
        /// Users having access to given feature
        /// GET
        /// {0} : KeyFeature
        /// </summary>
        [LtbUrl("/v2/users/features/{0}")]
        UsersByFeature,

        /// <summary>
        /// Features list, localized
        /// GET
        /// {0} : lcid
        /// </summary>
        [LtbUrl("/v2/features/{0}")]
        FeaturesByLcid,

        /// <summary>
        /// Features accessible to given user
        /// GET
        /// {0} : KeyUser
        /// </summary>
        [LtbUrl("/v2/features/users/{0}")]
        FeaturesByUser,

        /// <summary>
        /// Limitation for given feature and given user
        /// GET
        /// {0} : KeyUser
        /// {1} : KeyFeature
        /// </summary>
        [LtbUrl("/v2/features/{1}/users/{0}")]
        LimitationByUserByFeature,

        /// <summary>
        /// Offers list, localized
        /// GET
        /// {0} : lcid
        /// </summary>
        [LtbUrl("/v2/offers/{0}")]
        OffersByLcid,

        /// <summary>
        /// Offers localized in given user's language (contains user-specific Urls)
        /// GET
        /// {0} : KeyUser
        /// </summary>
        [LtbUrl("/v2/offers/users/{0}")]
        OffersByUser,

        /// <summary>
        /// Deals concluded by given user
        /// GET
        /// {0} : KeyUser
        /// </summary>
        [LtbUrl("/v2/deals/users/{0}")]
        DealsByUser,

        /// <summary>
        /// 3-in-1 operation : insertion of a user, free deal creation + returns the limitations for that user
        /// POST
        /// {0} : KeyUser
        /// </summary>
        [LtbUrl("/v2/trial/{0}")]
        Trial
    }
}