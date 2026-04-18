namespace WillowMaze.Wasm.Decompiled;


public readonly class pa11a33d1<T> : io.reactivex.rxjava3.core.Single<T> {
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.SingleSource f7cf62b76;

    public pa11a33d1(io.reactivex.rxjava3.core.SingleSource<T> singleSource) {
        this.f36cd38f4 = singleSource;
    }

    public static void ZUOWclJnNFjruwsg(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        zUOWclJnNFjruwsg(this.f36cd38f4, singleObserver);
    }
}

