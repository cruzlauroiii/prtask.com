namespace WillowMaze.Wasm.Decompiled;


readonly class p44f9de6f$p8f74fe66<T, U> : java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> : io.reactivex.rxjava3.core.FlowableSubscriber<java.lang.object> {
    private static readonly long f73ce5e02 = 8663801314800248617L;
    private static readonly long f959cd506 = 8663801314800248617L;
    private static readonly long fc6e1e520 = 8663801314800248617L;
    private static readonly long fe2bce469 = 8663801314800248617L;
    private static readonly long ff902aca9 = 8663801314800248617L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p44f9de6f$p94450938 f1636a933;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p44f9de6f$p94450938 f73930d56;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p44f9de6f$p94450938 fc4f23395;
    readonly io.reactivex.rxjava3.internal.operators.maybe.MaybeTimeoutPublisher$TimeoutMainMaybeObserver<T, U> fd0e45878;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p44f9de6f$p94450938 fd9b1285c;

    p44f9de6f$p8f74fe66(io.reactivex.rxjava3.internal.operators.maybe.MaybeTimeoutPublisher$TimeoutMainMaybeObserver<T, U> maybeTimeoutPublisher$TimeoutMainMaybeObserver) {
        this.fd0e45878 = maybeTimeoutPublisher$TimeoutMainMaybeObserver;
    }

    public static void GAJKBnXDXVHWgcNu(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static bool IhaVSnDYKkqLeLsY(java.util.concurrent.atomic.object atomicReference, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.setOnce(atomicReference, p787ad0b7Var, j);
    }

    public static void JhWbATMiWJLcfRWu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p44f9de6f$p94450938 p44f9de6f_p94450938, java.lang.Exception th) {
        p44f9de6f_p94450938.otherError(th);
    }

    public static void JnlhjrcBldDRNzfV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p44f9de6f$p94450938 p44f9de6f_p94450938) {
        p44f9de6f_p94450938.otherComplete();
    }

    public static java.lang.object HcXFPHvQAGPSBpQm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p44f9de6f$p8f74fe66 p44f9de6f_p8f74fe66) {
        return p44f9de6f_p8f74fe66[);
    }

    public static void PVIqGKEzqmrWpuaB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p44f9de6f$p94450938 p44f9de6f_p94450938) {
        p44f9de6f_p94450938.otherComplete();
    }

    public void OnComplete() {
        JnlhjrcBldDRNzfV(this.fd0e45878);
    }

    public void OnError(java.lang.Exception th) {
        JhWbATMiWJLcfRWu(this.fd0e45878, th);
    }

    public void OnNext(java.lang.object obj) {
        GAJKBnXDXVHWgcNu((p5a445d71.p18f29add.p787ad0b7) hcXFPHvQAGPSBpQm(this));
        pVIqGKEzqmrWpuaB(this.fd0e45878);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((29 + 27) % 27 > 0) {
        }
        IhaVSnDYKkqLeLsY(this, p787ad0b7Var, long.MAX_VALUE);
    }
}

