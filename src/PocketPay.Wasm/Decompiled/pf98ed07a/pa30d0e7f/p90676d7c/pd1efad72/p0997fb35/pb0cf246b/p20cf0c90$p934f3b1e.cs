namespace WillowMaze.Wasm.Decompiled;


readonly class p20cf0c90$p934f3b1e<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    readonly p5a445d71.p18f29add.p992c4a5b f0c12c18c;
    p5a445d71.p18f29add.p787ad0b7 f43c2ee17;
    readonly p5a445d71.p18f29add.p992c4a5b f48446214;
    p5a445d71.p18f29add.p787ad0b7 f76bb6c5c;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly p5a445d71.p18f29add.p992c4a5b fce469608;
    p5a445d71.p18f29add.p787ad0b7 fce972907;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;

    p20cf0c90$p934f3b1e(org.reactivestreams.Subscriber<T> subscriber) {
        this.fd22a0a80 = subscriber;
    }

    public static void IAOrssQAPdoavvIV(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void ZpnbWuBVwPEqfOfF(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void FLkGuqpjgsmrprze(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void LFoDmQmDFUCjUVdc(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void PTlwygHeQjAFvzPK(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static bool QJRdOjQiOqeflepa(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void YYgUBLiLHwHbWAfP(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public override void Cancel() {
        lFoDmQmDFUCjUVdc(this.fbc3b0556);
    }

    public void OnComplete() {
        IAOrssQAPdoavvIV(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        yYgUBLiLHwHbWAfP(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        ZpnbWuBVwPEqfOfF(this.fd22a0a80, t);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (qJRdOjQiOqeflepa(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            fLkGuqpjgsmrprze(this.fd22a0a80, this);
        }
    }

    public override void Request(long j) {
        pTlwygHeQjAFvzPK(this.fbc3b0556, j);
    }
}

