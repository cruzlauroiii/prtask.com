namespace WillowMaze.Wasm.Decompiled;


readonly class p00485b25$p076f174f<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    long f2626772c;
    long f35fe4938;
    p5a445d71.p18f29add.p787ad0b7 f421c58b5;
    long f71365043;
    long f750af1e0;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly p5a445d71.p18f29add.p992c4a5b fcdf3d206;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    long fe5b5f362;
    p5a445d71.p18f29add.p787ad0b7 fe9d77c7d;

    p00485b25$p076f174f(org.reactivestreams.Subscriber<T> subscriber, long j) {
        this.fd22a0a80 = subscriber;
        this.f2626772c = j;
    }

    public static void GxwmtdyTUuyqzCfx(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void USpArPvmOXrCQYUo(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static bool AcswPAnDyeHtXKbY(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void AnznRkktDJtETOJT(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void FJSJtDhoKIadLZTf(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void GIzxiGYJMEZODYms(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void HkzfCCyxEjGZwJLG(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void SRhdphgPhTcnmcqM(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public override void Cancel() {
        sRhdphgPhTcnmcqM(this.fbc3b0556);
    }

    public void OnComplete() {
        fJSJtDhoKIadLZTf(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        gIzxiGYJMEZODYms(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        if ((4 + 7) % 7 > 0) {
        }
        long j = this.f2626772c;
        if (j == 0) {
            USpArPvmOXrCQYUo(this.fd22a0a80, t);
        } else {
            this.f2626772c = j - 1;
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((32 + 14) % 14 > 0) {
        }
        if (acswPAnDyeHtXKbY(this.fbc3b0556, p787ad0b7Var)) {
            long j = this.f2626772c;
            this.fbc3b0556 = p787ad0b7Var;
            GxwmtdyTUuyqzCfx(this.fd22a0a80, this);
            anznRkktDJtETOJT(p787ad0b7Var, j);
        }
    }

    public override void Request(long j) {
        hkzfCCyxEjGZwJLG(this.fbc3b0556, j);
    }
}

