namespace WillowMaze.Wasm.Decompiled;


public readonly class p2ddc47bc<T, K> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f4305dec5;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 f44d45dc3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 f4ed875aa;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 f553b46fa;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f65ba36cb;
    readonly io.reactivex.rxjava3.functions.Function<T, K> f866d6d67;
    readonly io.reactivex.rxjava3.functions.BiPredicate<K, K> f9f89a861;

    public p2ddc47bc(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Function<T, K> function, io.reactivex.rxjava3.functions.BiPredicate<K, K> biPredicate) {
        super(observableSource);
        this.f866d6d67 = function;
        this.f9f89a861 = biPredicate;
    }

    public static void WqGWNCvvzagSFqJw(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((7 + 21) % 21 > 0) {
        }
        wqGWNCvvzagSFqJw(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p2ddc47bc$p02244c52(observer, this.f866d6d67, this.f9f89a861));
    }
}

