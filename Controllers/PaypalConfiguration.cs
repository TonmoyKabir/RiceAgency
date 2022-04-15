using System;
using PayPal.Api;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rice_Agency.Controllers
{
    internal class PaypalConfiguration
    {
        public readonly static string clientId;
        public readonly static string clientSecret;

                static PaypalConfiguration()
        {
            var config = getconfig();
            clientId = "AWErk9hUMcJHBk0dAgOTG1n8wlnG2b_HZJd1IJLQTlWjLBZHWxZ3Mw9hzqtG4ET6VZA_BuuSBnfM-lEk";
            clientSecret = "EAhT3IqIGlUIY9YIyEYjaDvjRqoYCzbyso1XfNuF7V2cA2TkVgSMgw1HBt21zAqtCAHGWKlmhb3aLEuV";
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