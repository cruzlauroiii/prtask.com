namespace WillowMaze.Wasm.Decompiled;


public readonly class p94390900<T> : io.reactivex.rxjava3.core.Maybe<T> : io.reactivex.rxjava3.internal.fuseable.HasUpstreamSingleSource<T> {
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.SingleSource f5f5c53e8;
    readonly io.reactivex.rxjava3.core.SingleSource f776fe663;

    public p94390900(io.reactivex.rxjava3.core.SingleSource<T> singleSource) {
        this.f36cd38f4 = singleSource;
    }

    public static void NBZUtbDFSxghhNhK(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public io.reactivex.rxjava3.core.SingleSource<T> Source() {
        return this.f36cd38f4;
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        NBZUtbDFSxghhNhK(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p94390900$pc0663a1c(maybeObserver));
    }
}

