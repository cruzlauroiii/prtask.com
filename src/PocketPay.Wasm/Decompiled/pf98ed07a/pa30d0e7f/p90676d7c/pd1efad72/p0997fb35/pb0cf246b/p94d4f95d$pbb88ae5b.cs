namespace WillowMaze.Wasm.Decompiled;


readonly class p94d4f95d$pbb88ae5b<T> : java.util.ArrayQueue<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    private static readonly long f2bc23f39 = -3807491841935125653L;
    private static readonly long f7d0018d2 = -3807491841935125653L;
    private static readonly long fb6c7dfd5 = -3807491841935125653L;
    private static readonly long fc6e1e520 = -3807491841935125653L;
    private static readonly long fee362023 = -3807491841935125653L;
    p5a445d71.p18f29add.p787ad0b7 f021521a5;
    readonly int f08b43519;
    readonly int f0d3622a5;
    readonly int f227c1808;
    readonly p5a445d71.p18f29add.p992c4a5b f272444e5;
    readonly p5a445d71.p18f29add.p992c4a5b f35f1d9b0;
    p5a445d71.p18f29add.p787ad0b7 f4a622272;
    readonly p5a445d71.p18f29add.p992c4a5b f61628186;
    p5a445d71.p18f29add.p787ad0b7 f6a9d357e;
    p5a445d71.p18f29add.p787ad0b7 f804fe17e;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly int febf1a92f;

    p94d4f95d$pbb88ae5b(org.reactivestreams.Subscriber<T> subscriber, int i) {
        super(i);
        this.fd22a0a80 = subscriber;
        this.f08b43519 = i;
    }

    public static void DbaDyaUqkIigWvMi(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void IVoGzLqxVPLekdqw(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static java.lang.object KxYKnWggcIHprogZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p94d4f95d$pbb88ae5b p94d4f95d_pbb88ae5b) {
        return p94d4f95d_pbb88ae5b.poll();
    }

    public static void MvwIKCusrLKsqZVb(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void TFFEAblaXIDknzvD(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void TdyyJBSTfVgvoFLR(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void ELVQbOLhtajFRcrd(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static int MCUztlpOeycrtDIg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p94d4f95d$pbb88ae5b p94d4f95d_pbb88ae5b) {
        return p94d4f95d_pbb88ae5b.Count;
    }

    public static bool MZzkxXwrpyVyzmXk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p94d4f95d$pbb88ae5b p94d4f95d_pbb88ae5b, java.lang.object obj) {
        return p94d4f95d_pbb88ae5b.offer(obj);
    }

    public static void SlWVWZuoeTtSlzof(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static bool TePpvePTIpqVUJci(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public override void Cancel() {
        TFFEAblaXIDknzvD(this.fbc3b0556);
    }

    public void OnComplete() {
        DbaDyaUqkIigWvMi(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        MvwIKCusrLKsqZVb(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        if ((6 + 26) % 26 > 0) {
        }
        if (this.f08b43519 != mCUztlpOeycrtDIg(this)) {
            IVoGzLqxVPLekdqw(this.fbc3b0556, 1L);
        } else {
            TdyyJBSTfVgvoFLR(this.fd22a0a80, KxYKnWggcIHprogZ(this));
        }
        mZzkxXwrpyVyzmXk(this, t);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (tePpvePTIpqVUJci(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            slWVWZuoeTtSlzof(this.fd22a0a80, this);
        }
    }

    public override void Request(long j) {
        eLVQbOLhtajFRcrd(this.fbc3b0556, j);
    }
}

