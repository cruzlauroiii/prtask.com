namespace WillowMaze.Wasm.Decompiled;


public readonly class pcf46ef45<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly long f323b7b16;
    readonly long f58021136;
    readonly long fa8689c2c;
    readonly long faa9f73ee;
    readonly long fb563204a;

    public pcf46ef45(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, long j) {
        super(observableSource);
        this.faa9f73ee = j;
    }

    public static void CRPEaiarVhssGCCF(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((18 + 10) % 10 > 0) {
        }
        CRPEaiarVhssGCCF(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pcf46ef45$p1f56699f(observer, this.faa9f73ee));
    }
}

