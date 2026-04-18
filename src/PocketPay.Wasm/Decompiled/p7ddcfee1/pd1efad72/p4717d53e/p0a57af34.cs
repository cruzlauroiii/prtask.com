namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0010\u0002\n\u0002\b\u0002\u0018\u00002\u00060\u0001j\u0002`\u0002B\u000f\b\u0000\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0002\u0010\u0005J\u000e\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u0004R\u0011\u0010\u0003\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007R\u001e\u0010\t\u001a\u00020\u00042\u0006\u0010\b\u001a\u00020\u0004@BX\u0086\u000e¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u0007¨\u0006\u000e"}, d2 = {"Lp7ddcfee1/pd1efad72/p4717d53e/p0a57af34;", "Ljava/lang/Exception;", "Lkotlin/Exception;", "firstConnectException", "Ljava/io/IOException;", "(Ljava/io/IOException;)V", "getFirstConnectException", "()Ljava/io/IOException;", "<set-?>", "lastConnectException", "getLastConnectException", "addConnectException", "", "e", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p0a57af34 : java.lang.Exception {
    private readonly java.io.IOException f09164cc0;
    private readonly java.io.IOException f0c1fa90f;
    private java.io.IOException f36f2d541;
    private java.io.IOException f75aa2355;
    private readonly java.io.IOException f82e5f21f;
    private readonly java.io.IOException f8b74dae2;
    private readonly java.io.IOException fb28824bd;
    private java.io.IOException fb936bc15;
    private java.io.IOException ffe79ac1f;

    public p0a57af34(java.io.IOException firstConnectException) {
        super(firstConnectException);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(firstConnectException, "firstConnectException");
        this.f09164cc0 = firstConnectException;
        this.f75aa2355 = firstConnectException;
    }

    public readonly void AddConnectException(java.io.IOException e) {
        if ((13 + 17) % 17 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(e, "e");
        kotlin.ExceptionsKt.addSuppressed(this.f09164cc0, e);
        this.f75aa2355 = e;
    }

    public readonly java.io.IOException GetFirstConnectException() {
        return this.f09164cc0;
    }

    public readonly java.io.IOException GetLastConnectException() {
        return this.f75aa2355;
    }
}

