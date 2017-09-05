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

        /// <summary>
        /// Get selected column
        /// </summary>
        [TestMethod]
        public void VTS_rotate_messages()
        {
            string[] columns = {"CNUM", "SurName", "Name", "MiddleName", "BirthDay", "City" };

            Dictionary<string, string> user = VTS.rotate_messages(columns, SendRow.Stacked);

            Assert.AreNotEqual(user["SurName"], user["Name"]);
        }

        /// <summary>
        /// Get all columns - get row
        /// </summary>
        [TestMethod]
        public void VTS_rotate_messages_empty_columns()
        {
            
            string[] columns = { };

            Dictionary<string, string> user = VTS.rotate_messages(columns, SendRow.Stacked);

            Assert.AreNotEqual(user["SurName"], user["Name"]);
        }
    }
}
