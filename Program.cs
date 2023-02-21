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
using System.Security.Cryptography;

namespace svchost
{

    class Program
    {
        //import the message box functionality
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);

        static void Main(string[] args)
        {
            //display the Message Box
            MessageBox(new IntPtr(0), "New pwn, who dis?", "This box is kinda shady but prolly ok", 0);
            try
            {
                //This is a little loop that calls the FSutil and just checks some symlinks. 
                //It doesn't do much, but it does fork a process and is worth exploring
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
                //This belwo prints out the link - it checks to see if symlinks are enabled.
                process.Start();

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

            //This starts Chrome and launches a YouTube page - specifically, Bob Ross saying
            //We don't have mistakes - just happy little accidents"
            
            Process.Start("chrome.exe", "https://youtu.be/wCsO56kWwTc?t=13");


            //just print a silly little string to have something to do
            string s = "50m3th1n@Ph1$hy";
            foreach (char c in s)
            {
                Console.WriteLine(c);
            };



            //Copy calc.exe from system32 dir and add it to local. 
            try
            {
                // Find the temp directory, copy calc.exe to it
                var dest = System.IO.Path.GetTempPath();
                File.Copy(@"C:\\Windows\\System32\\calc.exe", dest + "\\calc.exe");              
            }
            
            catch (Exception f)
            {
                //Console.WriteLine(f.Message);
            }

            try
            {
                var dest = System.IO.Path.GetTempPath();
              
                //starting calc from the temp directory, not C:\windows\system32 directory
                Process.Start(dest + "\\calc.exe");
            }
            catch (Exception g)
            {
               // Console.WriteLine(g.Message);
            }

            try
            {
                Console.WriteLine("Checking for updates....");
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
            }

            catch (Exception h)
            {
                // Console.WriteLine(h.Message);
            }

            try
            {
                //Reach out to this domain and enumerate the IPs it resolves to
                var name = "xkcd.com";
                IPHostEntry host = Dns.GetHostEntry(name);
                var addresses = host.AddressList;



                //print out the IP's from the domain resolution
                Console.WriteLine("The domain in question resolves to ");
                foreach (var address in addresses)
                {
                    Console.WriteLine($"{address}");
                }
            }

            catch (Exception i)
            {
                // Console.WriteLine(i.Message);
            }

        }

    }
}