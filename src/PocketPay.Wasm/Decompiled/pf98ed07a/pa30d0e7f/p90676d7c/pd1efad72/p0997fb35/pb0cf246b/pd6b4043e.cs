namespace WillowMaze.Wasm.Decompiled;


public readonly class pd6b4043e<T, U : java.util.ICollection<T>> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, U> {
    readonly io.reactivex.rxjava3.functions.Supplier<U> f590a3e62;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f94c656a2;

    public pd6b4043e(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Supplier<U> supplier) {
        super(flowable);
        this.f590a3e62 = supplier;
    }

    public static java.lang.object IsMsSvBPBPzjiPHE(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void NrIlSaoVhZdpfuRR(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object NuMoGggHDCbqEogv(java.lang.object obj, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me6c135c2(obj, str);
    }

    public static void VoDDdWIALSEztSfU(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static void KXFZpbiURlQraQnV(java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.error(th, p992c4a5bVar);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<U> subscriber) {
        if ((24 + 31) % 31 > 0) {
        }
        try {
            VoDDdWIALSEztSfU(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd6b4043e$pf047b211(subscriber, (java.util.ICollection) NuMoGggHDCbqEogv(IsMsSvBPBPzjiPHE(this.f590a3e62), "The collectionSupplier returned a null ICollection.")));
        } catch (java.lang.Exception th) {
            NrIlSaoVhZdpfuRR(th);
            kXFZpbiURlQraQnV(th, subscriber);
        }
    }
}

