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
