using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Web.Mvc;
using LicenceToBill.Api;


namespace LicenceToBill.Web.DemoRest
{
    [Authenticated]
    public class DemoController : Controller
    {
        #region Pages

        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Action : 
        /// </summary>
        /// <returns></returns>
        public ActionResult Feature1()
        {
            return this.View("Feature", this.CheckLimitations(Constants.KeyFeature1));
        }

        public ActionResult Feature2()
        {
            // check the rights on that feature
            var model = this.CheckLimitations(Constants.KeyFeature2);

            // get user's key
            var keyuser = CustomPrincipal.Current.KeyUser;

            // if unlimited is allowed
            if(!model.Limitation.HasValue)
            {
                // increase the volume
                DataManager.IncreaseVolumeFeature(keyuser);
            }
            // if limited
            else
            {
                // if more than 0 is allowed
                if(model.Limitation.Value > 0)
                {
                    // get current volume
                    var volume = DataManager.GetVolumeFeature(keyuser);

                    // if quota not exceeded
                    if(model.Limitation.Value > volume)
                        // increase the volume
                        DataManager.IncreaseVolumeFeature(keyuser);
                    else
                        // trigger the appropriate message
                        model.Exceeded = true;
                }
            }

            return this.View("Feature", model);
        }

        public ActionResult PaymentCancel()
        {
            return this.View();
        }
        public ActionResult PaymentFailure()
        {
            return this.View();
        }
        public ActionResult PaymentSuccess()
        {
            return this.View();
        }
        public ActionResult CreditCardRegistered()
        {
            return this.View();
        }
        public ActionResult CreditCardUpated()
        {
            return this.View();
        }
        public ActionResult CreditCardUpdatedPartial()
        {
            return this.View();
        }

        #endregion

        #region Inner logic

        /// <summary>
        /// Check limitations for current user to given feature
        /// </summary>
        private DemoCheckLimitation CheckLimitations(string keyFeature)
        {
            // get the model
            var result = new DemoCheckLimitation();

            // get the limitations for that feature
            var feature = LicenceManager.GetLimitation(keyFeature, CustomPrincipal.Current.KeyUser);

            // push data into the model
            result.Limitation = feature.Limitation;
            result.NameFeature = feature.TitleLocalized;
            result.UrlChooseOffer = feature.UrlForChooseOffer;

            return result;
        }

        #endregion
    }
}
