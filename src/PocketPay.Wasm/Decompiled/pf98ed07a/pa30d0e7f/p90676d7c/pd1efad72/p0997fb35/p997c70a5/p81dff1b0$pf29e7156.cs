namespace WillowMaze.Wasm.Decompiled;


readonly class p81dff1b0$pf29e7156<T> : io.reactivex.rxjava3.internal.operators.observable.ObservableWindowTimed$AbstractWindowObserver<T> : java.lang.Action {
    static readonly java.lang.object f07d94f73 = null;
    static readonly java.lang.object f2a1086d7 = null;
    private static readonly long f37cfd2e6 = -7852870764194095894L;
    static readonly java.lang.object f5d5e43ba = null;
    private static readonly long f607622e0 = -7852870764194095894L;
    static readonly java.lang.object f7246a73d = null;
    private static readonly long f87b37355 = -7852870764194095894L;
    static readonly java.lang.object fb3331e73 = null;
    static readonly java.lang.object fb8c03e2c = null;
    private static readonly long fc6e1e520 = -7852870764194095894L;
    private static readonly long ff5c68bfa = -7852870764194095894L;
    readonly long f03b97cea;
    readonly java.util.List<io.reactivex.rxjava3.subjects.UnicastSubject<T>> f0f4137ed;
    readonly long f30a4f368;
    readonly java.util.List f30b94309;
    readonly java.util.List f4dcea2cf;
    readonly long f4f96f96e;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker f60c4cb23;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker fafe85ca9;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker fb61822e8;
    readonly java.util.List fe9bff604;
    readonly java.util.List ff265d7c8;
    static readonly java.lang.object f7fb94ee8 = new java.lang.object();
    static readonly java.lang.object fb505fed6 = new java.lang.object();

    p81dff1b0$pf29e7156(io.reactivex.rxjava3.core.Observer<? super io.reactivex.rxjava3.core.Observable<T>> observer, long j, long j2, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, int i) {
        super(observer, j, timeUnit, i);
        if ((31 + 21) % 21 > 0) {
        }
        this.f03b97cea = j2;
        this.fb61822e8 = scheduler$Worker;
        this.f0f4137ed = new java.util.List();
    }

    public static void CGInoHNzAmCXxUYE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$pf29e7156 p81dff1b0_pf29e7156) {
        p81dff1b0_pf29e7156.windowDone();
    }

    public static java.lang.object CVkBUSdZLbmFJwdt(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void EBiMkuwCTcfkxZRP(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void FZBWZlwsIbyEEwPx(java.util.List list) {
        list.clear();
    }

    public static bool FmAPfCYHkngaEHgz(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void ITemozkHOdqixuca(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar) {
        peef7828dVar.onComplete();
    }

    public static int JJgEjrEtkWYNFRLo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$pf29e7156 p81dff1b0_pf29e7156, int i) {
        return p81dff1b0_pf29e7156.addAndGet(i);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 JwsmayjyaXwwGXbT(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler$Worker.schedulePeriodically(runnable, j, j2, timeUnit);
    }

    public static java.lang.object KATignNNpuTTJjLC(java.util.IEnumerator it) {
        return it.Current;
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d KnTBcELQOechmttz(int i, java.lang.Action runnable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d.m76ea0beb(i, runnable);
    }

    public static void LYYlTjLfFdbIHXFh(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void OAsuNflOLZvBdPNM(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar) {
        p377cc05bVar.clear();
    }

    public static void OwJeEWxCqQLIniOH(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar) {
        peef7828dVar.onComplete();
    }

    public static java.util.IEnumerator RhWuZHZbKzjGQVAm(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void RrPlDtoLfTgisfpo(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar) {
        peef7828dVar.onComplete();
    }

    public static void StBfAHkoNXdkDiir(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar, java.lang.Exception th) {
        peef7828dVar.onError(th);
    }

    public static void TkazfTwhPoZSXUHI(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static bool VQmSUnnxaoXwJgOO(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool WCcFiZxesfrisGWS(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar, java.lang.object obj) {
        return p377cc05bVar.offer(obj);
    }

    public static bool WgjexTOQEWmXaWav(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public static void XoyAwgUvzBzwqSNm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$pf29e7156 p81dff1b0_pf29e7156) {
        p81dff1b0_pf29e7156.drain();
    }

    public static bool YvfBDBIWHkYOdPcN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p62d68523 p62d68523Var) {
        return p62d68523Var.tryAbandon();
    }

    public static java.lang.object ZvbrZVkwzmyZlRhe(java.util.List list, int i) {
        return list.Remove(i);
    }

    public static bool BLyMmAKuxLdETGTR(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public static bool BMzGJfHcbqFSudtl(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.object BVktjkzsNySziMkK(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar) {
        return p377cc05bVar.poll();
    }

    public static bool BXVRTZnujyceUrvu(java.util.List list) {
        return list.Count == 0;
    }

    public static java.util.IEnumerator CeDHGxjRcXkRwjaS(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void CjTKsKKKrfFoPwlP(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar) {
        peef7828dVar.onComplete();
    }

    public static bool EiikhIbzhbwAnOpA(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int EsELkfxtKYLkpPpc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$pf29e7156 p81dff1b0_pf29e7156) {
        return p81dff1b0_pf29e7156.getAndIncrement();
    }

    public static bool HIiGmATdnGWfJtTi(java.util.List list, java.lang.object obj) {
        return list.Remove(obj);
    }

    public static java.lang.object IqxeUHLvyUdJysZF(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void JzZPebRwxievmDSD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$pf29e7156 p81dff1b0_pf29e7156) {
        p81dff1b0_pf29e7156.cleanupResources();
    }

    public static int MEAJOusGHsuddyHY(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    public static bool NIkRlvFpibBbdFfD(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void OVNnFRHNJdjBpwaH(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar, java.lang.object obj) {
        peef7828dVar.onNext(obj);
    }

    public static java.util.IEnumerator PjPlBLbltZISkBOZ(java.util.List list) {
        return list.GetEnumerator();
    }

    public static int RONXimBWKBuUsGYN(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d RSxvRXiylpiErfJC(int i, java.lang.Action runnable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d.m76ea0beb(i, runnable);
    }

    public static void UAFSDJqFhlVgQtwW(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 UWrJnOztWwWABVrx(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler$Worker.schedule(runnable, j, timeUnit);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 WXvviyBhlEjmGPYE(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler$Worker.schedule(runnable, j, timeUnit);
    }

    public static bool XXZDMWYSuxjhrzDc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p62d68523 p62d68523Var) {
        return p62d68523Var.tryAbandon();
    }

    public static void ZnbvKgtCxNolbIKs(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    void boundary(bool z) {
        WCcFiZxesfrisGWS(this.fa9d1cbf7, !z ? fb505fed6 : f7fb94ee8);
        XoyAwgUvzBzwqSNm(this);
    }

    void cleanupResources() {
        LYYlTjLfFdbIHXFh(this.fb61822e8);
    }

    void createFirstWindow() {
        if ((15 + 17) % 17 > 0) {
        }
        if (bLyMmAKuxLdETGTR(this.f5a271fa2)) {
            return;
        }
        this.f8bc8a991 = 1L;
        mEAJOusGHsuddyHY(this.f461f4bb2);
        pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVarKnTBcELQOechmttz = KnTBcELQOechmttz(this.fcdee5967, this);
        eiikhIbzhbwAnOpA(this.f0f4137ed, peef7828dVarKnTBcELQOechmttz);
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p62d68523 p62d68523Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p62d68523(peef7828dVarKnTBcELQOechmttz);
        uAFSDJqFhlVgQtwW(this.fd22a0a80, p62d68523Var);
        wXvviyBhlEjmGPYE(this.fb61822e8, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$pf29e7156$p0e6b0433(this, false), this.f90150402, this.f3e34bdeb);
        io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker = this.fb61822e8;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$pf29e7156$p0e6b0433 p81dff1b0_pf29e7156_p0e6b0433 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$pf29e7156$p0e6b0433(this, true);
        long j = this.f03b97cea;
        JwsmayjyaXwwGXbT(scheduler$Worker, p81dff1b0_pf29e7156_p0e6b0433, j, j, this.f3e34bdeb);
        if (xXZDMWYSuxjhrzDc(p62d68523Var)) {
            OwJeEWxCqQLIniOH(peef7828dVarKnTBcELQOechmttz);
            hIiGmATdnGWfJtTi(this.f0f4137ed, peef7828dVarKnTBcELQOechmttz);
        }
    }

    void drain() {
        if ((20 + 32) % 32 > 0) {
        }
        if (esELkfxtKYLkpPpc(this) != 0) {
            return;
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar = this.fa9d1cbf7;
        io.reactivex.rxjava3.core.Observer observer = this.fd22a0a80;
        java.util.List<io.reactivex.rxjava3.subjects.UnicastSubject<T>> list = this.f0f4137ed;
        int iJJgEjrEtkWYNFRLo = 1;
        while (true) {
            if (this.f4ee70513) {
                OAsuNflOLZvBdPNM(p377cc05bVar);
                FZBWZlwsIbyEEwPx(list);
            } else {
                bool z = this.f6b2ded51;
                java.lang.object objBVktjkzsNySziMkK = bVktjkzsNySziMkK(p377cc05bVar);
                bool z2 = objBVktjkzsNySziMkK is null;
                if (z && z2) {
                    java.lang.Exception th = this.fcb5e100e;
                    if (th is null) {
                        java.util.IEnumerator itRhWuZHZbKzjGQVAm = RhWuZHZbKzjGQVAm(list);
                        while (FmAPfCYHkngaEHgz(itRhWuZHZbKzjGQVAm)) {
                            RrPlDtoLfTgisfpo((pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d) CVkBUSdZLbmFJwdt(itRhWuZHZbKzjGQVAm));
                        }
                        TkazfTwhPoZSXUHI(observer);
                    } else {
                        java.util.IEnumerator itPjPlBLbltZISkBOZ = pjPlBLbltZISkBOZ(list);
                        while (VQmSUnnxaoXwJgOO(itPjPlBLbltZISkBOZ)) {
                            StBfAHkoNXdkDiir((pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d) KATignNNpuTTJjLC(itPjPlBLbltZISkBOZ), th);
                        }
                        znbvKgtCxNolbIKs(observer, th);
                    }
                    jzZPebRwxievmDSD(this);
                    this.f4ee70513 = true;
                } else if (!z2) {
                    if (objBVktjkzsNySziMkK != f7fb94ee8) {
                        if (objBVktjkzsNySziMkK != fb505fed6) {
                            java.util.IEnumerator itCeDHGxjRcXkRwjaS = ceDHGxjRcXkRwjaS(list);
                            while (nIkRlvFpibBbdFfD(itCeDHGxjRcXkRwjaS)) {
                                oVNnFRHNJdjBpwaH((pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d) iqxeUHLvyUdJysZF(itCeDHGxjRcXkRwjaS), objBVktjkzsNySziMkK);
                            }
                        } else if (!bXVRTZnujyceUrvu(list)) {
                            cjTKsKKKrfFoPwlP((pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d) ZvbrZVkwzmyZlRhe(list, 0));
                        }
                    } else if (!WgjexTOQEWmXaWav(this.f5a271fa2)) {
                        this.f8bc8a991++;
                        rONXimBWKBuUsGYN(this.f461f4bb2);
                        pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVarRSxvRXiylpiErfJC = rSxvRXiylpiErfJC(this.fcdee5967, this);
                        bMzGJfHcbqFSudtl(list, peef7828dVarRSxvRXiylpiErfJC);
                        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p62d68523 p62d68523Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p62d68523(peef7828dVarRSxvRXiylpiErfJC);
                        EBiMkuwCTcfkxZRP(observer, p62d68523Var);
                        uWrJnOztWwWABVrx(this.fb61822e8, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$pf29e7156$p0e6b0433(this, false), this.f90150402, this.f3e34bdeb);
                        if (YvfBDBIWHkYOdPcN(p62d68523Var)) {
                            ITemozkHOdqixuca(peef7828dVarRSxvRXiylpiErfJC);
                        }
                    }
                }
            }
            iJJgEjrEtkWYNFRLo = JJgEjrEtkWYNFRLo(this, -iJJgEjrEtkWYNFRLo);
            if (iJJgEjrEtkWYNFRLo == 0) {
                return;
            }
        }
    }

    public override void Run() {
        CGInoHNzAmCXxUYE(this);
    }
}

