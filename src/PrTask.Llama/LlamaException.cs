namespace PrTask.Llama;

public sealed class LlamaException : Exception
{
    public LlamaException()
    {
    }

    public LlamaException(string Message)
        : base(Message)
    {
    }

    public LlamaException(string Message, Exception InnerException)
        : base(Message, InnerException)
    {
    }
}
