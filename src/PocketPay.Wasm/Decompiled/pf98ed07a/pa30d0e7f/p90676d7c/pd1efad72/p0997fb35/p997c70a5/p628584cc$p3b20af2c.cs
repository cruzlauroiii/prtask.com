namespace WillowMaze.Wasm.Decompiled;


readonly class p628584cc$p3b20af2c<U> : io.reactivex.rxjava3.core.Observer<U> {
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p628584cc$pf81b0546 f469559ac;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p628584cc$pf81b0546 f82625df5;
    private readonly io.reactivex.rxjava3.internal.operators.observable.ObservableWithLatestFrom$WithLatestFromObserver<T, U, R> fd0e45878;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p628584cc this$0;

    p628584cc$p3b20af2c(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p628584cc p628584ccVar, io.reactivex.rxjava3.internal.operators.observable.ObservableWithLatestFrom$WithLatestFromObserver<T, U, R> observableWithLatestFrom$WithLatestFromObserver) {
        this.this$0 = p628584ccVar;
        this.fd0e45878 = observableWithLatestFrom$WithLatestFromObserver;
    }

    public static void JHEozwhngAFJAkze(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p628584cc$pf81b0546 p628584cc_pf81b0546, java.lang.Exception th) {
        p628584cc_pf81b0546.otherError(th);
    }

    public static bool YkkYROUZASKTAqFy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p628584cc$pf81b0546 p628584cc_pf81b0546, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p628584cc_pf81b0546.setOther(p7beea252Var);
    }

    public static void CCGgUoGwmycxEAPW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p628584cc$pf81b0546 p628584cc_pf81b0546, java.lang.object obj) {
        p628584cc_pf81b0546.lazyHashSet(obj);
    }

    public override void OnComplete() {
    }

    public override void OnError(java.lang.Exception th) {
        JHEozwhngAFJAkze(this.fd0e45878, th);
    }

    public override void OnNext(U u) {
        cCGgUoGwmycxEAPW(this.fd0e45878, u);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        YkkYROUZASKTAqFy(this.fd0e45878, p7beea252Var);
    }
}

