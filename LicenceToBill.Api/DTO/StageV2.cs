///////////////////////////////////////////////////////////////
// LicenceToBill - brought to you by Mose - 2012
///////////////////////////////////////////////////////////////
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LicenceToBill.Api
{
    /// <summary>
    /// Offer or deal stage
    /// </summary>
    [DataContract(Name="stage")]
    public class StageV2
    {
        /// <summary>
        /// Duration of this stage
        /// </summary>
        [DataMember(EmitDefaultValue=false, Name="duration")]
        public int Duration { get; set; }

        /// <summary>
        /// Unit of the duration of this stage (month, year, etc.)
        /// </summary>
        [DataMember(EmitDefaultValue=false, Name="unit_duration")]
        public string UnitDuration { get; set; }
        /// <summary>
        /// Number of recurrence of this stage, null for infinite
        /// </summary>
        [DataMember(EmitDefaultValue=false, Name="count_recurrences")]
        public int? CountRecurrences { get; set; }
        /// <summary>
        /// Price for this stage
        /// </summary>
        [DataMember(EmitDefaultValue=false, Name="amount")]
        public int Amount { get; set; }
        
        /// <summary>
        /// Features in this stage
        /// </summary>
        [DataMember(EmitDefaultValue=false, Name="features")]
        public List<FeatureV2> Features { get; set; }
    }
}
