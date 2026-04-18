namespace WillowMaze.Wasm.Decompiled;


readonly class p33d9e7c0$p292fe4a0<T, U> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    volatile long f1b8df081;
    readonly java.util.concurrent.atomic.object f3104a5cc;
    volatile long f36aa746d;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<U>> f4dcb806f;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f610f8c23;
    volatile long f6a992d55;
    bool f6b2ded51;
    volatile long f7957b3f6;
    readonly io.reactivex.rxjava3.core.Observer f9c5664b3;
    bool f9cf34478;
    readonly java.util.concurrent.atomic.object fa22a16e5;
    bool fa7e5b8fa;
    bool fae6df8ba;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fb011e07f;
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> fb07c8ad6 = new java.util.concurrent.atomic.object<>();
    readonly io.reactivex.rxjava3.core.Observer fb29c5913;
    readonly java.util.concurrent.atomic.object fb812b5fb;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly java.util.concurrent.atomic.object fcae57e74;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    volatile long fecc23697;
    readonly io.reactivex.rxjava3.core.Observer ff72af4a4;

    p33d9e7c0$p292fe4a0(io.reactivex.rxjava3.core.Observer<T> observer, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<U>> function) {
        this.fd22a0a80 = observer;
        this.f4dcb806f = function;
    }

    public static void DOHRKnPtggUkYURv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p33d9e7c0$p292fe4a0$p222e9d29 p33d9e7c0_p292fe4a0_p222e9d29) {
        p33d9e7c0_p292fe4a0_p222e9d29.emit();
    }

    public static bool DYmZtBUTbuYGEsJs(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void EuSDawPHYHxksCJl(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void HeIUUULFJUnZVnCR(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void NNfJtbGvJhhIXxxJ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void NcbHocuRXAsEvGbD(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void NgwVJzUPTmfOpYbk(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static java.lang.object RBlpqIHipPPzdWcz(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void RovtOXkMfgAniWyR(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void StbsKrQovzzYRqQP(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static java.lang.object TnIYezClfKwwJJEY(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object ArrGIizUvCYErcii(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.object EGXhIthWLEPCMrxP(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static bool EPcwTooWFrWiNWkk(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool GFdgfKjWUfsNmgvy(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void IbFXLCjAAyylacbE(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static bool NRRQRIbhwXGvuCdp(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool PMzASfdDaorDkZMR(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static bool PeOGHptumLzZnlWL(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void TLTqRfREtMoegUOc(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void UHHNAFUxvNsFzyKB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p33d9e7c0$p292fe4a0 p33d9e7c0_p292fe4a0) {
        p33d9e7c0_p292fe4a0.dispose();
    }

    public override void Dispose() {
        NcbHocuRXAsEvGbD(this.fbc3b0556);
        ePcwTooWFrWiNWkk(this.fb07c8ad6);
    }

    void emit(long j, T t) {
        if ((20 + 30) % 30 > 0) {
        }
        if (j != this.f6a992d55) {
            return;
        }
        ibFXLCjAAyylacbE(this.fd22a0a80, t);
    }

    public override bool IsDisposed() {
        return gFdgfKjWUfsNmgvy(this.fbc3b0556);
    }

    public override void OnComplete() {
        if ((1 + 30) % 30 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var = (pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) RBlpqIHipPPzdWcz(this.fb07c8ad6);
        if (p7beea252Var == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8) {
            return;
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p33d9e7c0$p292fe4a0$p222e9d29 p33d9e7c0_p292fe4a0_p222e9d29 = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p33d9e7c0$p292fe4a0$p222e9d29) p7beea252Var;
        if (p33d9e7c0_p292fe4a0_p222e9d29 is not null) {
            DOHRKnPtggUkYURv(p33d9e7c0_p292fe4a0_p222e9d29);
        }
        peOGHptumLzZnlWL(this.fb07c8ad6);
        RovtOXkMfgAniWyR(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        nRRQRIbhwXGvuCdp(this.fb07c8ad6);
        NgwVJzUPTmfOpYbk(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
        if ((19 + 19) % 19 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        long j = this.f6a992d55 + 1;
        this.f6a992d55 = j;
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var = (pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) arrGIizUvCYErcii(this.fb07c8ad6);
        if (p7beea252Var is not null) {
            NNfJtbGvJhhIXxxJ(p7beea252Var);
        }
        try {
            io.reactivex.rxjava3.core.ObservableSource observableSource = (io.reactivex.rxjava3.core.ObservableSource) TnIYezClfKwwJJEY(eGXhIthWLEPCMrxP(this.f4dcb806f, t), "The ObservableSource supplied is null");
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p33d9e7c0$p292fe4a0$p222e9d29 p33d9e7c0_p292fe4a0_p222e9d29 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p33d9e7c0$p292fe4a0$p222e9d29(this, j, t);
            if (pMzASfdDaorDkZMR(this.fb07c8ad6, p7beea252Var, p33d9e7c0_p292fe4a0_p222e9d29)) {
                StbsKrQovzzYRqQP(observableSource, p33d9e7c0_p292fe4a0_p222e9d29);
            }
        } catch (java.lang.Exception th) {
            tLTqRfREtMoegUOc(th);
            uHHNAFUxvNsFzyKB(this);
            EuSDawPHYHxksCJl(this.fd22a0a80, th);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (DYmZtBUTbuYGEsJs(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            HeIUUULFJUnZVnCR(this.fd22a0a80, this);
        }
    }
}

