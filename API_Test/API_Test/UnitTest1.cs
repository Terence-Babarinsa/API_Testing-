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
            HttpResponseMessage response = await client.GetAsync("https://open.er-api.com/v6/latest/USD");

            Assert.IsTrue(response.IsSuccessStatusCode);
            //Assert.That(response.Content ,Is.Not.Null);

        }

        [TearDown]
        public void Cleanup()
        {
            client.Dispose();
        }
    }
}
