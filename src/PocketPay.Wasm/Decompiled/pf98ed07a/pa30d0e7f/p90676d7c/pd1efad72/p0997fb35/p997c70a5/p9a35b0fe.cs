namespace WillowMaze.Wasm.Decompiled;


public readonly class p9a35b0fe<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly long f03a3c24f;
    readonly T f16830a58;
    readonly bool f1d2566b1;
    readonly long f4f3f1ea7;
    readonly bool f50ff5138;
    readonly bool f558e3cbe;
    readonly long f6a992d55;
    readonly bool f7b41d252;
    readonly long fb4df5fc6;
    readonly bool fb76719d9;
    readonly java.lang.object fbd6d8a18;
    readonly long fff42b05f;

    public p9a35b0fe(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, long j, T t, bool z) {
        super(observableSource);
        this.f6a992d55 = j;
        this.f16830a58 = t;
        this.f1d2566b1 = z;
    }

    public static void BQHRQaRkGJxsMtny(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((4 + 21) % 21 > 0) {
        }
        BQHRQaRkGJxsMtny(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9a35b0fe$pe6e37ea6(observer, this.f6a992d55, this.f16830a58, this.f1d2566b1));
    }
}

