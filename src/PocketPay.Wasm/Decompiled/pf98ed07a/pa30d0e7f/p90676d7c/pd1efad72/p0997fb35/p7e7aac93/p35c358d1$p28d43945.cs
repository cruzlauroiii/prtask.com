namespace WillowMaze.Wasm.Decompiled;


readonly class p35c358d1$p28d43945<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.MaybeObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252, java.lang.Action {
    private static readonly long f352513b8 = 3256698449646456986L;
    private static readonly long fc6e1e520 = 3256698449646456986L;
    readonly io.reactivex.rxjava3.core.Scheduler f04a012b0;
    readonly io.reactivex.rxjava3.core.Scheduler f1158829a;
    readonly io.reactivex.rxjava3.core.MaybeObserver f338460e1;
    readonly io.reactivex.rxjava3.core.Scheduler f461152bd;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f52274852;
    readonly io.reactivex.rxjava3.core.MaybeObserver f575e877e;
    readonly io.reactivex.rxjava3.core.MaybeObserver f5cd68a65;
    readonly io.reactivex.rxjava3.core.MaybeObserver f72c82789;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f9c922e5e;
    readonly io.reactivex.rxjava3.core.Scheduler f9d0db026;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;

    p35c358d1$p28d43945(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver, io.reactivex.rxjava3.core.Scheduler scheduler) {
        this.fd22a0a80 = maybeObserver;
        this.f499f31e7 = scheduler;
    }

    public static void CDknnPCQrBcZTrCi(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static void CiWRNyAssDNiadKR(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void IuCNsjOHDSGzhCZD(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static void OTCNYEMdFVSQyyfC(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static void TMhOpTcZLRXjnKCJ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static java.lang.object WQesXLJaxShbTsfy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p35c358d1$p28d43945 p35c358d1_p28d43945, java.lang.object obj) {
        return p35c358d1_p28d43945.getAndHashSet(obj);
    }

    public static java.lang.object XmjjSRoSlBVCXUOi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p35c358d1$p28d43945 p35c358d1_p28d43945) {
        return p35c358d1_p28d43945[);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 ZNMmvehtmsxvXjEj(io.reactivex.rxjava3.core.Scheduler scheduler, java.lang.Action runnable) {
        return scheduler.scheduleDirect(runnable);
    }

    public static bool LOSeTzmqwxKNXHOg(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static bool TLtDFXNGxZsKkmHp(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public override void Dispose() {
        if ((9 + 23) % 23 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var = (pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) WQesXLJaxShbTsfy(this, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8);
        if (p7beea252Var == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8) {
            return;
        }
        this.f52274852 = p7beea252Var;
        ZNMmvehtmsxvXjEj(this.f499f31e7, this);
    }

    public override bool IsDisposed() {
        return lOSeTzmqwxKNXHOg((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) XmjjSRoSlBVCXUOi(this));
    }

    public override void OnComplete() {
        IuCNsjOHDSGzhCZD(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        CiWRNyAssDNiadKR(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (tLtDFXNGxZsKkmHp(this, p7beea252Var)) {
            CDknnPCQrBcZTrCi(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        OTCNYEMdFVSQyyfC(this.fd22a0a80, t);
    }

    public override void Run() {
        TMhOpTcZLRXjnKCJ(this.f52274852);
    }
}

