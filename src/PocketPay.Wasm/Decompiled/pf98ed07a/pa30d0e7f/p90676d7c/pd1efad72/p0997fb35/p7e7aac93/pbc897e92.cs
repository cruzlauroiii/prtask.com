namespace WillowMaze.Wasm.Decompiled;


abstract class pbc897e92<T, R> : io.reactivex.rxjava3.core.Maybe<R> : io.reactivex.rxjava3.internal.fuseable.HasUpstreamMaybeSource<T> {
    protected readonly io.reactivex.rxjava3.core.MaybeSource<T> f36cd38f4;
    protected readonly io.reactivex.rxjava3.core.MaybeSource f5949cb9a;
    protected readonly io.reactivex.rxjava3.core.MaybeSource f942a9023;
    protected readonly io.reactivex.rxjava3.core.MaybeSource f9862df97;
    protected readonly io.reactivex.rxjava3.core.MaybeSource fa5b5c4b3;

    pbc897e92(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource) {
        this.f36cd38f4 = maybeSource;
    }

    public readonly io.reactivex.rxjava3.core.MaybeSource<T> Source() {
        return this.f36cd38f4;
    }
}

