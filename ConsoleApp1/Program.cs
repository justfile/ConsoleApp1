using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //CallInternetBrowser(args);

            //Chapter6.NewMethod();
            //Chapter6.NewMethod1();
            //Chapter6.NewMethod2();

            Chapter6.Chapter6_Main();

            Console.Read();
        }


        private static void CallInternetBrowser(string[] args)
        {
            string query = string.Empty;
            if (args.Length > 0)
            {
                OpenBrowser("https://www.google.co.kr/search?q=" + args[0]);
            }
            else
            {
                //System.Diagnostics.Process.Start("https://www.google.co.kr/search?q=test");
                OpenBrowser("https://www.google.co.kr/search?q=test");
            }
        }


        public static void OpenBrowser(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }
    }
}
