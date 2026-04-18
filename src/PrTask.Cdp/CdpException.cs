namespace PrTask.Cdp;

#pragma warning disable SA1600
public class CdpException : Exception
{
    public CdpException()
    {
    }

    public CdpException(string Message)
        : base(Message)
    {
    }

    public CdpException(string Message, Exception InnerException)
        : base(Message, InnerException)
    {
    }
}

public class CdpConnectionException : CdpException
{
    public CdpConnectionException()
    {
    }

    public CdpConnectionException(string Message)
        : base(Message)
    {
    }

    public CdpConnectionException(string Message, Exception InnerException)
        : base(Message, InnerException)
    {
    }
}

public class CdpTimeoutException : CdpException
{
    public CdpTimeoutException()
    {
    }

    public CdpTimeoutException(string Message)
        : base(Message)
    {
    }

    public CdpTimeoutException(string Message, Exception InnerException)
        : base(Message, InnerException)
    {
    }
}

public class CdpProtocolException : CdpException
{
    public int Code { get; }
    public string? Data { get; }

    public CdpProtocolException()
    {
    }

    public CdpProtocolException(string Message)
        : base(Message)
    {
    }

    public CdpProtocolException(string Message, Exception InnerException)
        : base(Message, InnerException)
    {
    }

    public CdpProtocolException(int Code, string Message, string? Data = null)
        : base(Message)
    {
        this.Code = Code;
        this.Data = Data;
    }
}
#pragma warning restore SA1600
