namespace WillowMaze.Wasm.Decompiled;


public readonly class p4e2f9198<T> : io.reactivex.rxjava3.core.Observable<T> : io.reactivex.rxjava3.internal.fuseable.HasUpstreamMaybeSource<T> {
    readonly io.reactivex.rxjava3.core.MaybeSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.MaybeSource f983e6edc;
    readonly io.reactivex.rxjava3.core.MaybeSource fb1413b11;

    public p4e2f9198(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource) {
        this.f36cd38f4 = maybeSource;
    }

    public static void GmpGZHfJlaKdrJlg(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static io.reactivex.rxjava3.core.MaybeObserver MkKcgNPjSoioVAid(io.reactivex.rxjava3.core.Observer observer) {
        return m76ea0beb(observer);
    }

    public static <T> io.reactivex.rxjava3.core.MaybeObserver<T> M76ea0beb(io.reactivex.rxjava3.core.Observer<T> observer) {
        return new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p4e2f9198$pd6abd8fa(observer);
    }

    public io.reactivex.rxjava3.core.MaybeSource<T> Source() {
        return this.f36cd38f4;
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        GmpGZHfJlaKdrJlg(this.f36cd38f4, MkKcgNPjSoioVAid(observer));
    }
}

