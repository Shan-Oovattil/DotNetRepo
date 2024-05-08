
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure;
using RestSharp;
using RestSharpApi_Sample1;
using static Microsoft.Graph.Constants;

namespace RestSharpAPISample
{
    public class Program
    {
        static void Main(string[] args) 
        {
            // This is GET request
            RequestGET();

            // This is POST request
            RequestPOST();
        }

        public static void RequestGET()
        {
            string url = "https://jsonplaceholder.typicode.com/posts/1";

            var client = new RestClient(url);

            var request = new RestRequest();

            var json = client.Get(request);

            Console.WriteLine("GET REQUEST");

            Console.WriteLine("Status Code=" + json.StatusCode.ToString());

            Console.WriteLine("Response:" + json.Content.ToString());

            Console.Read();
        }

        public static void RequestPOST()
        {
            string url = "https://jsonplaceholder.typicode.com/posts";

            var client = new RestClient(url);

            var request = new RestRequest();

            // Create a body object
            var body = new PostModel
            {
                title = "test post request",
                body ="This is the test body",  
                userId=44
            };

            // convert model class (object) into json and send it ( Serialization)
            request.AddJsonBody(body);

            // Create Response
            var response = client.Post(request);

            Console.WriteLine("POST REQUEST");
            Console.WriteLine("Status Code=" + response.StatusCode.ToString());
            Console.WriteLine("Response:" + response.Content.ToString());

            Console.Read();
        }

    }
}
