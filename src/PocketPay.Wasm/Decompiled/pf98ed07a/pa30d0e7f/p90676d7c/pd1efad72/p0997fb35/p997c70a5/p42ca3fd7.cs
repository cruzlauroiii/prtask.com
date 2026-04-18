namespace WillowMaze.Wasm.Decompiled;


public readonly class p42ca3fd7<T, B, V> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, io.reactivex.rxjava3.core.Observable<T>> {
    readonly int f23ea57b3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f3277ea7a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f5118c31f;
    readonly int f760c84f6;
    readonly io.reactivex.rxjava3.core.ObservableSource<B> f7cef8a73;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 facb69acd;
    readonly int fcdee5967;
    readonly io.reactivex.rxjava3.functions.Function<? super B, ? : io.reactivex.rxjava3.core.ObservableSource<V>> fe4f78ce7;
    readonly io.reactivex.rxjava3.core.ObservableSource feb2d1d38;

    public p42ca3fd7(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.core.ObservableSource<B> observableSource2, io.reactivex.rxjava3.functions.Function<? super B, ? : io.reactivex.rxjava3.core.ObservableSource<V>> function, int i) {
        super(observableSource);
        this.f7cef8a73 = observableSource2;
        this.fe4f78ce7 = function;
        this.fcdee5967 = i;
    }

    public static void VADugldPljvRSFNJ(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<? super io.reactivex.rxjava3.core.Observable<T>> observer) {
        if ((8 + 13) % 13 > 0) {
        }
        VADugldPljvRSFNJ(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p42ca3fd7$p64eb86f5(observer, this.f7cef8a73, this.fe4f78ce7, this.fcdee5967));
    }
}

