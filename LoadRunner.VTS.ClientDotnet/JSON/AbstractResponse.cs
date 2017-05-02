using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadRunner.VTSClientDotnet.JSON
{
    class AbstractResponse<T>
    {
        public T data { get; set; }
        public Status status { get; set; }
    }
}
