namespace WillowMaze.Wasm.Decompiled;


readonly class p7ded80f6$pa9bdabca<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.MaybeObserver<T> {
    private static readonly long f4141c024 = -3031974433025990931L;
    private static readonly long f53b6dfe2 = -3031974433025990931L;
    private static readonly long f7352af3f = -3031974433025990931L;
    private static readonly long fc6e1e520 = -3031974433025990931L;
    java.lang.object f100bc0ee;
    java.lang.object f2063c160;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p7ded80f6$pe7a52b77 f3f021fd4;
    java.lang.object f4061b72f;
    java.lang.object f630e2ffc;
    java.lang.object f98f237d4;
    readonly io.reactivex.rxjava3.internal.operators.maybe.MaybeEqualSingle$EqualCoordinator<T> fd0e45878;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p7ded80f6$pe7a52b77 fdebc56c7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p7ded80f6$pe7a52b77 ff44d32d0;

    p7ded80f6$pa9bdabca(io.reactivex.rxjava3.internal.operators.maybe.MaybeEqualSingle$EqualCoordinator<T> maybeEqualSingle$EqualCoordinator) {
        this.fd0e45878 = maybeEqualSingle$EqualCoordinator;
    }

    public static void KOVKgNxBtMjCLnKk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p7ded80f6$pe7a52b77 p7ded80f6_pe7a52b77, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p7ded80f6$pa9bdabca p7ded80f6_pa9bdabca, java.lang.Exception th) {
        p7ded80f6_pe7a52b77.error(p7ded80f6_pa9bdabca, th);
    }

    public static bool WgcWAslMDToYwseH(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void BFQbJYalnNpJtChn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p7ded80f6$pe7a52b77 p7ded80f6_pe7a52b77) {
        p7ded80f6_pe7a52b77.done();
    }

    public static bool EPtcKjWDPPmrggSb(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void NbQTSqFvEIgoKdic(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p7ded80f6$pe7a52b77 p7ded80f6_pe7a52b77) {
        p7ded80f6_pe7a52b77.done();
    }

    public void Dispose() {
        ePtcKjWDPPmrggSb(this);
    }

    public override void OnComplete() {
        bFQbJYalnNpJtChn(this.fd0e45878);
    }

    public override void OnError(java.lang.Exception th) {
        KOVKgNxBtMjCLnKk(this.fd0e45878, this, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        WgcWAslMDToYwseH(this, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        this.f2063c160 = t;
        nbQTSqFvEIgoKdic(this.fd0e45878);
    }
}

