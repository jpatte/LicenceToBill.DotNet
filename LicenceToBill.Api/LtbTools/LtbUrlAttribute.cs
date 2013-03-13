///////////////////////////////////////////////////////////////
// LicenceToBill - brought to you by Mose - 2012
///////////////////////////////////////////////////////////////
using System;

namespace LicenceToBill.Api.Tools
{
    /// <summary>
    /// Attribute for LtbResource enum
    /// Used to specify the Url pattern
    /// </summary>
    public class LtbUrlAttribute : Attribute
    {
        #region Constructors

        /// <summary>
        /// Base constructor
        /// </summary>
        public LtbUrlAttribute( string urlPattern )
        {
            this.UrlPattern = urlPattern;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Url pattern
        /// </summary>
        public string UrlPattern { get; set; }

        #endregion
    }
}
