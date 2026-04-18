namespace WillowMaze.Wasm.Decompiled;


readonly class pb5c59a83$pa453bafa<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f3d5bf6e6 = 8094547886072529208L;
    private static readonly long fc6e1e520 = 8094547886072529208L;
    private static readonly long fff503d01 = 8094547886072529208L;
    readonly io.reactivex.rxjava3.core.Observer f02deba54;
    readonly io.reactivex.rxjava3.core.Observer f50fda9de;
    readonly java.util.concurrent.atomic.object f98abfde8;
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> fbc3b0556 = new java.util.concurrent.atomic.object<>();
    readonly java.util.concurrent.atomic.object fc7c5ff9c;
    readonly io.reactivex.rxjava3.core.Observer fc96554cf;
    readonly io.reactivex.rxjava3.core.Observer fcec2f95a;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;

    pb5c59a83$pa453bafa(io.reactivex.rxjava3.core.Observer<T> observer) {
        this.fd22a0a80 = observer;
    }

    public static void HkmthufWMoMYfIQN(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void KbCMMDlzpiWIRCDk(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void MlDUEjvPMoJOKjuR(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static bool NYcrQGmMPMQiJVPT(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static bool NdBclArAdwZdKlQC(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static bool SzgZaezEXbFiRvmt(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool TCeCeBeGzoPYUsYt(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool UgSrAFxUFJKLFRvr(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static java.lang.object FMdFIySeiOfHAAYc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pb5c59a83$pa453bafa pb5c59a83_pa453bafa) {
        return pb5c59a83_pa453bafa[);
    }

    public override void Dispose() {
        TCeCeBeGzoPYUsYt(this.fbc3b0556);
        SzgZaezEXbFiRvmt(this);
    }

    public override bool IsDisposed() {
        return NdBclArAdwZdKlQC((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) fMdFIySeiOfHAAYc(this));
    }

    public override void OnComplete() {
        KbCMMDlzpiWIRCDk(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        MlDUEjvPMoJOKjuR(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
        HkmthufWMoMYfIQN(this.fd22a0a80, t);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        NYcrQGmMPMQiJVPT(this.fbc3b0556, p7beea252Var);
    }

    void setDisposable(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        UgSrAFxUFJKLFRvr(this, p7beea252Var);
    }
}

