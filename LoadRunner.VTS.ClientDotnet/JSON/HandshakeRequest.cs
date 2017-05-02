using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadRunner.VTSClientDotnet.JSON
{
    class HandshakeRequest : AbstractRequest<HandshakeRequestData>
    {
        public HandshakeRequest()
        {
            cmd = "handshake";
            data = new HandshakeRequestData();
        }
    }
}
