using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadRunner.VTSClientDotnet.JSON
{
    class RotateRequest : AbstractRequest<RotateRequestData>
    {
        public RotateRequest(List<string> columns = null, SendRow option = SendRow.Stacked)
        {
            cmd = "rotate";
            data = new RotateRequestData();
            data.columns = columns;
            data.option = option;
        }
    }
}
