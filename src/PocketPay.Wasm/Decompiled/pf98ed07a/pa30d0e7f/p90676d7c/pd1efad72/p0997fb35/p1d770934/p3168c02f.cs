namespace WillowMaze.Wasm.Decompiled;


public abstract class p3168c02f<T> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.FlowableSubscriber<T> {
    private static readonly long f2fb97182 = -3214213361171757852L;
    private static readonly long f48fdf930 = -3214213361171757852L;
    private static readonly long fc1b330b0 = -3214213361171757852L;
    private static readonly long fc6e1e520 = -3214213361171757852L;
    private static readonly long fc989ab97 = -3214213361171757852L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f07213a01 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d();
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f1052b8b3;
    pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 f240a93cf;
    volatile bool f38881e0a;
    readonly int f4c203b76;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f560019e4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f6a963dbe;
    volatile bool f6b2ded51;
    readonly int f7eb51e8a;
    volatile bool f7f6d591f;
    p5a445d71.p18f29add.p787ad0b7 f8a089def;
    pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 f9605d2f8;
    bool f96889a29;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f9d4477f7;
    p5a445d71.p18f29add.p787ad0b7 fa4f9c0b3;
    bool fa528beeb;
    io.reactivex.rxjava3.operators.SimpleQueue<T> fa9d1cbf7;
    readonly int fae32ba45;
    readonly int faed600e7;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    bool fbf1a3fd2;
    p5a445d71.p18f29add.p787ad0b7 fc2826911;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 fcef14485;
    pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 fd15f27ce;
    p5a445d71.p18f29add.p787ad0b7 fd2129469;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d ff6e8d0f0;
    volatile bool ff9d200bd;
    volatile bool fffc50c3a;

    public p3168c02f(int i, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 pcd04add9Var) {
        this.f560019e4 = pcd04add9Var;
        this.f4c203b76 = i;
    }

    public static void CxzBFlsXtToKyRqs(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static bool EAgrycXLQFJGiFsW(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void FaLDgQUKDCJcvpqO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p3168c02f p3168c02fVar) {
        p3168c02fVar.disposeInner();
    }

    public static void GqrPBhJozAuAhSEo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p3168c02f p3168c02fVar) {
        p3168c02fVar.drain();
    }

    public static void PUeqvHWlmxZyPcHK(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void QrwuMgxSffQQFeuB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p3168c02f p3168c02fVar) {
        p3168c02fVar.onSubscribeDownstream();
    }

    public static void SWtKeGlIdrrVRGjq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p3168c02f p3168c02fVar) {
        p3168c02fVar.onSubscribeDownstream();
    }

    public static bool TRfFxlTlNETdRtNI(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var, java.lang.object obj) {
        return pe1601823Var.offer(obj);
    }

    public static bool VUPQcwelDqIQhJlO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void YDxoaKGMXqfUfsfr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        p36a52e5dVar.tryTerminateAndReport();
    }

    public static void YuygArjEnmrkPpzj(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p3168c02f p3168c02fVar, java.lang.Exception th) {
        p3168c02fVar.onError(th);
    }

    public static void BRPgqjunJTXSStAE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p3168c02f p3168c02fVar) {
        p3168c02fVar.drain();
    }

    public static void BgCZKHLTMprEqUxk(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void BggmuHrjldWPFqFg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p3168c02f p3168c02fVar) {
        p3168c02fVar.disposeInner();
    }

    public static int LqFlBLayRnoHHpUB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p3168c02f p3168c02fVar) {
        return p3168c02fVar.getAndIncrement();
    }

    public static void MIgyTrJyZhESbxTy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p3168c02f p3168c02fVar) {
        p3168c02fVar.onSubscribeDownstream();
    }

    public static void PBdclXOILYWkXCRp(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static int PdvjBYVDYUDKNKID(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var, int i) {
        return p5d5a5670Var.requestFusion(i);
    }

    public static void RFAjyyRlUUApYnNb(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static void WtymamQTpmgizcqS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p3168c02f p3168c02fVar) {
        p3168c02fVar.drain();
    }

    public static void WxDxjRRODLYIdUGx(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p3168c02f p3168c02fVar) {
        p3168c02fVar.clearValue();
    }

    public static void XDzVLeqyEQxfkFQH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p3168c02f p3168c02fVar) {
        p3168c02fVar.drain();
    }

    void clearValue() {
    }

    abstract void DisposeInner();

    abstract void Drain();

    public readonly void OnComplete() {
        this.f6b2ded51 = true;
        GqrPBhJozAuAhSEo(this);
    }

    public readonly void OnError(java.lang.Exception th) {
        if (VUPQcwelDqIQhJlO(this.f07213a01, th)) {
            if (this.f560019e4 == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9.fe35884a2) {
                bggmuHrjldWPFqFg(this);
            }
            this.f6b2ded51 = true;
            xDzVLeqyEQxfkFQH(this);
        }
    }

    public readonly void OnNext(T t) {
        if (t is null || TRfFxlTlNETdRtNI(this.fa9d1cbf7, t)) {
            bRPgqjunJTXSStAE(this);
        } else {
            pBdclXOILYWkXCRp(this.fbc3b0556);
            YuygArjEnmrkPpzj(this, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p30784cd1("queue full?!"));
        }
    }

    public override readonly void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((2 + 4) % 4 > 0) {
        }
        if (EAgrycXLQFJGiFsW(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            if (p787ad0b7Var is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670) {
                pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var = (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670) p787ad0b7Var;
                int iPdvjBYVDYUDKNKID = pdvjBYVDYUDKNKID(p5d5a5670Var, 7);
                if (iPdvjBYVDYUDKNKID == 1) {
                    this.fa9d1cbf7 = p5d5a5670Var;
                    this.fbf1a3fd2 = true;
                    this.f6b2ded51 = true;
                    SWtKeGlIdrrVRGjq(this);
                    wtymamQTpmgizcqS(this);
                    return;
                }
                if (iPdvjBYVDYUDKNKID == 2) {
                    this.fa9d1cbf7 = p5d5a5670Var;
                    mIgyTrJyZhESbxTy(this);
                    PUeqvHWlmxZyPcHK(this.fbc3b0556, this.f4c203b76);
                    return;
                }
            }
            this.fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pb8a628fd(this.f4c203b76);
            QrwuMgxSffQQFeuB(this);
            bgCZKHLTMprEqUxk(this.fbc3b0556, this.f4c203b76);
        }
    }

    abstract void OnSubscribeDownstream();

    readonly void stop() {
        this.f38881e0a = true;
        CxzBFlsXtToKyRqs(this.fbc3b0556);
        FaLDgQUKDCJcvpqO(this);
        YDxoaKGMXqfUfsfr(this.f07213a01);
        if (lqFlBLayRnoHHpUB(this) != 0) {
            return;
        }
        rFAjyyRlUUApYnNb(this.fa9d1cbf7);
        wxDxjRRODLYIdUGx(this);
    }
}

