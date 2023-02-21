using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace scvhost
{

    class Program
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);

        static void Main(string[] args)
        {
            MessageBox(new IntPtr(0), "New pwn, who dis?", "This box is kinda shady but prolly ok", 0);
            try
            {
                var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "C:\\Windows\\System32\\fsutil.exe",
                        Arguments = "behavior query SymlinkEvaluation",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true
                    }
                };

                process.Start();
                Process.Start("chrome.exe", "https://youtu.be/wCsO56kWwTc?t=13");



                while (!process.StandardOutput.EndOfStream)
                {
                    var line = process.StandardOutput.ReadLine();
                    Console.WriteLine(line);
                }

                process.WaitForExit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //just print a silly little string to have something to do
            string s = "50m3th1n@Ph1$hy";
            foreach (char c in s)
            {
                Console.WriteLine(c);
            };

            // Find the temp directory, copy calc.exe to it
            var dest = System.IO.Path.GetTempPath();
            File.Copy(@"C:\\Windows\\System32\\calc.exe", dest + "\\calc.exe");

            //concat the whole temp dir and include calc.exe
            string myTempCalc = Path.Combine(System.IO.Path.GetTempPath(), "calc.exe");
            Process.Start(dest + "\\calc.exe");

            //Build  URI to reach out to and grab response 
            var uriBuilder = new UriBuilder();
            uriBuilder.Scheme = "https";
            uriBuilder.Host = "medicinaldevices.com";
            uriBuilder.Path = "/updates";


            Uri uri = uriBuilder.Uri;

            //Send request and get response
            WebRequest request = WebRequest.Create(uri);
            WebResponse response = request.GetResponse();


            var headers = response.Headers;
            Console.WriteLine(headers);

            //Reach out to this domain and enumerate the IPs it resolves to
            var name = "xkcd.com";
            IPHostEntry host = Dns.GetHostEntry(name);
            var addresses = host.AddressList;

            //print out the IP's from the domain resolution
            foreach (var address in addresses)
            {
                Console.WriteLine($"{address}");
            }

            

        }

    }
}