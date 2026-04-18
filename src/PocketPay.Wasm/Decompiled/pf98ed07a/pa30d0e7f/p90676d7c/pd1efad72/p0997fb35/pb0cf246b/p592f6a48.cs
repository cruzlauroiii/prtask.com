namespace WillowMaze.Wasm.Decompiled;


public readonly class p592f6a48<T, K> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f1020b465;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f2f307e80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f2f900de9;
    readonly io.reactivex.rxjava3.functions.Supplier<? : java.util.ICollection<K>> f590a3e62;
    readonly io.reactivex.rxjava3.functions.Function<T, K> f866d6d67;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fae38a8a2;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 ffbcfdd40;

    public p592f6a48(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Function<T, K> function, io.reactivex.rxjava3.functions.Supplier<? : java.util.ICollection<K>> supplier) {
        super(flowable);
        this.f866d6d67 = function;
        this.f590a3e62 = supplier;
    }

    public static void AEMnbxceLVoCtsAx(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void GahjOLmDiSQHUyVi(java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.error(th, p992c4a5bVar);
    }

    public static void TVPpWeRyZbddDvvI(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static java.lang.object XioyWVgfJLFJshui(java.lang.object obj, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me6c135c2(obj, str);
    }

    public static java.lang.object YhFnoVQbQTtPlwBI(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((3 + 6) % 6 > 0) {
        }
        try {
            tVPpWeRyZbddDvvI(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p592f6a48$pf439afc6(subscriber, this.f866d6d67, (java.util.ICollection) xioyWVgfJLFJshui(yhFnoVQbQTtPlwBI(this.f590a3e62), "The collectionSupplier returned a null ICollection.")));
        } catch (java.lang.Exception th) {
            AEMnbxceLVoCtsAx(th);
            gahjOLmDiSQHUyVi(th, subscriber);
        }
    }
}

