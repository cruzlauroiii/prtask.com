namespace WillowMaze.Wasm.Decompiled;


readonly class p44f9de6f$p2b68ab46<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.MaybeObserver<T> {
    private static readonly long f11f6ab0d = 8663801314800248617L;
    private static readonly long f7e01b949 = 8663801314800248617L;
    private static readonly long f7ed0e048 = 8663801314800248617L;
    private static readonly long fa8363272 = 8663801314800248617L;
    private static readonly long fc6e1e520 = 8663801314800248617L;
    readonly io.reactivex.rxjava3.core.MaybeObserver f01dbbcc1;
    readonly io.reactivex.rxjava3.core.MaybeObserver f39243f7a;
    readonly io.reactivex.rxjava3.core.MaybeObserver f65bfc0d4;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;

    p44f9de6f$p2b68ab46(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        this.fd22a0a80 = maybeObserver;
    }

    public static bool RMwEIkkJausONmzx(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void JFTLJWvZDetFwngU(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static void LbEOILbBsdRpuKAq(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static void YxYYNNdWBfbYCZdf(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public override void OnComplete() {
        lbEOILbBsdRpuKAq(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        yxYYNNdWBfbYCZdf(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        RMwEIkkJausONmzx(this, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        jFTLJWvZDetFwngU(this.fd22a0a80, t);
    }
}

