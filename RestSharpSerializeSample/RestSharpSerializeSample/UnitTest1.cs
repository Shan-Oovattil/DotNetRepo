using Newtonsoft.Json;
using RestSharp;
using System.Security.Principal;

namespace RestSharpSerializeSample
{
    public class Tests
    {

    [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            RestClient client = new RestClient("http://api.zippopotam.us");
            RestRequest request = new RestRequest("us/12345", Method.Get);
            var response = client.Execute(request);

            //LocationResponse locationResponse = JsonConvert.DeserializeObject<LocationResponse>(response.ToString());

            string json = @"{
                              'Email': 'james@example.com',
                              'Active': true,
                              'CreatedDate': '2013-01-20T00:00:00Z',
                              'Roles': [
                                'User',
                                'Admin'
                              ]
                            }";

            Account account = JsonConvert.DeserializeObject<Account>(json);

            Console.WriteLine(account.Email);


        }

        
    }
}