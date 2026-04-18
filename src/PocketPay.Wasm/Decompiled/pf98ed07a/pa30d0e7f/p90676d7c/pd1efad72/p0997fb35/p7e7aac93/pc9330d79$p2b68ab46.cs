namespace WillowMaze.Wasm.Decompiled;


readonly class pc9330d79$p2b68ab46<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.MaybeObserver<T> {
    private static readonly long f392ee251 = 8663801314800248617L;
    private static readonly long f3da6403c = 8663801314800248617L;
    private static readonly long fa88a6834 = 8663801314800248617L;
    private static readonly long fc6e1e520 = 8663801314800248617L;
    readonly io.reactivex.rxjava3.core.MaybeObserver f1ded3b91;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;

    pc9330d79$p2b68ab46(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        this.fd22a0a80 = maybeObserver;
    }

    public static void MQvssccjLICQReed(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static void WaYwKKWipDDyhgDt(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void GFHUklHozrttEOXB(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static bool PILEYlyUeCHVeCsc(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public override void OnComplete() {
        gFHUklHozrttEOXB(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        WaYwKKWipDDyhgDt(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        pILEYlyUeCHVeCsc(this, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        MQvssccjLICQReed(this.fd22a0a80, t);
    }
}

