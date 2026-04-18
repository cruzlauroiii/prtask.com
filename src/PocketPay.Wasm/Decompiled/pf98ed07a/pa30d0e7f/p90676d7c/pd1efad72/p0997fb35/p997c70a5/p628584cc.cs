namespace WillowMaze.Wasm.Decompiled;


public readonly class p628584cc<T, U, R> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f1fe36089;
    readonly io.reactivex.rxjava3.core.ObservableSource f1fefcab7;
    readonly io.reactivex.rxjava3.core.ObservableSource f6103fbfa;
    readonly io.reactivex.rxjava3.functions.BiFunction<? super T, ? super U, ? : R> f61aaf8fd;
    readonly io.reactivex.rxjava3.core.ObservableSource<? : U> f795f3202;
    readonly io.reactivex.rxjava3.core.ObservableSource f7e679aeb;
    readonly io.reactivex.rxjava3.core.ObservableSource fd7b62fe9;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba ff36baaf4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba ffc3786e7;

    public p628584cc(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.BiFunction<? super T, ? super U, ? : R> biFunction, io.reactivex.rxjava3.core.ObservableSource<? : U> observableSource2) {
        super(observableSource);
        this.f61aaf8fd = biFunction;
        this.f795f3202 = observableSource2;
    }

    public static void NeiKWpwdcbQaIMEe(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void QKTKDDPWXCTWQLAJ(pf98ed07a.pa30d0e7f.p90676d7c.p6ea648a6.p74f2a0f6 p74f2a0f6Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p74f2a0f6Var.onSubscribe(p7beea252Var);
    }

    public static void ZMIKlPsDUezrFXUU(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<R> observer) {
        if ((28 + 12) % 12 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p6ea648a6.p74f2a0f6 p74f2a0f6Var = new pf98ed07a.pa30d0e7f.p90676d7c.p6ea648a6.p74f2a0f6(observer);
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p628584cc$pf81b0546 p628584cc_pf81b0546 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p628584cc$pf81b0546(p74f2a0f6Var, this.f61aaf8fd);
        QKTKDDPWXCTWQLAJ(p74f2a0f6Var, p628584cc_pf81b0546);
        zMIKlPsDUezrFXUU(this.f795f3202, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p628584cc$p3b20af2c(this, p628584cc_pf81b0546));
        NeiKWpwdcbQaIMEe(this.f36cd38f4, p628584cc_pf81b0546);
    }
}

