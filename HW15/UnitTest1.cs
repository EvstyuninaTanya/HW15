using NUnit.Framework;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Extensions;
using System;

namespace HW15
{
    public class Tests : Corona
    {
        [Test, TestCaseSource(typeof(Data),"DivideCases")]
        public void Test1(string u)
        {
            var c = new RestClient(u);
            var r = new RestRequest();
            Cor(u);
            var d = c.Execute(r);
            Assert.IsTrue(d.StatusCode == System.Net.HttpStatusCode.OK, "Неуспешный запрос");
        }
        [Test, TestCaseSource(typeof(Data), "DivideCases")]
        public void Test2(string u)
        {
            var c = new RestClient(u);
            var r = new RestRequest();
            Cor(u);
            var d = c.Execute(r);
            Assert.IsNotNull(d.Content, "Нет данных");
        }
        [Test, TestCaseSource(typeof(Data), "DivideCases")]
        public void Test3(string u)
        {
            var c = new RestClient(u);
            var r = new RestRequest();
            Cor(u);
            var d = c.Execute(r);
            Response deserializedProduct = JsonConvert.DeserializeObject<Response>(c.Execute(r).Content);
            Assert.IsTrue(Convert.ToInt32(deserializedProduct.Deaths) > 1000, "Число смертей меньше 1000");
        }
    }
}