namespace WillowMaze.Wasm.Decompiled;


public readonly class pe963eb11<T> : io.reactivex.rxjava3.core.Single<java.lang.bool> : io.reactivex.rxjava3.internal.fuseable.HasUpstreamMaybeSource<T>, io.reactivex.rxjava3.internal.fuseable.FuseToMaybe<java.lang.bool> {
    readonly io.reactivex.rxjava3.core.MaybeSource f31f27163;
    readonly io.reactivex.rxjava3.core.MaybeSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.MaybeSource f9d598925;
    readonly io.reactivex.rxjava3.core.MaybeSource fa813dc61;
    readonly io.reactivex.rxjava3.core.MaybeSource ffda8ab3d;

    public pe963eb11(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource) {
        this.f36cd38f4 = maybeSource;
    }

    public static void ZMLmUCDLduSeRjpZ(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static io.reactivex.rxjava3.core.Maybe MfBIekDSHAGcFaaZ(io.reactivex.rxjava3.core.Maybe maybe) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mcb1bf51a(maybe);
    }

    public io.reactivex.rxjava3.core.Maybe<java.lang.bool> FuseToMaybe() {
        return mfBIekDSHAGcFaaZ(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p6a7394bd(this.f36cd38f4));
    }

    public io.reactivex.rxjava3.core.MaybeSource<T> Source() {
        return this.f36cd38f4;
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<java.lang.bool> singleObserver) {
        ZMLmUCDLduSeRjpZ(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pe963eb11$pde4b4ce5(singleObserver));
    }
}

