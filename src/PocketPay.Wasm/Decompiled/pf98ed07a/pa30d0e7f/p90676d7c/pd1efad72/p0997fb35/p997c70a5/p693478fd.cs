namespace WillowMaze.Wasm.Decompiled;


public readonly class p693478fd<T> : io.reactivex.rxjava3.core.Completable : io.reactivex.rxjava3.internal.fuseable.FuseToObservable<T> {
    readonly io.reactivex.rxjava3.core.ObservableSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.ObservableSource f9c740b62;
    readonly io.reactivex.rxjava3.core.ObservableSource fb52d9555;

    public p693478fd(io.reactivex.rxjava3.core.ObservableSource<T> observableSource) {
        this.f36cd38f4 = observableSource;
    }

    public static void NoxbQkKSOugSmQCV(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static io.reactivex.rxjava3.core.Observable QeAAsPpWwApInvUG(io.reactivex.rxjava3.core.Observable observable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mcb1bf51a(observable);
    }

    public io.reactivex.rxjava3.core.Observable<T> FuseToObservable() {
        return qeAAsPpWwApInvUG(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pf54eae58(this.f36cd38f4));
    }

    public override void SubscribeActual(io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        NoxbQkKSOugSmQCV(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p693478fd$p8e20dfb2(completableObserver));
    }
}

