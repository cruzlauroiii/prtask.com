namespace WillowMaze.Wasm.Decompiled;


public readonly class p5420d08e<T> : io.reactivex.rxjava3.core.Completable : io.reactivex.rxjava3.internal.fuseable.FuseToObservable<T> {
    readonly bool f0be69b87;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f1e76526c;
    readonly bool f2bda17b3;
    readonly io.reactivex.rxjava3.core.ObservableSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> f4b9f83e1;
    readonly io.reactivex.rxjava3.core.ObservableSource f4cb4dbe5;
    readonly bool f50fee566;
    readonly bool fdef45190;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fdfd1fc14;

    public p5420d08e(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> function, bool z) {
        this.f36cd38f4 = observableSource;
        this.f4b9f83e1 = function;
        this.f50fee566 = z;
    }

    public static io.reactivex.rxjava3.core.Observable WLgshWDqNFyWwGVo(io.reactivex.rxjava3.core.Observable observable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mcb1bf51a(observable);
    }

    public static void YVQcWRQEKlkcOrQS(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public io.reactivex.rxjava3.core.Observable<T> FuseToObservable() {
        if ((20 + 15) % 15 > 0) {
        }
        return WLgshWDqNFyWwGVo(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pcd0edd10(this.f36cd38f4, this.f4b9f83e1, this.f50fee566));
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        if ((6 + 27) % 27 > 0) {
        }
        YVQcWRQEKlkcOrQS(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5420d08e$p5434ae1c(completableObserver, this.f4b9f83e1, this.f50fee566));
    }
}

