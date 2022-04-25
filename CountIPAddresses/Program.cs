﻿using System;
using System.Net;

namespace CountIPAddresses
{
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

