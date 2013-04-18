using System.Collections.Generic;

namespace LicenceToBill.Api
{
    public interface ILicenceManager
    {
        List<UserV2> ListUsers();
        UserV2 GetUser(string keyUser);
        UserV2 PostUser(string keyUser, string nameUser, int? lcid = null);

        List<UserV2> ListUsersByFeature(string keyFeature);
        List<FeatureV2> ListFeatures(int? lcid = null);
        List<FeatureV2> ListFeaturesByUser(string keyUser);
        FeatureV2 GetLimitation(string keyFeature, string keyUser);

        List<OfferV2> ListOffers(int? lcid = null);
        List<OfferV2> ListOffersByUser(string keyUser);
        
        List<DealV2> ListDealsByUser(string keyUser);
        
        List<FeatureV2> PostTrial(string keyOffer, string keyUser, string nameUser, int? lcid = null);

        void ActivateOffer(string keyUser, string keyOffer);
        void TerminateOffer(string keyUser, string keyOffer);
    }
}