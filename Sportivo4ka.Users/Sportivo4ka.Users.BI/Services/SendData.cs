using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Sportivo4ka.Users.BI.Interfaces;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Sportivo4ka.Users.General.Expansions;

namespace Sportivo4ka.Users.BI.Services
{
    public class DataSend : ISendData
    {
        public async Task Post(object data, string url, string token = null) => await Post<object>(data, url, token);

        public async Task<T> Post<T>(object data, string url, string token = null)
        {
            if (String.IsNullOrEmpty(url))
                throw new Exception("Ссылка недействительна!");

                var body = data.ToJson();
                HttpResponseMessage responseMessage = null;
                using (HttpClient httpClient = new HttpClient())
                {
                    StringContent httpConent = new StringContent(body, Encoding.UTF8, "application/json");

                    if (!String.IsNullOrEmpty(token))
                        httpClient.DefaultRequestHeaders.Add("Token", token);
                    responseMessage = await httpClient.PostAsync(url, httpConent);

                    var json = await responseMessage.Content.ReadAsStringAsync();

                    if (responseMessage.StatusCode != HttpStatusCode.OK && responseMessage.StatusCode != HttpStatusCode.Created)
                        throw new Exception("Код ответа не Ok!");

                    if (typeof(T) == typeof(object))
                        return default(T);

                    return json.ToObject<T>();
                }
        }

        public async Task<T> Get<T>(string url, string token = null)
        {
            if (String.IsNullOrEmpty(url))
                throw new Exception("Ссылка недействительна!");

            using (HttpClient httpClient = new HttpClient())
            {
                if (!String.IsNullOrEmpty(token))
                    httpClient.DefaultRequestHeaders.Add("Token", token);
                var response = await httpClient.GetAsync(url);
                var content = await response.Content.ReadAsStringAsync();

                return content.ToObject<T>();
            }
        }
    }
}