namespace WillowMaze.Wasm.Decompiled;


public readonly class p9442da0d$pd41d8cd9$p95263d50 : kotlin.jvm.functions.Function1 {
    public readonly pe0212e54.pf0719ea8.p9442da0d f$0;
    public readonly java.lang.string f$1;

    public p9442da0d$pd41d8cd9$p95263d50(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar, java.lang.string str) {
        this.f$0 = p9442da0dVar;
        this.f$1 = str;
    }

    public static java.lang.object GpMGqKTCrJIXVvoy(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return p9442da0dVar.m3903lambda$selectDevice$1$devicesdaoDeviceDao_Impl(str, continuation);
    }

    public override readonly java.lang.object Invoke(java.lang.object obj) {
        return gpMGqKTCrJIXVvoy(this.f$0, this.f$1, (kotlin.coroutines.Continuation) obj);
    }
}

