using APIs.APITest;
using APITest.Models;
using APITest.Verifiers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;
using System;
using System.Net;
using Xunit;

namespace Tests.APITest
{
    public class FestivalsOutputTests
    {
        private CodingTestAPI api;

        private FestivalsVerifier verifier = new FestivalsVerifier();

        public FestivalsOutputTests()
        {
            api = new CodingTestAPI(CodingTestAPI.Version.v1, CodingTestAPI.Path.festivals)
                    .SetContentType("text/plain");
        }

        [Fact]
        public void OutputTest()
        {
            var response = api.SendGetRequest();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.True(!string.IsNullOrEmpty(response.Content));
            Assert.True(SchemaVerifier.IsValidFestivals(response.Content));

            var festivals = JsonConvert.DeserializeObject<Festival[]>(response.Content);
            verifier.Verify(festivals);
        }
    }
}
