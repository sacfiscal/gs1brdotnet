using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gs1Br
{
    public class ConsultaGtin
    {
        public RetornoConsultaGtinGs1Br ConsultarGtin(string gtin, RetornoLogin login)
        {
            var client = new RestClient("https://api.gs1br.org/gs1/v2/");

            RestRequest request = new RestRequest($"products/{gtin}", Method.Get);

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("client_id", login.clientId);
            request.AddHeader("access_token", login.access_token);

            request.AddParameter("application/json", ParameterType.RequestBody);
            RestResponse response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.Created && response.StatusCode != System.Net.HttpStatusCode.OK)
                throw new Exception($"Erro: {response.StatusCode} - {response.ErrorMessage}");

            string json = response.Content;
            RetornoConsultaGtinGs1Br retornoConsulta = JsonConvert.DeserializeObject<RetornoConsultaGtinGs1Br>(json);
            return retornoConsulta;

        }
    }
}
