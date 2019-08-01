using System;

namespace Netnr.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var hwr = Core.HttpTo.HWRequest("");

            System.Net.HttpWebResponse v1 = Core.HttpTo.UrlResponse(hwr);

            var v2 = v1;

            Console.WriteLine("Hello World!");
        }
    }
}
