using System;
using System.Net;

namespace CountIPAddresses
{
    // Count IP Addresses
    //
    // https://www.codewars.com/kata/526989a41034285187000de4/train/csharp
    //

    // Implement a function that receives two IPv4 addresses, and returns the number of addresses between them (including the first one, excluding the last one).
    //
    // All inputs will be valid IPv4 addresses in the form of strings.The last address will always be greater than the first one.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountIPAddresses.IpsBetween("10.0.0.0", "10.0.0.50"));
            Console.WriteLine(CountIPAddresses.IpsBetween("20.0.0.10", "20.0.1.0"));
            Console.WriteLine(CountIPAddresses.IpsBetween("0.0.0.0", "255.255.255.255"));
        }
    }
    public static class CountIPAddresses
    {
        public static long IpsBetween(string start, string end)
        {
            return (long)(uint)IPAddress.NetworkToHostOrder((int)IPAddress.Parse(end).Address) - (long)(uint)IPAddress.NetworkToHostOrder((int)IPAddress.Parse(start).Address);
        }
    }
}

