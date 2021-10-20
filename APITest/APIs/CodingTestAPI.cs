using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIs.APITest
{
    public class CodingTestAPI
    {
        private static string URL = "https://eacp.energyaustralia.com.au/codingtest/api/";

        private RestClient client;

        private RestRequest request;

        public enum Version
        {
            v1
        }

        public enum Path
        {
            festivals
        }

        public CodingTestAPI(Version version, Path path)
        {
            client = new RestClient($"{URL}{version}/{path}");
            request = new RestRequest();
        }

        public CodingTestAPI SetContentType(string type)
        {
            request.AddHeader("Content-Type", type);

            return this;
        }

        public IRestResponse SendGetRequest()
        {
            request.Method = Method.GET;

            return client.Execute(request);
        }
    }
}
