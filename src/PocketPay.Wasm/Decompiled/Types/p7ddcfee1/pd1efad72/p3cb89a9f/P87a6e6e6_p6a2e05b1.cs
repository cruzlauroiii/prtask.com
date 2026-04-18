namespace WillowMaze.Wasm.Decompiled;

public class P87a6e6e6_p6a2e05b1 : P65e25ac1
{
    private readonly p87a6e6e6 This$0;

    public void ExitAndThrowIfTimedOut()
    {
        // call: p87a6e6e6$p6a2e05b1.newTimeoutException
        // call: p87a6e6e6$p6a2e05b1.exit
    }

    private IOException NewTimeoutException(IOException P0)
    {
        // str: "timeout"
        // call: SocketTimeoutException.initCause
        // call: SocketTimeoutException.<init>
        // type: SocketTimeoutException
        return default!;
    }

    private void TimedOut()
    {
        // call: p87a6e6e6.closeLater
        // call: p87a6e6e6.getConnection
        // call: p2d68e184.sendDegradedPingLater$okhttp
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6$p6a2e05b1.this$0
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.f2027c027
    }

}
