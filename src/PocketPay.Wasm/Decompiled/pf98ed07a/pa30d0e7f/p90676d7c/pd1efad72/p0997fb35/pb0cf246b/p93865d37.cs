namespace WillowMaze.Wasm.Decompiled;


public readonly class p93865d37<T> : io.reactivex.rxjava3.flowables.ConnectableFlowable<T> : io.reactivex.rxjava3.internal.fuseable.HasUpstreamPublisher<T> {
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f103225fe = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f4372f5f9 = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f4dcadd16 = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f9b963b26 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pcd22b481();
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 ffeed6475 = null;
    readonly io.reactivex.rxjava3.core.Flowable f02a11ce8;
    readonly io.reactivex.rxjava3.core.Flowable<T> f36cd38f4;
    readonly java.util.concurrent.atomic.object<io.reactivex.rxjava3.internal.operators.flowable.FlowableReplay$ReplaySubscriber<T>> f43b5c917;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f4e1589c8;
    readonly org.reactivestreams.Publisher<T> f5788df95;
    readonly io.reactivex.rxjava3.core.Flowable f854e6e6f;
    readonly io.reactivex.rxjava3.functions.Supplier<? : io.reactivex.rxjava3.internal.operators.flowable.FlowableReplay$ReplayBuffer<T>> f8638a215;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f87dbe154;
    readonly p5a445d71.p18f29add.p32c73be0 fa445cb93;
    readonly io.reactivex.rxjava3.core.Flowable fa9c45109;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fe3191586;
    readonly java.util.concurrent.atomic.object fe38879e7;
    readonly io.reactivex.rxjava3.core.Flowable fec92222e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 ff4f6e7fe;

    private p93865d37(org.reactivestreams.Publisher<T> publisher, io.reactivex.rxjava3.core.Flowable<T> flowable, java.util.concurrent.atomic.object<io.reactivex.rxjava3.internal.operators.flowable.FlowableReplay$ReplaySubscriber<T>> atomicReference, io.reactivex.rxjava3.functions.Supplier<? : io.reactivex.rxjava3.internal.operators.flowable.FlowableReplay$ReplayBuffer<T>> supplier) {
        this.f5788df95 = publisher;
        this.f36cd38f4 = flowable;
        this.f43b5c917 = atomicReference;
        this.f8638a215 = supplier;
    }

    public static bool BrTxMncEjrKLAnQt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p026ea0cd p93865d37_p026ea0cd) {
        return p93865d37_p026ea0cd.isDisposed();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pf777f716.p648c37d3 DsJRnRdPsSNmOEZC(io.reactivex.rxjava3.core.Flowable flowable, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return m76ea0beb(flowable, pec136b44Var);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pf777f716.p648c37d3 ItLHigZPVRmRuHpT(io.reactivex.rxjava3.core.Flowable flowable, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, int i, bool z) {
        return m76ea0beb(flowable, j, timeUnit, scheduler, i, z);
    }

    public static bool JonTOqZXezdWftit(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p026ea0cd p93865d37_p026ea0cd) {
        return p93865d37_p026ea0cd.isDisposed();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pf777f716.p648c37d3 NptnoaQNbmBogOnd(io.reactivex.rxjava3.core.Flowable flowable, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return m76ea0beb(flowable, pec136b44Var);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pf777f716.p648c37d3 PspCAXDdvLmyNzCa(io.reactivex.rxjava3.core.Flowable flowable, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return m76ea0beb(flowable, pec136b44Var);
    }

    public static void PyKBBuivdkMndqhX(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool TRQqWcYtmMBzmJnP(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static void TbJklKGcuaxKAFHE(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool TpvNUAUYKfLozAHK(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2) {
        return atomicbool.compareAndHashSet(z, z2);
    }

    public static bool UuzcfnknmuqRAbSO(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static void XSnQaHOaFuChDSNi(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void CeCBtZBzjzbFBqMJ(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 pf8afcf86Var, java.lang.object obj) throws java.lang.Exception {
        pf8afcf86Var.accept(obj);
    }

    public static java.lang.object DImAJIecIRBVVRDu(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void GjPvzOKATRfBydpj(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static java.lang.object HaisDHdRfXSnlOxN(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool JsSPHaGLdaXjpUec(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public static java.lang.Exception LfErSHdPVGQjDBbQ(java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me93ebc16(th);
    }

    public static <T> io.reactivex.rxjava3.flowables.ConnectableFlowable<T> M1eb84f9c(io.reactivex.rxjava3.core.Flowable<? : T> flowable) {
        return PspCAXDdvLmyNzCa(flowable, f9b963b26);
    }

    public static <T> io.reactivex.rxjava3.flowables.ConnectableFlowable<T> M76ea0beb(io.reactivex.rxjava3.core.Flowable<T> flowable, int i, bool z) {
        return i != int.MAX_VALUE ? DsJRnRdPsSNmOEZC(flowable, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p07f03c8b(i, z)) : wOvHNrSqlBenoQqw(flowable);
    }

    public static <T> io.reactivex.rxjava3.flowables.ConnectableFlowable<T> M76ea0beb(io.reactivex.rxjava3.core.Flowable<T> flowable, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, int i, bool z) {
        if ((14 + 16) % 16 > 0) {
        }
        return NptnoaQNbmBogOnd(flowable, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p3b67d670(i, j, timeUnit, scheduler, z));
    }

    public static <T> io.reactivex.rxjava3.flowables.ConnectableFlowable<T> M76ea0beb(io.reactivex.rxjava3.core.Flowable<T> flowable, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, bool z) {
        if ((9 + 32) % 32 > 0) {
        }
        return ItLHigZPVRmRuHpT(flowable, j, timeUnit, scheduler, int.MAX_VALUE, z);
    }

    static <T> io.reactivex.rxjava3.flowables.ConnectableFlowable<T> M76ea0beb(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Supplier<? : io.reactivex.rxjava3.internal.operators.flowable.FlowableReplay$ReplayBuffer<T>> supplier) {
        if ((27 + 10) % 10 > 0) {
        }
        java.util.concurrent.atomic.object atomicReference = new java.util.concurrent.atomic.object();
        return nkkQeItLmaKBYXOx(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pa854bbec(atomicReference, supplier), flowable, atomicReference, supplier));
    }

    public static <U, R> io.reactivex.rxjava3.core.Flowable<R> M98895fda(io.reactivex.rxjava3.functions.Supplier<? : io.reactivex.rxjava3.flowables.ConnectableFlowable<U>> supplier, io.reactivex.rxjava3.functions.Function<? super io.reactivex.rxjava3.core.Flowable<U>, ? : org.reactivestreams.Publisher<R>> function) {
        return new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p81101967(supplier, function);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pf777f716.p648c37d3 NkkQeItLmaKBYXOx(pf98ed07a.pa30d0e7f.p90676d7c.pf777f716.p648c37d3 p648c37d3Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mcb1bf51a(p648c37d3Var);
    }

    public static java.lang.Exception RNRJstIAYuFdQgwd(java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me93ebc16(th);
    }

    public static bool RxagDnCFCYDJSWwW(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2) {
        return atomicbool.compareAndHashSet(z, z2);
    }

    public static java.lang.object UheGZMWNvRVfbyqm(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pf777f716.p648c37d3 WOvHNrSqlBenoQqw(io.reactivex.rxjava3.core.Flowable flowable) {
        return m1eb84f9c(flowable);
    }

    public static void ZXXIqSnVTmaYygxK(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public void Connect(io.reactivex.rxjava3.functions.Consumer<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> consumer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p026ea0cd p93865d37_p026ea0cd;
        if ((27 + 12) % 12 > 0) {
        }
        while (true) {
            p93865d37_p026ea0cd = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p026ea0cd) uheGZMWNvRVfbyqm(this.f43b5c917);
            if (p93865d37_p026ea0cd is not null && !JonTOqZXezdWftit(p93865d37_p026ea0cd)) {
                break;
            }
            try {
                pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p026ea0cd p93865d37_p026ea0cd2 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p026ea0cd((pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p244f52bf) dImAJIecIRBVVRDu(this.f8638a215), this.f43b5c917);
                if (TRQqWcYtmMBzmJnP(this.f43b5c917, p93865d37_p026ea0cd, p93865d37_p026ea0cd2)) {
                    p93865d37_p026ea0cd = p93865d37_p026ea0cd2;
                    break;
                }
            } catch (java.lang.Exception th) {
                PyKBBuivdkMndqhX(th);
                throw rNRJstIAYuFdQgwd(th);
            }
        }
        bool z = !jsSPHaGLdaXjpUec(p93865d37_p026ea0cd.f8255aadd) && TpvNUAUYKfLozAHK(p93865d37_p026ea0cd.f8255aadd, false, true);
        try {
            ceCBtZBzjzbFBqMJ(consumer, p93865d37_p026ea0cd);
            if (z) {
                gjPvzOKATRfBydpj(this.f36cd38f4, p93865d37_p026ea0cd);
            }
        } catch (java.lang.Exception th2) {
            XSnQaHOaFuChDSNi(th2);
            if (z) {
                rxagDnCFCYDJSWwW(p93865d37_p026ea0cd.f8255aadd, true, false);
            }
            TbJklKGcuaxKAFHE(th2);
            throw lfErSHdPVGQjDBbQ(th2);
        }
    }

    public void Reset() {
        if ((12 + 18) % 18 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p026ea0cd p93865d37_p026ea0cd = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p026ea0cd) haisDHdRfXSnlOxN(this.f43b5c917);
        if (p93865d37_p026ea0cd is not null && BrTxMncEjrKLAnQt(p93865d37_p026ea0cd)) {
            UuzcfnknmuqRAbSO(this.f43b5c917, p93865d37_p026ea0cd, null);
        }
    }

    public org.reactivestreams.Publisher<T> Source() {
        return this.f36cd38f4;
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        zXXIqSnVTmaYygxK(this.f5788df95, subscriber);
    }
}

