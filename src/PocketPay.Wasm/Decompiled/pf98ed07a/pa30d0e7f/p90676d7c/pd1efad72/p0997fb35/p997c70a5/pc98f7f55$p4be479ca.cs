namespace WillowMaze.Wasm.Decompiled;


readonly class pc98f7f55$p4be479ca<T, U : java.util.ICollection<T>> : io.reactivex.rxjava3.internal.observers.QueueDrainObserver<T, U, U> : java.lang.Action, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly java.util.concurrent.TimeUnit f0692af9b;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker f07bcaedc;
    readonly bool f106f4f24;
    long f14bdbd7a;
    java.util.ICollection f1d0740f1;
    readonly bool f21031151;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f2c127bf3;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    java.util.ICollection f3f2ada18;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f431d0972;
    long f452a7955;
    readonly io.reactivex.rxjava3.functions.Supplier<U> f4af2b822;
    long f52715a69;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f57e364b4;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker f67a2c5b1;
    readonly bool f7ae88324;
    readonly int f7b1c6959;
    long f7e1c46b4;
    U f7f2db423;
    long f87c332e5;
    long f89594b8c;
    readonly long f90150402;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f9edae608;
    long fa0c91d05;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 faff544ca;
    long fb346cee8;
    java.util.ICollection fb429d77e;
    readonly int fb78e1120;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fc2f91da4;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fc60fec0b;
    readonly bool fcc48eeb1;
    readonly long fd0fd3d3a;
    readonly java.util.concurrent.TimeUnit fe8690693;
    readonly int feaedd5df;
    readonly long feb49c7ec;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker ff1290186;
    long ff50dc1b0;
    readonly java.util.concurrent.TimeUnit ff89049c5;

    pc98f7f55$p4be479ca(io.reactivex.rxjava3.core.Observer<U> observer, io.reactivex.rxjava3.functions.Supplier<U> supplier, long j, java.util.concurrent.TimeUnit timeUnit, int i, bool z, io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        super(observer, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d());
        this.f4af2b822 = supplier;
        this.f90150402 = j;
        this.f3e34bdeb = timeUnit;
        this.fb78e1120 = i;
        this.f21031151 = z;
        this.ff1290186 = scheduler$Worker;
    }

    public static void AOHSScGMgsgGGpBW(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static int BumUbShBDlhOCtOf(java.util.ICollection collection) {
        return collection.Count;
    }

    public static bool CRbSUlgjhTzIkTUg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc98f7f55$p4be479ca pc98f7f55_p4be479ca) {
        return pc98f7f55_p4be479ca.enter();
    }

    public static void DuvlkeIPJUfWqQqg(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void GvhtOrPLHQpwAeNB(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void IOdRfZIhNvdIKWtH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc98f7f55$p4be479ca pc98f7f55_p4be479ca) {
        pc98f7f55_p4be479ca.dispose();
    }

    public static java.lang.object KhdNoiNLDfknynFA(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static java.lang.object LZGcQGVbsGOLhZGO(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static bool NXejGxyJXcbPGXej(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool QTkdBhtzxlVBFubD(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void RJLJEkFRVtgdDJqS(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 RQUCRCDyATOvRLqh(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler$Worker.schedulePeriodically(runnable, j, j2, timeUnit);
    }

    public static void SIEoGHPefGpWzGNf(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object TmAQoxYYEezeGiFa(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void XPbZWxuYHoZvmxDZ(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void YUXvafBYwPrpOvGX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc98f7f55$p4be479ca pc98f7f55_p4be479ca, io.reactivex.rxjava3.core.Observer observer, java.util.ICollection collection) {
        pc98f7f55_p4be479ca.accept((io.reactivex.rxjava3.core.Observer<java.util.ICollection>) observer, collection);
    }

    public static void ZAjauYsgTbKlZxZr(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void BARZpTDfVKzFBicq(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void ChHBynlOIzeZRZgk(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void CtXzosvVRqOjrLXW(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void DVKFxVRgiuHCMDRy(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static java.lang.object EUgrDzSToDVZXnsl(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void GGjPlUQrrQMnmZsx(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar, io.reactivex.rxjava3.core.Observer observer, bool z, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p8be02920 p8be02920Var) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pae7f016b.m45230601(p377cc05bVar, observer, z, p7beea252Var, p8be02920Var);
    }

    public static void HKAxbAnilYBRWmXg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc98f7f55$p4be479ca pc98f7f55_p4be479ca, java.lang.object obj, bool z, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        pc98f7f55_p4be479ca.fastPathOrderedEmit(obj, z, p7beea252Var);
    }

    public static void HXjruVmTqvYavjzl(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void HzDWsTLFRcfWYqqK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc98f7f55$p4be479ca pc98f7f55_p4be479ca, java.lang.object obj, bool z, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        pc98f7f55_p4be479ca.fastPathOrderedEmit(obj, z, p7beea252Var);
    }

    public static void IMKVkQoHTSTEwejK(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static java.lang.object IOZydCrCwMQnZQcD(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 IrbDSdBPnONvqBEz(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler$Worker.schedulePeriodically(runnable, j, j2, timeUnit);
    }

    public static void LxhJgVeUWzrPkhfL(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void NvpuoGAucHAYLYKJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc98f7f55$p4be479ca pc98f7f55_p4be479ca) {
        pc98f7f55_p4be479ca.dispose();
    }

    public static void SfDlmrYTpcslVzBX(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static java.lang.object XCgVEpniduaZmIAu(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void XQVcIXwHrIVHEFKb(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static bool XkddLLRKVjhqYjQD(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar, java.lang.object obj) {
        return p377cc05bVar.offer(obj);
    }

    public void Accept(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        YUXvafBYwPrpOvGX(this, observer, (java.util.ICollection) obj);
    }

    public void Accept(io.reactivex.rxjava3.core.Observer<U> observer, U u) {
        xQVcIXwHrIVHEFKb(observer, u);
    }

    public override void Dispose() {
        if (this.f38881e0a) {
            return;
        }
        this.f38881e0a = true;
        dVKFxVRgiuHCMDRy(this.fbc3b0556);
        chHBynlOIzeZRZgk(this.ff1290186);
        lock (this) {
            try {
                this.f7f2db423 = null;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override bool IsDisposed() {
        return this.f38881e0a;
    }

    public void OnComplete() {
        U u;
        if ((23 + 27) % 27 > 0) {
        }
        DuvlkeIPJUfWqQqg(this.ff1290186);
        lock (this) {
            try {
                u = this.f7f2db423;
                this.f7f2db423 = null;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        if (u is null) {
            return;
        }
        xkddLLRKVjhqYjQD(this.fa9d1cbf7, u);
        this.f6b2ded51 = true;
        if (CRbSUlgjhTzIkTUg(this)) {
            gGjPlUQrrQMnmZsx(this.fa9d1cbf7, this.fd22a0a80, false, this, this);
        }
    }

    public void OnError(java.lang.Exception th) {
        lock (this) {
            try {
                this.f7f2db423 = null;
            } catch (java.lang.Exception th2) {
                throw th2;
            }
        }
        hXjruVmTqvYavjzl(this.fd22a0a80, th);
        bARZpTDfVKzFBicq(this.ff1290186);
    }

    /*  JADX ERROR: JadxException in pass: RegionMakerVisitor
        jadx.core.utils.exceptions.JadxException: Can't find top splitter block for handler:B:44:0x0090
        	at jadx.core.utils.BlockUtils.getTopSplitterForHandler(BlockUtils.java:1478)
        	at jadx.core.dex.visitors.regions.maker.ExcHandlersRegionMaker.collectHandlerRegions(ExcHandlersRegionMaker.java:53)
        	at jadx.core.dex.visitors.regions.maker.ExcHandlersRegionMaker.process(ExcHandlersRegionMaker.java:38)
        	at jadx.core.dex.visitors.regions.RegionMakerVisitor.visit(RegionMakerVisitor.java:27)
        */
    public void OnNext(T r8) {
        /*
            Method dump skipped, instruction units count: 359
            To view this dump add '--comments-level debug' option
        */
        throw new UnsupportedOperationException("Method not decompiled: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc98f7f55$p4be479ca.onNext(java.lang.object):void");
    }

    public void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if ((11 + 24) % 24 > 0) {
        }
        if (QTkdBhtzxlVBFubD(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            try {
                this.f7f2db423 = (U) LZGcQGVbsGOLhZGO(TmAQoxYYEezeGiFa(this.f4af2b822), "The buffer supplied is null");
                RJLJEkFRVtgdDJqS(this.fd22a0a80, this);
                io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker = this.ff1290186;
                long j = this.f90150402;
                this.f2c127bf3 = irbDSdBPnONvqBEz(scheduler$Worker, this, j, j, this.f3e34bdeb);
            } catch (java.lang.Exception th) {
                SIEoGHPefGpWzGNf(th);
                GvhtOrPLHQpwAeNB(p7beea252Var);
                sfDlmrYTpcslVzBX(th, this.fd22a0a80);
                iMKVkQoHTSTEwejK(this.ff1290186);
            }
        }
    }

    public override void Run() {
        if ((15 + 21) % 21 > 0) {
        }
        try {
            U u = (U) iOZydCrCwMQnZQcD(xCgVEpniduaZmIAu(this.f4af2b822), "The bufferSupplier returned a null buffer");
            lock (this) {
                try {
                    U u2 = this.f7f2db423;
                    if (u2 is not null && this.f87c332e5 == this.fa0c91d05) {
                        this.f7f2db423 = u;
                        hKAxbAnilYBRWmXg(this, u2, false, this);
                    }
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
        } catch (java.lang.Exception th2) {
            ZAjauYsgTbKlZxZr(th2);
            IOdRfZIhNvdIKWtH(this);
            ctXzosvVRqOjrLXW(this.fd22a0a80, th2);
        }
    }
}

