///////////////////////////////////////////////////////////////
// LicenceToBill - brought to you by Mose - 2012
///////////////////////////////////////////////////////////////
using System.Linq;
using System.Collections.Generic;

using LicenceToBill.Api;

namespace LicenceToBill.Web.DemoRest
{
    /// <summary>
    /// Manages data per user (faking a databae)
    /// </summary>
    public class DataManager
    {
        #region Initialization

        /// <summary>
        /// Initialization
        /// </summary>
        static DataManager()
        {
            ///////////////////// 1 - GETTING LOCALIZED TEXTS /////////////////////

            // let's get the features's list
            var features = LicenceManager.ListFeatures();

            // look for feature 1
            var feature1 = features
                               .Where(f => f.KeyFeature.ToLower() == Constants.KeyFeature1.ToLower())
                               .FirstOrDefault();

            // if found
            if(feature1 != null)
            {
                TitleFeature1 = feature1.TitleLocalized;
                DescriptionFeature1 = feature1.DescriptionLocalized;
            }
            else
            {
                TitleFeature1 = "[Error]";
                DescriptionFeature1 = "[Error]";
            }

            // look for feature 2
            var feature2 = features
                               .Where(f => f.KeyFeature.ToLower() == Constants.KeyFeature2.ToLower())
                               .FirstOrDefault();

            // if found
            if(feature2 != null)
            {
                TitleFeature2 = feature2.TitleLocalized;
                DescriptionFeature2 = feature2.DescriptionLocalized;
            }
            else
            {
                TitleFeature2 = "[Error]";
                DescriptionFeature2 = "[Error]";
            }

            ///////////////////// 2 - FAKING DATA /////////////////////

            // let's add default volume for the feature that uses volume
            _FeatureCurrentPerUser = new Dictionary<string, int>();
            _FeatureCurrentPerUser.Add("124", 9);
            _FeatureCurrentPerUser.Add("125", 35);
        }

        #endregion

        #region Private - Inner data

        /// <summary>
        /// Cached features per user
        /// </summary>
        private static Dictionary<string, int> _FeatureCurrentPerUser = null;
        /// <summary>
        /// Feature 1 name
        /// </summary>
        public static readonly string TitleFeature1;
        /// <summary>
        /// Feature 1 description
        /// </summary>
        public static readonly string DescriptionFeature1;
        /// <summary>
        /// Feature 2 name
        /// </summary>
        public static readonly string TitleFeature2;
        /// <summary>
        /// Feature 2 description
        /// </summary>
        public static readonly string DescriptionFeature2;

        #endregion

        #region Public - Volumes per user

        /// <summary>
        /// Cached features per user
        /// </summary>
        public static int GetVolumeFeature(string keyUser)
        {
            // get the value
            int result;
            if(!_FeatureCurrentPerUser.TryGetValue(keyUser, out result))
            {
                // if not found, set to 0
                result = 0;
            }
            return result;
        }
        /// <summary>
        /// Cached features per user
        /// </summary>
        public static void IncreaseVolumeFeature(string keyUser)
        {
            // get the value
            int volume;
            // if not found
            if(!_FeatureCurrentPerUser.TryGetValue(keyUser, out volume))
            {
                // set to 0;
                volume = 0;
            }

            // increase
            volume++;
            // store
            _FeatureCurrentPerUser[keyUser] = volume;
        }

        #endregion
    }
}