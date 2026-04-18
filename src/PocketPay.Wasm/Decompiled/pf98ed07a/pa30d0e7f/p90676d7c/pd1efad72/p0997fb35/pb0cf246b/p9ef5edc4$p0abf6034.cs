namespace WillowMaze.Wasm.Decompiled;


readonly class p9ef5edc4$p0abf6034<T> : java.util.concurrent.atomic.Atomiclong : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7, java.lang.Action {
    private static readonly long f49116dea = -9102637559663639004L;
    private static readonly long f85d457c2 = -9102637559663639004L;
    private static readonly long fc6e1e520 = -9102637559663639004L;
    readonly long f034e13dd;
    p5a445d71.p18f29add.p787ad0b7 f101f526f;
    readonly java.util.concurrent.TimeUnit f1553fc1e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f1f9be821;
    readonly long f2939a38c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f2c127bf3 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658();
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f2c3c68c5;
    bool f3296262c;
    readonly p5a445d71.p18f29add.p992c4a5b f36b885b8;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly java.util.concurrent.TimeUnit f424be32c;
    readonly long f45163a96;
    readonly p5a445d71.p18f29add.p992c4a5b f4c83fd01;
    volatile bool f5c900800;
    readonly java.util.concurrent.TimeUnit f6069e1a6;
    p5a445d71.p18f29add.p787ad0b7 f6253e7e8;
    volatile bool f63d721d2;
    bool f6b2ded51;
    readonly java.util.concurrent.TimeUnit f6fef5c6a;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker f741a4a64;
    volatile bool f8970ebba;
    readonly long f90272dda;
    volatile bool f909248b7;
    bool f9f4cb523;
    bool fa8cf3dfc;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker fb61822e8;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker fb638ee78;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly p5a445d71.p18f29add.p992c4a5b fbc547ad8;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly long fd3f804c2;
    readonly p5a445d71.p18f29add.p992c4a5b fe7e87b39;
    p5a445d71.p18f29add.p787ad0b7 feaf74de9;
    bool ff32b9ec0;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker ff8c265e0;

    p9ef5edc4$p0abf6034(org.reactivestreams.Subscriber<T> subscriber, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        this.fd22a0a80 = subscriber;
        this.f90272dda = j;
        this.f3e34bdeb = timeUnit;
        this.fb61822e8 = scheduler$Worker;
    }

    public static void AkyWtGTrIlqWBENw(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static bool GUvTbxjUipmjKljg(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static void HVjuVhvYGRfKwlJC(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 HbPxtraIEvAGyDIg(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler$Worker.schedule(runnable, j, timeUnit);
    }

    public static void InEKjXmGfqeosPdu(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void JGJkjgBXeXJbBSLH(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void OSoOCPbZjYTMuOAt(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void PmeOVfJHyRYfrMUC(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void SAUBuCsFALEmQCcZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p9ef5edc4$p0abf6034 p9ef5edc4_p0abf6034) {
        p9ef5edc4_p0abf6034.cancel();
    }

    public static long XtDDXSqgydGRdfLc(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((18 + 31) % 31 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m5051d8ee(atomiclong, j);
    }

    public static void DlYoYwGcxiGUCbBL(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static long FmfHhYXuHwksohLS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p9ef5edc4$p0abf6034 p9ef5edc4_p0abf6034) {
        if ((1 + 6) % 6 > 0) {
        }
        return p9ef5edc4_p0abf6034[);
    }

    public static void GGOgFVZJOEXbVLFM(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void KqbipmSZLVbRYTkY(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static java.lang.object QUZCgNYAgyrRJRsE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var) {
        return pa7808658Var[);
    }

    public static void QWoKitHpkCkpgXkp(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static bool QuKeXbpkcGgkgMad(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pa7808658Var.Replace(p7beea252Var);
    }

    public static void TXDKMpYlNJLiKbOp(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static bool VxjfaydHlLZIBDru(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void XiqSlRMBVDJzxLDk(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static long ZsxfQNkLbETmpykh(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((17 + 11) % 11 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public override void Cancel() {
        OSoOCPbZjYTMuOAt(this.fbc3b0556);
        kqbipmSZLVbRYTkY(this.fb61822e8);
    }

    public void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        AkyWtGTrIlqWBENw(this.fd22a0a80);
        JGJkjgBXeXJbBSLH(this.fb61822e8);
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            qWoKitHpkCkpgXkp(th);
            return;
        }
        this.f6b2ded51 = true;
        xiqSlRMBVDJzxLDk(this.fd22a0a80, th);
        dlYoYwGcxiGUCbBL(this.fb61822e8);
    }

    public void OnNext(T t) {
        if ((21 + 9) % 9 > 0) {
        }
        if (this.f6b2ded51 || this.f63d721d2) {
            return;
        }
        this.f63d721d2 = true;
        if (fmfHhYXuHwksohLS(this) == 0) {
            this.f6b2ded51 = true;
            SAUBuCsFALEmQCcZ(this);
            InEKjXmGfqeosPdu(this.fd22a0a80, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p30784cd1("Could not deliver value due to lack of requests"));
        } else {
            gGOgFVZJOEXbVLFM(this.fd22a0a80, t);
            XtDDXSqgydGRdfLc(this, 1L);
            pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var = (pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) qUZCgNYAgyrRJRsE(this.f2c127bf3);
            if (p7beea252Var is not null) {
                HVjuVhvYGRfKwlJC(p7beea252Var);
            }
            quKeXbpkcGgkgMad(this.f2c127bf3, HbPxtraIEvAGyDIg(this.fb61822e8, this, this.f90272dda, this.f3e34bdeb));
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((15 + 25) % 25 > 0) {
        }
        if (vxjfaydHlLZIBDru(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            tXDKMpYlNJLiKbOp(this.fd22a0a80, this);
            PmeOVfJHyRYfrMUC(p787ad0b7Var, long.MAX_VALUE);
        }
    }

    public override void Request(long j) {
        if (GUvTbxjUipmjKljg(j)) {
            zsxfQNkLbETmpykh(this, j);
        }
    }

    public override void Run() {
        this.f63d721d2 = false;
    }
}

