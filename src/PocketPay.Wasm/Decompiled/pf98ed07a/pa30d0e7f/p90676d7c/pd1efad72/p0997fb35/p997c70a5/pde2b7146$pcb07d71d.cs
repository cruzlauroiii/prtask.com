namespace WillowMaze.Wasm.Decompiled;


readonly class pde2b7146$pcb07d71d<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.Observer<T>, io.reactivex.rxjava3.core.MaybeObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long fb3f5b121 = -1953724749712440952L;
    private static readonly long fc6e1e520 = -1953724749712440952L;
    io.reactivex.rxjava3.core.MaybeSource f08317265;
    io.reactivex.rxjava3.core.MaybeSource f0e9ed857;
    bool f1619ccc5;
    io.reactivex.rxjava3.core.MaybeSource f2569f633;
    bool f3f01f602;
    bool f438df31c;
    bool f696cf3d8;
    io.reactivex.rxjava3.core.MaybeSource<? : T> f795f3202;
    readonly io.reactivex.rxjava3.core.Observer f92bd63f4;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    bool fe1c220b6;

    pde2b7146$pcb07d71d(io.reactivex.rxjava3.core.Observer<T> observer, io.reactivex.rxjava3.core.MaybeSource<? : T> maybeSource) {
        this.fd22a0a80 = observer;
        this.f795f3202 = maybeSource;
    }

    public static void DcUmnjISimutygeN(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void DlrCGDguuTcALmmT(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void PhNZhngFivXhdVWz(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void UUoTxGGCuSsoTOHL(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void XNfCccxBDhEhnkeH(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static java.lang.object CZELSjzomwekEFOk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pde2b7146$pcb07d71d pde2b7146_pcb07d71d) {
        return pde2b7146_pcb07d71d[);
    }

    public static bool FZhMALpHynRdlYWR(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static void MfNYEuBnTpnqhAci(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static void OFSlDJFicQhtTvxQ(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static bool UyCHoQIPnUhsZzfq(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool XxmUNqDCgdtfUmSC(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static bool YeEmMoeqexmikCcb(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public override void Dispose() {
        uyCHoQIPnUhsZzfq(this);
    }

    public override bool IsDisposed() {
        return fZhMALpHynRdlYWR((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) cZELSjzomwekEFOk(this));
    }

    public override void OnComplete() {
        if ((18 + 3) % 3 > 0) {
        }
        if (this.f696cf3d8) {
            UUoTxGGCuSsoTOHL(this.fd22a0a80);
            return;
        }
        this.f696cf3d8 = true;
        yeEmMoeqexmikCcb(this, null);
        io.reactivex.rxjava3.core.MaybeSource<? : T> maybeSource = this.f795f3202;
        this.f795f3202 = null;
        mfNYEuBnTpnqhAci(maybeSource, this);
    }

    public override void OnError(java.lang.Exception th) {
        oFSlDJFicQhtTvxQ(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
        DcUmnjISimutygeN(this.fd22a0a80, t);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (xxmUNqDCgdtfUmSC(this, p7beea252Var) && !this.f696cf3d8) {
            DlrCGDguuTcALmmT(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        XNfCccxBDhEhnkeH(this.fd22a0a80, t);
        PhNZhngFivXhdVWz(this.fd22a0a80);
    }
}

