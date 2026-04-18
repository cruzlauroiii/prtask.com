namespace WillowMaze.Wasm.Decompiled;


public readonly class pdd6ba593<T> : io.reactivex.rxjava3.core.Completable : io.reactivex.rxjava3.internal.fuseable.FuseToMaybe<T> {
    readonly io.reactivex.rxjava3.core.MaybeSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.MaybeSource f8179aa35;
    readonly io.reactivex.rxjava3.core.MaybeSource f9a9f8735;

    public pdd6ba593(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource) {
        this.f36cd38f4 = maybeSource;
    }

    public static void DAtGOhGaQvZGSvki(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static io.reactivex.rxjava3.core.Maybe PgOrTcdXWONkXVUe(io.reactivex.rxjava3.core.Maybe maybe) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mcb1bf51a(maybe);
    }

    public io.reactivex.rxjava3.core.Maybe<T> FuseToMaybe() {
        return pgOrTcdXWONkXVUe(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pa224cd38(this.f36cd38f4));
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        DAtGOhGaQvZGSvki(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pdd6ba593$p2a9c7bcf(completableObserver));
    }
}

