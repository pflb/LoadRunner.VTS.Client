//---------------------------------------------
//Script Title        :
//Script Description  :
//
//
//Recorder Version    : 
//---------------------------------------------
using System.Reflection;
using System;
using System.IO;

namespace Script
{
    public partial class VuserClass
    {
        public int vuser_init()
        {
            vts.connect("localhost", 10000, LoadRunner.ConnectionOptions.KeepAlive);

            return 0;
        }
    }
}

