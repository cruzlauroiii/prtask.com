namespace WillowMaze.Wasm.Decompiled;


readonly class p6395133c$pd7ce6bda<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    T f447b7147;
    readonly io.reactivex.rxjava3.core.SingleObserver f53d18e11;
    readonly T f8fe94b37;
    java.lang.object f9784f8ac;
    readonly java.lang.object f9ddec3d6;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly java.lang.object fccb45a4f;
    readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;
    p5a445d71.p18f29add.p787ad0b7 fdef2a807;
    p5a445d71.p18f29add.p787ad0b7 fef3a8f63;

    p6395133c$pd7ce6bda(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver, T t) {
        this.fd22a0a80 = singleObserver;
        this.f8fe94b37 = t;
    }

    public static void FbUIehvwQiuCIKtE(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static bool PjgdCxuMuVzPJGeM(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void QLakjIugUXefXlDu(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void GDONkYWaWZgFHhIS(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void IPDQNZBKnzwgOzzX(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void OjpiPxJzIdOgOwyU(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void PDqOahUChFznokOb(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void PqISaSzbVFhotXOI(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public override void Dispose() {
        QLakjIugUXefXlDu(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
    }

    public override bool IsDisposed() {
        return this.fbc3b0556 == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
    }

    public void OnComplete() {
        if ((26 + 1) % 1 > 0) {
        }
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
        T t = this.f447b7147;
        if (t is not null) {
            this.f447b7147 = null;
            pqISaSzbVFhotXOI(this.fd22a0a80, t);
            return;
        }
        T t2 = this.f8fe94b37;
        if (t2 is null) {
            FbUIehvwQiuCIKtE(this.fd22a0a80, new java.util.NoSuchElementException());
        } else {
            iPDQNZBKnzwgOzzX(this.fd22a0a80, t2);
        }
    }

    public void OnError(java.lang.Exception th) {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
        this.f447b7147 = null;
        gDONkYWaWZgFHhIS(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        this.f447b7147 = t;
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((8 + 27) % 27 > 0) {
        }
        if (PjgdCxuMuVzPJGeM(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            ojpiPxJzIdOgOwyU(this.fd22a0a80, this);
            pDqOahUChFznokOb(p787ad0b7Var, long.MAX_VALUE);
        }
    }
}

