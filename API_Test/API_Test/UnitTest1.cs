using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using System.Net.Http;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace API_Test
{
    [TestClass]
    public class APITest
    {

        private HttpClient client;

        [TestInitialize]
        public void Setup()
        {
            HttpClient client = new HttpClient();
        }

        [TestMethod]
        public async void NewsAPI()
        {
            //HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://newsapi.org/v2/everything?q=apple&from=2023-11-21&to=2023-11-21&sortBy=popularity&apiKey=API_KEY");

            Assert.IsTrue(response.IsSuccessStatusCode);

        }

        [TearDown]
        public void Cleanup()
        {
            client.Dispose();
        }
    }
}
