using System;
using System.Collections.Generic;
using System.Linq;

namespace LicenceToBill.Api
{
    public class OptimisticLicenceManager : ILicenceManager
    {
        public List<UserV2> ListUsers()
        {
            return LicenceManager.ListUsers();
        }

        public UserV2 GetUser(string keyUser)
        {
            try
            {
                return LicenceManager.GetUser(keyUser);
            }
            catch(Exception)
            {
                return null;
            }
        }

        public UserV2 PostUser(string keyUser, string nameUser, int? lcid = null)
        {
            return LicenceManager.PostUser(keyUser, nameUser, lcid);
        }

        public List<UserV2> ListUsersByFeature(string keyFeature)
        {
            return LicenceManager.ListUsersByFeature(keyFeature);
        }

        public List<FeatureV2> ListFeatures(int? lcid = null)
        {
            return LicenceManager.ListFeatures(lcid);
        }

        public List<FeatureV2> ListFeaturesByUser(string keyUser)
        {
            return LicenceManager.ListFeaturesByUser(keyUser);
        }

        public FeatureV2 GetLimitation(string keyFeature, string keyUser)
        {
            return LicenceManager.GetLimitation(keyFeature, keyUser);
        }

        public List<OfferV2> ListOffers(int? lcid = null)
        {
            return LicenceManager.ListOffers(lcid);
        }

        public List<OfferV2> ListOffersByUser(string keyUser)
        {
            return LicenceManager.ListOffersByUser(keyUser);
        }

        public List<DealV2> ListDealsByUser(string keyUser)
        {
            return LicenceManager.ListDealsByUser(keyUser);
        }

        public List<FeatureV2> PostTrial(string keyOffer, string keyUser, string nameUser, int? lcid = null)
        {
            return LicenceManager.PostTrial(keyOffer, keyUser, nameUser, lcid);
        }

        public DealV2 ActivateDeal(string keyUser, string keyOffer, bool andTerminatePreviousDeals = true)
        {
            throw new NotSupportedException();
        }

        public void TerminateDeal(string keyUser, string keyDeal)
        {
            throw new NotSupportedException();
        }
    }
}