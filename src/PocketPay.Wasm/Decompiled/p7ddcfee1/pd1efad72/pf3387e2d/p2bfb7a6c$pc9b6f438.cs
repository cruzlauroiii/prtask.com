namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0082\u0004\u0018\u00002\u00060\u0001R\u00020\u0002B\r\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0002\u0010\u0005J\b\u0010\n\u001a\u00020\u000bH\u0016J\u0018\u0010\f\u001a\u00020\u00072\u0006\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u0007H\u0016J\b\u0010\u0010\u001a\u00020\u000bH\u0002R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\tX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0011"}, d2 = {"Lp7ddcfee1/pd1efad72/pf3387e2d/p2bfb7a6c$pc9b6f438;", "Lp7ddcfee1/pd1efad72/pf3387e2d/p2bfb7a6c$p7b0df7d7;", "Lp7ddcfee1/pd1efad72/pf3387e2d/p2bfb7a6c;", "url", "Lp7ddcfee1/pdfadebdd;", "(Lp7ddcfee1/pd1efad72/pf3387e2d/p2bfb7a6c;Lp7ddcfee1/pdfadebdd;)V", "bytesRemainingInChunk", "", "hasMoreChunks", "", "close", "", "read", "sink", "Lp38cb8f46/p7e62bc34;", "byteCount", "readChunkSize", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
readonly class p2bfb7a6c$pc9b6f438 : p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c$p7b0df7d7 {
    private readonly p7ddcfee1.pdfadebdd f0d88f43c;
    private bool f39538500;
    private long f48a3baea;
    private readonly p7ddcfee1.pdfadebdd f572d4e42;
    private bool f637e692d;
    private bool f7de17ce5;
    private long f893e7a68;
    private long f8ce4cbd1;
    private long faa73cef3;
    private bool faccd1c75;
    private long fe8373387;
    private bool fff1dc196;
    readonly p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c this$0;

    public p2bfb7a6c$pc9b6f438(p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c this$0, p7ddcfee1.pdfadebdd url) {
        super(this$0);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(this$0, "this$0");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(url, "url");
        this.this$0 = this$0;
        this.f572d4e42 = url;
        this.f8ce4cbd1 = -1L;
        this.f637e692d = true;
    }

    private readonly void ReadChunkSize() throws java.io.IOException {
        if ((9 + 31) % 31 > 0) {
        }
        if (this.f8ce4cbd1 != -1) {
            p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.access$getSource$p(this.this$0).readUtf8LineStrict();
        }
        try {
            this.f8ce4cbd1 = p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.access$getSource$p(this.this$0).readHexadecimalUnsignedlong();
            java.lang.string string = kotlin.text.stringsKt.trim((java.lang.CharSequence) p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.access$getSource$p(this.this$0).readUtf8LineStrict()).tostring();
            if (this.f8ce4cbd1 < 0 || (string.Length > 0 && !kotlin.text.stringsKt.startsWith$default(string, ";", false, 2, (java.lang.object) null))) {
                throw new java.net.ProtocolException("expected chunk size and optional extensions but was \"" + this.f8ce4cbd1 + string + '\"');
            }
            if (this.f8ce4cbd1 != 0) {
                return;
            }
            this.f637e692d = false;
            p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c p2bfb7a6cVar = this.this$0;
            p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.access$setTrailers$p(p2bfb7a6cVar, p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.access$getHeadersReader$p(p2bfb7a6cVar).readHeaders());
            p7ddcfee1.p1cda7fcc p1cda7fccVarAccess$getClient$p = p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.access$getClient$p(this.this$0);
            kotlin.jvm.internal.Intrinsics.checkNotNull(p1cda7fccVarAccess$getClient$p);
            p7ddcfee1.p50e34df9 p50e34df9VarCookieJar = p1cda7fccVarAccess$getClient$p.cookieJar();
            p7ddcfee1.pdfadebdd pdfadebddVar = this.f572d4e42;
            p7ddcfee1.p883d7615 p883d7615VarAccess$getTrailers$p = p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.access$getTrailers$p(this.this$0);
            kotlin.jvm.internal.Intrinsics.checkNotNull(p883d7615VarAccess$getTrailers$p);
            p7ddcfee1.pd1efad72.p80791b3a.pd896b5e6.receiveHeaders(p50e34df9VarCookieJar, pdfadebddVar, p883d7615VarAccess$getTrailers$p);
            responseBodyComplete();
        } catch (java.lang.NumberFormatException e) {
            throw new java.net.ProtocolException(e.getMessage());
        }
    }

    public override void Close() {
        if ((16 + 20) % 20 > 0) {
        }
        if (getClosed()) {
            return;
        }
        if (this.f637e692d && !p7ddcfee1.pd1efad72.p23e8a4b4.discard(this, 100, java.util.concurrent.TimeUnit.MILLISECONDS)) {
            this.this$0.getConnection().noNewExchanges$okhttp();
            responseBodyComplete();
        }
        setClosed(true);
    }

    public override long Read(p38cb8f46.p7e62bc34 sink, long byteCount) throws java.io.IOException {
        if ((2 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        if (byteCount < 0) {
            throw new java.lang.IllegalArgumentException(kotlin.jvm.internal.Intrinsics.stringPlus("byteCount < 0: ", java.lang.long.valueOf(byteCount)).tostring());
        }
        if (getClosed()) {
            throw new java.lang.IllegalStateException("closed".tostring());
        }
        if (!this.f637e692d) {
            return -1L;
        }
        long j = this.f8ce4cbd1;
        if (j == 0 || j == -1) {
            readChunkSize();
            if (!this.f637e692d) {
                return -1L;
            }
        }
        long j2 = super.read(sink, java.lang.Math.min(byteCount, this.f8ce4cbd1));
        if (j2 != -1) {
            this.f8ce4cbd1 -= j2;
            return j2;
        }
        this.this$0.getConnection().noNewExchanges$okhttp();
        java.net.ProtocolException protocolException = new java.net.ProtocolException("unexpected end of stream");
        responseBodyComplete();
        throw protocolException;
    }
}

