namespace WillowMaze.Wasm.Decompiled;


public readonly class pff13980b<T> : io.reactivex.rxjava3.core.Flowable<T> {
    readonly io.reactivex.rxjava3.core.CompletableSource f36cd38f4;
    readonly io.reactivex.rxjava3.core.CompletableSource f54254886;

    public pff13980b(io.reactivex.rxjava3.core.CompletableSource completableSource) {
        this.f36cd38f4 = completableSource;
    }

    public static void YkGviJZArvgelmJL(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        completableSource.subscribe(completableObserver);
    }

    public static void YkGviJZArvgelmJL(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YkGviJZArvgelmJL(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YkGviJZArvgelmJL(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        ykGviJZArvgelmJL(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe23411c6$p93332f27(subscriber));
    }
}

