using MelissaData.CloudAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelissaCloudAPINuGet.APIResponse
{
    public class TokenServerResponse : ResponseBase
    {
        public string Result { get; set; }
        public string Token { get; set; }

        // Setters
        public void SetResult(string result)
        {
            this.Result = result;
        }

        public void SetToken(string token)
        {
            this.Token = token;
        }

        // Getters
        public string GetResult() 
        {
            return string.IsNullOrEmpty(this.Result) ? "" : this.Result;
        }

        public string GetToken()
        {
            return string.IsNullOrEmpty(this.Token) ? "" : this.Token;
        }
    }
}
