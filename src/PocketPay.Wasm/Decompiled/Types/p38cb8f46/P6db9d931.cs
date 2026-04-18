namespace WillowMaze.Wasm.Decompiled;

public class P6db9d931 : P65e25ac1
{
    private readonly Socket F334c21e7;
    private readonly Socket F61f25293;
    private readonly Socket Fa181b34f;

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
        // str: "Failed to close timed out socket "
        // call: Logger.log
        // call: StringBuilder.<init>
        // call: p0af9afa4.m87df3e77
        // call: p84e09430.m27f3fc40
        // call: StringBuilder.append
        // call: Socket.close
        // call: StringBuilder.toString
        // field: java.util.logging.Level.WARNING
        // field: p38cb8f46.p6db9d931.f61f25293
        // type: StringBuilder
    }

}
