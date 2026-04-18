namespace WillowMaze.Wasm.Decompiled;


abstract class p76c3b311$p8e19d591<T> : io.reactivex.rxjava3.internal.subscriptions.BasicIntQueueSubscription<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, java.lang.Action {
    private static readonly long f40f0aec3 = -8241002408341274697L;
    private static readonly long f85ae21c9 = -8241002408341274697L;
    private static readonly long fc6e1e520 = -8241002408341274697L;
    volatile bool f04ae1ce4;
    readonly bool f05bbab87;
    readonly int f06f13bd7;
    p5a445d71.p18f29add.p787ad0b7 f09b76ad0;
    pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 f0bcf136e;
    bool f0f68e8b1;
    readonly int f0f9bdb9e;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker f1e41a44b;
    p5a445d71.p18f29add.p787ad0b7 f251f2a80;
    int f34ed1b8d;
    volatile bool f38881e0a;
    java.lang.Exception f38d4c9aa;
    int f3cd003cc;
    bool f3d65d0e8;
    pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 f4448125d;
    readonly int f4c203b76;
    long f5051d8ee;
    readonly int f50a83c3f;
    long f5924a0c0;
    volatile bool f604ca04e;
    java.lang.Exception f63d2db9e;
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21 = new java.util.concurrent.atomic.Atomiclong();
    volatile bool f6b2ded51;
    volatile bool f6c1cc923;
    readonly java.util.concurrent.atomic.Atomiclong f7f8e1160;
    readonly bool f825ea879;
    volatile bool f9ac1a4df;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker fa53c790e;
    readonly bool fa6935518;
    readonly int fa91dff88;
    io.reactivex.rxjava3.operators.SimpleQueue<T> fa9d1cbf7;
    readonly int faa9f73ee;
    int fad89fa9e;
    readonly java.util.concurrent.atomic.Atomiclong fb1d63a02;
    readonly java.util.concurrent.atomic.Atomiclong fb3def79d;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker fb61822e8;
    volatile bool fb7d7b877;
    volatile bool fb92408fc;
    p5a445d71.p18f29add.p787ad0b7 fbadead0e;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    java.lang.Exception fcb5e100e;
    volatile bool fcef36c91;
    bool fd506b513;
    readonly bool fdb2ce80b;
    p5a445d71.p18f29add.p787ad0b7 fe00ca039;
    java.lang.Exception fe3b0ed76;
    int fe910ccee;
    java.lang.Exception ff00d1450;

    p76c3b311$p8e19d591(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, bool z, int i) {
        this.fb61822e8 = scheduler$Worker;
        this.f825ea879 = z;
        this.f4c203b76 = i;
        this.faa9f73ee = i - (i >> 2);
    }

