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
            AppDomain.CurrentDomain.SetData(
                "APP_CONFIG_FILE"
                , Assembly.GetExecutingAssembly().Location + ".config"
                );
            vts.connect("localhost", 10000, LoadRunner.ConnectionOptions.KeepAlive);


            return 0;
        }
    }
}

