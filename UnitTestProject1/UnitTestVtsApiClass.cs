using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoadRunner.VTSClientDotnet;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestVtsApiClass
    {
        VtsApiClass VTS { get; set; }

        [TestInitialize]
        public void init()
        {
            VTS = new VtsApiClass();
            VTS.connect("localhost", 8888, ConnectionOptions.None);
        }

        [TestMethod]
        public void VTS_rotate_messages()
        {
            string column1 = "timeStamp";
            string column2 = "elapsed";
            List<string> columns = new List<string>();
            columns.Add(column1);
            columns.Add(column2);

            Dictionary<string, string> data = VTS.rotate_messages(columns, SendRow.Stacked);

            Assert.AreNotEqual(data[column1], data[column2]);
        }
    }
}
