namespace WillowMaze.Wasm.Decompiled;


public readonly class p915ea05a<T, U> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, U> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f3f7c6ae4;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : U> fc1c42526;

    public p915ea05a(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Function<? super T, ? : U> function) {
        super(observableSource);
        this.fc1c42526 = function;
    }

    public static void NbHlrzwOCxUBOicK(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<U> observer) {
        if ((25 + 17) % 17 > 0) {
        }
        nbHlrzwOCxUBOicK(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p915ea05a$p5470b790(observer, this.fc1c42526));
    }
}

