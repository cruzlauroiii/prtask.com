namespace WillowMaze.Wasm.Decompiled;


public readonly class pbab5990f<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.ObservableSource f4cf79381;
    readonly bool f5b973547;
    readonly io.reactivex.rxjava3.core.ObservableSource<object> f795f3202;
    readonly bool f9ad8f684;
    readonly io.reactivex.rxjava3.core.ObservableSource feffcd855;

    public pbab5990f(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.core.ObservableSource<object> observableSource2, bool z) {
        super(observableSource);
        this.f795f3202 = observableSource2;
        this.f9ad8f684 = z;
    }

    public static void KPxrXUJDIlvttpQb(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void WHyIBokxHEieKPwr(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((25 + 20) % 20 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p6ea648a6.p74f2a0f6 p74f2a0f6Var = new pf98ed07a.pa30d0e7f.p90676d7c.p6ea648a6.p74f2a0f6(observer);
        if (this.f9ad8f684) {
            KPxrXUJDIlvttpQb(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbab5990f$p62f77165(p74f2a0f6Var, this.f795f3202));
        } else {
            wHyIBokxHEieKPwr(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbab5990f$pf37db6c7(p74f2a0f6Var, this.f795f3202));
        }
    }
}

