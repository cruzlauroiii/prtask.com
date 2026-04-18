namespace WillowMaze.Wasm.Decompiled;


public readonly class p70631f3c<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f5bad32aa;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f9aff0b92;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : T> fdb9d6c56;

    public p70631f3c(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : T> function) {
        super(observableSource);
        this.fdb9d6c56 = function;
    }

    public static void YmxqbHMVeWrhKwgS(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((28 + 30) % 30 > 0) {
        }
        YmxqbHMVeWrhKwgS(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p70631f3c$p46e76e1b(observer, this.fdb9d6c56));
    }
}

