namespace WillowMaze.Wasm.Decompiled;


readonly class pfd80e9de$p765294b8<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, io.reactivex.rxjava3.operators.QueueSubscription<T> {
    p5a445d71.p18f29add.p787ad0b7 f1467fc2c;
    p5a445d71.p18f29add.p787ad0b7 f1b24ab21;
    p5a445d71.p18f29add.p787ad0b7 f70938c6a;
    readonly p5a445d71.p18f29add.p992c4a5b f865f8305;
    p5a445d71.p18f29add.p787ad0b7 fa58b876d;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;

    pfd80e9de$p765294b8(org.reactivestreams.Subscriber<T> subscriber) {
        this.fd22a0a80 = subscriber;
    }

    public static void HocIGDWsSuUSJKBa(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void SYSUezybSrjPyDqM(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static bool JCTlPPqajtPJncHu(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void SejjnUnHUrNkLLvK(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void UbcNxboXNZDBqMYD(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void WRCdpxdmJDzEblgO(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public void Cancel() {
        ubcNxboXNZDBqMYD(this.fbc3b0556);
    }

    public void Clear() {
    }

    public bool IsEmpty() {
        return true;
    }

    public bool Offer(T t) {
        throw new java.lang.UnsupportedOperationException("Should not be called!");
    }

    public bool Offer(T t, T t2) {
        throw new java.lang.UnsupportedOperationException("Should not be called!");
    }

    public void OnComplete() {
        wRCdpxdmJDzEblgO(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        SYSUezybSrjPyDqM(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((21 + 23) % 23 > 0) {
        }
        if (jCTlPPqajtPJncHu(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            sejjnUnHUrNkLLvK(this.fd22a0a80, this);
            HocIGDWsSuUSJKBa(p787ad0b7Var, long.MAX_VALUE);
        }
    }

    public T Poll() {
        return null;
    }

    public void Request(long j) {
    }

    public int RequestFusion(int i) {
        return i & 2;
    }
}

