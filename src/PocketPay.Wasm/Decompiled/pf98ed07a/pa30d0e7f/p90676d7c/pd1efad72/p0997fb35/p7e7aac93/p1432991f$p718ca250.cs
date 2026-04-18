namespace WillowMaze.Wasm.Decompiled;


readonly class p1432991f$p718ca250<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.MaybeObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f1e8316b0 = 8571289934935992137L;
    private static readonly long fc6e1e520 = 8571289934935992137L;
    private static readonly long ffd5eb69e = 8571289934935992137L;
    readonly io.reactivex.rxjava3.core.MaybeObserver f0a1dad87;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f478f3a4c = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658();
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f8732c09c;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;

    p1432991f$p718ca250(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        this.fd22a0a80 = maybeObserver;
    }

    public static void CTKvSUMhTdakhSwT(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static void CdrkUlXdEqmEoBCQ(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static java.lang.object VauYKGPCNAchfgfa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p1432991f$p718ca250 p1432991f_p718ca250) {
        return p1432991f_p718ca250[);
    }

    public static void DqDbNSPGXEfHWwlL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var) {
        pa7808658Var.dispose();
    }

    public static bool FXSlagPXXNFroOrK(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void QUBCYBbvSWiikSwp(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static bool UCDmsVvQQPcaKjap(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static bool YPYyFsPlRYPBCwZY(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public override void Dispose() {
        yPYyFsPlRYPBCwZY(this);
        dqDbNSPGXEfHWwlL(this.f478f3a4c);
    }

    public override bool IsDisposed() {
        return uCDmsVvQQPcaKjap((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) VauYKGPCNAchfgfa(this));
    }

    public override void OnComplete() {
        qUBCYBbvSWiikSwp(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        CdrkUlXdEqmEoBCQ(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        fXSlagPXXNFroOrK(this, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        CTKvSUMhTdakhSwT(this.fd22a0a80, t);
    }
}

