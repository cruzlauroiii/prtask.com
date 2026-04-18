namespace WillowMaze.Wasm.Decompiled;


abstract class p2dc94426$pa72693c2<T> : java.util.concurrent.atomic.object<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7, java.lang.Action {
    private static readonly long f57573b86 = -3517602651313910099L;
    private static readonly long f9f765181 = -3517602651313910099L;
    private static readonly long fc6e1e520 = -3517602651313910099L;
    private static readonly long fd2771820 = -3517602651313910099L;
    p5a445d71.p18f29add.p787ad0b7 f1e161a23;
    readonly long f1ef57e10;
    readonly io.reactivex.rxjava3.core.Scheduler f359da366;
    readonly p5a445d71.p18f29add.p992c4a5b f3caaf1df;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly java.util.concurrent.atomic.Atomiclong f4e672f0c;
    readonly java.util.concurrent.atomic.Atomiclong f776619a0;
    readonly io.reactivex.rxjava3.core.Scheduler f8a869ac0;
    readonly long fa0acfa46;
    readonly java.util.concurrent.TimeUnit fa4fb4e80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 fb1f85fda;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly java.util.concurrent.atomic.Atomiclong fd0dd1501;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly java.util.concurrent.atomic.Atomiclong fd44b65dd;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 fd6f555f0;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 fef5c1433;
    readonly io.reactivex.rxjava3.core.Scheduler fefb283b4;
    readonly p5a445d71.p18f29add.p992c4a5b ffe2e5f34;
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21 = new java.util.concurrent.atomic.Atomiclong();
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f2c127bf3 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658();

    p2dc94426$pa72693c2(org.reactivestreams.Subscriber<T> subscriber, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler) {
        this.fd22a0a80 = subscriber;
        this.fa0acfa46 = j;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
    }

    public static void CJwEkvwgRVoLpYvK(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void CVkUmjrGMjbiZpBS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p2dc94426$pa72693c2 p2dc94426_pa72693c2) {
        p2dc94426_pa72693c2.cancelTimer();
    }

    public static java.lang.object DmOyNTvmbDxISznV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p2dc94426$pa72693c2 p2dc94426_pa72693c2, java.lang.object obj) {
        return p2dc94426_pa72693c2.getAndHashSet(obj);
    }

    public static bool GhDIGKSjvnGuxnZe(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void IPMfodJjvyBDFxVU(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p2dc94426$pa72693c2 p2dc94426_pa72693c2) {
        p2dc94426_pa72693c2.cancel();
    }

    public static void LKbXmUnmtwzPdXtF(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static long MGXElvPvBbucPXfi(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((3 + 6) % 6 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 PnSfzQuWjamsWZKU(io.reactivex.rxjava3.core.Scheduler scheduler, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler.schedulePeriodicallyDirect(runnable, j, j2, timeUnit);
    }

    public static void QLSBIBngcXOhFjqq(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void VaByvMheYhBRWlFK(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void ATOOpLrLiKiTUbPC(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void CtxtfScBRdHRKqUX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p2dc94426$pa72693c2 p2dc94426_pa72693c2) {
        p2dc94426_pa72693c2.complete();
    }

    public static void GnwptaavaRkdZcPL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p2dc94426$pa72693c2 p2dc94426_pa72693c2) {
        p2dc94426_pa72693c2.cancelTimer();
    }

    public static void JrYwnhCBJriPjZIR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p2dc94426$pa72693c2 p2dc94426_pa72693c2) {
        p2dc94426_pa72693c2.cancelTimer();
    }

    public static bool MCQMobCsXFbmWcqz(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static bool ORWcWfbVRToMwtsc(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static long TTcVfjwtgERMzuLR(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((2 + 29) % 29 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m5051d8ee(atomiclong, j);
    }

    public static long TfWwTHPmtkmRxIkH(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((8 + 10) % 10 > 0) {
        }
        return atomiclong[);
    }

    public static bool VNvjvHwMjIbINqrE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pa7808658Var.Replace(p7beea252Var);
    }

    public static void XFPTrqttKpjQbLOh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p2dc94426$pa72693c2 p2dc94426_pa72693c2, java.lang.object obj) {
        p2dc94426_pa72693c2.lazyHashSet(obj);
    }

    public static void YEaOyPlAeQtMfddY(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public override void Cancel() {
        CVkUmjrGMjbiZpBS(this);
        VaByvMheYhBRWlFK(this.fbc3b0556);
    }

    void cancelTimer() {
        GhDIGKSjvnGuxnZe(this.f2c127bf3);
    }

    abstract void Complete();

    void emit() {
        if ((19 + 11) % 11 > 0) {
        }
        java.lang.object objDmOyNTvmbDxISznV = DmOyNTvmbDxISznV(this, null);
        if (objDmOyNTvmbDxISznV is null) {
            return;
        }
        if (tfWwTHPmtkmRxIkH(this.f67a14a21) == 0) {
            IPMfodJjvyBDFxVU(this);
            CJwEkvwgRVoLpYvK(this.fd22a0a80, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p30784cd1("Couldn't emit value due to lack of requests!"));
        } else {
            LKbXmUnmtwzPdXtF(this.fd22a0a80, objDmOyNTvmbDxISznV);
            tTcVfjwtgERMzuLR(this.f67a14a21, 1L);
        }
    }

    public void OnComplete() {
        gnwptaavaRkdZcPL(this);
        ctxtfScBRdHRKqUX(this);
    }

    public void OnError(java.lang.Exception th) {
        jrYwnhCBJriPjZIR(this);
        QLSBIBngcXOhFjqq(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        xFPTrqttKpjQbLOh(this, t);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((3 + 29) % 29 > 0) {
        }
        if (oRWcWfbVRToMwtsc(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            yEaOyPlAeQtMfddY(this.fd22a0a80, this);
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var = this.f2c127bf3;
            io.reactivex.rxjava3.core.Scheduler scheduler = this.f499f31e7;
            long j = this.fa0acfa46;
            vNvjvHwMjIbINqrE(pa7808658Var, PnSfzQuWjamsWZKU(scheduler, this, j, j, this.f3e34bdeb));
            aTOOpLrLiKiTUbPC(p787ad0b7Var, long.MAX_VALUE);
        }
    }

    public override void Request(long j) {
        if (mCQMobCsXFbmWcqz(j)) {
            MGXElvPvBbucPXfi(this.f67a14a21, j);
        }
    }
}

