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
            string[] columns = {"CNUM", "SurName", "Name", "MiddleName", "BirthDay", "City" };

            Dictionary<string, string> user = VTS.rotate_messages(columns, SendRow.Stacked);

            Assert.AreNotEqual(user["SurName"], user["Name"]);
        }
    }
}
