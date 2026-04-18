namespace WillowMaze.Wasm.Decompiled;


public readonly class p16c2cc15<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 f2fd78796;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 fec0e7b8a;
    readonly io.reactivex.rxjava3.functions.BiPredicate<java.lang.int, java.lang.Exception> ff670ef68;

    public p16c2cc15(io.reactivex.rxjava3.core.Observable<T> observable, io.reactivex.rxjava3.functions.BiPredicate<java.lang.int, java.lang.Exception> biPredicate) {
        super(observable);
        this.ff670ef68 = biPredicate;
    }

    public static void VNHYkjfJVVJQpfSC(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void BjJAxESmtmLwdIud(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p16c2cc15$p351db019 p16c2cc15_p351db019) {
        p16c2cc15_p351db019.subscribeNext();
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((22 + 5) % 5 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658();
        VNHYkjfJVVJQpfSC(observer, pa7808658Var);
        bjJAxESmtmLwdIud(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p16c2cc15$p351db019(observer, this.ff670ef68, pa7808658Var, this.f36cd38f4));
    }
}

