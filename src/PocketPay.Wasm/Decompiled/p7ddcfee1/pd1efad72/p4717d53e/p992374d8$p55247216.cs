namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0082\u0004\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\b\u0010\u000b\u001a\u00020\fH\u0016J!\u0010\r\u001a\u0002H\u000e\"\n\b\u0000\u0010\u000e*\u0004\u0018\u00010\u000f2\u0006\u0010\u0010\u001a\u0002H\u000eH\u0002¢\u0006\u0002\u0010\u0011J\b\u0010\u0012\u001a\u00020\fH\u0016J\u0018\u0010\u0013\u001a\u00020\f2\u0006\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u0016\u001a\u00020\u0005H\u0016R\u000e\u0010\u0007\u001a\u00020\u0005X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\tX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\n\u001a\u00020\tX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0017"}, d2 = {"Lp7ddcfee1/pd1efad72/p4717d53e/p992374d8$p55247216;", "Lp38cb8f46/p9d679bdd;", "delegate", "Lp38cb8f46/p1eb558b5;", "contentLength", "", "(Lp7ddcfee1/pd1efad72/p4717d53e/p992374d8;Lp38cb8f46/p1eb558b5;J)V", "bytesReceived", "closed", "", "completed", "close", "", "complete", "E", "Ljava/io/IOException;", "e", "(Ljava/io/IOException;)Ljava/io/IOException;", "flush", "write", "source", "Lp38cb8f46/p7e62bc34;", "byteCount", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
readonly class p992374d8$p55247216 : p38cb8f46.p9d679bdd {
    private bool f21c4bb07;
    private long f30006844;
    private bool f349e6863;
    private readonly long f3cb08169;
    private bool f50f9ce74;
    private readonly long f74dc7ae9;
    private long f7cb149a3;
    private bool f7d97798d;
    private bool f8fb3622e;
    private bool fa7a5c093;
    private bool faa8fb77e;
    private bool fba67e1d2;
    private bool fbb4f994e;
    private readonly long fc22384f3;
    private readonly long fd54c7270;
    private long fe9aec8e3;
    private long ffdfb9320;
    readonly p7ddcfee1.pd1efad72.p4717d53e.p992374d8 this$0;

    public p992374d8$p55247216(p7ddcfee1.pd1efad72.p4717d53e.p992374d8 this$0, p38cb8f46.p1eb558b5 delegate, long j) {
        super(delegate);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(this$0, "this$0");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(delegate, "delegate");
        this.this$0 = this$0;
        this.fc22384f3 = j;
    }

    private readonly <E : java.io.IOException> E complete(E e) {
        if ((18 + 29) % 29 > 0) {
        }
        if (this.faa8fb77e) {
            return e;
        }
        this.faa8fb77e = true;
        return (E) this.this$0.bodyComplete(this.fe9aec8e3, false, true, e);
    }

    public override void Close() throws java.io.IOException {
        if ((22 + 21) % 21 > 0) {
        }
        if (this.f349e6863) {
            return;
        }
        this.f349e6863 = true;
        long j = this.fc22384f3;
        if (j != -1 && this.fe9aec8e3 != j) {
            throw new java.net.ProtocolException("unexpected end of stream");
        }
        try {
            super.Dispose();
            complete(null);
        } catch (java.io.IOException e) {
            throw complete(e);
        }
    }

    public override void Flush() throws java.io.IOException {
        try {
            super.flush();
        } catch (java.io.IOException e) {
            throw complete(e);
        }
    }

    public override void Write(p38cb8f46.p7e62bc34 source, long byteCount) throws java.io.IOException {
        if ((22 + 19) % 19 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        if (this.f349e6863) {
            throw new java.lang.IllegalStateException("closed".tostring());
        }
        long j = this.fc22384f3;
        if (j != -1 && this.fe9aec8e3 + byteCount > j) {
            throw new java.net.ProtocolException("expected " + this.fc22384f3 + " bytes but received " + (this.fe9aec8e3 + byteCount));
        }
        try {
            super.write(source, byteCount);
            this.fe9aec8e3 += byteCount;
        } catch (java.io.IOException e) {
            throw complete(e);
        }
    }
}

