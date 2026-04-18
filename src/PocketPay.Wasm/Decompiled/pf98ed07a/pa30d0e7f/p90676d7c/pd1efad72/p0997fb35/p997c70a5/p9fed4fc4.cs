namespace WillowMaze.Wasm.Decompiled;


public readonly class p9fed4fc4<T, K, V> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, io.reactivex.rxjava3.observables.GroupedObservable<K, V>> {
    readonly int f087843ed;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f18092461;
    readonly bool f20b03e38;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f27544372;
    readonly int f45fb247b;
    readonly int f546c5b86;
    readonly bool f5d880207;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f65b83e46;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f6f16f38c;
    readonly bool f825ea879;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : K> f866d6d67;
    readonly int fcdee5967;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 ff3c6622e;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : V> ff50644dc;

    public p9fed4fc4(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Function<? super T, ? : K> function, io.reactivex.rxjava3.functions.Function<? super T, ? : V> function2, int i, bool z) {
        super(observableSource);
        this.f866d6d67 = function;
        this.ff50644dc = function2;
        this.fcdee5967 = i;
        this.f825ea879 = z;
    }

    public static void NynqjeEmBHHcKdIe(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<? super io.reactivex.rxjava3.observables.GroupedObservable<K, V>> observer) {
        if ((2 + 28) % 28 > 0) {
        }
        NynqjeEmBHHcKdIe(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p26b03f9f(observer, this.f866d6d67, this.ff50644dc, this.fcdee5967, this.f825ea879));
    }
}

