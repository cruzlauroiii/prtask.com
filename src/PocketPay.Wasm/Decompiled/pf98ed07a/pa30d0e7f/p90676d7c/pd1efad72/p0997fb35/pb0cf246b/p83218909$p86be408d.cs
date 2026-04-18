namespace WillowMaze.Wasm.Decompiled;


readonly class p83218909$p86be408d<T> : io.reactivex.rxjava3.internal.operators.flowable.FlowableRepeatWhen$WhenSourceSubscriber<T, java.lang.object> {
    private static readonly long fbc62da9b = -2680129890138081029L;
    private static readonly long fc6e1e520 = -2680129890138081029L;

    p83218909$p86be408d(org.reactivestreams.Subscriber<T> subscriber, io.reactivex.rxjava3.processors.FlowableProcessor<java.lang.object> flowableProcessor, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        super(subscriber, flowableProcessor, p787ad0b7Var);
    }

    public static void GPqPijIpGoTczTTY(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static java.lang.int ScuyHceMWdZxSBDK(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void AdtjPzJlOBEzNEDd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p83218909$p86be408d p83218909_p86be408d, java.lang.object obj) {
        p83218909_p86be408d.again(obj);
    }

    public static void NbGtUDPynGKxCtfs(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public void OnComplete() {
        adtjPzJlOBEzNEDd(this, ScuyHceMWdZxSBDK(0));
    }

    public void OnError(java.lang.Exception th) {
        nbGtUDPynGKxCtfs(this.fa2ae6cc9);
        GPqPijIpGoTczTTY(this.fd22a0a80, th);
    }
}

