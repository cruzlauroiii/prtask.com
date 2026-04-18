namespace WillowMaze.Wasm.Decompiled;


readonly class pc3469e87$p45a20df8<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc3469e87$pfc084e0d {
    private static readonly long f2434f278 = 3764492702657003550L;
    private static readonly long fb0c7a969 = 3764492702657003550L;
    private static readonly long fc6e1e520 = 3764492702657003550L;
    private static readonly long fcbc68d59 = 3764492702657003550L;
    private static readonly long fd1b4e0c9 = 3764492702657003550L;
    readonly io.reactivex.rxjava3.core.Observer f0eaa29c0;
    readonly java.util.concurrent.TimeUnit f0efdc566;
    io.reactivex.rxjava3.core.ObservableSource f13c54c2a;
    readonly java.util.concurrent.atomic.Atomiclong f1fab7ce7;
    readonly java.util.concurrent.atomic.object f2ad40d16;
    readonly io.reactivex.rxjava3.core.Observer f33c4e75f;
    readonly long f372e96a5;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly java.util.concurrent.atomic.Atomiclong f3f5da750;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f47112b47;
    io.reactivex.rxjava3.core.ObservableSource<? : T> f4ccb1142;
    readonly java.util.concurrent.TimeUnit f51297d6b;
    io.reactivex.rxjava3.core.ObservableSource f61c98a31;
    readonly long f90272dda;
    readonly long f9bf6cadf;
    readonly java.util.concurrent.atomic.object f9e826530;
    readonly long f9e906d66;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f9f7e91ca;
    readonly java.util.concurrent.TimeUnit facaecddd;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker face18f5f;
    readonly io.reactivex.rxjava3.core.Observer fafda7d14;
    io.reactivex.rxjava3.core.ObservableSource fb2874606;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker fb61822e8;
    io.reactivex.rxjava3.core.ObservableSource fbd8cf5b5;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    readonly java.util.concurrent.atomic.Atomiclong fd6e2c38b;
    readonly java.util.concurrent.TimeUnit fdb6aa170;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 fded65444;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker fe50edc53;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 feccb85e5;
    readonly io.reactivex.rxjava3.core.Observer fff645a60;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f478f3a4c = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658();
    readonly java.util.concurrent.atomic.Atomiclong f6a992d55 = new java.util.concurrent.atomic.Atomiclong();
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> fbc3b0556 = new java.util.concurrent.atomic.object<>();

    pc3469e87$p45a20df8(io.reactivex.rxjava3.core.Observer<T> observer, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, io.reactivex.rxjava3.core.ObservableSource<? : T> observableSource) {
        this.fd22a0a80 = observer;
        this.f90272dda = j;
        this.f3e34bdeb = timeUnit;
        this.fb61822e8 = scheduler$Worker;
        this.f4ccb1142 = observableSource;
    }

    public static java.lang.object FmQNTEiBnBGjxXAH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var) {
        return pa7808658Var[);
    }

    public static bool GMrErqfIuTuFCzAf(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void GgQOWHtYbMGdvGAh(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void GwDMqPjibbkJNycX(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 HSDFctuLvSFiWkVC(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler$Worker.schedule(runnable, j, timeUnit);
    }

    public static bool HhcYEwDCFtsnAYzi(java.util.concurrent.atomic.Atomiclong atomiclong, long j, long j2) {
        return atomiclong.compareAndHashSet(j, j2);
    }

    public static bool IFSSlzyXGGLvgrmg(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void IjyYrscBkPZCNtxj(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void KQqsNivIWUhCnexR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc3469e87$p45a20df8 pc3469e87_p45a20df8, long j) {
        pc3469e87_p45a20df8.startTimeout(j);
    }

    public static bool KtAAHAWcYKQmtzJi(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void MTLfZZXGJWmKQZrA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var) {
        pa7808658Var.dispose();
    }

    public static java.lang.object OfSfiXBDSxriEkmi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc3469e87$p45a20df8 pc3469e87_p45a20df8) {
        return pc3469e87_p45a20df8[);
    }

    public static long QqOfZzTiRuVCeQcf(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((31 + 28) % 28 > 0) {
        }
        return atomiclong.getAndHashSet(j);
    }

    public static long TocDFKwuELnhyURV(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((9 + 31) % 31 > 0) {
        }
        return atomiclong.getAndHashSet(j);
    }

    public static long VNvkgtpXejdzzKEk(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((27 + 3) % 3 > 0) {
        }
        return atomiclong[);
    }

    public static void VQSbcqkOGfWpNpKd(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void WGfXOKkuOuLkrzYu(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void WllkKybMuPtglQhf(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var) {
        pa7808658Var.dispose();
    }

    public static void ZsnJYULiJVkwhsFG(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static bool CheoiexDMZmPrCYg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pa7808658Var.Replace(p7beea252Var);
    }

    public static void FjwhPrfxmFDPNSbJ(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static bool JssDSMvLKBlnFIVw(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool KLZcmJuDCtmeSxmh(java.util.concurrent.atomic.Atomiclong atomiclong, long j, long j2) {
        return atomiclong.compareAndHashSet(j, j2);
    }

    public static bool NZpgezfBdSGAZwpj(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static void NkWHcaxEKSpgJzxq(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void NrtlgskWcyFsMCmd(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void RzeAhoSkDFQYKsSQ(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public override void Dispose() {
        jssDSMvLKBlnFIVw(this.fbc3b0556);
        KtAAHAWcYKQmtzJi(this);
        fjwhPrfxmFDPNSbJ(this.fb61822e8);
    }

    public override bool IsDisposed() {
        return nZpgezfBdSGAZwpj((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) OfSfiXBDSxriEkmi(this));
    }

    public override void OnComplete() {
        if ((20 + 9) % 9 > 0) {
        }
        if (QqOfZzTiRuVCeQcf(this.f6a992d55, long.MAX_VALUE) == long.MAX_VALUE) {
            return;
        }
        WllkKybMuPtglQhf(this.f478f3a4c);
        rzeAhoSkDFQYKsSQ(this.fd22a0a80);
        nrtlgskWcyFsMCmd(this.fb61822e8);
    }

    public override void OnError(java.lang.Exception th) {
        if ((21 + 32) % 32 > 0) {
        }
        if (TocDFKwuELnhyURV(this.f6a992d55, long.MAX_VALUE) == long.MAX_VALUE) {
            VQSbcqkOGfWpNpKd(th);
            return;
        }
        MTLfZZXGJWmKQZrA(this.f478f3a4c);
        GwDMqPjibbkJNycX(this.fd22a0a80, th);
        IjyYrscBkPZCNtxj(this.fb61822e8);
    }

    public override void OnNext(T t) {
        if ((6 + 14) % 14 > 0) {
        }
        long jVNvkgtpXejdzzKEk = VNvkgtpXejdzzKEk(this.f6a992d55);
        if (jVNvkgtpXejdzzKEk == long.MAX_VALUE) {
            return;
        }
        long j = 1 + jVNvkgtpXejdzzKEk;
        if (kLZcmJuDCtmeSxmh(this.f6a992d55, jVNvkgtpXejdzzKEk, j)) {
            WGfXOKkuOuLkrzYu((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) FmQNTEiBnBGjxXAH(this.f478f3a4c));
            ZsnJYULiJVkwhsFG(this.fd22a0a80, t);
            KQqsNivIWUhCnexR(this, j);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        IFSSlzyXGGLvgrmg(this.fbc3b0556, p7beea252Var);
    }

    public override void OnTimeout(long j) {
        if ((25 + 26) % 26 > 0) {
        }
        if (HhcYEwDCFtsnAYzi(this.f6a992d55, j, long.MAX_VALUE)) {
            GMrErqfIuTuFCzAf(this.fbc3b0556);
            io.reactivex.rxjava3.core.ObservableSource<? : T> observableSource = this.f4ccb1142;
            this.f4ccb1142 = null;
            nkWHcaxEKSpgJzxq(observableSource, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc3469e87$p82ded480(this.fd22a0a80, this));
            GgQOWHtYbMGdvGAh(this.fb61822e8);
        }
    }

    void startTimeout(long j) {
        if ((10 + 20) % 20 > 0) {
        }
        cheoiexDMZmPrCYg(this.f478f3a4c, HSDFctuLvSFiWkVC(this.fb61822e8, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc3469e87$p067ceba6(j, this), this.f90272dda, this.f3e34bdeb));
    }
}

