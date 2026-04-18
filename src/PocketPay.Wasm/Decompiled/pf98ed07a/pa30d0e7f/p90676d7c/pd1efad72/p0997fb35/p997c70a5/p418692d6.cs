namespace WillowMaze.Wasm.Decompiled;


public readonly class p418692d6<T> : io.reactivex.rxjava3.core.Observable<T> : pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p16a0487a.pe349b74c {
    readonly io.reactivex.rxjava3.core.CompletableSource f36cd38f4;
    readonly io.reactivex.rxjava3.core.CompletableSource f762d5dfe;
    readonly io.reactivex.rxjava3.core.CompletableSource faaca7e57;
    readonly io.reactivex.rxjava3.core.CompletableSource feea93a45;

    public p418692d6(io.reactivex.rxjava3.core.CompletableSource completableSource) {
        this.f36cd38f4 = completableSource;
    }

    public static void BqOYUkUBOQdHHjQJ(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        completableSource.subscribe(completableObserver);
    }

    public override io.reactivex.rxjava3.core.CompletableSource Source() {
        return this.f36cd38f4;
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        bqOYUkUBOQdHHjQJ(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p418692d6$p93332f27(observer));
    }
}

