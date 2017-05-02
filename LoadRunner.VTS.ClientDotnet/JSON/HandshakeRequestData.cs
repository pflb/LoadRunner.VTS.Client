using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadRunner.VTSClientDotnet.JSON
{
    class HandshakeRequestData
    {
        public HandshakeRequestData()
        {
            version = "1.3";
        }
        public string version { get; set; }
    }
}
