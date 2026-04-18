namespace WillowMaze.Wasm.Decompiled;


readonly class pe52476f1$p61103ed0<T> : io.reactivex.rxjava3.internal.subscriptions.DeferredScalarSubscription<T> : io.reactivex.rxjava3.core.SingleObserver<T> {
    private static readonly long f1605323c = 187782011903685568L;
    private static readonly long f78fcb6db = 187782011903685568L;
    private static readonly long fb9cecf09 = 187782011903685568L;
    private static readonly long fc6e1e520 = 187782011903685568L;
    private static readonly long fdf0503b5 = 187782011903685568L;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fb5558b8b;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;

    pe52476f1$p61103ed0(org.reactivestreams.Subscriber<T> subscriber) {
        super(subscriber);
    }

    public static void JGjyWPGhifPtTSSA(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void KkIDAWzKalXwFhHa(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void OWWjHXPJylQePvkq(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static bool VAbBhLUrFSeXfprz(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void ActhXrzNbsMVSPEp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pe52476f1$p61103ed0 pe52476f1_p61103ed0, java.lang.object obj) {
        pe52476f1_p61103ed0.complete(obj);
    }

    public static void GaJcZrsGIxxpthPy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pb7d2cb4c pb7d2cb4cVar) {
        super.cancel();
    }

    public void Cancel() {
        gaJcZrsGIxxpthPy(this);
        JGjyWPGhifPtTSSA(this.fbc3b0556);
    }

    public override void OnError(java.lang.Exception th) {
        KkIDAWzKalXwFhHa(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (VAbBhLUrFSeXfprz(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            OWWjHXPJylQePvkq(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        acthXrzNbsMVSPEp(this, t);
    }
}

