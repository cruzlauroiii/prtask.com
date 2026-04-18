namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0002\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J(\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\u00062\u0006\u0010\n\u001a\u00020\u0004H\u0016J&\u0010\u000b\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\f\u0010\f\u001a\b\u0012\u0004\u0012\u00020\u000e0\r2\u0006\u0010\n\u001a\u00020\u0004H\u0016J\u001e\u0010\u000f\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\f\u0010\u0010\u001a\b\u0012\u0004\u0012\u00020\u000e0\rH\u0016J\u0018\u0010\u0011\u001a\u00020\u00122\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0013\u001a\u00020\u0014H\u0016¨\u0006\u0015"}, d2 = {"Lp7ddcfee1/pd1efad72/p3cb89a9f/p96b6dd38$p910eef8c$pbcd3bea8;", "Lp7ddcfee1/pd1efad72/p3cb89a9f/p96b6dd38;", "()V", "onData", "", "streamId", "", "source", "Lp38cb8f46/pcc81e3f6;", "byteCount", "last", "onHeaders", "responseHeaders", "", "Lp7ddcfee1/pd1efad72/p3cb89a9f/pbf50d5e6;", "onRequest", "requestHeaders", "onReset", "", "errorCode", "Lp7ddcfee1/pd1efad72/p3cb89a9f/p9bc96b38;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
readonly class p96b6dd38$p910eef8c$pbcd3bea8 : p7ddcfee1.pd1efad72.p3cb89a9f.p96b6dd38 {
    public override bool OnData(int streamId, p38cb8f46.pcc81e3f6 source, int byteCount, bool last) throws java.io.IOException {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        source.skip(byteCount);
        return true;
    }

    public override bool OnHeaders(int streamId, java.util.List<p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6> responseHeaders, bool last) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(responseHeaders, "responseHeaders");
        return true;
    }

    public override bool OnRequest(int streamId, java.util.List<p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6> requestHeaders) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(requestHeaders, "requestHeaders");
        return true;
    }

    public override void OnReset(int streamId, p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 errorCode) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(errorCode, "errorCode");
    }
}

