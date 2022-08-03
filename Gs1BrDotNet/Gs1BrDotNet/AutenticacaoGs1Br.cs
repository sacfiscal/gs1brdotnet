using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gs1Br
{
    public class AutenticacaoGs1Br
    {
        public AutenticacaoGs1Br(Gs1brConfig configGs1br)
        {
            config = configGs1br;
        }

        public Gs1brConfig config { get; }

        public RetornoLogin Autenticar()
        {
            //var gs1brConfig = Gs1brConfig.InstanciaConfig;

            var client = new RestClient("https://api.gs1br.org/oauth/");
            client.Authenticator = new HttpBasicAuthenticator(config.ClientId, config.SecretId);

            RestRequest request = new RestRequest("access-token", Method.Post);

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("client_id", config.ClientId);

            var body = new { grant_type = "password", username = config.Username, password = config.Password };

            request.AddParameter("application/json", body, ParameterType.RequestBody);
            RestResponse response = client.Execute(request);
            if(response.StatusCode != System.Net.HttpStatusCode.Created && response.StatusCode != System.Net.HttpStatusCode.OK)
                throw new Exception(response.ErrorMessage);

            string json = response.Content;

            RetornoLogin retornoLogin = JsonConvert.DeserializeObject<RetornoLogin>(json);
            retornoLogin.clientId = config.ClientId;
            return retornoLogin;
        }
    }


    public class RetornoLogin
    {
        public RetornoLogin()
        {
            created = DateTime.Now;
        }

        public bool Expired()
        {
            DateTime expires = created.AddMilliseconds(expires_in);
            return expires > DateTime.Now;
        }

        public string clientId { get; set; }
        public string access_token { get; set; }
        public string refresh_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
        private DateTime created { get; set; }
    }    
}

