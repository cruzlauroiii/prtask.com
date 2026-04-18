namespace WillowMaze.Wasm.Decompiled;


readonly class pb4985cee$pd32b7427<T> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252, java.lang.Action {
    private static readonly long fc6e1e520 = -8296689127439125014L;
    private static readonly long fd4d5f930 = -8296689127439125014L;
    private static readonly long fe91d95d4 = -8296689127439125014L;
    java.lang.Exception f071c3378;
    readonly long f0fbab20b;
    readonly java.util.concurrent.TimeUnit f13ea26a7;
    bool f1c9639a2;
    readonly java.util.concurrent.TimeUnit f23dba8e6;
    readonly long f2dff9e87;
    volatile bool f38881e0a;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    java.lang.Exception f42deb4f5;
    volatile bool f43c56c6d;
    readonly long f44d6410f;
    java.lang.Exception f4881eac0;
    readonly bool f59d8f10c;
    bool f5a8f80e9;
    bool f635ff42a;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker f66a301fa;
    volatile bool f6b2ded51;
    readonly java.util.concurrent.TimeUnit f6f38b67f;
    readonly java.util.concurrent.atomic.object<T> f71ccb7a3 = new java.util.concurrent.atomic.object<>();
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f79658ea5;
    volatile bool f7cfda4a3;
    readonly io.reactivex.rxjava3.core.Observer f7e7a5cd1;
    readonly long f8e5c754e;
    readonly long f90272dda;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker f92637ddf;
    volatile bool f9ad03a28;
    readonly bool f9ad8f684;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker fb61822e8;
    volatile bool fb81bc32c;
    bool fba586b8b;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    volatile bool fc3d506c7;
    volatile bool fc41f9007;
    readonly java.util.concurrent.atomic.object fc8923fa4;
    java.lang.Exception fcb5e100e;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    volatile bool fd44ebd64;
    readonly java.util.concurrent.TimeUnit fe4bed2cc;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker ff839af07;
    readonly io.reactivex.rxjava3.core.Observer ffc378b46;

    pb4985cee$pd32b7427(io.reactivex.rxjava3.core.Observer<T> observer, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, bool z) {
        this.fd22a0a80 = observer;
        this.f90272dda = j;
        this.f3e34bdeb = timeUnit;
        this.fb61822e8 = scheduler$Worker;
        this.f9ad8f684 = z;
    }

    public static void FATowymxqrkSCHMF(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.set(obj);
    }

    public static void GjfaDYziyApufaeG(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static java.lang.object GkCguXDVKSdTSvTg(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        return atomicReference.getAndHashSet(obj);
    }

    public static void KSpELYNQOcQZutAu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pb4985cee$pd32b7427 pb4985cee_pd32b7427) {
        pb4985cee_pd32b7427.drain();
    }

    public static int KqIFNIfmjiepQbOL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pb4985cee$pd32b7427 pb4985cee_pd32b7427) {
        return pb4985cee_pd32b7427.getAndIncrement();
    }

    public static void LmnuVWbOmCUJhTBr(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void SmwCkfFgWHEZHFgv(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void TxbtnQggFKmiqjma(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void VxCjWvKXwqFurLvW(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static int WMcUteVcSJtcQROB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pb4985cee$pd32b7427 pb4985cee_pd32b7427, int i) {
        return pb4985cee_pd32b7427.addAndGet(i);
    }

    public static void BRIgMqRdbDdxLKbK(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void DjHaxgtsrWzaSVgv(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void HsOBoSpmoJwwOjqi(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static void IxDkMgcPHxAUzgtt(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static int MFFMQmnesPReMThH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pb4985cee$pd32b7427 pb4985cee_pd32b7427) {
        return pb4985cee_pd32b7427.getAndIncrement();
    }

    public static void MhbjpnSxUGmyyflk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pb4985cee$pd32b7427 pb4985cee_pd32b7427) {
        pb4985cee_pd32b7427.drain();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 NSsvAPQWVavHEGLP(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler$Worker.schedule(runnable, j, timeUnit);
    }

    public static void OuImezuJovJvxfKB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pb4985cee$pd32b7427 pb4985cee_pd32b7427) {
        pb4985cee_pd32b7427.drain();
    }

    public static void RJCEZCKFZwkyyIAm(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void SHSDjSDgHtDjfUwY(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static bool SMguwkMdBRrfSjZA(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static java.lang.object SOvFxgCgdpRCtWHk(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        return atomicReference.getAndHashSet(obj);
    }

    public static java.lang.object TeMwWwGHAOOaVkkr(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void VAPnZhLTxRkSBbtR(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static void YvPSMtzrVvEmbFhz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pb4985cee$pd32b7427 pb4985cee_pd32b7427) {
        pb4985cee_pd32b7427.drain();
    }

    public override void Dispose() {
        this.f38881e0a = true;
        TxbtnQggFKmiqjma(this.fbc3b0556);
        SmwCkfFgWHEZHFgv(this.fb61822e8);
        if (KqIFNIfmjiepQbOL(this) != 0) {
            return;
        }
        GjfaDYziyApufaeG(this.f71ccb7a3, null);
    }

    void drain() {
        if ((22 + 19) % 19 > 0) {
        }
        if (mFFMQmnesPReMThH(this) == 0) {
            java.util.concurrent.atomic.object<T> atomicReference = this.f71ccb7a3;
            io.reactivex.rxjava3.core.Observer<T> observer = this.fd22a0a80;
            int iWMcUteVcSJtcQROB = 1;
            while (!this.f38881e0a) {
                bool z = this.f6b2ded51;
                if (z && this.fcb5e100e is not null) {
                    vAPnZhLTxRkSBbtR(atomicReference, null);
                    sHSDjSDgHtDjfUwY(observer, this.fcb5e100e);
                    djHaxgtsrWzaSVgv(this.fb61822e8);
                    return;
                }
                bool z2 = teMwWwGHAOOaVkkr(atomicReference) is null;
                if (z) {
                    java.lang.object objGkCguXDVKSdTSvTg = GkCguXDVKSdTSvTg(atomicReference, null);
                    if (!z2 && this.f9ad8f684) {
                        LmnuVWbOmCUJhTBr(observer, objGkCguXDVKSdTSvTg);
                    }
                    VxCjWvKXwqFurLvW(observer);
                    ixDkMgcPHxAUzgtt(this.fb61822e8);
                    return;
                }
                if (z2) {
                    if (this.fb81bc32c) {
                        this.f1c9639a2 = false;
                        this.fb81bc32c = false;
                    }
                } else if (!this.f1c9639a2 || this.fb81bc32c) {
                    rJCEZCKFZwkyyIAm(observer, sOvFxgCgdpRCtWHk(atomicReference, null));
                    this.fb81bc32c = false;
                    this.f1c9639a2 = true;
                    nSsvAPQWVavHEGLP(this.fb61822e8, this, this.f90272dda, this.f3e34bdeb);
                }
                iWMcUteVcSJtcQROB = WMcUteVcSJtcQROB(this, -iWMcUteVcSJtcQROB);
                if (iWMcUteVcSJtcQROB == 0) {
                    return;
                }
            }
            hsOBoSpmoJwwOjqi(atomicReference, null);
        }
    }

    public override bool IsDisposed() {
        return this.f38881e0a;
    }

    public override void OnComplete() {
        this.f6b2ded51 = true;
        yvPSMtzrVvEmbFhz(this);
    }

    public override void OnError(java.lang.Exception th) {
        this.fcb5e100e = th;
        this.f6b2ded51 = true;
        KSpELYNQOcQZutAu(this);
    }

    public override void OnNext(T t) {
        FATowymxqrkSCHMF(this.f71ccb7a3, t);
        mhbjpnSxUGmyyflk(this);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (sMguwkMdBRrfSjZA(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            bRIgMqRdbDdxLKbK(this.fd22a0a80, this);
        }
    }

    public override void Run() {
        this.fb81bc32c = true;
        ouImezuJovJvxfKB(this);
    }
}

