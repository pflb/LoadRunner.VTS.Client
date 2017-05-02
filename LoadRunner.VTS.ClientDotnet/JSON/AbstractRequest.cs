using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadRunner.VTSClientDotnet.JSON
{
    class AbstractRequest<T>
    {
        public string cmd { get; set; }
        public string version = "1.1";
        public T data { get; set; }
    }
}
