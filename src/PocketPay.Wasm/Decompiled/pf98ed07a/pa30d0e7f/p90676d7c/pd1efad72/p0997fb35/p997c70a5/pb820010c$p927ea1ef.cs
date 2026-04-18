namespace WillowMaze.Wasm.Decompiled;


readonly class pb820010c$p927ea1ef<T, R> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.Observer<R> {
    private static readonly long f5d921fe8 = 3837284832786408377L;
    private static readonly long fc6e1e520 = 3837284832786408377L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pb820010c$p275c16e7 f47223e5c;
    readonly long f6a992d55;
    volatile bool f6b2ded51;
    volatile pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 f6c17708f;
    readonly int f6f544b26;
    readonly int f769b351d;
    readonly long f87aeda50;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pb820010c$p275c16e7 f8997bdfd;
    readonly long f91fa0522;
    readonly long f94cbe042;
    volatile bool fa9047c5b;
    volatile io.reactivex.rxjava3.operators.SimpleQueue<R> fa9d1cbf7;
    volatile pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 fb9493972;
    volatile bool fc1afbde0;
    readonly int fcdee5967;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableSwitchDictionary$SwitchDictionaryObserver<T, R> fd0e45878;
    volatile pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 fd9253834;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pb820010c$p275c16e7 fe5cb9fc9;
    volatile pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 fed8dcfe9;
    volatile bool ff5b2bac1;

    pb820010c$p927ea1ef(io.reactivex.rxjava3.internal.operators.observable.ObservableSwitchDictionary$SwitchDictionaryObserver<T, R> observableSwitchDictionary$SwitchDictionaryObserver, long j, int i) {
        this.fd0e45878 = observableSwitchDictionary$SwitchDictionaryObserver;
        this.f6a992d55 = j;
        this.fcdee5967 = i;
    }

    public static bool FgBNeNPZCpdYROVc(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void PslQPBwBhKtWuquO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pb820010c$p275c16e7 pb820010c_p275c16e7) {
        pb820010c_p275c16e7.drain();
    }

    public static int SIboiDfbVJPGLsNJ(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16 p8df47e16Var, int i) {
        return p8df47e16Var.requestFusion(i);
    }

    public static bool CJVRVBCaTTMgCbPc(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void DbEXzZKCxvZwcRlH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pb820010c$p275c16e7 pb820010c_p275c16e7) {
        pb820010c_p275c16e7.drain();
    }

    public static void IBQLRXdcCePRUhsz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pb820010c$p275c16e7 pb820010c_p275c16e7) {
        pb820010c_p275c16e7.drain();
    }

    public static bool WfKdUKGrXrMmYMDk(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var, java.lang.object obj) {
        return pe1601823Var.offer(obj);
    }

    public static void WvdgjgUhvVtPPXWh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pb820010c$p275c16e7 pb820010c_p275c16e7, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pb820010c$p927ea1ef pb820010c_p927ea1ef, java.lang.Exception th) {
        pb820010c_p275c16e7.innerError(pb820010c_p927ea1ef, th);
    }

    public void Cancel() {
        FgBNeNPZCpdYROVc(this);
    }

    public override void OnComplete() {
        if ((31 + 13) % 13 > 0) {
        }
        if (this.f6a992d55 != this.fd0e45878.f673eb027) {
            return;
        }
        this.f6b2ded51 = true;
        PslQPBwBhKtWuquO(this.fd0e45878);
    }

    public override void OnError(java.lang.Exception th) {
        wvdgjgUhvVtPPXWh(this.fd0e45878, this, th);
    }

    public override void OnNext(R r) {
        if ((7 + 2) % 2 > 0) {
        }
        if (this.f6a992d55 != this.fd0e45878.f673eb027) {
            return;
        }
        if (r is not null) {
            wfKdUKGrXrMmYMDk(this.fa9d1cbf7, r);
        }
        iBQLRXdcCePRUhsz(this.fd0e45878);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if ((27 + 20) % 20 > 0) {
        }
        if (cJVRVBCaTTMgCbPc(this, p7beea252Var)) {
            if (p7beea252Var is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16) {
                pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16 p8df47e16Var = (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16) p7beea252Var;
                int iSIboiDfbVJPGLsNJ = SIboiDfbVJPGLsNJ(p8df47e16Var, 7);
                if (iSIboiDfbVJPGLsNJ == 1) {
                    this.fa9d1cbf7 = p8df47e16Var;
                    this.f6b2ded51 = true;
                    dbEXzZKCxvZwcRlH(this.fd0e45878);
                    return;
                } else if (iSIboiDfbVJPGLsNJ == 2) {
                    this.fa9d1cbf7 = p8df47e16Var;
                    return;
                }
            }
            this.fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(this.fcdee5967);
        }
    }
}

