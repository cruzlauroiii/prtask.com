namespace WillowMaze.Wasm.Decompiled;


public readonly class pe23411c6<T> : io.reactivex.rxjava3.core.Flowable<T> : pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p16a0487a.pe349b74c {
    readonly io.reactivex.rxjava3.core.CompletableSource f36cd38f4;
    readonly io.reactivex.rxjava3.core.CompletableSource f58db0bae;
    readonly io.reactivex.rxjava3.core.CompletableSource f962f0d27;
    readonly io.reactivex.rxjava3.core.CompletableSource f9e0d1283;
    readonly io.reactivex.rxjava3.core.CompletableSource fac3c384e;

    public pe23411c6(io.reactivex.rxjava3.core.CompletableSource completableSource) {
        this.f36cd38f4 = completableSource;
    }

    public static void MOYIwRTgtxTWYqCE(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        completableSource.subscribe(completableObserver);
    }

    public override io.reactivex.rxjava3.core.CompletableSource Source() {
        return this.f36cd38f4;
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        mOYIwRTgtxTWYqCE(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe23411c6$p93332f27(subscriber));
    }
}

