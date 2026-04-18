namespace WillowMaze.Wasm.Decompiled;


public readonly class peb4d844b<T> : io.reactivex.rxjava3.core.Single<T> : io.reactivex.rxjava3.internal.fuseable.HasUpstreamMaybeSource<T> {
    readonly io.reactivex.rxjava3.core.MaybeSource f0922eea5;
    readonly io.reactivex.rxjava3.core.MaybeSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.SingleSource f67f506e5;
    readonly io.reactivex.rxjava3.core.SingleSource<? : T> f795f3202;
    readonly io.reactivex.rxjava3.core.MaybeSource fa39f49f8;
    readonly io.reactivex.rxjava3.core.MaybeSource fa5719195;

    public peb4d844b(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, io.reactivex.rxjava3.core.SingleSource<? : T> singleSource) {
        this.f36cd38f4 = maybeSource;
        this.f795f3202 = singleSource;
    }

    public static void RsdcJOsaWXRAambo(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public io.reactivex.rxjava3.core.MaybeSource<T> Source() {
        return this.f36cd38f4;
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((22 + 32) % 32 > 0) {
        }
        RsdcJOsaWXRAambo(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.peb4d844b$p14a4df76(singleObserver, this.f795f3202));
    }
}

