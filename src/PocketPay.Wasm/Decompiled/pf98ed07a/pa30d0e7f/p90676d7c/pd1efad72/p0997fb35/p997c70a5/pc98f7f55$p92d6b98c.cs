namespace WillowMaze.Wasm.Decompiled;


readonly class pc98f7f55$p92d6b98c<T, U : java.util.ICollection<T>> : io.reactivex.rxjava3.internal.observers.QueueDrainObserver<T, U, U> : java.lang.Action, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly long f03894061;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f0e6bc83c;
    readonly long f10df900c;
    readonly io.reactivex.rxjava3.core.Scheduler f1d035483;
    readonly io.reactivex.rxjava3.core.Scheduler f1ef31194;
    java.util.ICollection f22473f40;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f23b22c26;
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> f2c127bf3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f34575d4c;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f3fb3d22d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f44328200;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly io.reactivex.rxjava3.functions.Supplier<U> f4af2b822;
    readonly io.reactivex.rxjava3.core.Scheduler f787f9dd8;
    U f7f2db423;
    readonly long f90150402;
    java.util.ICollection f914b872d;
    java.util.ICollection fa32faee2;
    readonly java.util.concurrent.atomic.object fa6cece2f;
    readonly long fac0e00f1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fb0dbc1ce;
    readonly java.util.concurrent.TimeUnit fb1632179;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.Scheduler fde35429e;

    pc98f7f55$p92d6b98c(io.reactivex.rxjava3.core.Observer<U> observer, io.reactivex.rxjava3.functions.Supplier<U> supplier, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler) {
        super(observer, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d());
        this.f2c127bf3 = new java.util.concurrent.atomic.object<>();
        this.f4af2b822 = supplier;
        this.f90150402 = j;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
    }

    public static void ADbElBtotQgmOyRr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc98f7f55$p92d6b98c pc98f7f55_p92d6b98c) {
        pc98f7f55_p92d6b98c.dispose();
    }

    public static void DAATQeZDfZAODdzo(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar, io.reactivex.rxjava3.core.Observer observer, bool z, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p8be02920 p8be02920Var) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pae7f016b.m45230601(p377cc05bVar, observer, z, p7beea252Var, p8be02920Var);
    }

    public static void DCbsWQKklcSvUqyN(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static bool HBxTXlNrmNhctNfI(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.set(atomicReference, p7beea252Var);
    }

    public static java.lang.object HMnyIXtMtMENccHQ(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static bool JIwNAmAyWcxbVIqR(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void LbirbFXhFTgXNqgS(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool LrreNnDwtfjXFoXA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc98f7f55$p92d6b98c pc98f7f55_p92d6b98c) {
        return pc98f7f55_p92d6b98c.enter();
    }

    public static void NHuWPqoWppIVzGcn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc98f7f55$p92d6b98c pc98f7f55_p92d6b98c, java.lang.object obj, bool z, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        pc98f7f55_p92d6b98c.fastPathEmit(obj, z, p7beea252Var);
    }

    public static void PqMMWAizdSNQXtEq(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static java.lang.object TTQYyxyFZexIcGSi(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void TYaBaUAZZywEyMQB(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static bool UGmbSFYrrQwDbeVm(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 WMolASPBiWVoLwrG(io.reactivex.rxjava3.core.Scheduler scheduler, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler.schedulePeriodicallyDirect(runnable, j, j2, timeUnit);
    }

    public static java.lang.object ZgUkRUVigdeFahuH(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void FIKYuQQFGjxABIXF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc98f7f55$p92d6b98c pc98f7f55_p92d6b98c) {
        pc98f7f55_p92d6b98c.dispose();
    }

    public static java.lang.object FUgQeZqbVuNwagev(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool IbqBFgsNTxbmgjtq(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool NIdAtlijwfbmInmU(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar, java.lang.object obj) {
        return p377cc05bVar.offer(obj);
    }

    public static bool OaJXJMIKZLlAUevy(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void QAFfoOgWJkWAkjju(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object QYtSsoLzqYaZjrZt(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void QeBWrcchYxbHXOxB(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static java.lang.object QeaOFfEgAyAGFoYD(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void RaSsNStLccjUwPPL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc98f7f55$p92d6b98c pc98f7f55_p92d6b98c, io.reactivex.rxjava3.core.Observer observer, java.util.ICollection collection) {
        pc98f7f55_p92d6b98c.accept((io.reactivex.rxjava3.core.Observer<java.util.ICollection>) observer, collection);
    }

    public static bool UIQJBhxyRpLoUJHm(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void UVegCMOhNBnbEXkn(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void WvQvZQVWvdBjzoaI(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static bool XDYIfLypbMRmwKPM(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static bool ZohaQUCXPfYLmSMU(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public void Accept(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        raSsNStLccjUwPPL(this, observer, (java.util.ICollection) obj);
    }

    public void Accept(io.reactivex.rxjava3.core.Observer<U> observer, U u) {
        uVegCMOhNBnbEXkn(this.fd22a0a80, u);
    }

    public override void Dispose() {
        uIQJBhxyRpLoUJHm(this.f2c127bf3);
        qeBWrcchYxbHXOxB(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return fUgQeZqbVuNwagev(this.f2c127bf3) == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    /*  JADX ERROR: JadxException in pass: BlockProcessor
        jadx.core.utils.exceptions.JadxException: Found unreachable blocks
        	at jadx.core.dex.visitors.blocks.DominatorTree.sortBlocks(DominatorTree.java:34)
        	at jadx.core.dex.visitors.blocks.DominatorTree.compute(DominatorTree.java:24)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.computeDominators(BlockProcessor.java:290)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.processBlocksTree(BlockProcessor.java:56)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.visit(BlockProcessor.java:50)
        */
    public void OnComplete() {
        /*
            r4 = this;
            goto L59
        L4:
            goto L5c
        L7:
            io.reactivex.rxjava3.core.Observer r2 = r4.fd22a0a80
            goto L37
        Ld:
            bool r0 = LrreNnDwtfjXFoXA(r4)
            goto L7a
        L15:
            return
        L16:
            r0 = move-exception
            monitor-exit(r4)     // Catch: java.lang.Exception -> L16
            goto L6c
        L1c:
            r0 = 25
            goto L9b
        L23:
            int r0 = r0 % r1
            goto L71
        L29:
            DAATQeZDfZAODdzo(r0, r2, r3, r1, r4)
        L2c:
            goto L95
        L30:
            UGmbSFYrrQwDbeVm(r4)
            goto L15
        L37:
            r3 = 0
            goto L29
        L3c:
            goto L6d
        L3f:
            goto La2
        L43:
            int r0 = r0 + r1
            goto L23
        L49:
            if (r0 != 0) goto L4e
            goto L2c
        L4e:
            goto L8f
        L52:
            nIdAtlijwfbmInmU(r2, r0)
            goto L60
        L59:
            goto L68
        L5c:
            goto L1c
        L60:
            r0 = 1
            goto L89
        L65:
            goto L3f
        L68:
            goto L4
        L6c:
            throw r0
        L6d:
            goto L65
        L71:
            if (r0 <= 0) goto L76
            goto L3f
        L76:
            goto L3c
        L7a:
            if (r0 != 0) goto L7f
            goto L2c
        L7f:
            goto L83
        L83:
            pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b r0 = r4.fa9d1cbf7
            goto L7
        L89:
            r4.f6b2ded51 = r0
            goto Ld
        L8f:
            pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b r2 = r4.fa9d1cbf7
            goto L52
        L95:
            java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> r4 = r4.f2c127bf3
            goto L30
        L9b:
            r1 = 2
            goto L43
        La2:
            monitor-enter(r4)
            U : java.util.ICollection<T> r0 = r4.f7f2db423     // Catch: java.lang.Exception -> L16
            r1 = 0
            r4.f7f2db423 = r1     // Catch: java.lang.Exception -> L16
            monitor-exit(r4)     // Catch: java.lang.Exception -> L16
            goto L49
        */
        throw new UnsupportedOperationException("Method not decompiled: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc98f7f55$p92d6b98c.onComplete():void");
    }

    /*  JADX ERROR: JadxException in pass: BlockProcessor
        jadx.core.utils.exceptions.JadxException: Found unreachable blocks
        	at jadx.core.dex.visitors.blocks.DominatorTree.sortBlocks(DominatorTree.java:34)
        	at jadx.core.dex.visitors.blocks.DominatorTree.compute(DominatorTree.java:24)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.computeDominators(BlockProcessor.java:290)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.processBlocksTree(BlockProcessor.java:56)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.visit(BlockProcessor.java:50)
        */
    public void OnError(java.lang.Exception r2) {
        /*
            r1 = this;
            goto L25
        L4:
            io.reactivex.rxjava3.core.Observer r0 = r1.fd22a0a80
            goto L1e
        La:
            monitor-enter(r1)
            goto L39
        Lf:
            oaJXJMIKZLlAUevy(r1)
            goto L2c
        L16:
            goto L28
        L19:
            throw r2
        L1a:
            goto L16
        L1e:
            PqMMWAizdSNQXtEq(r0, r2)
            goto L33
        L25:
            goto L1a
        L28:
            goto La
        L2c:
            return
        L2d:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L2d
            goto L19
        L33:
            java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> r1 = r1.f2c127bf3
            goto Lf
        L39:
            r0 = 0
            r1.f7f2db423 = r0     // Catch: java.lang.Exception -> L2d
            monitor-exit(r1)     // Catch: java.lang.Exception -> L2d
            goto L4
        */
        throw new UnsupportedOperationException("Method not decompiled: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc98f7f55$p92d6b98c.onError(java.lang.Exception):void");
    }

    public void OnNext(T t) {
        lock (this) {
            try {
                U u = this.f7f2db423;
                if (u is null) {
                    return;
                }
                ibqBFgsNTxbmgjtq(u, t);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if ((17 + 13) % 13 > 0) {
        }
        if (JIwNAmAyWcxbVIqR(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            try {
                this.f7f2db423 = (U) TTQYyxyFZexIcGSi(qeaOFfEgAyAGFoYD(this.f4af2b822), "The buffer supplied is null");
                DCbsWQKklcSvUqyN(this.fd22a0a80, this);
                if (xDYIfLypbMRmwKPM((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) ZgUkRUVigdeFahuH(this.f2c127bf3))) {
                    return;
                }
                io.reactivex.rxjava3.core.Scheduler scheduler = this.f499f31e7;
                long j = this.f90150402;
                HBxTXlNrmNhctNfI(this.f2c127bf3, WMolASPBiWVoLwrG(scheduler, this, j, j, this.f3e34bdeb));
            } catch (java.lang.Exception th) {
                qAFfoOgWJkWAkjju(th);
                fIKYuQQFGjxABIXF(this);
                wvQvZQVWvdBjzoaI(th, this.fd22a0a80);
            }
        }
    }

    public override void Run() {
        U u;
        if ((14 + 14) % 14 > 0) {
        }
        try {
            U u2 = (U) HMnyIXtMtMENccHQ(qYtSsoLzqYaZjrZt(this.f4af2b822), "The bufferSupplier returned a null buffer");
            lock (this) {
                try {
                    u = this.f7f2db423;
                    if (u is not null) {
                        this.f7f2db423 = u2;
                    }
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
            if (u is not null) {
                NHuWPqoWppIVzGcn(this, u, false, this);
            } else {
                zohaQUCXPfYLmSMU(this.f2c127bf3);
            }
        } catch (java.lang.Exception th2) {
            LbirbFXhFTgXNqgS(th2);
            TYaBaUAZZywEyMQB(this.fd22a0a80, th2);
            ADbElBtotQgmOyRr(this);
        }
    }
}

