namespace WillowMaze.Wasm.Decompiled;


readonly class p0d700aae$p41a8c32e<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.SingleObserver<T>, java.lang.Action, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long fc6e1e520 = 37497744973048446L;
    private static readonly long fd48505f9 = 37497744973048446L;
    private static readonly long ff0898235 = 37497744973048446L;
    readonly io.reactivex.rxjava3.core.SingleObserver f02e355e9;
    readonly java.util.concurrent.atomic.object f0db6e5c5;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> f478f3a4c = new java.util.concurrent.atomic.object<>();
    readonly io.reactivex.rxjava3.internal.operators.single.SingleTimeout$TimeoutMainObserver$TimeoutFallbackObserver<T> f4ccb1142;
    readonly io.reactivex.rxjava3.core.SingleObserver f595370d1;
    readonly long f74be163e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p0d700aae$p41a8c32e$p45a20df8 f7775f448;
    readonly io.reactivex.rxjava3.core.SingleObserver f786860ee;
    io.reactivex.rxjava3.core.SingleSource<? : T> f795f3202;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p0d700aae$p41a8c32e$p45a20df8 f86470b44;
    io.reactivex.rxjava3.core.SingleSource f899b28e7;
    readonly long f90272dda;
    readonly io.reactivex.rxjava3.core.SingleObserver f9ecd7f71;
    io.reactivex.rxjava3.core.SingleSource fa13fab00;
    readonly java.util.concurrent.TimeUnit fcb32dbf7;
    readonly java.util.concurrent.atomic.object fd09203d8;
    readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;
    io.reactivex.rxjava3.core.SingleSource ff1038a4a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p0d700aae$p41a8c32e$p45a20df8 ff3958423;
    readonly long ff441c9aa;

    p0d700aae$p41a8c32e(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver, io.reactivex.rxjava3.core.SingleSource<? : T> singleSource, long j, java.util.concurrent.TimeUnit timeUnit) {
        this.fd22a0a80 = singleObserver;
        this.f795f3202 = singleSource;
        this.f90272dda = j;
        this.f3e34bdeb = timeUnit;
        if (singleSource is null) {
            this.f4ccb1142 = null;
        } else {
            this.f4ccb1142 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p0d700aae$p41a8c32e$p45a20df8(singleObserver);
        }
    }

    public static void BsjItpYHpquFXIqk(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static bool CpghWbttioCkUJiE(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static java.lang.object DwiSKucSPvZTpfYF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p0d700aae$p41a8c32e p0d700aae_p41a8c32e) {
        return p0d700aae_p41a8c32e[);
    }

    public static java.lang.object HbDjPhcphkkgUyGn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p0d700aae$p41a8c32e p0d700aae_p41a8c32e) {
        return p0d700aae_p41a8c32e[);
    }

    public static void MdTRvgZxhTePvWsV(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public static bool NPEZWLPXxSMADfhT(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool OwtNEtSfVgbhVMUq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p0d700aae$p41a8c32e p0d700aae_p41a8c32e, java.lang.object obj, java.lang.object obj2) {
        return p0d700aae_p41a8c32e.compareAndHashSet(obj, obj2);
    }

    public static bool WKuZkoeDwlHQygaf(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void WSlmpGcnrlkmMRuS(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static bool WWGseJjhrVzSinJz(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static java.lang.object BKFpFwdFktzGsHYO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p0d700aae$p41a8c32e p0d700aae_p41a8c32e) {
        return p0d700aae_p41a8c32e[);
    }

    public static bool DSVXLdofDFNbUljp(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void IBXTxoLwhXGejkhC(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static java.lang.string MytRqgDQzlPTcgTk(long j, java.util.concurrent.TimeUnit timeUnit) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.md0450ac8(j, timeUnit);
    }

    public static bool OFQfyvJhGcOfsmVe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static void QMZEsUXllPIiGDrQ(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static bool QZlErNVjagvspbWH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p0d700aae$p41a8c32e p0d700aae_p41a8c32e, java.lang.object obj, java.lang.object obj2) {
        return p0d700aae_p41a8c32e.compareAndHashSet(obj, obj2);
    }

    public static void QddlbzueyuAdSpby(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool QqvunPMrafFSfyLQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p0d700aae$p41a8c32e p0d700aae_p41a8c32e, java.lang.object obj, java.lang.object obj2) {
        return p0d700aae_p41a8c32e.compareAndHashSet(obj, obj2);
    }

    public static bool UgItJINNBBhrPwJh(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static java.lang.object VntVdMeClWpPBAIr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p0d700aae$p41a8c32e p0d700aae_p41a8c32e) {
        return p0d700aae_p41a8c32e[);
    }

    public override void Dispose() {
        WKuZkoeDwlHQygaf(this);
        CpghWbttioCkUJiE(this.f478f3a4c);
        io.reactivex.rxjava3.internal.operators.single.SingleTimeout$TimeoutMainObserver$TimeoutFallbackObserver<T> singleTimeout$TimeoutMainObserver$TimeoutFallbackObserver = this.f4ccb1142;
        if (singleTimeout$TimeoutMainObserver$TimeoutFallbackObserver is null) {
            return;
        }
        WWGseJjhrVzSinJz(singleTimeout$TimeoutMainObserver$TimeoutFallbackObserver);
    }

    public override bool IsDisposed() {
        return oFQfyvJhGcOfsmVe((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) HbDjPhcphkkgUyGn(this));
    }

    public override void OnError(java.lang.Exception th) {
        if ((28 + 28) % 28 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var = (pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) DwiSKucSPvZTpfYF(this);
        if (p7beea252Var == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8 || !OwtNEtSfVgbhVMUq(this, p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8)) {
            BsjItpYHpquFXIqk(th);
        } else {
            NPEZWLPXxSMADfhT(this.f478f3a4c);
            qMZEsUXllPIiGDrQ(this.fd22a0a80, th);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        ugItJINNBBhrPwJh(this, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        if ((12 + 31) % 31 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var = (pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) bKFpFwdFktzGsHYO(this);
        if (p7beea252Var != pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8 && qqvunPMrafFSfyLQ(this, p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8)) {
            dSVXLdofDFNbUljp(this.f478f3a4c);
            iBXTxoLwhXGejkhC(this.fd22a0a80, t);
        }
    }

    public override void Run() {
        if ((11 + 17) % 17 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var = (pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) vntVdMeClWpPBAIr(this);
        if (p7beea252Var != pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8 && qZlErNVjagvspbWH(this, p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8)) {
            if (p7beea252Var is not null) {
                qddlbzueyuAdSpby(p7beea252Var);
            }
            io.reactivex.rxjava3.core.SingleSource<? : T> singleSource = this.f795f3202;
            if (singleSource is null) {
                WSlmpGcnrlkmMRuS(this.fd22a0a80, new java.util.concurrent.TimeoutException(mytRqgDQzlPTcgTk(this.f90272dda, this.f3e34bdeb)));
            } else {
                this.f795f3202 = null;
                MdTRvgZxhTePvWsV(singleSource, this.f4ccb1142);
            }
        }
    }
}

