
    // This is a sample of Rest API - POST Request by using HTTPClient library

using PostApiDemo;
using RestSharp;
using System;
using System.Text;
using System.Text.Json;

namespace SendPostRequest
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            var postData = new PostData
            {
                Name = "Sherlock Homes",
                Age  = 58,
                Address = "Backer Street"
            };


            HttpClient client = new ();
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");


            // Convert C# object to json
            var json = JsonSerializer.Serialize(postData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PostAsync("posts", content).Result;

            if(response.IsSuccessStatusCode)
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                var responseContent = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(responseContent);

                var postResponse = JsonSerializer.Deserialize<PostResponse>(responseContent, options);
                Console.WriteLine("Id "+postResponse.Id);

            }
            else
            {
                Console.WriteLine("Error: "+response.StatusCode);
            }



        }

    }
}

