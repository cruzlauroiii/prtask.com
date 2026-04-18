namespace WillowMaze.Wasm.Decompiled;


public readonly class pb5c59a83<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly io.reactivex.rxjava3.core.Scheduler f64b82b35;

    public pb5c59a83(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.core.Scheduler scheduler) {
        super(observableSource);
        this.f499f31e7 = scheduler;
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 UxGwkhgBcrYGQAzB(io.reactivex.rxjava3.core.Scheduler scheduler, java.lang.Action runnable) {
        return scheduler.scheduleDirect(runnable);
    }

    public static void VuAuEPfIwOoRceZe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pb5c59a83$pa453bafa pb5c59a83_pa453bafa, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        pb5c59a83_pa453bafa.setDisposable(p7beea252Var);
    }

    public static void COCQMTRggxcHJUjC(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((7 + 28) % 28 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pb5c59a83$pa453bafa pb5c59a83_pa453bafa = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pb5c59a83$pa453bafa(observer);
        cOCQMTRggxcHJUjC(observer, pb5c59a83_pa453bafa);
        VuAuEPfIwOoRceZe(pb5c59a83_pa453bafa, UxGwkhgBcrYGQAzB(this.f499f31e7, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pb5c59a83$ped40debe(this, pb5c59a83_pa453bafa)));
    }
}

