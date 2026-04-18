namespace WillowMaze.Wasm.Decompiled;


readonly class p1901bdb3$pe0acc004<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.CompletableObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f24b4658b = 703409937383992161L;
    private static readonly long fc6e1e520 = 703409937383992161L;
    private static readonly long fcb7977d3 = 703409937383992161L;
    private static readonly long fd2d5cb91 = 703409937383992161L;
    private static readonly long ffd2e04a9 = 703409937383992161L;
    readonly io.reactivex.rxjava3.core.MaybeObserver f069207e8;
    readonly io.reactivex.rxjava3.core.MaybeSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.MaybeSource f41a0801a;
    readonly io.reactivex.rxjava3.core.MaybeObserver fad1642a0;
    readonly io.reactivex.rxjava3.core.MaybeObserver fb74d81d1;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;

    p1901bdb3$pe0acc004(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver, io.reactivex.rxjava3.core.MaybeSource<T> maybeSource) {
        this.fd22a0a80 = maybeObserver;
        this.f36cd38f4 = maybeSource;
    }

    public static void BkAbQVeSQXkYGTEA(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static void EtfDMspbyveSRFyK(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static bool MOBHwAKDkwcxjtJv(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool PkrmcKiQGyhecZLG(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void LDSpjbwDwslwOhrl(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static bool MDUQuuUUcybACxFD(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static java.lang.object VUaCsEZWNwzfhgiB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p1901bdb3$pe0acc004 p1901bdb3_pe0acc004) {
        return p1901bdb3_pe0acc004[);
    }

    public override void Dispose() {
        MOBHwAKDkwcxjtJv(this);
    }

    public override bool IsDisposed() {
        return mDUQuuUUcybACxFD((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) vUaCsEZWNwzfhgiB(this));
    }

    public override void OnComplete() {
        if ((32 + 25) % 25 > 0) {
        }
        EtfDMspbyveSRFyK(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p1901bdb3$pa4bce3d6(this, this.fd22a0a80));
    }

    public override void OnError(java.lang.Exception th) {
        lDSpjbwDwslwOhrl(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (PkrmcKiQGyhecZLG(this, p7beea252Var)) {
            BkAbQVeSQXkYGTEA(this.fd22a0a80, this);
        }
    }
}

