using PayPal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rice_Agency
{
    public class PayPalConfiguration
    {
        public readonly static string clientId;
        public readonly static string clientSecret;
        static PayPalConfiguration()
        {
            var config = getconfig();
            clientId = "Ab2YctKA0_Yr1BRTDHWHg3SBVr0QStWun_X08Q7gyBvcH5sEWoL2Nb2GbuHn-iiFuTt9CmnqiU1Q_uLF";
            clientSecret = "EOyC6TuYWciCSE-1D2mmTNg-ULs0i-SZs6SXo8Z0K5mxyKRdMWiTB6quUQTK-3sUNbnkr3nQdnAWIlkb";
        }
        private static Dictionary<string, string> getconfig()
        {
            return PayPal.Api.ConfigManager.Instance.GetProperties();
        }
        private static string GetAccessToken()
        {
            string accessToken = new OAuthTokenCredential(clientId, clientSecret, getconfig()).GetAccessToken();
            return accessToken;
        }
        public static APIContext GetAPIContext()
        {
            APIContext apicontext = new APIContext(GetAccessToken());
            apicontext.Config = getconfig();
            return apicontext;
        }
    }

}