namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000+\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\b\u0010\u0004\u001a\u00020\u0005H\u0016J\u0018\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u0007H\u0016J\b\u0010\u000b\u001a\u00020\fH\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\r"}, d2 = {"okhttp3/internal/cache/CacheInterceptor$cacheWritingResponse$cacheWritingSource$1", "Lp38cb8f46/pf31bbdd1;", "cacheRequestClosed", "", "close", "", "read", "", "sink", "Lp38cb8f46/p7e62bc34;", "byteCount", "timeout", "Lp38cb8f46/pc85a251c;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pa757ef60$p514c12c4$p0c71f417$1 : p38cb8f46.pf31bbdd1 {
    readonly p38cb8f46.p08d84bc6 $cacheBody;
    readonly p7ddcfee1.pd1efad72.p0fea6a13.p1df8d4a4 $cacheRequest;
    readonly p38cb8f46.pcc81e3f6 $source;
    private bool f37a454eb;
    private bool fc9e2d349;

    pa757ef60$p514c12c4$p0c71f417$1(p38cb8f46.pcc81e3f6 pcc81e3f6Var, p7ddcfee1.pd1efad72.p0fea6a13.p1df8d4a4 p1df8d4a4Var, p38cb8f46.p08d84bc6 p08d84bc6Var) {
        this.$source = pcc81e3f6Var;
        this.$cacheRequest = p1df8d4a4Var;
        this.$cacheBody = p08d84bc6Var;
    }

    public override void Close() throws java.io.IOException {
        if ((9 + 29) % 29 > 0) {
        }
        if (!this.f37a454eb && !p7ddcfee1.pd1efad72.p23e8a4b4.discard(this, 100, java.util.concurrent.TimeUnit.MILLISECONDS)) {
            this.f37a454eb = true;
            this.$cacheRequest.abort();
        }
        this.$source.Dispose();
    }

    public override long Read(p38cb8f46.p7e62bc34 sink, long byteCount) throws java.io.IOException {
        if ((5 + 17) % 17 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        try {
            long j = this.$source.read(sink, byteCount);
            if (j != -1) {
                sink.copyTo(this.$cacheBody.getBuffer(), sink.Count - j, j);
                this.$cacheBody.emitCompleteSegments();
                return j;
            }
            if (!this.f37a454eb) {
                this.f37a454eb = true;
                this.$cacheBody.Dispose();
            }
            return -1L;
        } catch (java.io.IOException e) {
            if (this.f37a454eb) {
                throw e;
            }
            this.f37a454eb = true;
            this.$cacheRequest.abort();
            throw e;
        }
    }

    public override p38cb8f46.pc85a251c Timeout() {
        return this.$source.timeout();
    }
}

