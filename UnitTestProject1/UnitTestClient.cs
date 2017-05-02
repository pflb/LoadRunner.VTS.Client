using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoadRunner.VTSClientDotnet;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestClient
    {
        Client client;

        [TestInitialize]
        public void init()
        {
            client = new Client(new Uri("http://localhost:10000/api"));
        }

        [TestMethod]
        public void ClientHandshake()
        {
            string version = client.handshake();
            Assert.AreEqual(version, "1.1");
        }

        [TestMethod]
        public void ClientRotate()
        {
            string column1 = "NPM5.Name.Ru";
            string column2 = "NPM5.Name.En";
            List<string> columns = new List<string>();
            columns.Add(column1);
            columns.Add(column2);

            Dictionary<string, string> data = client.rotate(columns);

            Assert.AreNotEqual(data[column1], data[column2]);
        }
    }
}
