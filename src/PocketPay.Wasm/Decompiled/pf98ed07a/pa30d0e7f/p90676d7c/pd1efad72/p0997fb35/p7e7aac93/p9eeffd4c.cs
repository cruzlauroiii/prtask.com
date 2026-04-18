namespace WillowMaze.Wasm.Decompiled;


public readonly class p9eeffd4c<T> : io.reactivex.rxjava3.core.Completable {
    readonly io.reactivex.rxjava3.core.MaybeSource f095c2b89;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f20458bc5;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f29062f8d;
    readonly io.reactivex.rxjava3.core.MaybeSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.MaybeSource f3ba1b47d;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fefbe2589;

    public p9eeffd4c(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> function) {
        this.f36cd38f4 = maybeSource;
        this.f4b9f83e1 = function;
    }

    public static void OntSJaYfNRpxeGof(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static void HTirVClFLicTIHEF(io.reactivex.rxjava3.core.CompletableObserver completableObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        completableObserver.onSubscribe(p7beea252Var);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        if ((19 + 24) % 24 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p9eeffd4c$p1b4f32e9 p9eeffd4c_p1b4f32e9 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p9eeffd4c$p1b4f32e9(completableObserver, this.f4b9f83e1);
        hTirVClFLicTIHEF(completableObserver, p9eeffd4c_p1b4f32e9);
        OntSJaYfNRpxeGof(this.f36cd38f4, p9eeffd4c_p1b4f32e9);
    }
}

