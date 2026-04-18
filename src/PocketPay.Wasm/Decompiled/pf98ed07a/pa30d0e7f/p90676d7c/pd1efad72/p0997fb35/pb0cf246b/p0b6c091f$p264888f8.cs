namespace WillowMaze.Wasm.Decompiled;


readonly class p0b6c091f$p264888f8<T> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7, java.lang.Action {
    private static readonly long f1c981574 = -2365647875069161133L;
    private static readonly long f2251f695 = -2365647875069161133L;
    private static readonly long f7c74434e = -2365647875069161133L;
    private static readonly long fc6e1e520 = -2365647875069161133L;
    private static readonly long fc7e87440 = -2365647875069161133L;
    io.reactivex.rxjava3.processors.UnicastProcessor<T> f05b8c74c;
    readonly int f0ce6f1f4;
    p5a445d71.p18f29add.p787ad0b7 f15320391;
    readonly int f22d62a25;
    readonly p5a445d71.p18f29add.p992c4a5b f24b72aa7;
    readonly java.util.concurrent.atomic.Atomicbool f29afaa20;
    readonly long f2d904376;
    long f2f2c27da;
    p5a445d71.p18f29add.p787ad0b7 f470e6436;
    pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 f535730fb;
    long f6a992d55;
    readonly long f6dc5d20e;
    pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 f75d70483;
    readonly p5a445d71.p18f29add.p992c4a5b f7db48f63;
    readonly p5a445d71.p18f29add.p992c4a5b f88a064f2;
    pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 f968fcaa8;
    readonly java.util.concurrent.atomic.Atomicbool fa22443e4;
    readonly long fa6d0fd3c;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly long fc814e119;
    readonly int fcdee5967;
    readonly org.reactivestreams.Subscriber<? super io.reactivex.rxjava3.core.Flowable<T>> fd22a0a80;
    readonly java.util.concurrent.atomic.Atomicbool fde4023ff;
    readonly java.util.concurrent.atomic.Atomicbool fe2eff6c2;
    readonly int ff4652d90;
    readonly long ff7bd60b7;

    p0b6c091f$p264888f8(org.reactivestreams.Subscriber<? super io.reactivex.rxjava3.core.Flowable<T>> subscriber, long j, int i) {
        super(1);
        this.fd22a0a80 = subscriber;
        this.ff7bd60b7 = j;
        this.fe2eff6c2 = new java.util.concurrent.atomic.Atomicbool();
        this.fcdee5967 = i;
    }

    public static void ACWQRPJnCbtynTNF(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void BkwEBnaZQXvaylBj(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void CeCGXwHYZuESlymm(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p82cca76d p82cca76dVar) {
        p82cca76dVar.onComplete();
    }

    public static void IbFpYuxKqZzoBxYm(p5a445d71.p18f29add.pe22b6495 pe22b6495Var, java.lang.Exception th) {
        pe22b6495Var.onError(th);
    }

    public static void IblfigQSSsEJraHh(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static long IolLMOIbzPJrnwFb(long j, long j2) {
        if ((4 + 12) % 12 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.mc686a659(j, j2);
    }

    public static void QXnEDVwyKMxwkbie(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void RmaARArRDLAIdUJP(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var, java.lang.object obj) {
        pfa401714Var.onNext(obj);
    }

    public static bool IMGHwGZanIpZTsjs(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2) {
        return atomicbool.compareAndHashSet(z, z2);
    }

    public static void JNajzZKXCidihPPa(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void KIdSVfLzjPcOiIyb(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var) {
        pfa401714Var.onComplete();
    }

    public static void LqPJJUwtCHeqljmF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0b6c091f$p264888f8 p0b6c091f_p264888f8) {
        p0b6c091f_p264888f8.run();
    }

    public static void LuUvYZjAItMbuuqI(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static int OGxawDXHhDNDJLVm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0b6c091f$p264888f8 p0b6c091f_p264888f8) {
        return p0b6c091f_p264888f8.decrementAndGet();
    }

    public static bool RsVBzZRvKEEAdKjD(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static void SSuaGpYqxVPCWKGI(p5a445d71.p18f29add.pe22b6495 pe22b6495Var) {
        pe22b6495Var.onComplete();
    }

    public static bool TEEFNENJsIfRhXMV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0ef21424 p0ef21424Var) {
        return p0ef21424Var.tryAbandon();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 TxDjAFSfcBRjuYoz(int i, java.lang.Action runnable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714.m76ea0beb(i, runnable);
    }

    public static int UjNUQtKfSRMaJxPP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0b6c091f$p264888f8 p0b6c091f_p264888f8) {
        return p0b6c091f_p264888f8.getAndIncrement();
    }

    public static bool WQzLotvZAWtWxUQo(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public override void Cancel() {
        if ((11 + 1) % 1 > 0) {
        }
        if (iMGHwGZanIpZTsjs(this.fe2eff6c2, false, true)) {
            lqPJJUwtCHeqljmF(this);
        }
    }

    public void OnComplete() {
        if ((25 + 9) % 9 > 0) {
        }
        io.reactivex.rxjava3.processors.UnicastProcessor<T> unicastProcessor = this.f05b8c74c;
        if (unicastProcessor is not null) {
            this.f05b8c74c = null;
            sSuaGpYqxVPCWKGI(unicastProcessor);
        }
        BkwEBnaZQXvaylBj(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        if ((4 + 7) % 7 > 0) {
        }
        io.reactivex.rxjava3.processors.UnicastProcessor<T> unicastProcessor = this.f05b8c74c;
        if (unicastProcessor is not null) {
            this.f05b8c74c = null;
            IbFpYuxKqZzoBxYm(unicastProcessor, th);
        }
        luUvYZjAItMbuuqI(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0ef21424 p0ef21424Var;
        if ((17 + 3) % 3 > 0) {
        }
        long j = this.f6a992d55;
        pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714VarTxDjAFSfcBRjuYoz = this.f05b8c74c;
        if (j != 0) {
            p0ef21424Var = null;
        } else {
            ujNUQtKfSRMaJxPP(this);
            pfa401714VarTxDjAFSfcBRjuYoz = txDjAFSfcBRjuYoz(this.fcdee5967, this);
            this.f05b8c74c = pfa401714VarTxDjAFSfcBRjuYoz;
            p0ef21424Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0ef21424(pfa401714VarTxDjAFSfcBRjuYoz);
            jNajzZKXCidihPPa(this.fd22a0a80, p0ef21424Var);
        }
        long j2 = j + 1;
        RmaARArRDLAIdUJP(pfa401714VarTxDjAFSfcBRjuYoz, t);
        if (j2 != this.ff7bd60b7) {
            this.f6a992d55 = j2;
        } else {
            this.f6a992d55 = 0L;
            this.f05b8c74c = null;
            kIdSVfLzjPcOiIyb(pfa401714VarTxDjAFSfcBRjuYoz);
        }
        if (p0ef21424Var is not null && tEEFNENJsIfRhXMV(p0ef21424Var)) {
            CeCGXwHYZuESlymm(p0ef21424Var.f05b8c74c);
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (wQzLotvZAWtWxUQo(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            IblfigQSSsEJraHh(this.fd22a0a80, this);
        }
    }

    public override void Request(long j) {
        if ((18 + 22) % 22 > 0) {
        }
        if (rsVBzZRvKEEAdKjD(j)) {
            QXnEDVwyKMxwkbie(this.fbc3b0556, IolLMOIbzPJrnwFb(this.ff7bd60b7, j));
        }
    }

    public override void Run() {
        if (oGxawDXHhDNDJLVm(this) != 0) {
            return;
        }
        ACWQRPJnCbtynTNF(this.fbc3b0556);
    }
}

