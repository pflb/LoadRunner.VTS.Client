using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoadRunner.VTSClientDotnet;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Client client = new Client(new Uri("http://localhost:8888/api"));
            client.handshake();
        }
    }
}
