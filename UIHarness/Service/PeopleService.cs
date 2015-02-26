using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using UIHarness.Models;

namespace UIHarness.Service
{
    public class Method1PeopleService
    {
        string baseUri = "http://localhost:45624";
        public PeopleVM Method1GetPeopleV1()
        {
            PeopleVM people = new PeopleVM();
            try
            {
                using (var client = new HttpClient())
                {
                    string GetRequestUri = String.Format("{0}/api/people/", baseUri);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.meijer.cart.cart-v1.0+json"));
                    var result = client.GetAsync(GetRequestUri).Result;
                    if (result.IsSuccessStatusCode)
                    {
                        string resultContent = result.Content.ReadAsStringAsync().Result;
                        people = JsonConvert.DeserializeObject<PeopleVM>(resultContent);
                    }
                    else
                    {
                        throw new Exception(String.Format("Error Calling /api/people", result.ReasonPhrase));
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return people;
        }

        public PeopleVM2 Method1GetPeopleV2()
        {
            PeopleVM2 people = new PeopleVM2();
            try
            {
                using (var client = new HttpClient())
                {
                    string GetRequestUri = String.Format("{0}/api/people/", baseUri);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.meijer.cart.cart-v2.0+json"));
                    var result = client.GetAsync(GetRequestUri).Result;
                    if (result.IsSuccessStatusCode)
                    {
                        string resultContent = result.Content.ReadAsStringAsync().Result;
                        people = JsonConvert.DeserializeObject<PeopleVM2>(resultContent);
                    }
                    else
                    {
                        throw new Exception(String.Format("Error Calling /api/people", result.ReasonPhrase));
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return people;
        }
    }
}