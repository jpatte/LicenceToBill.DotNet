///////////////////////////////////////////////////////////////
// LicenceToBill - brought to you by Mose - 2012
///////////////////////////////////////////////////////////////
using System.Threading;
using System.Security.Principal;

namespace LicenceToBill.Web.DemoRest
{
    /// <summary>
    /// Custom principal
    /// </summary>
    public class CustomPrincipal : IPrincipal
    {
        #region Static

        /// <summary>
        /// Current principal
        /// 
        /// never null
        /// </summary>
        public static CustomPrincipal Current
        {
            get
            {
                // return setted principal, or the empty one
                return ((Thread.CurrentPrincipal as CustomPrincipal)
                        ?? Empty);
            }
        }
        /// <summary>
        /// Empty principal
        /// </summary>
        public static readonly CustomPrincipal Empty = new CustomPrincipal(null, null);

        #endregion

        #region Construction

        /// <summary>
        /// Construction
        /// </summary>
        public CustomPrincipal(string keyUser, string nameUser)
        {
            this.KeyUser = keyUser;
            this.NameUser = nameUser;

            this.NestedIdentity = new CustomIdentity(nameUser);
        }

        #endregion

        #region Public properties

        /// <summary>
        /// User Key
        /// </summary>
        public string KeyUser { get; private set; }
        /// <summary>
        /// User Name
        /// </summary>
        public string NameUser { get; private set; }
        /// <summary>
        /// User Name
        /// </summary>
        protected CustomIdentity NestedIdentity { get; private set; }
        /// <summary>
        /// True if user is authenticated
        /// </summary>
        public bool IsAuthenticated
        {
            get { return !string.IsNullOrEmpty(this.NameUser); }
        }

        #endregion

        #region IPrincipal Members

        /// <summary>
        /// Mandatory
        /// </summary>
        public IIdentity Identity
        {
            get { return this.NestedIdentity; }
        }
        /// <summary>
        /// Mandatory
        /// </summary>
        public bool IsInRole(string role)
        {
            return false;
        }

        #endregion

        #region CustomIdentity definition

        /// <summary>
        /// Custom identity
        /// </summary>
        public class CustomIdentity : IIdentity
        {
            #region Construction

            /// <summary>
            /// Empty constructor (meaning no identity)
            /// </summary>
            public CustomIdentity()
            {
            }
            /// <summary>
            /// Construction
            /// </summary>
            public CustomIdentity(string nameUser)
            {
                this.Name = nameUser;
            }

            #endregion

            #region IIdentity Members

            /// <summary>
            /// Mandatory
            /// </summary>
            public string AuthenticationType
            {
                get { return "Forms"; }
            }
            /// <summary>
            /// Mandatory
            /// </summary>
            public bool IsAuthenticated
            {
                get { return !string.IsNullOrEmpty(this.Name); }
            }

            public string Name { get; private set; }

            #endregion
        }

        #endregion
    }
}