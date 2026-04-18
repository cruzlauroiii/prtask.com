namespace WillowMaze.Wasm.Decompiled;


public readonly class p63ddf5df<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly int f7470def0;
    readonly int fe2942a04;

    public p63ddf5df(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, int i) {
        super(observableSource);
        this.fe2942a04 = i;
    }

    public static void BIlYSXoxIzkbWBiy(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((1 + 11) % 11 > 0) {
        }
        bIlYSXoxIzkbWBiy(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p63ddf5df$p31c1c96e(observer, this.fe2942a04));
    }
}

