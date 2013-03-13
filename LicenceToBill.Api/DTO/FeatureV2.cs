///////////////////////////////////////////////////////////////
// LicenceToBill - brought to you by Mose - 2012
///////////////////////////////////////////////////////////////
using System;
using System.Runtime.Serialization;

namespace LicenceToBill.Api
{
    /// <summary>
    /// Feature
    /// </summary>
    [DataContract(Name="feature")]
    public class FeatureV2
    {
        /// <summary>
        /// Feature key
        /// </summary>
        [DataMember(IsRequired=true, Name="key_feature")]
        public string KeyFeature { get; set; }

        /// <summary>
        /// Feature visibility
        /// </summary>
        [DataMember(EmitDefaultValue=false, Name="is_visible")]
        public bool IsVisible { get; set; }

        /// <summary>
        /// Feature localized title
        /// </summary>
        [DataMember(EmitDefaultValue=false, Name="title")]
        public string TitleLocalized { get; set; }
        /// <summary>
        /// Feature localized description
        /// </summary>
        [DataMember(EmitDefaultValue=false, Name="description")]
        public string DescriptionLocalized { get; set; }

        /// <summary>
        /// Limitation for this feature
        /// </summary>
        [DataMember(EmitDefaultValue=false, Name="limitation")]
        public int? Limitation { get; set; }

        /// <summary>
        /// Start date of the working period
        /// </summary>
        [DataMember(EmitDefaultValue=false, Name="date_period_start")]
        public DateTime? DatePeriodStart { get; set; }
        /// <summary>
        /// End date of the working period
        /// </summary>
        [DataMember(EmitDefaultValue=false, Name="date_period_end")]
        public DateTime? DatePeriodEnd { get; set; }

        /// <summary>
        /// Url for the 'choose an offer' page
        /// </summary>
        [DataMember(Name="url_choose_offer", EmitDefaultValue=false)]
        public string UrlForChooseOffer { get; set; }
    }
}
