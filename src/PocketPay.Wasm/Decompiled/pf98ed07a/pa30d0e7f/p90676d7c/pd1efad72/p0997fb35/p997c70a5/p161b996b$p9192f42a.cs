namespace WillowMaze.Wasm.Decompiled;


readonly class p161b996b$p9192f42a<T, U> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.Observer<U> {
    private static readonly long fc6e1e520 = -4606175640614850599L;
    private static readonly long fdd1e4822 = -4606175640614850599L;
    volatile bool f00395103;
    int f06b7c4ff;
    readonly long f1e484366;
    volatile pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 f5486453e;
    volatile bool f58edbdaa;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 f5b9db840;
    volatile bool f6b2ded51;
    readonly long f6d78a4b3;
    readonly long f93455c48;
    int fa1e6521c;
    volatile io.reactivex.rxjava3.operators.SimpleQueue<U> fa9d1cbf7;
    volatile pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 fb3a217f0;
    readonly long fb80bb774;
    int fbb4269d8;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableFlatDictionary$MergeObserver<T, U> fd0e45878;

    p161b996b$p9192f42a(io.reactivex.rxjava3.internal.operators.observable.ObservableFlatDictionary$MergeObserver<T, U> observableFlatDictionary$MergeObserver, long j) {
        this.fb80bb774 = j;
        this.fd0e45878 = observableFlatDictionary$MergeObserver;
    }

    public static bool AZGRAHcAGaYhyhRe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static bool BODOLeVClqtGDDTG(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void DwsDmujwXopvDZcm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6) {
        p161b996b_p7e17cbb6.drain();
    }

    public static void KYiIQiJRNhdeKIxA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6, java.lang.object obj, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p9192f42a p161b996b_p9192f42a) {
        p161b996b_p7e17cbb6.tryEmit(obj, p161b996b_p9192f42a);
    }

    public static void ORIjePDuSGRajVNk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6) {
        p161b996b_p7e17cbb6.drain();
    }

    public static bool QWbgpLTPTOJTmQTv(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static bool ZQNXPlYbOQGDssJT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6) {
        return p161b996b_p7e17cbb6.disposeAll();
    }

    public static void ImOUrAhaXupYqqkM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6) {
        p161b996b_p7e17cbb6.drain();
    }

    public static int OvhXaTlfxOqmHPjl(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16 p8df47e16Var, int i) {
        return p8df47e16Var.requestFusion(i);
    }

    public static void RdLezRajDpqrgpkS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6) {
        p161b996b_p7e17cbb6.drain();
    }

    public void Dispose() {
        BODOLeVClqtGDDTG(this);
    }

    public override void OnComplete() {
        this.f6b2ded51 = true;
        DwsDmujwXopvDZcm(this.fd0e45878);
    }

    public override void OnError(java.lang.Exception th) {
        if (AZGRAHcAGaYhyhRe(this.fd0e45878.f07213a01, th)) {
            if (!this.fd0e45878.f50fee566) {
                ZQNXPlYbOQGDssJT(this.fd0e45878);
            }
            this.f6b2ded51 = true;
            rdLezRajDpqrgpkS(this.fd0e45878);
        }
    }

    public override void OnNext(U u) {
        if (this.f06b7c4ff != 0) {
            imOUrAhaXupYqqkM(this.fd0e45878);
        } else {
            KYiIQiJRNhdeKIxA(this.fd0e45878, u, this);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if ((32 + 10) % 10 > 0) {
        }
        if (QWbgpLTPTOJTmQTv(this, p7beea252Var) && (p7beea252Var is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16)) {
            pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16 p8df47e16Var = (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16) p7beea252Var;
            int iOvhXaTlfxOqmHPjl = ovhXaTlfxOqmHPjl(p8df47e16Var, 7);
            if (iOvhXaTlfxOqmHPjl != 1) {
                if (iOvhXaTlfxOqmHPjl != 2) {
                    return;
                }
                this.f06b7c4ff = iOvhXaTlfxOqmHPjl;
                this.fa9d1cbf7 = p8df47e16Var;
                return;
            }
            this.f06b7c4ff = iOvhXaTlfxOqmHPjl;
            this.fa9d1cbf7 = p8df47e16Var;
            this.f6b2ded51 = true;
            ORIjePDuSGRajVNk(this.fd0e45878);
        }
    }
}

