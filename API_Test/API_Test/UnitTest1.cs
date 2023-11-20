using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using System.Net.Http;

namespace API_Test
{
    [TestClass]
    public class APITest
    {

        private HttpClient httpClient;
        [TestInitialize]
        public void Setup()
        {
            httpClient = new HttpClient();
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
