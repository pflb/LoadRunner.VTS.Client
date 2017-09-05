using System.Collections.Generic;

namespace LoadRunner.VTSClientDotnet.JSON
{
    class RotateRequest : AbstractRequest<RotateRequestData>
    {
        public RotateRequest(IEnumerable<string> columns = null, SendRow option = SendRow.Stacked)
        {
            cmd = "rotate";
            data = new RotateRequestData();
            data.columns = columns;
            data.option = option;
        }
    }
}
