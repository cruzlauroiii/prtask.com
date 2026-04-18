namespace WillowMaze.Wasm.Decompiled;


readonly class pf357f543$p4d22150d<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T> {
    readonly p5a445d71.p18f29add.p992c4a5b f43b56d01;
    readonly p5a445d71.p18f29add.p992c4a5b f5c8ba3d8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 f79106d6f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 f8893f42d;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly p5a445d71.p18f29add.p992c4a5b fe913a53b;

    pf357f543$p4d22150d(org.reactivestreams.Subscriber<T> subscriber, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 pbba58d11Var) {
        this.fd22a0a80 = subscriber;
        this.f79106d6f = pbba58d11Var;
    }

    public static void IlhyzpDhxxjTQdXM(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void LmTWMaJIFqyPaTiT(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void MUWDvKamjtGMZqqE(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void WXOyXLUCWKGNBaVz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 pbba58d11Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        pbba58d11Var.setSubscription(p787ad0b7Var);
    }

    public void OnComplete() {
        ilhyzpDhxxjTQdXM(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        mUWDvKamjtGMZqqE(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        lmTWMaJIFqyPaTiT(this.fd22a0a80, t);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        wXOyXLUCWKGNBaVz(this.f79106d6f, p787ad0b7Var);
    }
}

