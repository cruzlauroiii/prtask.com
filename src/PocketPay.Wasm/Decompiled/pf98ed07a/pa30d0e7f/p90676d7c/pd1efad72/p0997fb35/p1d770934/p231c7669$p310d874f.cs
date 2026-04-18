namespace WillowMaze.Wasm.Decompiled;


readonly class p231c7669$p310d874f<R> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.Observer<R>, io.reactivex.rxjava3.core.CompletableObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f1271816f = -8948264376121066672L;
    private static readonly long f19326a8d = -8948264376121066672L;
    private static readonly long f403c95d1 = -8948264376121066672L;
    private static readonly long fc6e1e520 = -8948264376121066672L;
    private static readonly long fe1f02432 = -8948264376121066672L;
    readonly io.reactivex.rxjava3.core.Observer f3223d981;
    io.reactivex.rxjava3.core.ObservableSource f68f68d5e;
    io.reactivex.rxjava3.core.ObservableSource<? : R> f795f3202;
    readonly io.reactivex.rxjava3.core.Observer f891e8cb5;
    readonly io.reactivex.rxjava3.core.Observer f93bd7beb;
    readonly io.reactivex.rxjava3.core.Observer fd08a642d;
    readonly io.reactivex.rxjava3.core.Observer<R> fd22a0a80;
    io.reactivex.rxjava3.core.ObservableSource fdd9b5c2e;

    p231c7669$p310d874f(io.reactivex.rxjava3.core.Observer<R> observer, io.reactivex.rxjava3.core.ObservableSource<? : R> observableSource) {
        this.f795f3202 = observableSource;
        this.fd22a0a80 = observer;
    }

    public static void AvZwHtmJYztgoxQl(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void MJTrdOGrKoEDXDHj(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static java.lang.object RimnsaWHVHVmxHeB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p231c7669$p310d874f p231c7669_p310d874f) {
        return p231c7669_p310d874f[);
    }

    public static bool SVJLqkRRYcMrFLfv(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static bool WLkGNMYsrnvXYfZU(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static bool BKuleQMjwUxYUNxx(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void OvbghXQszMPCvhtq(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void RLNpegpBdgCYzQgk(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public override void Dispose() {
        bKuleQMjwUxYUNxx(this);
    }

    public override bool IsDisposed() {
        return WLkGNMYsrnvXYfZU((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) RimnsaWHVHVmxHeB(this));
    }

    public override void OnComplete() {
        if ((30 + 14) % 14 > 0) {
        }
        io.reactivex.rxjava3.core.ObservableSource<? : R> observableSource = this.f795f3202;
        if (observableSource is null) {
            ovbghXQszMPCvhtq(this.fd22a0a80);
        } else {
            this.f795f3202 = null;
            MJTrdOGrKoEDXDHj(observableSource, this);
        }
    }

    public override void OnError(java.lang.Exception th) {
        AvZwHtmJYztgoxQl(this.fd22a0a80, th);
    }

    public override void OnNext(R r) {
        rLNpegpBdgCYzQgk(this.fd22a0a80, r);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        SVJLqkRRYcMrFLfv(this, p7beea252Var);
    }
}

