namespace WillowMaze.Wasm.Decompiled;


readonly class pe1471596$p475bc90e<R> : io.reactivex.rxjava3.core.SingleObserver<R> {
    readonly java.util.concurrent.atomic.object f03a6101a;
    readonly java.util.concurrent.atomic.object f59fc70a4;
    readonly io.reactivex.rxjava3.core.MaybeObserver f7076f711;
    readonly io.reactivex.rxjava3.core.MaybeObserver f75870f54;
    readonly io.reactivex.rxjava3.core.MaybeObserver fb7bcd495;
    readonly io.reactivex.rxjava3.core.MaybeObserver fbc415d4f;
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> fd0e45878;
    readonly io.reactivex.rxjava3.core.MaybeObserver<R> fd22a0a80;

    pe1471596$p475bc90e(java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> atomicReference, io.reactivex.rxjava3.core.MaybeObserver<R> maybeObserver) {
        this.fd0e45878 = atomicReference;
        this.fd22a0a80 = maybeObserver;
    }

    public static void BBFHiDmJQPxtMUdZ(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static bool WjkgjJHVHObyqSfx(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static void XeHYmdfjNUSWaPGp(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public override void OnError(java.lang.Exception th) {
        xeHYmdfjNUSWaPGp(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        wjkgjJHVHObyqSfx(this.fd0e45878, p7beea252Var);
    }

    public override void OnSuccess(R r) {
        bBFHiDmJQPxtMUdZ(this.fd22a0a80, r);
    }
}

