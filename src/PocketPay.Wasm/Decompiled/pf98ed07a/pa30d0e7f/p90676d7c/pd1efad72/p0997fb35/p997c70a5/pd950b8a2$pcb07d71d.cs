namespace WillowMaze.Wasm.Decompiled;


readonly class pd950b8a2$pcb07d71d<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.Observer<T>, io.reactivex.rxjava3.core.SingleObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f8e4d2930 = -1953724749712440952L;
    private static readonly long f994cfedc = -1953724749712440952L;
    private static readonly long fa580200f = -1953724749712440952L;
    private static readonly long fc6e1e520 = -1953724749712440952L;
    bool f11253fdc;
    readonly io.reactivex.rxjava3.core.Observer f1717bc40;
    readonly io.reactivex.rxjava3.core.Observer f2a5bd44e;
    io.reactivex.rxjava3.core.SingleSource f36a93039;
    bool f3fc37bd0;
    io.reactivex.rxjava3.core.SingleSource f601d50e8;
    io.reactivex.rxjava3.core.SingleSource<? : T> f795f3202;
    bool f9eccff5e;
    io.reactivex.rxjava3.core.SingleSource fc1f16664;
    io.reactivex.rxjava3.core.SingleSource fc95c8c12;
    bool fcf601aff;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.Observer ff4008e3e;
    readonly io.reactivex.rxjava3.core.Observer ffd2fa089;

    pd950b8a2$pcb07d71d(io.reactivex.rxjava3.core.Observer<T> observer, io.reactivex.rxjava3.core.SingleSource<? : T> singleSource) {
        this.fd22a0a80 = observer;
        this.f795f3202 = singleSource;
    }

    public static void DqMeUXpGtIWpcqcJ(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static bool LBVQslOSvxnXsLZu(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void LWCIbuePYJrXKusp(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void LircriWSegNwYRjM(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static java.lang.object NuTGOraVMppJwojG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd950b8a2$pcb07d71d pd950b8a2_pcb07d71d) {
        return pd950b8a2_pcb07d71d[);
    }

    public static bool EvlRjyAmIUtzXhHo(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static void LysaxAReZuuiTomE(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public static void NgWlpUfdpZfYSiIp(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static bool OgrlaFMUWpDadVjX(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool QggjbtenocdPDSfT(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static void RLgJOobqEDvfykyE(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public override void Dispose() {
        ogrlaFMUWpDadVjX(this);
    }

    public override bool IsDisposed() {
        return evlRjyAmIUtzXhHo((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) NuTGOraVMppJwojG(this));
    }

    public override void OnComplete() {
        if ((4 + 11) % 11 > 0) {
        }
        this.f9eccff5e = true;
        qggjbtenocdPDSfT(this, null);
        io.reactivex.rxjava3.core.SingleSource<? : T> singleSource = this.f795f3202;
        this.f795f3202 = null;
        lysaxAReZuuiTomE(singleSource, this);
    }

    public override void OnError(java.lang.Exception th) {
        LWCIbuePYJrXKusp(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
        DqMeUXpGtIWpcqcJ(this.fd22a0a80, t);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (LBVQslOSvxnXsLZu(this, p7beea252Var) && !this.f9eccff5e) {
            LircriWSegNwYRjM(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        rLgJOobqEDvfykyE(this.fd22a0a80, t);
        ngWlpUfdpZfYSiIp(this.fd22a0a80);
    }
}

