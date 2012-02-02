using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;

namespace TrelloWrapper
{
    public class TrelloAPI
    {
        
        public T GetRequest<T>(string path, params string[] args) where T: new()
        {
            if (string.IsNullOrEmpty(Config.AuthKey))
                throw new InvalidOperationException("WAT...there's no key???- Well go get one @" +  "https://trello.com/1/appKey/generate");
                                                   
            RestClient  client  = new RestClient (Config.ApiBaseUrl);
            RestRequest request = new RestRequest(BuildUrl(path, args));

            return client.Execute<T>(request).Data;
        }

        public string GetRequest(string path, params string[] args)
        {
            if (string.IsNullOrEmpty(Config.AuthKey))
                    throw new InvalidOperationException("WAT...there's no key???- Well go get one @" +  "https://trello.com/1/appKey/generate");

            RestClient  client  = new RestClient (Config.ApiBaseUrl);
            RestRequest request = new RestRequest(BuildUrl(path, args));

            return client.Execute(request).Content;
        }

        public string BuildUrl(string path, params string[] args)
        {
            path = string.Format(path, args);
            return string.Format("{0}?key={1}", path, Config.AuthKey);
        }
    }
         /*
         * Need to create variables to contain API key and the secret so that the user can be authenticated
         */
    
}
