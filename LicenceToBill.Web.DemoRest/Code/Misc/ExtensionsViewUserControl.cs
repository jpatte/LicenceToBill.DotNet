///////////////////////////////////////////////////////////////
// LicenceToBill - brought to you by Mose - 2012
///////////////////////////////////////////////////////////////
using System.Web.Mvc;

namespace LicenceToBill.Web.DemoRest 
{
    /// <summary>
    /// Extend ViewUserControl
    /// </summary>
    public static class ExtensionsViewUserControl
    {
        /// <summary>
        /// Format code
        /// </summary>
        public static string FormatCode(this ViewUserControl control, string code)
        {
            return
                code.Replace("'", "\\'")
                    .Replace("&", "&amp;")
                    .Replace("<", "&lt;")
                    .Replace(">", "&gt;")
                    .Replace("\r\n", "<br/>");
        }
    }
}