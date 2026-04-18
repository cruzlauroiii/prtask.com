namespace WillowMaze.Wasm.Decompiled;


public readonly class p140e669d<T> : io.reactivex.rxjava3.core.Observable<T> {
    readonly io.reactivex.rxjava3.core.CompletableSource f22e39e39;
    readonly io.reactivex.rxjava3.core.CompletableSource f36cd38f4;
    readonly io.reactivex.rxjava3.core.CompletableSource fa11f23bb;

    public p140e669d(io.reactivex.rxjava3.core.CompletableSource completableSource) {
        this.f36cd38f4 = completableSource;
    }

    public static void EhQNkqrGPtxcEWDe(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        completableSource.subscribe(completableObserver);
    }

    public static void EhQNkqrGPtxcEWDe(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EhQNkqrGPtxcEWDe(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EhQNkqrGPtxcEWDe(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        EhQNkqrGPtxcEWDe(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p418692d6$p93332f27(observer));
    }
}

