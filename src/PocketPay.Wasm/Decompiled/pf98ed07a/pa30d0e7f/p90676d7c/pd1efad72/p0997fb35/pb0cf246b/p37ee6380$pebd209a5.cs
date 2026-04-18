namespace WillowMaze.Wasm.Decompiled;


abstract class p37ee6380$pebd209a5<T> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    private static readonly long f0cbcf470 = 5724293814035355511L;
    private static readonly long f1022aace = 5724293814035355511L;
    private static readonly long fc6e1e520 = 5724293814035355511L;
    private static readonly long fcf73b6e9 = 5724293814035355511L;
    private static readonly long fd6b8c131 = 5724293814035355511L;
    readonly p5a445d71.p18f29add.p992c4a5b f057b87e9;
    java.lang.Exception f0ee6ad68;
    volatile bool f10b07ec1;
    readonly int f1abb33e3;
    readonly java.util.concurrent.TimeUnit f1fb3f601;
    readonly long f2c6d5ee9;
    readonly int f36c64839;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    p5a445d71.p18f29add.p787ad0b7 f3e91df1c;
    long f3f9dc119;
    readonly java.util.concurrent.atomic.Atomicbool f4773d6d8;
    java.lang.Exception f4812e3fb;
    volatile bool f4ee70513;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b f4f78b32f;
    p5a445d71.p18f29add.p787ad0b7 f50b45b11;
    readonly java.util.concurrent.TimeUnit f66f01223;
    volatile bool f6b2ded51;
    p5a445d71.p18f29add.p787ad0b7 f7538512b;
    readonly java.util.concurrent.atomic.Atomiclong f7bb53052;
    readonly p5a445d71.p18f29add.p992c4a5b f7e8fe9f3;
    p5a445d71.p18f29add.p787ad0b7 f85beabd5;
    long f88d041d8;
    volatile bool f8ac5a3c5;
    readonly int f8b86c064;
    long f8bc8a991;
    readonly long f90150402;
    readonly java.util.concurrent.atomic.Atomicint f90d9eb9e;
    readonly java.util.concurrent.atomic.Atomicint f95ea974d;
    readonly p5a445d71.p18f29add.p992c4a5b f98574cc5;
    readonly int f9d07b322;
    volatile bool fa18f698b;
    long faceac67f;
    readonly java.util.concurrent.atomic.Atomiclong fb7a53569;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    long fc9203d20;
    java.lang.Exception fcb5e100e;
    readonly int fcdee5967;
    readonly org.reactivestreams.Subscriber<? super io.reactivex.rxjava3.core.Flowable<T>> fd22a0a80;
    readonly java.util.concurrent.atomic.Atomiclong fd99bf11d;
    readonly java.util.concurrent.atomic.Atomicbool fda2bfa41;
    java.lang.Exception fe44f99e4;
    volatile bool ffa492f05;
    readonly io.reactivex.rxjava3.operators.SimplePlainQueue<java.lang.object> fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d();
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21 = new java.util.concurrent.atomic.Atomiclong();
    readonly java.util.concurrent.atomic.Atomicbool f5a271fa2 = new java.util.concurrent.atomic.Atomicbool();
    readonly java.util.concurrent.atomic.Atomicint f461f4bb2 = new java.util.concurrent.atomic.Atomicint(1);

    p37ee6380$pebd209a5(org.reactivestreams.Subscriber<? super io.reactivex.rxjava3.core.Flowable<T>> subscriber, long j, java.util.concurrent.TimeUnit timeUnit, int i) {
        this.fd22a0a80 = subscriber;
        this.f90150402 = j;
        this.f3e34bdeb = timeUnit;
        this.fcdee5967 = i;
    }

    public static bool CeccrVyNyjcSsbSM(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static int JKgWWOSQvJCPZrEr(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static bool KrILeATZFTLhXKxv(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static void TGUFJrmcWUDeMkUj(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void AfTIpfwOhRFzezPo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p37ee6380$pebd209a5 p37ee6380_pebd209a5) {
        p37ee6380_pebd209a5.drain();
    }

    public static void FPoaTLCtltEriVxe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p37ee6380$pebd209a5 p37ee6380_pebd209a5) {
        p37ee6380_pebd209a5.drain();
    }

    public static bool FeIxtAvLBNencqhL(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2) {
        return atomicbool.compareAndHashSet(z, z2);
    }

    public static void IZVHCnsqhMSKZhND(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void JEGAkaZjJtSdDPLM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p37ee6380$pebd209a5 p37ee6380_pebd209a5) {
        p37ee6380_pebd209a5.drain();
    }

    public static void OfvyTqKLBBJqkKCh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p37ee6380$pebd209a5 p37ee6380_pebd209a5) {
        p37ee6380_pebd209a5.drain();
    }

    public static void PBYJDHjiWtgXDJaV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p37ee6380$pebd209a5 p37ee6380_pebd209a5) {
        p37ee6380_pebd209a5.createFirstWindow();
    }

    public static void RvhtVIjmYUkScZQk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p37ee6380$pebd209a5 p37ee6380_pebd209a5) {
        p37ee6380_pebd209a5.cleanupResources();
    }

    public static long TzViZGCdKTQPZZtU(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((12 + 18) % 18 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static void VtrAAIqMvabmUBfF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p37ee6380$pebd209a5 p37ee6380_pebd209a5) {
        p37ee6380_pebd209a5.windowDone();
    }

    public static bool XrFBZBHWFhyxyeUS(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar, java.lang.object obj) {
        return p377cc05bVar.offer(obj);
    }

    public override readonly void Cancel() {
        if ((29 + 1) % 1 > 0) {
        }
        if (feIxtAvLBNencqhL(this.f5a271fa2, false, true)) {
            vtrAAIqMvabmUBfF(this);
        }
    }

    abstract void CleanupResources();

    abstract void CreateFirstWindow();

    abstract void Drain();

    public readonly void OnComplete() {
        this.f6b2ded51 = true;
        afTIpfwOhRFzezPo(this);
    }

    public readonly void OnError(java.lang.Exception th) {
        this.fcb5e100e = th;
        this.f6b2ded51 = true;
        fPoaTLCtltEriVxe(this);
    }

    public readonly void OnNext(T t) {
        xrFBZBHWFhyxyeUS(this.fa9d1cbf7, t);
        jEGAkaZjJtSdDPLM(this);
    }

    public override readonly void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (CeccrVyNyjcSsbSM(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            TGUFJrmcWUDeMkUj(this.fd22a0a80, this);
            pBYJDHjiWtgXDJaV(this);
        }
    }

    public override readonly void Request(long j) {
        if (KrILeATZFTLhXKxv(j)) {
            tzViZGCdKTQPZZtU(this.f67a14a21, j);
        }
    }

    readonly void windowDone() {
        if (JKgWWOSQvJCPZrEr(this.f461f4bb2) != 0) {
            return;
        }
        rvhtVIjmYUkScZQk(this);
        iZVHCnsqhMSKZhND(this.fbc3b0556);
        this.f4ee70513 = true;
        ofvyTqKLBBJqkKCh(this);
    }
}

