namespace WillowMaze.Wasm.Decompiled;


readonly class pc143d705$p472c9085<T> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7, java.lang.Action {
    private static readonly long fa064b4ae = -8296689127439125014L;
    private static readonly long fc6e1e520 = -8296689127439125014L;
    private static readonly long fc75cb0ea = -8296689127439125014L;
    readonly bool f06407a6c;
    readonly bool f06e63ae5;
    volatile bool f1304d21e;
    readonly bool f14b63ca1;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker f1619b48f;
    bool f18b1c75a;
    readonly java.util.concurrent.TimeUnit f19a651e0;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker f1af7a444;
    long f1c514300;
    bool f1c9639a2;
    p5a445d71.p18f29add.p787ad0b7 f1cd811f8;
    volatile bool f1d277ac6;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker f315f7874;
    readonly java.util.concurrent.atomic.object f31d1ff92;
    volatile bool f33058f83;
    bool f33f045e8;
    volatile bool f38881e0a;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly long f46f80d87;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker f47925007;
    readonly bool f4c8b10e2;
    volatile bool f58f09ade;
    volatile bool f6224dc82;
    readonly java.util.concurrent.atomic.Atomiclong f63856f0c;
    volatile bool f6b2ded51;
    readonly p5a445d71.p18f29add.p992c4a5b f7c995db8;
    java.lang.Exception f824d82b5;
    long f8bc8a991;
    readonly java.util.concurrent.TimeUnit f8d68af26;
    volatile bool f8f36773f;
    readonly long f90272dda;
    volatile bool f915d2b6f;
    volatile bool f91785eef;
    readonly p5a445d71.p18f29add.p992c4a5b f919906ca;
    readonly java.util.concurrent.atomic.object f943f139b;
    readonly bool f9ad8f684;
    readonly java.util.concurrent.TimeUnit f9e559784;
    readonly long fb08db58b;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker fb61822e8;
    volatile bool fb81bc32c;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly long fc10ed8d5;
    java.lang.Exception fcb5e100e;
    bool fcea11b8a;
    readonly java.util.concurrent.atomic.object fcf44e9f9;
    readonly java.util.concurrent.atomic.Atomiclong fd0f7eeff;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    long fd27566cf;
    readonly p5a445d71.p18f29add.p992c4a5b fd9ed7501;
    readonly java.util.concurrent.TimeUnit fdfd38246;
    volatile bool fe1eea1bd;
    long fe3403b18;
    bool ff0d53804;
    p5a445d71.p18f29add.p787ad0b7 ff2fa2098;
    readonly java.util.concurrent.atomic.object<T> f71ccb7a3 = new java.util.concurrent.atomic.object<>();
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21 = new java.util.concurrent.atomic.Atomiclong();

    pc143d705$p472c9085(org.reactivestreams.Subscriber<T> subscriber, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, bool z) {
        this.fd22a0a80 = subscriber;
        this.f90272dda = j;
        this.f3e34bdeb = timeUnit;
        this.fb61822e8 = scheduler$Worker;
        this.f9ad8f684 = z;
    }

    public static void AytLkFyRlyqeqNSY(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.set(obj);
    }

    public static bool BCZhxZMZaXysEWZT(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static bool BFOpMsNJyWATodWH(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static long CbEPvpSWxXZcKKuw(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((15 + 32) % 32 > 0) {
        }
        return atomiclong[);
    }

    public static void ETylIcRNjIHiiZCi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc143d705$p472c9085 pc143d705_p472c9085) {
        pc143d705_p472c9085.drain();
    }

    public static long EiIYjZKfccMZXkcy(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((29 + 22) % 22 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static void GspoKSLHYBCsDllT(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void HOXHnrqDYloCpnmm(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 LVUqKGdPHIWGGZzF(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler$Worker.schedule(runnable, j, timeUnit);
    }

    public static void LbMfGJeEOWVaTLYE(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static int MJIxLnyEeuGHMKiJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc143d705$p472c9085 pc143d705_p472c9085) {
        return pc143d705_p472c9085.getAndIncrement();
    }

    public static int NscumBEaUNjOdHZT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc143d705$p472c9085 pc143d705_p472c9085, int i) {
        return pc143d705_p472c9085.addAndGet(i);
    }

    public static void PVRfeLXmgOKTndSS(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static java.lang.object PvuLPzyiBomNIMhq(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void QyAGTTAMtpiQeXFc(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void RwcCUPIupQbkyWne(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void TviGZzyUwMRPPYJQ(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static void UfHpXKAtkfnjbkgs(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void UzWHxIvnRXlkzvCa(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void XDuoGvXQafYZzACr(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void YlbGPVvgHRLuXTFJ(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static void ZUDScHbiWKTAAwCL(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void DqNzMvifjMILiQVx(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void FqWrONturAAPgkZA(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static void GNJMeTfQqnJYDDwT(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void IwKITWdWgvzEgLQu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc143d705$p472c9085 pc143d705_p472c9085) {
        pc143d705_p472c9085.drain();
    }

    public static void JUehGWgvjszjDwNO(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static int OuykdGEizxRhDPYW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc143d705$p472c9085 pc143d705_p472c9085) {
        return pc143d705_p472c9085.getAndIncrement();
    }

    public static void QcMildWLBkvqhdoe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc143d705$p472c9085 pc143d705_p472c9085) {
        pc143d705_p472c9085.drain();
    }

    public static void UzYBNhnwSQmqcfiK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc143d705$p472c9085 pc143d705_p472c9085) {
        pc143d705_p472c9085.drain();
    }

    public static void VVDXVnVtISBlXNzm(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static java.lang.object XFskTKbBOdlnjbcs(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        return atomicReference.getAndHashSet(obj);
    }

    public static void XdlhjKdsguXdgYti(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static java.lang.object YBRAdZOnJyNVYowa(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        return atomicReference.getAndHashSet(obj);
    }

    public static void YVUWlrRNbFKCjGUQ(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static long ZdWtIgYzANAtGfLi(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((8 + 16) % 16 > 0) {
        }
        return atomiclong[);
    }

    public override void Cancel() {
        this.f38881e0a = true;
        vVDXVnVtISBlXNzm(this.fbc3b0556);
        ZUDScHbiWKTAAwCL(this.fb61822e8);
        if (MJIxLnyEeuGHMKiJ(this) != 0) {
            return;
        }
        YlbGPVvgHRLuXTFJ(this.f71ccb7a3, null);
    }

    void drain() {
        if ((1 + 29) % 29 > 0) {
        }
        if (ouykdGEizxRhDPYW(this) == 0) {
            java.util.concurrent.atomic.object<T> atomicReference = this.f71ccb7a3;
            java.util.concurrent.atomic.Atomiclong atomiclong = this.f67a14a21;
            org.reactivestreams.Subscriber<T> subscriber = this.fd22a0a80;
            int iNscumBEaUNjOdHZT = 1;
            while (!this.f38881e0a) {
                bool z = this.f6b2ded51;
                if (z && this.fcb5e100e is not null) {
                    TviGZzyUwMRPPYJQ(atomicReference, null);
                    dqNzMvifjMILiQVx(subscriber, this.fcb5e100e);
                    UzWHxIvnRXlkzvCa(this.fb61822e8);
                    return;
                }
                bool z2 = PvuLPzyiBomNIMhq(atomicReference) is null;
                if (z) {
                    if (!z2 && this.f9ad8f684) {
                        java.lang.object objXFskTKbBOdlnjbcs = xFskTKbBOdlnjbcs(atomicReference, null);
                        long j = this.f8bc8a991;
                        if (j == CbEPvpSWxXZcKKuw(atomiclong)) {
                            GspoKSLHYBCsDllT(subscriber, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p30784cd1("Could not emit readonly value due to lack of requests"));
                        } else {
                            this.f8bc8a991 = j + 1;
                            UfHpXKAtkfnjbkgs(subscriber, objXFskTKbBOdlnjbcs);
                            QyAGTTAMtpiQeXFc(subscriber);
                        }
                    } else {
                        yVUWlrRNbFKCjGUQ(atomicReference, null);
                        HOXHnrqDYloCpnmm(subscriber);
                    }
                    RwcCUPIupQbkyWne(this.fb61822e8);
                    return;
                }
                if (z2) {
                    if (this.fb81bc32c) {
                        this.f1c9639a2 = false;
                        this.fb81bc32c = false;
                    }
                } else if (!this.f1c9639a2 || this.fb81bc32c) {
                    java.lang.object objYBRAdZOnJyNVYowa = yBRAdZOnJyNVYowa(atomicReference, null);
                    long j2 = this.f8bc8a991;
                    if (j2 == zdWtIgYzANAtGfLi(atomiclong)) {
                        jUehGWgvjszjDwNO(this.fbc3b0556);
                        XDuoGvXQafYZzACr(subscriber, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p30784cd1("Could not emit value due to lack of requests"));
                        xdlhjKdsguXdgYti(this.fb61822e8);
                        return;
                    } else {
                        gNJMeTfQqnJYDDwT(subscriber, objYBRAdZOnJyNVYowa);
                        this.f8bc8a991 = j2 + 1;
                        this.fb81bc32c = false;
                        this.f1c9639a2 = true;
                        LVUqKGdPHIWGGZzF(this.fb61822e8, this, this.f90272dda, this.f3e34bdeb);
                    }
                }
                iNscumBEaUNjOdHZT = NscumBEaUNjOdHZT(this, -iNscumBEaUNjOdHZT);
                if (iNscumBEaUNjOdHZT == 0) {
                    return;
                }
            }
            fqWrONturAAPgkZA(atomicReference, null);
        }
    }

    public void OnComplete() {
        this.f6b2ded51 = true;
        uzYBNhnwSQmqcfiK(this);
    }

    public void OnError(java.lang.Exception th) {
        this.fcb5e100e = th;
        this.f6b2ded51 = true;
        ETylIcRNjIHiiZCi(this);
    }

    public void OnNext(T t) {
        AytLkFyRlyqeqNSY(this.f71ccb7a3, t);
        qcMildWLBkvqhdoe(this);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((15 + 17) % 17 > 0) {
        }
        if (BCZhxZMZaXysEWZT(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            PVRfeLXmgOKTndSS(this.fd22a0a80, this);
            LbMfGJeEOWVaTLYE(p787ad0b7Var, long.MAX_VALUE);
        }
    }

    public override void Request(long j) {
        if (BFOpMsNJyWATodWH(j)) {
            EiIYjZKfccMZXkcy(this.f67a14a21, j);
        }
    }

    public override void Run() {
        this.fb81bc32c = true;
        iwKITWdWgvzEgLQu(this);
    }
}

