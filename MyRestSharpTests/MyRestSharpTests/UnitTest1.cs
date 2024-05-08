using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
//using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;


namespace MyRestSharpTests
{
    [TestClass]
    public class RestSharpTest
    {
        [TestMethod]
        public void GET_Test()
        {
            RestClient client = new RestClient("https://jsonplaceholder.typicode.com/users");
            RestRequest request = new RestRequest("1", Method.Get);

            RestResponse response   =   client.Execute(request);

            Assert.IsNotNull(response);
            Assert.AreEqual(200, response.StatusCode);

        }
    }
}

