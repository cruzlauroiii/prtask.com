namespace WillowMaze.Wasm.Decompiled;


readonly class p8b8ee0e0$pcb07d71d<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.Observer<T>, io.reactivex.rxjava3.core.CompletableObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f5b3cc266 = -1953724749712440952L;
    private static readonly long f7b5de02e = -1953724749712440952L;
    private static readonly long fc6e1e520 = -1953724749712440952L;
    io.reactivex.rxjava3.core.CompletableSource f44c9505c;
    readonly io.reactivex.rxjava3.core.Observer f4c6c9624;
    bool f62138b98;
    bool f6591fb31;
    io.reactivex.rxjava3.core.CompletableSource f795f3202;
    readonly io.reactivex.rxjava3.core.Observer fa29ac435;
    readonly io.reactivex.rxjava3.core.Observer fa53946ed;
    io.reactivex.rxjava3.core.CompletableSource fa58e3b89;
    io.reactivex.rxjava3.core.CompletableSource fc9537913;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    io.reactivex.rxjava3.core.CompletableSource ff2fd2211;

    p8b8ee0e0$pcb07d71d(io.reactivex.rxjava3.core.Observer<T> observer, io.reactivex.rxjava3.core.CompletableSource completableSource) {
        this.fd22a0a80 = observer;
        this.f795f3202 = completableSource;
    }

    public static bool KtredMwBAoRUyjVN(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static bool QYesmpOoJbvJxEco(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void SLvjbMeNWBENxpGh(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static java.lang.object VWmGtdvBRqVBVsuB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8b8ee0e0$pcb07d71d p8b8ee0e0_pcb07d71d) {
        return p8b8ee0e0_pcb07d71d[);
    }

    public static bool ZAQeKVXziubUfxbA(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static void AwqADhgxKvhGckBE(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        completableSource.subscribe(completableObserver);
    }

    public static void CDmzxHEwfLpzRQDq(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void JBrajTPAtDqItTlc(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void PWIWyWEyBNrVQhlJ(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static bool WRnNgCxWgMGskLUp(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public override void Dispose() {
        QYesmpOoJbvJxEco(this);
    }

    public override bool IsDisposed() {
        return ZAQeKVXziubUfxbA((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) VWmGtdvBRqVBVsuB(this));
    }

    public override void OnComplete() {
        if ((28 + 29) % 29 > 0) {
        }
        if (this.f6591fb31) {
            pWIWyWEyBNrVQhlJ(this.fd22a0a80);
            return;
        }
        this.f6591fb31 = true;
        KtredMwBAoRUyjVN(this, null);
        io.reactivex.rxjava3.core.CompletableSource completableSource = this.f795f3202;
        this.f795f3202 = null;
        awqADhgxKvhGckBE(completableSource, this);
    }

    public override void OnError(java.lang.Exception th) {
        SLvjbMeNWBENxpGh(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
        cDmzxHEwfLpzRQDq(this.fd22a0a80, t);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (wRnNgCxWgMGskLUp(this, p7beea252Var) && !this.f6591fb31) {
            jBrajTPAtDqItTlc(this.fd22a0a80, this);
        }
    }
}

