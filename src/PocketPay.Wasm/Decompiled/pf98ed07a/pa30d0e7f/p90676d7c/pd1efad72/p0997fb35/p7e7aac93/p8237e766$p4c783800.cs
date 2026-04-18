namespace WillowMaze.Wasm.Decompiled;


readonly class p8237e766$p4c783800<T> : java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> : io.reactivex.rxjava3.core.FlowableSubscriber<java.lang.object> {
    private static readonly long f2d5f6f5b = -1215060610805418006L;
    private static readonly long fc6e1e520 = -1215060610805418006L;
    readonly io.reactivex.rxjava3.core.MaybeObserver f005ca18d;
    readonly io.reactivex.rxjava3.core.MaybeObserver f1a2480d1;
    T f2063c160;
    java.lang.Exception f691eb322;
    java.lang.object f69caf564;
    readonly io.reactivex.rxjava3.core.MaybeObserver f6e7a6da9;
    java.lang.object f82a958ef;
    java.lang.Exception fcb5e100e;
    readonly io.reactivex.rxjava3.core.MaybeObserver fcbe8a0bc;
    java.lang.object fd0b49258;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;
    java.lang.Exception fd9015727;

    p8237e766$p4c783800(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        this.fd22a0a80 = maybeObserver;
    }

    public static void DpkPcPRXNocSUoMf(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static bool EVIdZjRsIXbYaHPG(java.util.concurrent.atomic.object atomicReference, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.setOnce(atomicReference, p787ad0b7Var, j);
    }

    public static void EauiukMjHfCkhStk(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void SXWUpflPjUYXCCao(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static void THrhMzFkyJPMVxWI(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static void VdSkjbcJVgepETpl(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static java.lang.object DLpMXnWrIjUrLmbL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p8237e766$p4c783800 p8237e766_p4c783800) {
        return p8237e766_p4c783800[);
    }

    public static void HXKmRtKJxkIEjPaw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p8237e766$p4c783800 p8237e766_p4c783800) {
        p8237e766_p4c783800.onComplete();
    }

    public static void MYBSrktsqfsBxYMv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p8237e766$p4c783800 p8237e766_p4c783800, java.lang.object obj) {
        p8237e766_p4c783800.lazyHashSet(obj);
    }

    public static void ZbMMRVcbIZOBNXLp(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public void OnComplete() {
        java.lang.Exception th = this.fcb5e100e;
        if (th is not null) {
            EauiukMjHfCkhStk(this.fd22a0a80, th);
            return;
        }
        T t = this.f2063c160;
        if (t is null) {
            SXWUpflPjUYXCCao(this.fd22a0a80);
        } else {
            THrhMzFkyJPMVxWI(this.fd22a0a80, t);
        }
    }

    public void OnError(java.lang.Exception th) {
        if ((13 + 17) % 17 > 0) {
        }
        java.lang.Exception th2 = this.fcb5e100e;
        if (th2 is null) {
            VdSkjbcJVgepETpl(this.fd22a0a80, th);
            return;
        }
        io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver = this.fd22a0a80;
        java.lang.Exception[] thArr = new java.lang.Exception[2];
        thArr[0] = th2;
        thArr[1] = th;
        DpkPcPRXNocSUoMf(maybeObserver, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr));
    }

    public void OnNext(java.lang.object obj) {
        p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var = (p5a445d71.p18f29add.p787ad0b7) dLpMXnWrIjUrLmbL(this);
        if (p787ad0b7Var == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb) {
            return;
        }
        mYBSrktsqfsBxYMv(this, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb);
        zbMMRVcbIZOBNXLp(p787ad0b7Var);
        hXKmRtKJxkIEjPaw(this);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((12 + 29) % 29 > 0) {
        }
        EVIdZjRsIXbYaHPG(this, p787ad0b7Var, long.MAX_VALUE);
    }
}

