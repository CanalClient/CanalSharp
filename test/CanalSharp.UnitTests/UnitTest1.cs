using System;
using System.Net;
using CanalSharp.Client;
using CanalSharp.Client.Impl;
using CanalSharp.Common.Utils;
using Xunit;

namespace Canal4Net.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string destination = "example";
            ICanalConnector connector = CanalConnectors.NewSingleConnector("127.0.0.1", 11111, destination, "", "");
            connector.Connect();
            Console.Read();
        }
    }
}