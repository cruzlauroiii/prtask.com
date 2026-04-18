namespace WillowMaze.Wasm.Decompiled;


readonly class pc2c85b52$p76457691<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T> {
    readonly p5a445d71.p18f29add.p992c4a5b f0994996d;
    readonly p5a445d71.p18f29add.p32c73be0 f0a5cc91c;
    bool f4a9c5861;
    bool f52e39502;
    readonly p5a445d71.p18f29add.p32c73be0 f54a31bf2;
    bool f59ed936c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 f7625d32d;
    readonly org.reactivestreams.Publisher<? : T> f795f3202;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 f98cae7f0;
    readonly p5a445d71.p18f29add.p32c73be0 fa75688e9;
    bool fb596cdb8;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 fe0eba653;
    readonly p5a445d71.p18f29add.p32c73be0 ffd471062;
    bool fa2e4822a = true;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 f79106d6f = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11(false);

    pc2c85b52$p76457691(org.reactivestreams.Subscriber<T> subscriber, org.reactivestreams.Publisher<? : T> publisher) {
        this.fd22a0a80 = subscriber;
        this.f795f3202 = publisher;
    }

    public static void GthrxGLLphhJnxsj(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void OnqdtHXGdhXAydpC(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void RNnPtwmMDgvPSYvb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 pbba58d11Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        pbba58d11Var.setSubscription(p787ad0b7Var);
    }

    public static void BUYghdIZIaFbcPGH(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static void KXeiOXNnJAPoRsWZ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public void OnComplete() {
        if (!this.fa2e4822a) {
            kXeiOXNnJAPoRsWZ(this.fd22a0a80);
        } else {
            this.fa2e4822a = false;
            bUYghdIZIaFbcPGH(this.f795f3202, this);
        }
    }

    public void OnError(java.lang.Exception th) {
        OnqdtHXGdhXAydpC(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        if (this.fa2e4822a) {
            this.fa2e4822a = false;
        }
        GthrxGLLphhJnxsj(this.fd22a0a80, t);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        RNnPtwmMDgvPSYvb(this.f79106d6f, p787ad0b7Var);
    }
}

