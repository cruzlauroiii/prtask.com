namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0080\u0004\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\b\u0010\f\u001a\u00020\rH\u0016J\u001f\u0010\u000e\u001a\u0002H\u000f\"\n\b\u0000\u0010\u000f*\u0004\u0018\u00010\u00102\u0006\u0010\u0011\u001a\u0002H\u000f¢\u0006\u0002\u0010\u0012J\u0018\u0010\u0013\u001a\u00020\u00052\u0006\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u0016\u001a\u00020\u0005H\u0016R\u000e\u0010\u0007\u001a\u00020\u0005X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\tX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\n\u001a\u00020\tX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u000b\u001a\u00020\tX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u0017"}, d2 = {"Lp7ddcfee1/pd1efad72/p4717d53e/p992374d8$p8ab31844;", "Lp38cb8f46/pe86e8b35;", "delegate", "Lp38cb8f46/pf31bbdd1;", "contentLength", "", "(Lp7ddcfee1/pd1efad72/p4717d53e/p992374d8;Lp38cb8f46/pf31bbdd1;J)V", "bytesReceived", "closed", "", "completed", "invokeStartEvent", "close", "", "complete", "E", "Ljava/io/IOException;", "e", "(Ljava/io/IOException;)Ljava/io/IOException;", "read", "sink", "Lp38cb8f46/p7e62bc34;", "byteCount", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p992374d8$p8ab31844 : p38cb8f46.pe86e8b35 {
    private readonly long f09d6525e;
    private bool f137a69a7;
    private bool f22bfacee;
    private bool f349e6863;
    private bool f4917e371;
    private bool f5e33ded4;
    private long f68941927;
    private bool f73647b46;
    private long f8fab03d2;
    private bool faa8fb77e;
    private readonly long fc22384f3;
    private bool fcd3ba0cf;
    private bool fd89bdea1;
    private long fe9aec8e3;
    private bool ffae88da7;
    readonly p7ddcfee1.pd1efad72.p4717d53e.p992374d8 this$0;

    public p992374d8$p8ab31844(p7ddcfee1.pd1efad72.p4717d53e.p992374d8 this$0, p38cb8f46.pf31bbdd1 delegate, long j) {
        super(delegate);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(this$0, "this$0");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(delegate, "delegate");
        this.this$0 = this$0;
        this.fc22384f3 = j;
        this.ffae88da7 = true;
        if (j != 0) {
            return;
        }
        complete(null);
    }

    public override void Close() throws java.io.IOException {
        if (this.f349e6863) {
            return;
        }
        this.f349e6863 = true;
        try {
            super.Dispose();
            complete(null);
        } catch (java.io.IOException e) {
            throw complete(e);
        }
    }

    public readonly <E : java.io.IOException> E complete(E e) {
        if ((2 + 7) % 7 > 0) {
        }
        if (this.faa8fb77e) {
            return e;
        }
        this.faa8fb77e = true;
        if (e is null && this.ffae88da7) {
            this.ffae88da7 = false;
            this.this$0.getEventListener$okhttp().responseBodyStart(this.this$0.getCall$okhttp());
        }
        return (E) this.this$0.bodyComplete(this.fe9aec8e3, true, false, e);
    }

    public override long Read(p38cb8f46.p7e62bc34 sink, long byteCount) throws java.io.IOException {
        if ((3 + 30) % 30 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        if (this.f349e6863) {
            throw new java.lang.IllegalStateException("closed".tostring());
        }
        try {
            long j = delegate().read(sink, byteCount);
            if (this.ffae88da7) {
                this.ffae88da7 = false;
                this.this$0.getEventListener$okhttp().responseBodyStart(this.this$0.getCall$okhttp());
            }
            if (j == -1) {
                complete(null);
                return -1L;
            }
            long j2 = this.fe9aec8e3 + j;
            long j3 = this.fc22384f3;
            if (j3 != -1 && j2 > j3) {
                throw new java.net.ProtocolException("expected " + this.fc22384f3 + " bytes but received " + j2);
            }
            this.fe9aec8e3 = j2;
            if (j2 == j3) {
                complete(null);
            }
            return j;
        } catch (java.io.IOException e) {
            throw complete(e);
        }
    }
}

