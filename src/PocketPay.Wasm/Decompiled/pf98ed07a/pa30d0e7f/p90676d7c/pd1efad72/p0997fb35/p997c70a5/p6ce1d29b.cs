namespace WillowMaze.Wasm.Decompiled;


public readonly class p6ce1d29b<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f058178b9;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f188bd14a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f9cc63c82;
    readonly io.reactivex.rxjava3.functions.Predicate<T> ff670ef68;

    public p6ce1d29b(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Predicate<T> predicate) {
        super(observableSource);
        this.ff670ef68 = predicate;
    }

    public static void CNdeiHHMiXpPjvlN(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((15 + 9) % 9 > 0) {
        }
        CNdeiHHMiXpPjvlN(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p6ce1d29b$p4ecb2c26(observer, this.ff670ef68));
    }
}

