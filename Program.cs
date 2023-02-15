using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;



namespace scvhost
{
    class Program
    {



              static void Main(string[] args)
        {
            string s = "50m3th1n@Ph1$hy";
            foreach (char c in s)
            {
                Console.WriteLine((int)c);
            };


            var uriBuilder = new UriBuilder();
            uriBuilder.Scheme = "http";
            uriBuilder.Host = "wikipedia.com";
            uriBuilder.Path = "/";


            Uri uri = uriBuilder.Uri;


            WebRequest request = WebRequest.Create(uri);
            WebResponse response = request.GetResponse();


            var headers = response.Headers;
            Console.WriteLine(headers);


            var name = "dispareo.com";
            IPHostEntry host = Dns.GetHostEntry(name);
            var addresses = host.AddressList;


            foreach (var address in addresses)
            {
                Console.WriteLine($"{address}");
            }
        }




    }
}