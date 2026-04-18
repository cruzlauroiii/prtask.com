namespace WillowMaze.Wasm.Decompiled;


readonly class p969e70db$pa49a6305<T> : io.reactivex.rxjava3.internal.operators.flowable.FlowableRepeatWhen$WhenSourceSubscriber<T, java.lang.Exception> {
    private static readonly long f6f0320a8 = -2680129890138081029L;
    private static readonly long fa8cb32ab = -2680129890138081029L;
    private static readonly long fc69c1c42 = -2680129890138081029L;
    private static readonly long fc6e1e520 = -2680129890138081029L;
    private static readonly long fdcb144b7 = -2680129890138081029L;

    p969e70db$pa49a6305(org.reactivestreams.Subscriber<T> subscriber, io.reactivex.rxjava3.processors.FlowableProcessor<java.lang.Exception> flowableProcessor, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        super(subscriber, flowableProcessor, p787ad0b7Var);
    }

    public static void GCFqRjxxJAqxxPrl(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void CVlxerQkulSLpWcr(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void KUrotxydaQTtdKlO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p969e70db$pa49a6305 p969e70db_pa49a6305, java.lang.object obj) {
        p969e70db_pa49a6305.again(obj);
    }

    public void OnComplete() {
        cVlxerQkulSLpWcr(this.fa2ae6cc9);
        GCFqRjxxJAqxxPrl(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        kUrotxydaQTtdKlO(this, th);
    }
}

