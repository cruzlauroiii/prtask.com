namespace WillowMaze.Wasm.Decompiled;


readonly class p0de7c579$pcbd5c6a6$p49e5a87b<B> : java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> : io.reactivex.rxjava3.core.FlowableSubscriber<B> {
    private static readonly long f50718935 = -3326496781427702834L;
    private static readonly long f93fb15e6 = -3326496781427702834L;
    private static readonly long f9836ebfb = -3326496781427702834L;
    private static readonly long fc6e1e520 = -3326496781427702834L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6 fcb135bd6;
    readonly io.reactivex.rxjava3.internal.operators.flowable.FlowableWindowBoundarySelector$WindowBoundaryMainSubscriber<object, B, object> fd0e45878;

    p0de7c579$pcbd5c6a6$p49e5a87b(io.reactivex.rxjava3.internal.operators.flowable.FlowableWindowBoundarySelector$WindowBoundaryMainSubscriber<object, B, object> flowableWindowBoundarySelector$WindowBoundaryMainSubscriber) {
        this.fd0e45878 = flowableWindowBoundarySelector$WindowBoundaryMainSubscriber;
    }

    public static void ZCiuYjcHjyyTFaqk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6 p0de7c579_pcbd5c6a6) {
        p0de7c579_pcbd5c6a6.openComplete();
    }

    public static void ZcrAKmsOxCFVnLqo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6 p0de7c579_pcbd5c6a6, java.lang.Exception th) {
        p0de7c579_pcbd5c6a6.openError(th);
    }

    public static void BgxfFQxJSmhaprqE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6 p0de7c579_pcbd5c6a6, java.lang.object obj) {
        p0de7c579_pcbd5c6a6.open(obj);
    }

    public static bool DpdrfuUMNDjQKckZ(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static void TOPZpXuHCLYZAWTd(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static bool YvkBcjrKdXPZjDUt(java.util.concurrent.atomic.object atomicReference, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.setOnce(atomicReference, p787ad0b7Var);
    }

    void cancel() {
        dpdrfuUMNDjQKckZ(this);
    }

    public void OnComplete() {
        ZCiuYjcHjyyTFaqk(this.fd0e45878);
    }

    public void OnError(java.lang.Exception th) {
        ZcrAKmsOxCFVnLqo(this.fd0e45878, th);
    }

    public void OnNext(B b) {
        bgxfFQxJSmhaprqE(this.fd0e45878, b);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((23 + 2) % 2 > 0) {
        }
        if (yvkBcjrKdXPZjDUt(this, p787ad0b7Var)) {
            tOPZpXuHCLYZAWTd(p787ad0b7Var, long.MAX_VALUE);
        }
    }
}

