using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;

namespace HW15
{
    public class Corona
    {
        public static void Cor(string x)
        {
            var c = new RestClient(x);
            var r = new RestRequest();
            r.Method = Method.GET;
            r.AddHeader("Accept", "application/json");
        }
    }
}
