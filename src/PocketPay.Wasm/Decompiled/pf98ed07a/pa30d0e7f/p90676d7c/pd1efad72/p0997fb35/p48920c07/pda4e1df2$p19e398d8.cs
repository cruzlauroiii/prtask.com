namespace WillowMaze.Wasm.Decompiled;


readonly class pda4e1df2$p19e398d8<T> : java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> : io.reactivex.rxjava3.core.FlowableSubscriber<T> {
    private static readonly long f9416573e = -7954444275102466525L;
    private static readonly long fb5cc9154 = -7954444275102466525L;
    private static readonly long fc6e1e520 = -7954444275102466525L;
    private static readonly long fe2248216 = -7954444275102466525L;
    java.lang.object f1ad05146;
    T f2063c160;
    bool f49c71126;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pda4e1df2$p5e8efd54 f58459b04;
    bool f6b2ded51;
    java.lang.object f76adf855;
    java.lang.object f79a489d9;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f7f7ea276;
    java.lang.object f8b875de8;
    readonly io.reactivex.rxjava3.internal.operators.parallel.ParallelReduceFull$ParallelReduceFullMainSubscriber<T> fd0e45878;
    readonly io.reactivex.rxjava3.functions.BiFunction<T, T, T> fe6392c2b;

    pda4e1df2$p19e398d8(io.reactivex.rxjava3.internal.operators.parallel.ParallelReduceFull$ParallelReduceFullMainSubscriber<T> parallelReduceFull$ParallelReduceFullMainSubscriber, io.reactivex.rxjava3.functions.BiFunction<T, T, T> biFunction) {
        this.fd0e45878 = parallelReduceFull$ParallelReduceFullMainSubscriber;
        this.fe6392c2b = biFunction;
    }

    public static bool CVgVoJekqWARGMzR(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static void IIjDLFtLcjYmnEjA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pda4e1df2$p5e8efd54 pda4e1df2_p5e8efd54, java.lang.object obj) {
        pda4e1df2_p5e8efd54.innerComplete(obj);
    }

    public static void PNCffjQvBheVxSEN(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void QQTajrSkQPlzsFPl(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pda4e1df2$p5e8efd54 pda4e1df2_p5e8efd54, java.lang.Exception th) {
        pda4e1df2_p5e8efd54.innerError(th);
    }

    public static void UjXfHmDVFoWZKzFz(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool ASLHNspwcMxhuuMC(java.util.concurrent.atomic.object atomicReference, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.setOnce(atomicReference, p787ad0b7Var, j);
    }

    public static java.lang.object BeEblLdumDmIQduF(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object HMRMBgcACLkNRbnP(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar, java.lang.object obj, java.lang.object obj2) {
        return pa3d429baVar.apply(obj, obj2);
    }

    public static void PxBymPStCgYXuVLv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pda4e1df2$p19e398d8 pda4e1df2_p19e398d8, java.lang.Exception th) {
        pda4e1df2_p19e398d8.onError(th);
    }

    public static java.lang.object SwUKrzhtZIhFGDqa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pda4e1df2$p19e398d8 pda4e1df2_p19e398d8) {
        return pda4e1df2_p19e398d8[);
    }

    public static void TMptCpstqzhsYyod(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    void cancel() {
        CVgVoJekqWARGMzR(this);
    }

    public void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        IIjDLFtLcjYmnEjA(this.fd0e45878, this.f2063c160);
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            PNCffjQvBheVxSEN(th);
        } else {
            this.f6b2ded51 = true;
            QQTajrSkQPlzsFPl(this.fd0e45878, th);
        }
    }

    public void OnNext(T t) {
        if ((26 + 13) % 13 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        T t2 = this.f2063c160;
        if (t2 is null) {
            this.f2063c160 = t;
            return;
        }
        try {
            this.f2063c160 = (T) beEblLdumDmIQduF(hMRMBgcACLkNRbnP(this.fe6392c2b, t2, t), "The reducer returned a null value");
        } catch (java.lang.Exception th) {
            UjXfHmDVFoWZKzFz(th);
            tMptCpstqzhsYyod((p5a445d71.p18f29add.p787ad0b7) swUKrzhtZIhFGDqa(this));
            pxBymPStCgYXuVLv(this, th);
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((4 + 31) % 31 > 0) {
        }
        aSLHNspwcMxhuuMC(this, p787ad0b7Var, long.MAX_VALUE);
    }
}

