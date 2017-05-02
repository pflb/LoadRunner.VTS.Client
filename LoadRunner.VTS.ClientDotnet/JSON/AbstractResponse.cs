namespace LoadRunner.VTSClientDotnet.JSON
{
    class AbstractResponse<T>
    {
        public T data { get; set; }
        public Status status { get; set; }
    }
}
