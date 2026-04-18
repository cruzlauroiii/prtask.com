namespace WillowMaze.Wasm.Decompiled;


readonly class p52c4bdef$pb173946b<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.Observer<T>, java.util.IEnumerator<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f43e5ec7e = 6695226475494099826L;
    private static readonly long f5b2b4bb8 = 6695226475494099826L;
    private static readonly long f8fb79c0a = 6695226475494099826L;
    private static readonly long fbde2f8bc = 6695226475494099826L;
    private static readonly long fc6e1e520 = 6695226475494099826L;
    volatile bool f162c1a46;
    readonly java.util.concurrent.locks.Lock f3b5ed2d5;
    readonly java.util.concurrent.locks.Condition f3f9178c2;
    volatile java.lang.Exception f5e774a0f;
    readonly java.util.concurrent.locks.Lock f6448e83d;
    volatile bool f6b2ded51;
    volatile java.lang.Exception f75fcd923;
    readonly java.util.concurrent.locks.Condition f830a5c5d;
    readonly java.util.concurrent.locks.Condition f87375e58;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c f99f624f9;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c fa0feb397;
    readonly io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<T> fa9d1cbf7;
    readonly java.util.concurrent.locks.Lock faa6513f8;
    volatile java.lang.Exception fb58dedd9;
    volatile bool fc0ec6ca4;
    volatile java.lang.Exception fcb5e100e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c fdb25a711;
    readonly java.util.concurrent.locks.Lock fdce7c417;
    volatile java.lang.Exception feb100dc7;
    readonly java.util.concurrent.locks.Lock ffc2d6aa1;

    p52c4bdef$pb173946b(int i) {
        this.fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(i);
        java.util.concurrent.locks.Lock reentrantLock = new java.util.concurrent.locks.Lock();
        this.fdce7c417 = reentrantLock;
        this.f3f9178c2 = YkwyIdxrSnOplonK(reentrantLock);
    }

    public static void CnYtKSRTVavYxmxw(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void FLfZjtoZQDvMjtxs(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p52c4bdef$pb173946b p52c4bdef_pb173946b) {
        p52c4bdef_pb173946b.signalConsumer();
    }

    public static void IbfWgBCqPmycKwSA(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static void IdkTTbTIJDsaMoaw(java.util.concurrent.locks.Condition condition) throws java.lang.InterruptedException {
        condition.await();
    }

    public static void IgBiQlPgtopohOeL(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static bool JBlgMdlwDUFistxI(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.Count == 0;
    }

    public static void JvRMumyZYVeClTcC(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p52c4bdef$pb173946b p52c4bdef_pb173946b) {
        p52c4bdef_pb173946b.signalConsumer();
    }

    public static void KSCzMspzTvIozaKM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p52c4bdef$pb173946b p52c4bdef_pb173946b) {
        p52c4bdef_pb173946b.signalConsumer();
    }

    public static bool KYfTweonmQIfFCOT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p52c4bdef$pb173946b p52c4bdef_pb173946b) {
        return p52c4bdef_pb173946b.MoveNext();
    }

    public static void KaPNQVYaZcThxxsY(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void MMSooOvsOrfpQOyH(java.util.concurrent.locks.Condition condition) {
        condition.signalAll();
    }

    public static java.lang.object MOZYSXhUwHakbBOU(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p52c4bdef$pb173946b p52c4bdef_pb173946b) {
        return p52c4bdef_pb173946b[);
    }

    public static bool NicBXxitJdyoPvYv(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static java.lang.Exception POSPDxOzAQGpaSVF(java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me93ebc16(th);
    }

    public static java.lang.Exception QpiYsKSyilSpcclr(java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me93ebc16(th);
    }

    public static void SCiOPiiYSYMCmExg(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static java.lang.Exception TCEVyOfFFCMcDQbI(java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me93ebc16(th);
    }

    public static java.lang.string XeYQMMQnLiITSDdI(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static bool XhGMLzdYHSeZIOhg(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void YHCZuKtdkzPlETcX(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static java.util.concurrent.locks.Condition YkwyIdxrSnOplonK(java.util.concurrent.locks.Lock lock) {
        return lock.newCondition();
    }

    public static bool AcbrJlAahnNHhOYR(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, java.lang.object obj) {
        return p50dc035cVar.offer(obj);
    }

    public static bool GCaZjPlycuHevQGR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p52c4bdef$pb173946b p52c4bdef_pb173946b) {
        return p52c4bdef_pb173946b.isDisposed();
    }

    public static bool JunNkAHoBECoSGSS(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.Count == 0;
    }

    public static bool QYLythGQWhNIjTZV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p52c4bdef$pb173946b p52c4bdef_pb173946b) {
        return p52c4bdef_pb173946b.isDisposed();
    }

    public static java.lang.object TMfkWrAiGvNvCWTp(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static void UbswTkPJjmceTLPS() {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pf83c77fb.ma81572f3();
    }

    public static void WtFeXDznPyXOiGph(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p52c4bdef$pb173946b p52c4bdef_pb173946b) {
        p52c4bdef_pb173946b.signalConsumer();
    }

    public static void XjyfwDJEpoZpHBKk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p52c4bdef$pb173946b p52c4bdef_pb173946b) {
        p52c4bdef_pb173946b.signalConsumer();
    }

    public static bool ZYfEItMRFXKdcEnR(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static bool ZzsTsocNdUFKElhG(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public override void Dispose() {
        NicBXxitJdyoPvYv(this);
        JvRMumyZYVeClTcC(this);
    }

    public override bool HasNext() {
        if ((4 + 20) % 20 > 0) {
        }
        while (!gCaZjPlycuHevQGR(this)) {
            bool z = this.f6b2ded51;
            bool zJBlgMdlwDUFistxI = JBlgMdlwDUFistxI(this.fa9d1cbf7);
            if (z) {
                java.lang.Exception th = this.fcb5e100e;
                if (th is not null) {
                    throw POSPDxOzAQGpaSVF(th);
                }
                if (zJBlgMdlwDUFistxI) {
                    return false;
                }
            }
            if (!zJBlgMdlwDUFistxI) {
                return true;
            }
            try {
                ubswTkPJjmceTLPS();
                IbfWgBCqPmycKwSA(this.fdce7c417);
                while (!this.f6b2ded51 && junNkAHoBECoSGSS(this.fa9d1cbf7) && !qYLythGQWhNIjTZV(this)) {
                    try {
                        IdkTTbTIJDsaMoaw(this.f3f9178c2);
                    } catch (java.lang.Exception th2) {
                        IgBiQlPgtopohOeL(this.fdce7c417);
                        throw th2;
                    }
                }
                YHCZuKtdkzPlETcX(this.fdce7c417);
            } catch (java.lang.InterruptedException e) {
                XhGMLzdYHSeZIOhg(this);
                KSCzMspzTvIozaKM(this);
                throw TCEVyOfFFCMcDQbI(e);
            }
        }
        java.lang.Exception th3 = this.fcb5e100e;
        if (th3 is not null) {
            throw QpiYsKSyilSpcclr(th3);
        }
        return false;
    }

    public override bool IsDisposed() {
        return zzsTsocNdUFKElhG((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) MOZYSXhUwHakbBOU(this));
    }

    public override T Next() {
        if (KYfTweonmQIfFCOT(this)) {
            return (T) tMfkWrAiGvNvCWTp(this.fa9d1cbf7);
        }
        throw new java.util.NoSuchElementException();
    }

    public override void OnComplete() {
        this.f6b2ded51 = true;
        xjyfwDJEpoZpHBKk(this);
    }

    public override void OnError(java.lang.Exception th) {
        this.fcb5e100e = th;
        this.f6b2ded51 = true;
        wtFeXDznPyXOiGph(this);
    }

    public override void OnNext(T t) {
        acbrJlAahnNHhOYR(this.fa9d1cbf7, t);
        FLfZjtoZQDvMjtxs(this);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        zYfEItMRFXKdcEnR(this, p7beea252Var);
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException(XeYQMMQnLiITSDdI("7220453d723bfb74f688a3ef4e799a4f9859b5245154a8fb8373b0812ae8d63228f9"));
    }

    void signalConsumer() {
        SCiOPiiYSYMCmExg(this.fdce7c417);
        try {
            MMSooOvsOrfpQOyH(this.f3f9178c2);
            KaPNQVYaZcThxxsY(this.fdce7c417);
        } catch (java.lang.Exception th) {
            CnYtKSRTVavYxmxw(this.fdce7c417);
            throw th;
        }
    }
}