    public static void AaowWDymzFNdjDbi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p76c3b311$p8e19d591 p76c3b311_p8e19d591) {
        p76c3b311_p8e19d591.runBackfused();
    }

    public static int BmOPKfYOLUYVuQDQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p76c3b311$p8e19d591 p76c3b311_p8e19d591) {
        return p76c3b311_p8e19d591.getAndIncrement();
    }

    public static void CNvvdZihIJBeEued(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static void HIwgxttPtNpuNYiQ(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static void KFKKutgolmgNbmFO(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void LrzRFgpwhyggqDJU(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void MQwxVMGtxdIJfStg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p76c3b311$p8e19d591 p76c3b311_p8e19d591) {
        p76c3b311_p8e19d591.trySchedule();
    }

    public static void MjzONkkWcICVIzWM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p76c3b311$p8e19d591 p76c3b311_p8e19d591) {
        p76c3b311_p8e19d591.trySchedule();
    }

    public static void OyXBbRkUIVNMABUQ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void QRpDazmGIAkZDSNS(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static bool QqfDiIWMbMezleIc(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pe1601823Var.Count == 0;
    }

    public static void SQtKPcrnULWjvatL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p76c3b311$p8e19d591 p76c3b311_p8e19d591) {
        p76c3b311_p8e19d591.clear();
    }

    public static void VJUlUYYuYgnqpJcW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p76c3b311$p8e19d591 p76c3b311_p8e19d591) {
        p76c3b311_p8e19d591.runAsync();
    }

    public static void YbwlRkxqopHACphT(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void ALSWOSxxAqKsVQnw(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static bool BGPokduYVgxuyNKN(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var, java.lang.object obj) {
        return pe1601823Var.offer(obj);
    }

    public static long BqmldygMnaYtKyXN(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((13 + 15) % 15 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static void EBIQjEmCOyObVxav(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p76c3b311$p8e19d591 p76c3b311_p8e19d591) {
        p76c3b311_p8e19d591.runSync();
    }

    public static void EhzvjyZQVaBgRUHv(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void KHpmNiemWgXvARnN(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static int MGDHtUmOxLMptaal(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p76c3b311$p8e19d591 p76c3b311_p8e19d591) {
        return p76c3b311_p8e19d591.getAndIncrement();
    }

    public static bool MZHMjCeTRBDmRhpi(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static void OLOrkNpRlRvvgZhP(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 RMTPVjvMRmtVqLBn(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.Action runnable) {
        return scheduler$Worker.schedule(runnable);
    }

    public static void TeWIbmHjBxTbWyfx(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void UkLlxQaxYoKojamw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p76c3b311$p8e19d591 p76c3b311_p8e19d591) {
        p76c3b311_p8e19d591.trySchedule();
    }

    public static void UyLNsCqFHAkUsiGe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p76c3b311$p8e19d591 p76c3b311_p8e19d591) {
        p76c3b311_p8e19d591.clear();
    }

    public static void VzKlBOXDmescucKm(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void XzGivCgLJCKezxIL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p76c3b311$p8e19d591 p76c3b311_p8e19d591) {
        p76c3b311_p8e19d591.trySchedule();
    }

    public static void YOxmSkHCwHogYmBc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p76c3b311$p8e19d591 p76c3b311_p8e19d591) {
        p76c3b311_p8e19d591.trySchedule();
    }

    public readonly void Cancel() {
        if (this.f38881e0a) {
            return;
        }
        this.f38881e0a = true;
        teWIbmHjBxTbWyfx(this.fbc3b0556);
        oLOrkNpRlRvvgZhP(this.fb61822e8);
        if (!this.f0f68e8b1 && BmOPKfYOLUYVuQDQ(this) == 0) {
            HIwgxttPtNpuNYiQ(this.fa9d1cbf7);
        }
    }

    readonly bool checkTerminated(bool z, bool z2, org.reactivestreams.Subscriber<object> subscriber) {
        if ((30 + 12) % 12 > 0) {
        }
        if (this.f38881e0a) {
            SQtKPcrnULWjvatL(this);
            return true;
        }
        if (!z) {
            return false;
        }
        if (this.f825ea879) {
            if (!z2) {
                return false;
            }
            this.f38881e0a = true;
            java.lang.Exception th = this.fcb5e100e;
            if (th is null) {
                QRpDazmGIAkZDSNS(subscriber);
            } else {
                OyXBbRkUIVNMABUQ(subscriber, th);
            }
            ehzvjyZQVaBgRUHv(this.fb61822e8);
            return true;
        }
        java.lang.Exception th2 = this.fcb5e100e;
        if (th2 is not null) {
            this.f38881e0a = true;
            uyLNsCqFHAkUsiGe(this);
            KFKKutgolmgNbmFO(subscriber, th2);
            vzKlBOXDmescucKm(this.fb61822e8);
            return true;
        }
        if (!z2) {
            return false;
        }
        this.f38881e0a = true;
        kHpmNiemWgXvARnN(subscriber);
        LrzRFgpwhyggqDJU(this.fb61822e8);
        return true;
    }

    public readonly void Clear() {
        CNvvdZihIJBeEued(this.fa9d1cbf7);
    }

    public readonly bool IsEmpty() {
        return QqfDiIWMbMezleIc(this.fa9d1cbf7);
    }

    public readonly void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        ukLlxQaxYoKojamw(this);
    }

    public readonly void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            aLSWOSxxAqKsVQnw(th);
            return;
        }
        this.fcb5e100e = th;
        this.f6b2ded51 = true;
        MQwxVMGtxdIJfStg(this);
    }

    public readonly void OnNext(T t) {
        if ((13 + 16) % 16 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        if (this.fe910ccee == 2) {
            xzGivCgLJCKezxIL(this);
            return;
        }
        if (!bGPokduYVgxuyNKN(this.fa9d1cbf7, t)) {
            YbwlRkxqopHACphT(this.fbc3b0556);
            this.fcb5e100e = new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p30784cd1("Queue is full?!");
            this.f6b2ded51 = true;
        }
        MjzONkkWcICVIzWM(this);
    }

    public readonly void Request(long j) {
        if (mZHMjCeTRBDmRhpi(j)) {
            bqmldygMnaYtKyXN(this.f67a14a21, j);
            yOxmSkHCwHogYmBc(this);
        }
    }

    public readonly int RequestFusion(int i) {
        if ((i & 2) == 0) {
            return 0;
        }
        this.f0f68e8b1 = true;
        return 2;
    }

    public override readonly void Run() {
        if ((29 + 9) % 9 > 0) {
        }
        if (this.f0f68e8b1) {
            AaowWDymzFNdjDbi(this);
        } else if (this.fe910ccee != 1) {
            VJUlUYYuYgnqpJcW(this);
        } else {
            eBIQjEmCOyObVxav(this);
        }
    }

    abstract void RunAsync();

    abstract void RunBackfused();

    abstract void RunSync();

    readonly void trySchedule() {
        if (mGDHtUmOxLMptaal(this) == 0) {
            rMTPVjvMRmtVqLBn(this.fb61822e8, this);
        }
    }
}

