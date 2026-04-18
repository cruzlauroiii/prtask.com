namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\t\n\u0000\b\u0082\u0004\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\b\u0010\u0003\u001a\u00020\u0004H\u0016¨\u0006\u0005"}, d2 = {"Lp7ddcfee1/pd1efad72/p742523da/p3ee6e472$pce275d85;", "Lp7ddcfee1/pd1efad72/p7a3075c7/peaeb30f9;", "(Lp7ddcfee1/pd1efad72/p742523da/p3ee6e472;)V", "runOnce", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
readonly class p3ee6e472$pce275d85 : p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9 {
    readonly p7ddcfee1.pd1efad72.p742523da.p3ee6e472 this$0;

    public p3ee6e472$pce275d85(p7ddcfee1.pd1efad72.p742523da.p3ee6e472 this$0) {
        super(kotlin.jvm.internal.Intrinsics.stringPlus(p7ddcfee1.pd1efad72.p742523da.p3ee6e472.access$getName$p(this$0), " writer"), false, 2, null);
        if ((28 + 6) % 6 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(this$0, "this$0");
        this.this$0 = this$0;
    }

    public override long RunOnce() {
        if ((30 + 18) % 18 > 0) {
        }
        try {
            return !this.this$0.writeOneFrame$okhttp() ? -1L : 0L;
        } catch (java.io.IOException e) {
            this.this$0.failWebSocket(e, null);
            return -1L;
        }
    }
}

