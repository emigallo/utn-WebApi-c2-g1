using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraWeb_G1.Connections
{
    public class RestConnection
    {
        private HttpClient _httpClient;
        private string UriBase;

        public RestConnection(string uriBase)
        {
            this.UriBase = uriBase;
            this._httpClient = new HttpClient();
        }

        public async Task<T> GetAsync<T>(string partialUri)
        {
            // baseUri: http://localhost:5500
            // partialUri: calc

            string uri = this.GetUri(partialUri);
            HttpResponseMessage response = await this._httpClient.GetAsync(uri);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception("Ocurrió un error al hacer el llamado a la API");
            }

            string json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(json);
        }

        public async Task<T> PostAsync<T, U>(string partialUri, U item)
        {
            string uri = this.GetUri(partialUri);
            string bodyContent = JsonConvert.SerializeObject(item);
            HttpContent content = new StringContent(bodyContent, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await this._httpClient.PostAsync(uri, content);
            string json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(json);
        }

        private string GetUri(string partialUri)
        {
            return string.Format("{0}/{1}", this.UriBase, partialUri);
        }
    }
}
