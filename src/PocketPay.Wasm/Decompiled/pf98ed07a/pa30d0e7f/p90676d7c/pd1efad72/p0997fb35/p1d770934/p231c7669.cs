namespace WillowMaze.Wasm.Decompiled;


public readonly class p231c7669<R> : io.reactivex.rxjava3.core.Observable<R> {
    readonly io.reactivex.rxjava3.core.CompletableSource f36cd38f4;
    readonly io.reactivex.rxjava3.core.CompletableSource f715362b4;
    readonly io.reactivex.rxjava3.core.ObservableSource<? : R> f795f3202;
    readonly io.reactivex.rxjava3.core.ObservableSource f96e0d4ad;
    readonly io.reactivex.rxjava3.core.CompletableSource fafdd6b2a;
    readonly io.reactivex.rxjava3.core.ObservableSource fc7a81b84;

    public p231c7669(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.ObservableSource<? : R> observableSource) {
        this.f36cd38f4 = completableSource;
        this.f795f3202 = observableSource;
    }

    public static void WUmkBrBqTtqAsdTU(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void VqrkZFDQoxxWwThR(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        completableSource.subscribe(completableObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.Observer<R> observer) {
        if ((17 + 29) % 29 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p231c7669$p310d874f p231c7669_p310d874f = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p231c7669$p310d874f(observer, this.f795f3202);
        WUmkBrBqTtqAsdTU(observer, p231c7669_p310d874f);
        vqrkZFDQoxxWwThR(this.f36cd38f4, p231c7669_p310d874f);
    }
}

