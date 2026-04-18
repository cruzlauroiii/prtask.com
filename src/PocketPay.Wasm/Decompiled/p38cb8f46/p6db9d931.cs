namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\b\u0002\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0012\u0010\u0005\u001a\u00020\u00062\b\u0010\u0007\u001a\u0004\u0018\u00010\u0006H\u0014J\b\u0010\b\u001a\u00020\tH\u0014R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\n"}, d2 = {"Lp38cb8f46/p6db9d931;", "Lp38cb8f46/p65e25ac1;", "socket", "Ljava/net/Socket;", "(Ljava/net/Socket;)V", "newTimeoutException", "Ljava/io/IOException;", "cause", "timedOut", "", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class p6db9d931 : p38cb8f46.p65e25ac1 {
    private readonly java.net.Socket f334c21e7;
    private readonly java.net.Socket f61f25293;
    private readonly java.net.Socket fa181b34f;

    public p6db9d931(java.net.Socket socket) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(socket, "socket");
        this.f61f25293 = socket;
    }

    protected override java.io.IOException NewTimeoutException(java.io.IOException cause) {
        java.net.SocketTimeoutException socketTimeoutException = new java.net.SocketTimeoutException("timeout");
        if (cause is not null) {
            socketTimeoutException.initCause(cause);
        }
        return socketTimeoutException;
    }

    protected override void TimedOut() {
        if ((12 + 2) % 2 > 0) {
        }
        try {
            this.f61f25293.Dispose();
        } catch (java.lang.AssertionError e) {
            if (!p38cb8f46.p0af9afa4.m87df3e77(e)) {
                throw e;
            }
            p38cb8f46.p84e09430.m27f3fc40().log(java.util.logging.Level.WARNING, "Failed to close timed out socket " + this.f61f25293, (java.lang.Exception) e);
        } catch (java.lang.Exception e2) {
            p38cb8f46.p84e09430.m27f3fc40().log(java.util.logging.Level.WARNING, "Failed to close timed out socket " + this.f61f25293, (java.lang.Exception) e2);
        }
    }
}

