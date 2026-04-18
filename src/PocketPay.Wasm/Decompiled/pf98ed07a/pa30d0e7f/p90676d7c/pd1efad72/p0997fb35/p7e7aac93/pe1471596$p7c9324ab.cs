namespace WillowMaze.Wasm.Decompiled;


readonly class pe1471596$p7c9324ab<T, R> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.MaybeObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f49c4fa51 = 4827726964688405508L;
    private static readonly long f682e003b = 4827726964688405508L;
    private static readonly long fc6e1e520 = 4827726964688405508L;
    private static readonly long fcb4b2106 = 4827726964688405508L;
    readonly io.reactivex.rxjava3.core.MaybeObserver f0da97dd6;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f2e5ba807;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> f4b9f83e1;
    readonly io.reactivex.rxjava3.core.MaybeObserver f4ec31d55;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f85df1ea2;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fb586746d;
    readonly io.reactivex.rxjava3.core.MaybeObserver<R> fd22a0a80;
    readonly io.reactivex.rxjava3.core.MaybeObserver fd6a7a660;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fde82c800;

    pe1471596$p7c9324ab(io.reactivex.rxjava3.core.MaybeObserver<R> maybeObserver, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> function) {
        this.fd22a0a80 = maybeObserver;
        this.f4b9f83e1 = function;
    }

    public static java.lang.object BkpWlcdzxuXnPjXI(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void DDkUGmtRPVfmYAdL(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static java.lang.object FsxZpJNTDHdHgoRo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pe1471596$p7c9324ab pe1471596_p7c9324ab) {
        return pe1471596_p7c9324ab[);
    }

    public static bool IOBtSTxHrRAamVcV(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static void QMfBWSlOEiyPjjsX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pe1471596$p7c9324ab pe1471596_p7c9324ab, java.lang.Exception th) {
        pe1471596_p7c9324ab.onError(th);
    }

    public static void ZRBAeaUkbBifxMKA(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public static bool AEaJcUfLVnmrfXaj(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static java.lang.object DAQSzejmUXTbEbWd(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void HBXffNlghPriehJR(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void JNeOnuhXhYCrXVqF(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static void KvxGqCLpXrRWgftU(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static bool WUpNfhFuhAUIiqap(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pe1471596$p7c9324ab pe1471596_p7c9324ab) {
        return pe1471596_p7c9324ab.isDisposed();
    }

    public static bool ZAyqwMXNFDUfMpvP(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public override void Dispose() {
        zAyqwMXNFDUfMpvP(this);
    }

    public override bool IsDisposed() {
        return IOBtSTxHrRAamVcV((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) FsxZpJNTDHdHgoRo(this));
    }

    public override void OnComplete() {
        kvxGqCLpXrRWgftU(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        DDkUGmtRPVfmYAdL(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (aEaJcUfLVnmrfXaj(this, p7beea252Var)) {
            jNeOnuhXhYCrXVqF(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        if ((11 + 25) % 25 > 0) {
        }
        try {
            io.reactivex.rxjava3.core.SingleSource singleSource = (io.reactivex.rxjava3.core.SingleSource) BkpWlcdzxuXnPjXI(dAQSzejmUXTbEbWd(this.f4b9f83e1, t), "The mapper returned a null SingleSource");
            if (wUpNfhFuhAUIiqap(this)) {
                return;
            }
            ZRBAeaUkbBifxMKA(singleSource, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pe1471596$p475bc90e(this, this.fd22a0a80));
        } catch (java.lang.Exception th) {
            hBXffNlghPriehJR(th);
            QMfBWSlOEiyPjjsX(this, th);
        }
    }
}

