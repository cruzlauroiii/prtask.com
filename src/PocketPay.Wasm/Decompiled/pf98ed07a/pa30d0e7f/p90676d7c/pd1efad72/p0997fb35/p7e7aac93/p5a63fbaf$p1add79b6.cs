namespace WillowMaze.Wasm.Decompiled;


readonly class p5a63fbaf$p1add79b6<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.MaybeObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252, java.lang.Action {
    private static readonly long f138af30b = 5566860102500855068L;
    private static readonly long f3a6449fe = 5566860102500855068L;
    private static readonly long fb4ab5ab9 = 5566860102500855068L;
    private static readonly long fc6e1e520 = 5566860102500855068L;
    readonly io.reactivex.rxjava3.core.MaybeObserver f1af5ba52;
    T f2063c160;
    java.lang.Exception f2b8ddd11;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly io.reactivex.rxjava3.core.Scheduler f43363957;
    java.lang.object f4844a0fd;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly java.util.concurrent.TimeUnit f4b4630bd;
    java.lang.object f511d67d7;
    java.lang.object f6354bb46;
    readonly bool f68a13ba7;
    readonly long f7243f8be;
    java.lang.Exception f72e951ad;
    readonly bool f825ea879;
    readonly io.reactivex.rxjava3.core.Scheduler f931c7a40;
    readonly java.util.concurrent.TimeUnit f9feb7eac;
    readonly java.util.concurrent.TimeUnit fad88fb00;
    java.lang.object fb4ee51ca;
    readonly io.reactivex.rxjava3.core.MaybeObserver fb5b5210c;
    readonly long fc6a09646;
    java.lang.Exception fcb5e100e;
    readonly io.reactivex.rxjava3.core.Scheduler fcd9be897;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;
    java.lang.Exception fdb1adf2c;
    readonly bool fe4706174;

    p5a63fbaf$p1add79b6(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, bool z) {
        this.fd22a0a80 = maybeObserver;
        this.f7243f8be = j;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.f825ea879 = z;
    }

    public static bool ICvZhOeyRMQqfroG(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static java.lang.object JUGyHHhFyaRmIudf(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5a63fbaf$p1add79b6 p5a63fbaf_p1add79b6) {
        return p5a63fbaf_p1add79b6[);
    }

    public static void KXCSAWzLrZTTQqtf(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5a63fbaf$p1add79b6 p5a63fbaf_p1add79b6, long j) {
        p5a63fbaf_p1add79b6.schedule(j);
    }

    public static void NWaiviGpihJlAKUO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5a63fbaf$p1add79b6 p5a63fbaf_p1add79b6, long j) {
        p5a63fbaf_p1add79b6.schedule(j);
    }

    public static bool UdfMzEZYSKrXfihr(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void VQneFbPYcTlVNvom(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static void YFzYLsLefLuxZxVp(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static void BCNMevyVVarhKoDR(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 HiYxHHqNroNfKopx(io.reactivex.rxjava3.core.Scheduler scheduler, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler.scheduleDirect(runnable, j, timeUnit);
    }

    public static bool RKbLtcWkIqgEbvgn(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static bool SfnzsngLfgqUKzty(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void ViWcOQJgasLMgUKP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5a63fbaf$p1add79b6 p5a63fbaf_p1add79b6, long j) {
        p5a63fbaf_p1add79b6.schedule(j);
    }

    public static void ZvOnYOkomQMLyRir(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public override void Dispose() {
        sfnzsngLfgqUKzty(this);
    }

    public override bool IsDisposed() {
        return rKbLtcWkIqgEbvgn((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) JUGyHHhFyaRmIudf(this));
    }

    public override void OnComplete() {
        if ((28 + 3) % 3 > 0) {
        }
        viWcOQJgasLMgUKP(this, this.f7243f8be);
    }

    public override void OnError(java.lang.Exception th) {
        if ((26 + 1) % 1 > 0) {
        }
        this.fcb5e100e = th;
        KXCSAWzLrZTTQqtf(this, !this.f825ea879 ? 0L : this.f7243f8be);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (UdfMzEZYSKrXfihr(this, p7beea252Var)) {
            YFzYLsLefLuxZxVp(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        if ((3 + 14) % 14 > 0) {
        }
        this.f2063c160 = t;
        NWaiviGpihJlAKUO(this, this.f7243f8be);
    }

    public override void Run() {
        java.lang.Exception th = this.fcb5e100e;
        if (th is not null) {
            zvOnYOkomQMLyRir(this.fd22a0a80, th);
            return;
        }
        T t = this.f2063c160;
        if (t is null) {
            bCNMevyVVarhKoDR(this.fd22a0a80);
        } else {
            VQneFbPYcTlVNvom(this.fd22a0a80, t);
        }
    }

    void schedule(long j) {
        if ((23 + 20) % 20 > 0) {
        }
        ICvZhOeyRMQqfroG(this, hiYxHHqNroNfKopx(this.f499f31e7, this, j, this.f3e34bdeb));
    }
}

