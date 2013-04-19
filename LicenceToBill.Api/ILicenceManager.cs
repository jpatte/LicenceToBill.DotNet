using System.Collections.Generic;

namespace LicenceToBill.Api
{
    public interface ILicenceManager
    {
        // Users
        List<UserV2> ListUsers();
        UserV2 GetUser(string keyUser);
        UserV2 PostUser(string keyUser, string nameUser, int? lcid = null);
        List<FeatureV2> PostTrial(string keyOffer, string keyUser, string nameUser, int? lcid = null);

        // Features
        List<UserV2> ListUsersByFeature(string keyFeature);
        List<FeatureV2> ListFeatures(int? lcid = null);
        List<FeatureV2> ListFeaturesByUser(string keyUser);
        FeatureV2 GetLimitation(string keyFeature, string keyUser);

        // Offers
        List<OfferV2> ListOffers(int? lcid = null);
        List<OfferV2> ListOffersByUser(string keyUser);
        
        // Deals
        List<DealV2> ListDealsByUser(string keyUser);

        // For mockup purposes only
        DealV2 ActivateDeal(string keyUser, string keyOffer, bool andTerminatePreviousDeals = true);
        void TerminateDeal(string keyUser, string keyDeal);
    }
}