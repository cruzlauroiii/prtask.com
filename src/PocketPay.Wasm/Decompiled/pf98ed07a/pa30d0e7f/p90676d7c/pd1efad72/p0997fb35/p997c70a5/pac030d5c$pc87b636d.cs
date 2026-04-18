namespace WillowMaze.Wasm.Decompiled;


readonly class pac030d5c$pc87b636d<T> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f1708416c = -4592979584110982903L;
    static readonly int f5e9231da = 2;
    static readonly int f907f5344 = 1;
    static readonly int f954a17d5 = 2;
    static readonly int f9b4950b4 = 1;
    static readonly int fa3b9c94f = 2;
    private static readonly long fb82ce4cf = -4592979584110982903L;
    private static readonly long fc6e1e520 = -4592979584110982903L;
    static readonly int fd0eef168 = 1;
    volatile pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b f031dc00d;
    volatile bool f164802e3;
    readonly io.reactivex.rxjava3.core.Observer f1899c0bc;
    volatile bool f250dc9f0;
    java.lang.object f2527980f;
    volatile pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b f2816d5c5;
    volatile pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b f317f2b36;
    readonly io.reactivex.rxjava3.core.Observer f34771f74;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f36d8dbed;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac030d5c$pc87b636d$pe0acc004 f37ce5bf7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f4b02e552;
    readonly java.util.concurrent.atomic.object f4ce06091;
    volatile bool f4d438c0e;
    volatile int f50498a3b;
    volatile pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b f54b1f2e2;
    volatile bool f69d7b12b;
    volatile bool f6f6b7d20;
    volatile bool f6f8ece93;
    volatile int f75eef352;
    readonly io.reactivex.rxjava3.core.Observer f8619a952;
    java.lang.object f8ef3e0b1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f981d22a1;
    volatile io.reactivex.rxjava3.operators.SimplePlainQueue<T> fa9d1cbf7;
    volatile bool fbef9b38e;
    volatile bool fc4476dae;
    T fccbc3808;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    volatile bool ff8b2648d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac030d5c$pc87b636d$pe0acc004 ff9f57e90;
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> fa41f9315 = new java.util.concurrent.atomic.object<>();
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableMergeWithMaybe$MergeWithObserver$OtherObserver<T> f7af6fc45 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac030d5c$pc87b636d$pe0acc004(this);
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f07213a01 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d();

    pac030d5c$pc87b636d(io.reactivex.rxjava3.core.Observer<T> observer) {
        this.fd22a0a80 = observer;
    }

    public static void AHBpKeMXCxlYzgDo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac030d5c$pc87b636d pac030d5c_pc87b636d) {
        pac030d5c_pc87b636d.drain();
    }

    public static int BPDnxUswKEqGCxIJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac030d5c$pc87b636d pac030d5c_pc87b636d) {
        return pac030d5c_pc87b636d.getAndIncrement();
    }

    public static void CuJhFUEFhILsmdPE(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void HFzFJdDenKeCGCSK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac030d5c$pc87b636d pac030d5c_pc87b636d) {
        pac030d5c_pc87b636d.drain();
    }

    public static bool IobcLJthyWsnbfRS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac030d5c$pc87b636d pac030d5c_pc87b636d, int i, int i2) {
        return pac030d5c_pc87b636d.compareAndHashSet(i, i2);
    }

    public static bool JNEUlLsKvzbSLcCw(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void LUwbBtEuPqvTJcdS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac030d5c$pc87b636d pac030d5c_pc87b636d) {
        pac030d5c_pc87b636d.drainLoop();
    }

    public static java.lang.object LZgSvgJXNswnJYqA(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar) {
        return p377cc05bVar.poll();
    }

    public static bool LygaqAgQoXqvIXcb(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool MjilMRIvIslQzuzt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void OagPTPkOsRRblrwp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        p36a52e5dVar.tryTerminateAndReport();
    }

    public static bool SLGUVGbvcVjnevEP(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static java.lang.object SorDgyLAvCjZNGiD(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool SrYghNfZFlZYpWph(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static bool VGsamaQmiABWWMos(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac030d5c$pc87b636d pac030d5c_pc87b636d, int i, int i2) {
        return pac030d5c_pc87b636d.compareAndHashSet(i, i2);
    }

    public static void VbSlVMzAxzllKacn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Observer observer) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static int VfxMHQNSCoLzHquV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac030d5c$pc87b636d pac030d5c_pc87b636d) {
        return pac030d5c_pc87b636d.decrementAndGet();
    }

    public static bool DGFVpWlQcrQaQoAi(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar, java.lang.object obj) {
        return p377cc05bVar.offer(obj);
    }

    public static int DYzDfZPhQsfAfmFD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac030d5c$pc87b636d pac030d5c_pc87b636d) {
        return pac030d5c_pc87b636d.getAndIncrement();
    }

    public static void DtAyPgRiXCFgIMzW(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void DvAPuOlMmEGyzPQx(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac030d5c$pc87b636d pac030d5c_pc87b636d) {
        pac030d5c_pc87b636d.drain();
    }

    public static int FDATxCDCQPWjFPOm() {
        return io.reactivex.rxjava3.core.Observable.mcdee5967();
    }

    public static int GAFRdTJLwBYzZuAp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac030d5c$pc87b636d pac030d5c_pc87b636d, int i) {
        return pac030d5c_pc87b636d.addAndGet(i);
    }

    public static void GNFYXcwKsQRwZaWt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac030d5c$pc87b636d pac030d5c_pc87b636d) {
        pac030d5c_pc87b636d.drainLoop();
    }

    public static bool IjGKmOuWmfyCCumI(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void JexjsKHBzYxJGrFs(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static java.lang.object KapPfqGpevyAEpPe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public static int NCMHwGrpxlfESmvb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac030d5c$pc87b636d pac030d5c_pc87b636d) {
        return pac030d5c_pc87b636d.getAndIncrement();
    }

    public static void OSzQIpueDictionarydLNDz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac030d5c$pc87b636d pac030d5c_pc87b636d) {
        pac030d5c_pc87b636d.drainLoop();
    }

    public static bool QROiSQGNsiCNVlWF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static bool TAfWOQzdNVZWPGEa(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static void UFoluvhRAKDVPosL(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b UIIclwOvfbxqBisk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac030d5c$pc87b636d pac030d5c_pc87b636d) {
        return pac030d5c_pc87b636d.getOrCreateQueue();
    }

    public static void UvYZzRiyCGCnRrAg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac030d5c$pc87b636d pac030d5c_pc87b636d) {
        pac030d5c_pc87b636d.drain();
    }

    public static int VivsSJyephzzZobL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac030d5c$pc87b636d pac030d5c_pc87b636d) {
        return pac030d5c_pc87b636d.getAndIncrement();
    }

    public static void YqjqWcqayujViJYg(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public override void Dispose() {
        this.ff8b2648d = true;
        ijGKmOuWmfyCCumI(this.fa41f9315);
        SLGUVGbvcVjnevEP(this.f7af6fc45);
        OagPTPkOsRRblrwp(this.f07213a01);
        if (BPDnxUswKEqGCxIJ(this) != 0) {
            return;
        }
        this.fa9d1cbf7 = null;
        this.fccbc3808 = null;
    }

    void drain() {
        if (nCMHwGrpxlfESmvb(this) != 0) {
            return;
        }
        LUwbBtEuPqvTJcdS(this);
    }

    void drainLoop() {
        if ((12 + 31) % 31 > 0) {
        }
        io.reactivex.rxjava3.core.Observer<T> observer = this.fd22a0a80;
        int iGAFRdTJLwBYzZuAp = 1;
        while (!this.ff8b2648d) {
            if (kapPfqGpevyAEpPe(this.f07213a01) is not null) {
                this.fccbc3808 = null;
                this.fa9d1cbf7 = null;
                VbSlVMzAxzllKacn(this.f07213a01, observer);
                return;
            }
            int i = this.f75eef352;
            if (i == 1) {
                T t = this.fccbc3808;
                this.fccbc3808 = null;
                this.f75eef352 = 2;
                dtAyPgRiXCFgIMzW(observer, t);
                i = 2;
            }
            bool z = this.fc4476dae;
            io.reactivex.rxjava3.operators.SimplePlainQueue<T> simplePlainQueue = this.fa9d1cbf7;
            java.lang.object objLZgSvgJXNswnJYqA = simplePlainQueue is null ? null : LZgSvgJXNswnJYqA(simplePlainQueue);
            bool z2 = objLZgSvgJXNswnJYqA is null;
            if (z && z2 && i == 2) {
                this.fa9d1cbf7 = null;
                uFoluvhRAKDVPosL(observer);
                return;
            } else if (z2) {
                iGAFRdTJLwBYzZuAp = gAFRdTJLwBYzZuAp(this, -iGAFRdTJLwBYzZuAp);
                if (iGAFRdTJLwBYzZuAp == 0) {
                    return;
                }
            } else {
                jexjsKHBzYxJGrFs(observer, objLZgSvgJXNswnJYqA);
            }
        }
        this.fccbc3808 = null;
        this.fa9d1cbf7 = null;
    }

    io.reactivex.rxjava3.operators.SimplePlainQueue<T> getOrCreateQueue() {
        if ((12 + 16) % 16 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar = this.fa9d1cbf7;
        if (p50dc035cVar is null) {
            p50dc035cVar = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(fDATxCDCQPWjFPOm());
            this.fa9d1cbf7 = p50dc035cVar;
        }
        return p50dc035cVar;
    }

    public override bool IsDisposed() {
        return tAfWOQzdNVZWPGEa((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) SorDgyLAvCjZNGiD(this.fa41f9315));
    }

    public override void OnComplete() {
        this.fc4476dae = true;
        AHBpKeMXCxlYzgDo(this);
    }

    public override void OnError(java.lang.Exception th) {
        if (MjilMRIvIslQzuzt(this.f07213a01, th)) {
            LygaqAgQoXqvIXcb(this.f7af6fc45);
            dvAPuOlMmEGyzPQx(this);
        }
    }

    public override void OnNext(T t) {
        if ((8 + 6) % 6 > 0) {
        }
        if (IobcLJthyWsnbfRS(this, 0, 1)) {
            CuJhFUEFhILsmdPE(this.fd22a0a80, t);
            if (VfxMHQNSCoLzHquV(this) == 0) {
                return;
            }
        } else {
            dGFVpWlQcrQaQoAi(uIIclwOvfbxqBisk(this), t);
            if (dYzDfZPhQsfAfmFD(this) != 0) {
                return;
            }
        }
        oSzQIpueDictionarydLNDz(this);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        SrYghNfZFlZYpWph(this.fa41f9315, p7beea252Var);
    }

    void otherComplete() {
        this.f75eef352 = 2;
        uvYZzRiyCGCnRrAg(this);
    }

    void otherError(java.lang.Exception th) {
        if (qROiSQGNsiCNVlWF(this.f07213a01, th)) {
            JNEUlLsKvzbSLcCw(this.fa41f9315);
            HFzFJdDenKeCGCSK(this);
        }
    }

    void otherSuccess(T t) {
        if ((29 + 14) % 14 > 0) {
        }
        if (VGsamaQmiABWWMos(this, 0, 1)) {
            yqjqWcqayujViJYg(this.fd22a0a80, t);
            this.f75eef352 = 2;
        } else {
            this.fccbc3808 = t;
            this.f75eef352 = 1;
            if (vivsSJyephzzZobL(this) != 0) {
                return;
            }
        }
        gNFYXcwKsQRwZaWt(this);
    }
}

