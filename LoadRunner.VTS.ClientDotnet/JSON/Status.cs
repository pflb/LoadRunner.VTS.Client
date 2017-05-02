using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadRunner.VTSClientDotnet.JSON
{
    class Status
    {
        public string error { get; set; }
        public VtsErrorCode code { get; set; }
    }
}
