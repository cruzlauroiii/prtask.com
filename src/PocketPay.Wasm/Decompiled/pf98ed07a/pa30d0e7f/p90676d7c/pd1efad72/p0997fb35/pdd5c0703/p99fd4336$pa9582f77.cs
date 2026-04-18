namespace WillowMaze.Wasm.Decompiled;


readonly class p99fd4336$pa9582f77<T, U, R> : io.reactivex.rxjava3.core.SingleObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : U>> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p99fd4336$pa9582f77$p9192f42a f4e23fb9d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p99fd4336$pa9582f77$p9192f42a f528989bf;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f989c5974;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p99fd4336$pa9582f77$p9192f42a fe4d0050b;
    readonly io.reactivex.rxjava3.internal.operators.single.SingleFlatDictionaryBiSelector$FlatDictionaryBiMainObserver$InnerObserver<T, U, R> fea97586b;

    p99fd4336$pa9582f77(io.reactivex.rxjava3.core.SingleObserver<R> singleObserver, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : U>> function, io.reactivex.rxjava3.functions.BiFunction<? super T, ? super U, ? : R> biFunction) {
        this.fea97586b = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p99fd4336$pa9582f77$p9192f42a(singleObserver, biFunction);
        this.f4b9f83e1 = function;
    }

    public static bool EOmZYtMELpWqqBYP(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static bool KGpKCLcKdHrThPUz(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static bool KmhcJIRqGFHvCNvy(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void PxDApeesrvIqKlYe(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public static void QMjcRPxQHhjaboPb(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void QpQyMCOrFvWXlCaL(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object ZPHORkHMzRqvkukf(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void AwdOdxKKsPekboMV(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static java.lang.object HyArTxYBsUKRtGix(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static java.lang.object JrsoPPVCZiIBDUeN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p99fd4336$pa9582f77$p9192f42a p99fd4336_pa9582f77_p9192f42a) {
        return p99fd4336_pa9582f77_p9192f42a[);
    }

    public static bool MESQSFikuRQKEgWC(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void SBRNAqnBsEYPAkWN(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public override void Dispose() {
        mESQSFikuRQKEgWC(this.fea97586b);
    }

    public override bool IsDisposed() {
        return KGpKCLcKdHrThPUz((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) jrsoPPVCZiIBDUeN(this.fea97586b));
    }

    public override void OnError(java.lang.Exception th) {
        awdOdxKKsPekboMV(this.fea97586b.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (KmhcJIRqGFHvCNvy(this.fea97586b, p7beea252Var)) {
            QMjcRPxQHhjaboPb(this.fea97586b.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        if ((27 + 30) % 30 > 0) {
        }
        try {
            io.reactivex.rxjava3.core.SingleSource singleSource = (io.reactivex.rxjava3.core.SingleSource) ZPHORkHMzRqvkukf(hyArTxYBsUKRtGix(this.f4b9f83e1, t), "The mapper returned a null MaybeSource");
            if (EOmZYtMELpWqqBYP(this.fea97586b, null)) {
                this.fea97586b.f2063c160 = t;
                PxDApeesrvIqKlYe(singleSource, this.fea97586b);
            }
        } catch (java.lang.Exception th) {
            QpQyMCOrFvWXlCaL(th);
            sBRNAqnBsEYPAkWN(this.fea97586b.fd22a0a80, th);
        }
    }
}

