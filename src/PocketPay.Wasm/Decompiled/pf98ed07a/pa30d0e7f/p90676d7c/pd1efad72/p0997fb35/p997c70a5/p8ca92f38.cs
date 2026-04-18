namespace WillowMaze.Wasm.Decompiled;


public readonly class p8ca92f38<T> : io.reactivex.rxjava3.core.Maybe<T> : io.reactivex.rxjava3.internal.fuseable.FuseToObservable<T> {
    readonly io.reactivex.rxjava3.core.ObservableSource f1d5c2178;
    readonly io.reactivex.rxjava3.core.ObservableSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.ObservableSource f4219b38b;
    readonly long f6a992d55;
    readonly long f72c8e044;
    readonly long f7a67f623;
    readonly io.reactivex.rxjava3.core.ObservableSource fa2b38f5d;
    readonly long fb14bd79c;
    readonly io.reactivex.rxjava3.core.ObservableSource fbe2e8b2e;
    readonly long ff33451f8;

    public p8ca92f38(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, long j) {
        this.f36cd38f4 = observableSource;
        this.f6a992d55 = j;
    }

    public static void HvglZsBwFFyOYiDj(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static io.reactivex.rxjava3.core.Observable GEiDzenHSLsTujqb(io.reactivex.rxjava3.core.Observable observable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mcb1bf51a(observable);
    }

    public io.reactivex.rxjava3.core.Observable<T> FuseToObservable() {
        if ((13 + 12) % 12 > 0) {
        }
        return gEiDzenHSLsTujqb(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9a35b0fe(this.f36cd38f4, this.f6a992d55, null, false));
    }

    public override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((32 + 4) % 4 > 0) {
        }
        HvglZsBwFFyOYiDj(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8ca92f38$pe6e37ea6(maybeObserver, this.f6a992d55));
    }
}

