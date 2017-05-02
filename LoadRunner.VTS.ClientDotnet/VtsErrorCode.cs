namespace LoadRunner.VTSClientDotnet
{
    public enum VtsErrorCode
    {
        ClientRequestError = -11254,
        ColFormatError = -10108,
        ColValueNoMatch = -10109,
        DataNotExist = -10111,
        EvalString = -10110,
        FailedToConnect = -10003,
        FailedtoCreateSocket = -10002,
        FailedToRecvResponse = -10101,
        FailedToResolveAddr = -10001,
        HandleNotExist = -10105,
        IncompleteRequest = -10100,
        IncompleteResponse = -10102,
        InnerJsonConvert = -10106,
        InnerUtf8Convert = -10107,
        InvalidApiCall = -10004,
        InvalidArgument = -10104,
        InvalidConnectionInfo = -10000,
        OK = 0,
        OperationErrorBase = -11000,
        ResponseArgsUnmatch = -10103,
        ServerIsBusy = -11255
    }
}
