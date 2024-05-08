using RestSharp;
using System.Net;
using static System.Net.WebRequestMethods;

namespace RestSharpSample
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            string url = "https://jsonplaceholder.typicode.com/users";
        }

        [Test]
        public void Test1()
        {
            RestClient client = new RestClient("https://jsonplaceholder.typicode.com/users");
            RestRequest request = new RestRequest("1", Method.Get);
            RestResponse response = client.Execute(request);
            Assert.IsNotNull(response);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}