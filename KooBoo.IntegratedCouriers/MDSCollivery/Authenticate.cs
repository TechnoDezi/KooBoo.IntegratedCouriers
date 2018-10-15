using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooBoo.IntegratedCouriers.MDSCollivery
{
    public class AuthenticateRequest
    {
        /// <summary>
        /// Email address used to login
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// Password for the Email address username.
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// Previously Authenticated token. Store it and use it in every function call. If the token hasn't expired, it will increase its lifetime to an hour and return the same token again. 
        /// Creating too many tokens could be a security risk, so always send back the previously used token! 
        /// </summary>
        public string old_token { get; set; }

        /// <summary>
        /// (optional) This array can contain any information about your application. This information helps us better our services by understanding its usage. We highly recommend adding name and version to help with debugging later. 
        /// </summary>
        public AuthenticateRequestInfo info { get; set; }
    }

    public class AuthenticateRequestInfo
    {
        /// <summary>
        /// (recommended) Name of your application to be identified by.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// (recommended) Current Version of your application. eg 2.5.43
        /// </summary>
        public string version { get; set; }

        /// <summary>
        /// (optional) If your application runs on top of another application, eg "Magento 1.8.0.0", "Joomla 1.5.16", "Wordpress 3.6 - WooCommerce 2.0.20"
        /// </summary>
        public string host { get; set; }

        /// <summary>
        /// (optional) Main programming language(s) used and their version. eg "PHP 5.4.9", "Ruby 1.9.3"
        /// </summary>
        public string lang { get; set; }

        /// <summary>
        /// (optional) Your Reseller ID (If you have one)
        /// </summary>
        public int reseller_id { get; set; }
    }

    public class AuthenticateResponse:ColliveryResponseBase
    {
        /// <summary>
        /// Your client ID
        /// </summary>
        public int client_id { get; set; }

        /// <summary>
        /// Current user ID
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// Current user email address.
        /// </summary>
        public string user_email { get; set; }

        /// <summary>
        /// Client Default Address ID
        /// </summary>
        public int default_address_id { get; set; }

        /// <summary>
        /// Session Information
        /// </summary>
        public string session { get; set; }

        /// <summary>
        /// Obtained after authenticating. Store it and use it in every function call. Tokens expire after 1 hour of inactivity. 
        /// </summary>
        public string token { get; set; }
    }
}
