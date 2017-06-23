using System.Collections.Generic;

namespace LoadRunner.VTSClientDotnet.JSON
{
    class RotateRequestData
    {
        public IEnumerable<string> columns { get; set; }
        public SendRow option { get; set; }


    }
}
