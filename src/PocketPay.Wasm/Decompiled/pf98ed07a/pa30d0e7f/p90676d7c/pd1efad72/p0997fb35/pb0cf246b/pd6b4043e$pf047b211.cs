namespace WillowMaze.Wasm.Decompiled;


readonly class pd6b4043e$pf047b211<T, U : java.util.ICollection<T>> : io.reactivex.rxjava3.internal.subscriptions.DeferredScalarSubscription<U> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    private static readonly long f3232e7ba = -8134157938864266736L;
    private static readonly long f6fd6d92e = -8134157938864266736L;
    private static readonly long fc6e1e520 = -8134157938864266736L;
    p5a445d71.p18f29add.p787ad0b7 f3703bdd4;
    p5a445d71.p18f29add.p787ad0b7 f77f930b8;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    p5a445d71.p18f29add.p787ad0b7 ff3d1ea73;
    p5a445d71.p18f29add.p787ad0b7 ffc0563b2;

    pd6b4043e$pf047b211(org.reactivestreams.Subscriber<U> subscriber, U u) {
        super(subscriber);
        this.f2063c160 = u;
    }

    public static void AvtvxbiCgTioCnHt(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void ICOZVTifjftitlLh(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void MpOaAiojuevXnmWU(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void VuzkGDzHDNQtdhUy(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static bool ZnwiGFRDvNphIYpq(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool JXPcMyhJHpknUIfx(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void SbXTFuMFqINKXCqm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pb7d2cb4c pb7d2cb4cVar) {
        super.cancel();
    }

    public static void WMtHNzvDDEEVtRpy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd6b4043e$pf047b211 pd6b4043e_pf047b211, java.lang.object obj) {
        pd6b4043e_pf047b211.complete(obj);
    }

    public override void Cancel() {
        sbXTFuMFqINKXCqm(this);
        VuzkGDzHDNQtdhUy(this.fbc3b0556);
    }

    public void OnComplete() {
        wMtHNzvDDEEVtRpy(this, this.f2063c160);
    }

    public void OnError(java.lang.Exception th) {
        this.f2063c160 = null;
        MpOaAiojuevXnmWU(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        java.util.ICollection collection = (java.util.ICollection) this.f2063c160;
        if (collection is null) {
            return;
        }
        ZnwiGFRDvNphIYpq(collection, t);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((22 + 22) % 22 > 0) {
        }
        if (jXPcMyhJHpknUIfx(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            ICOZVTifjftitlLh(this.fd22a0a80, this);
            AvtvxbiCgTioCnHt(p787ad0b7Var, long.MAX_VALUE);
        }
    }
}

