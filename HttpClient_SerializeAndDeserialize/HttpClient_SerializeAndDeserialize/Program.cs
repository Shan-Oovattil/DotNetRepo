
    /*
        This program uses various methods to Seralize and Deserialize Json and Object
        Methods/Library used are:
                1.  HttpClient
                2.  Newtonsoft Library
                3.  RestSharp
    */

using System;
using System.Text;
using System.Text.Json;
using RestSharp;
using System.Net;
using HttpClient_SerializeAndDeserialize;
using System.Text.Json.Nodes;
using Newtonsoft.Json.Linq;


namespace HttpOperations
{
    internal class SeralizeAndDeserializeBy_HttpClient_Newtonsoft_RestSharp
    {

       static void Main(string[] args)
        {
            SerializeDataUsingHttpClient();

            DeserializeDataUsingHttpClient();

            SerializeDataByNewtonSoft();

            DeserializeDataByRestSharp();
        }

        
        // Serialize Object into Json
        public static void SerializeDataUsingHttpClient()
        {
            TestData testData = new TestData();
            testData.Name = "TestName1";
            testData.Value = "TestValue1";
            testData.Id = 1;

            TestData testData2 = new TestData
            {
                Name = "TestName2",
                Value = "TestValue2",
                Id = 2
            };

            // The above can also written as below in asimplified manner
            TestData testData3 = new()
            {
                Name = "TestName3",
                Value = "TestValue3",
                Id = 3
            };

            var options = new JsonSerializerOptions();
            options.WriteIndented = true;
            options.PropertyNameCaseInsensitive = true;

            // Serialize this object into Json
            var jsonSerailizedData = JsonSerializer.Serialize(testData2, options);

            // Write the Json into a file in the project folder
            File.WriteAllText("TestData.json", jsonSerailizedData);
        }
        
        
        // Deserialize Json into Object
        public static void DeserializeDataUsingHttpClient()
        {
            if(!File.Exists("TestData.json"))
            {
                return;
            }
            
            var testDataJson = File.ReadAllText("TestData.json");

            // Deserialize the data from Json to Object
            TestData? testData = JsonSerializer.Deserialize<TestData>(testDataJson);

            Console.WriteLine(testData?.Name);
            Console.WriteLine(testData?.Value);
            Console.WriteLine(testData?.Id);

        }
        
        
        // Deserialize by using NewtonSoft Library
        public static void SerializeDataByNewtonSoft()
        {
            if (!File.Exists("TestData.json"))
            {
                return;
            }

            var testDataJson = File.ReadAllText("TestData.json");

            JObject obs = JObject.Parse(testDataJson);
            
            string? name = obs["Name"]?.ToString();
            string? value = obs["Value"]?.ToString();

            Console.WriteLine(name);
            Console.WriteLine(value);
        }
               

        //Deserialize by using RestSharp Library
        public static void DeserializeDataByRestSharp()
        {
            if (!File.Exists("TestData.json"))
            {
                return;
            }

            var testDataJson = File.ReadAllText("TestData.json");

            TestData? testData = JsonSerializer.Deserialize<TestData>(testDataJson);

            Console.WriteLine(testData?.Name);
            Console.WriteLine(testData?.Value);
            Console.WriteLine(testData?.Id);

        }


    }   

}