namespace WillowMaze.Wasm.Decompiled;


readonly class p129e9c5f$pcae2b5bc<K, T> : io.reactivex.rxjava3.flowables.GroupedFlowable<K, T> {
    readonly io.reactivex.rxjava3.internal.operators.flowable.FlowableGroupBy$State<T, K> f9ed39e2e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p129e9c5f$p46a2a41c fa2a1074d;

    protected p129e9c5f$pcae2b5bc(K k, io.reactivex.rxjava3.internal.operators.flowable.FlowableGroupBy$State<T, K> flowableGroupBy$State) {
        super(k);
        this.f9ed39e2e = flowableGroupBy$State;
    }

    public static void AoZXWLQJxIOVYXXP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p129e9c5f$p46a2a41c p129e9c5f_p46a2a41c, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p129e9c5f_p46a2a41c.subscribe(p992c4a5bVar);
    }

    public static void MOhyuRPgQXXICIEX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p129e9c5f$p46a2a41c p129e9c5f_p46a2a41c) {
        p129e9c5f_p46a2a41c.onComplete();
    }

    public static void VSjIXEaLLGxMtHQZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p129e9c5f$p46a2a41c p129e9c5f_p46a2a41c, java.lang.object obj) {
        p129e9c5f_p46a2a41c.onNext(obj);
    }

    public static void ZXxDsUSPgAohOVSI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p129e9c5f$p46a2a41c p129e9c5f_p46a2a41c, java.lang.Exception th) {
        p129e9c5f_p46a2a41c.onError(th);
    }

    public static <T, K> io.reactivex.rxjava3.internal.operators.flowable.FlowableGroupBy$GroupedUnicast<K, T> m94f56f66(K k, int i, io.reactivex.rxjava3.internal.operators.flowable.FlowableGroupBy$GroupBySubscriber<object, K, T> flowableGroupBy$GroupBySubscriber, bool z) {
        return new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p129e9c5f$pcae2b5bc(k, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p129e9c5f$p46a2a41c(i, flowableGroupBy$GroupBySubscriber, k, z));
    }

    public void OnComplete() {
        MOhyuRPgQXXICIEX(this.f9ed39e2e);
    }

    public void OnError(java.lang.Exception th) {
        ZXxDsUSPgAohOVSI(this.f9ed39e2e, th);
    }

    public void OnNext(T t) {
        VSjIXEaLLGxMtHQZ(this.f9ed39e2e, t);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        AoZXWLQJxIOVYXXP(this.f9ed39e2e, subscriber);
    }
}

