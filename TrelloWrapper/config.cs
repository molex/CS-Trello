using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrelloWrapper
{
    
    public class Config
    {
        public static string AuthKey { get; set; }

        public static string ApiBaseUrl
        {
            get
            {
                return "https://api.trello.com/1";
            }
        }

        public static void Initialize(string authkey)
        {
            AuthKey = authkey;
        }
    }
}
