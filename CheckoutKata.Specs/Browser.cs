using System;
using System.IO;
using System.Net;
using NUnit.Framework;

namespace CheckoutKata.Specs
{
    public class Browser
    {
        public static HttpWebResponse Get(string basketUrl)
        {
            var webRequest = WebRequest.Create(basketUrl);
            return (HttpWebResponse)webRequest.GetResponse();
        }

        public static HttpWebResponse Post(Uri url)
        {
            var webRequest = WebRequest.Create(url);
            webRequest.ContentLength = 0;
            webRequest.Method = WebRequestMethods.Http.Post;
            return (HttpWebResponse)webRequest.GetResponse();
        }

        public static string ReadResponseStream(HttpWebResponse webResponse)
        {
            var responseStream = webResponse.GetResponseStream();
            Assert.IsNotNull(responseStream);
            var streamReader = new StreamReader(responseStream);
            return streamReader.ReadToEnd();
        }
    }
}