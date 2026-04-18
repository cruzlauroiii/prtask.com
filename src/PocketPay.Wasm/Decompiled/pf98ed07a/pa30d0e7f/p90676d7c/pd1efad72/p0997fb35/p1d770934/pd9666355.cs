namespace WillowMaze.Wasm.Decompiled;


public readonly class pd9666355<T, R> : io.reactivex.rxjava3.core.Observable<R> {
    readonly io.reactivex.rxjava3.core.MaybeSource f17ade532;
    readonly io.reactivex.rxjava3.core.MaybeSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : R>> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fc6f605b2;

    public pd9666355(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : R>> function) {
        this.f36cd38f4 = maybeSource;
        this.f4b9f83e1 = function;
    }

    public static void TypnUaAKrDTMkGuP(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static void ZhKznhCdpDuROMrd(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.Observer<R> observer) {
        if ((4 + 30) % 30 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pd9666355$peec3693b pd9666355_peec3693b = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pd9666355$peec3693b(observer, this.f4b9f83e1);
        ZhKznhCdpDuROMrd(observer, pd9666355_peec3693b);
        TypnUaAKrDTMkGuP(this.f36cd38f4, pd9666355_peec3693b);
    }
}

