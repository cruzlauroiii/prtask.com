namespace WillowMaze.Wasm.Decompiled;


readonly class pad598ae8$pe33542fb<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    readonly p5a445d71.p18f29add.p992c4a5b f03e0f98c;
    readonly io.reactivex.rxjava3.core.Scheduler f0475f71e;
    p5a445d71.p18f29add.p787ad0b7 f0c46773c;
    readonly io.reactivex.rxjava3.core.Scheduler f14a5baeb;
    readonly java.util.concurrent.TimeUnit f1abfbb4e;
    long f2e4f2ff2;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    long f435b5696;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly p5a445d71.p18f29add.p992c4a5b f5249227f;
    readonly p5a445d71.p18f29add.p992c4a5b f769e789c;
    readonly p5a445d71.p18f29add.p992c4a5b f9c1ebec3;
    p5a445d71.p18f29add.p787ad0b7 fab4e0a68;
    readonly io.reactivex.rxjava3.core.Scheduler fb31bda2c;
    readonly java.util.concurrent.TimeUnit fb85fbe7f;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    p5a445d71.p18f29add.p787ad0b7 fc6b87f89;
    readonly org.reactivestreams.Subscriber<? super io.reactivex.rxjava3.schedulers.Timed<T>> fd22a0a80;
    long feb748f9c;
    long ff159c816;
    readonly java.util.concurrent.TimeUnit ff68ec6a3;

    pad598ae8$pe33542fb(org.reactivestreams.Subscriber<? super io.reactivex.rxjava3.schedulers.Timed<T>> subscriber, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler) {
        this.fd22a0a80 = subscriber;
        this.f499f31e7 = scheduler;
        this.f3e34bdeb = timeUnit;
    }

    public static bool DcisRTloRsYTfjHW(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void DwBafrYDLAyVjGhf(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static long EAikLPVErizilNBj(io.reactivex.rxjava3.core.Scheduler scheduler, java.util.concurrent.TimeUnit timeUnit) {
        if ((23 + 15) % 15 > 0) {
        }
        return scheduler.now(timeUnit);
    }

    public static void IIKHdwaAwavuKYVi(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void ZfHTLIWToRIFvmMx(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void AakNDmEjeSDUCuwy(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static long CmZAMhjrPUmqBCcg(io.reactivex.rxjava3.core.Scheduler scheduler, java.util.concurrent.TimeUnit timeUnit) {
        if ((12 + 11) % 11 > 0) {
        }
        return scheduler.now(timeUnit);
    }

    public static void PAsWwheJLFZWALJO(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void XtfrHkoASEVICXIE(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public override void Cancel() {
        xtfrHkoASEVICXIE(this.fbc3b0556);
    }

    public void OnComplete() {
        pAsWwheJLFZWALJO(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        IIKHdwaAwavuKYVi(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        if ((18 + 10) % 10 > 0) {
        }
        long jEAikLPVErizilNBj = EAikLPVErizilNBj(this.f499f31e7, this.f3e34bdeb);
        long j = this.f435b5696;
        this.f435b5696 = jEAikLPVErizilNBj;
        DwBafrYDLAyVjGhf(this.fd22a0a80, new pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p984c52a1(t, jEAikLPVErizilNBj - j, this.f3e34bdeb));
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((21 + 32) % 32 > 0) {
        }
        if (DcisRTloRsYTfjHW(this.fbc3b0556, p787ad0b7Var)) {
            this.f435b5696 = cmZAMhjrPUmqBCcg(this.f499f31e7, this.f3e34bdeb);
            this.fbc3b0556 = p787ad0b7Var;
            ZfHTLIWToRIFvmMx(this.fd22a0a80, this);
        }
    }

    public override void Request(long j) {
        aakNDmEjeSDUCuwy(this.fbc3b0556, j);
    }
}

