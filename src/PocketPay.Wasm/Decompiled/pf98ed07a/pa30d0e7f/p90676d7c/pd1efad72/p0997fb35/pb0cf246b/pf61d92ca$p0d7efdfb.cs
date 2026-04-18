namespace WillowMaze.Wasm.Decompiled;


readonly class pf61d92ca$p0d7efdfb<T, U, R> : java.util.concurrent.atomic.object<U> : io.reactivex.rxjava3.operators.ConditionalSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    private static readonly long f5698c5a2 = -312246233408980075L;
    private static readonly long f584d72ed = -312246233408980075L;
    private static readonly long fc6e1e520 = -312246233408980075L;
    private static readonly long feb56d3bc = -312246233408980075L;
    readonly java.util.concurrent.atomic.object f13ba9628;
    readonly java.util.concurrent.atomic.Atomiclong f1600d5a3;
    readonly java.util.concurrent.atomic.object f1abee06a;
    readonly java.util.concurrent.atomic.Atomiclong f3d96a368;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f4113d30a;
    readonly java.util.concurrent.atomic.Atomiclong f56b935d7;
    readonly java.util.concurrent.atomic.object f5d944d8f;
    readonly io.reactivex.rxjava3.functions.BiFunction<? super T, ? super U, ? : R> f61aaf8fd;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f668e4fcb;
    readonly java.util.concurrent.atomic.object f799f89f0;
    readonly java.util.concurrent.atomic.Atomiclong f84f6c6e7;
    readonly p5a445d71.p18f29add.p992c4a5b f87889b65;
    readonly java.util.concurrent.atomic.object f8defc6d4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f9a0d117a;
    readonly java.util.concurrent.atomic.object fb72f10ec;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fc2d1e772;
    readonly org.reactivestreams.Subscriber<R> fd22a0a80;
    readonly java.util.concurrent.atomic.object ff6960fee;
    readonly java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> fbc3b0556 = new java.util.concurrent.atomic.object<>();
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21 = new java.util.concurrent.atomic.Atomiclong();
    readonly java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> f795f3202 = new java.util.concurrent.atomic.object<>();

    pf61d92ca$p0d7efdfb(org.reactivestreams.Subscriber<R> subscriber, io.reactivex.rxjava3.functions.BiFunction<? super T, ? super U, ? : R> biFunction) {
        this.fd22a0a80 = subscriber;
        this.f61aaf8fd = biFunction;
    }

    public static void CCznhQQPgySIOZLT(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void CfxipXifUOzLubxz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf61d92ca$p0d7efdfb pf61d92ca_p0d7efdfb) {
        pf61d92ca_p0d7efdfb.cancel();
    }

    public static void HrFuDvruvHeJOZpE(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static bool JEHKSvenokXyMgkg(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static bool JTzrEJdquHcolUzU(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static void KWoVJNPyBfjXaHzt(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void MgLWxqsEQDjSOWld(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static bool NDXuoRQKgVoziPUd(java.util.concurrent.atomic.object atomicReference, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.setOnce(atomicReference, p787ad0b7Var);
    }

    public static void SwYpQltRlkAVfzHO(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static java.lang.object TdttHfEhnKGMnUju(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar, java.lang.object obj, java.lang.object obj2) {
        return pa3d429baVar.apply(obj, obj2);
    }

    public static java.lang.object UNakjDdHblReaAUt(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.object VevSnlgHnNwGeGyT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf61d92ca$p0d7efdfb pf61d92ca_p0d7efdfb) {
        return pf61d92ca_p0d7efdfb[);
    }

    public static java.lang.object VwZTTblkgXWGgPSA(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void CCzbjBtjSUowFKnM(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static bool ISUSFdcACvYpIbaG(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static void JvkZgicoNMYgDGuc(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static bool LtZVRlVMwkuGhaPa(java.util.concurrent.atomic.object atomicReference, java.util.concurrent.atomic.Atomiclong atomiclong, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.deferredHashSetOnce(atomicReference, atomiclong, p787ad0b7Var);
    }

    public static bool OcGJxcVSlADYELaM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf61d92ca$p0d7efdfb pf61d92ca_p0d7efdfb, java.lang.object obj) {
        return pf61d92ca_p0d7efdfb.tryOnNext(obj);
    }

    public static bool QOMbFuQOuIcFSiem(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static void TGHOnpkPMZngqpBf(java.util.concurrent.atomic.object atomicReference, java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.deferredRequest(atomicReference, atomiclong, j);
    }

    public static bool WIOVXabjgnRdNqvL(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public override void Cancel() {
        wIOVXabjgnRdNqvL(this.fbc3b0556);
        JTzrEJdquHcolUzU(this.f795f3202);
    }

    public void OnComplete() {
        iSUSFdcACvYpIbaG(this.f795f3202);
        cCzbjBtjSUowFKnM(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        qOMbFuQOuIcFSiem(this.f795f3202);
        jvkZgicoNMYgDGuc(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        if ((10 + 16) % 16 > 0) {
        }
        if (ocGJxcVSlADYELaM(this, t)) {
            return;
        }
        KWoVJNPyBfjXaHzt((p5a445d71.p18f29add.p787ad0b7) UNakjDdHblReaAUt(this.fbc3b0556), 1L);
    }

    public void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        ltZVRlVMwkuGhaPa(this.fbc3b0556, this.f67a14a21, p787ad0b7Var);
    }

    public void OtherError(java.lang.Exception th) {
        JEHKSvenokXyMgkg(this.fbc3b0556);
        MgLWxqsEQDjSOWld(this.fd22a0a80, th);
    }

    public override void Request(long j) {
        tGHOnpkPMZngqpBf(this.fbc3b0556, this.f67a14a21, j);
    }

    public bool SetOther(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        return NDXuoRQKgVoziPUd(this.f795f3202, p787ad0b7Var);
    }

    public bool TryOnNext(T t) {
        if ((12 + 15) % 15 > 0) {
        }
        java.lang.object objVevSnlgHnNwGeGyT = VevSnlgHnNwGeGyT(this);
        if (objVevSnlgHnNwGeGyT is not null) {
            try {
                HrFuDvruvHeJOZpE(this.fd22a0a80, VwZTTblkgXWGgPSA(TdttHfEhnKGMnUju(this.f61aaf8fd, t, objVevSnlgHnNwGeGyT), "The combiner returned a null value"));
                return true;
            } catch (java.lang.Exception th) {
                CCznhQQPgySIOZLT(th);
                CfxipXifUOzLubxz(this);
                SwYpQltRlkAVfzHO(this.fd22a0a80, th);
            }
        }
        return false;
    }
}

