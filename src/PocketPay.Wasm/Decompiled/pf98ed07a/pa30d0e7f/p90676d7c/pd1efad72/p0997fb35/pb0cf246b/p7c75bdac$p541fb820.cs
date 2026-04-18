namespace WillowMaze.Wasm.Decompiled;


readonly class p7c75bdac$p541fb820<T> : io.reactivex.rxjava3.internal.subscriptions.DeferredScalarSubscription<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T> {
    private static readonly long f4a0bb8a2 = -5526049321428043809L;
    private static readonly long fc6e1e520 = -5526049321428043809L;
    private static readonly long ff99f46ad = -5526049321428043809L;
    readonly java.lang.object f0d024158;
    readonly T f16830a58;
    readonly bool f3c441afd;
    readonly java.lang.object f5009b7e2;
    bool f54379ede;
    readonly bool f563024d5;
    readonly java.lang.object f5ddde5e7;
    readonly bool f65ac3b14;
    p5a445d71.p18f29add.p787ad0b7 f67cece2a;
    bool f6b2ded51;
    bool f71c618b6;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly bool ff6ab40b1;

    p7c75bdac$p541fb820(org.reactivestreams.Subscriber<T> subscriber, T t, bool z) {
        super(subscriber);
        this.f16830a58 = t;
        this.ff6ab40b1 = z;
    }

    public static void JpVhaerHKQShgjVE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7c75bdac$p541fb820 p7c75bdac_p541fb820, java.lang.object obj) {
        p7c75bdac_p541fb820.complete(obj);
    }

    public static void KeUxMfqXILOGMwSg(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void QNfVfJbMkuxEwujd(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void ShvxyPccgnpfmTwB(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static bool ALHFOkjyBjcjRnyG(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void ANseBvpGXQAJkMHI(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void ATgfqrGvfWxaAlCZ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void FYbinzLiorJjjRte(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void GjTobROgbbHkTbjg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pb7d2cb4c pb7d2cb4cVar) {
        super.cancel();
    }

    public static void JHoryoMMtrjCxFLU(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void OgXyZpLzZtELnfrB(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void XSBJzckYnYqyTYge(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public void Cancel() {
        gjTobROgbbHkTbjg(this);
        aNseBvpGXQAJkMHI(this.fbc3b0556);
    }

    public void OnComplete() {
        if ((3 + 2) % 2 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        java.lang.object obj = this.f2063c160;
        this.f2063c160 = null;
        if (obj is null) {
            obj = this.f16830a58;
        }
        if (obj is not null) {
            JpVhaerHKQShgjVE(this, obj);
        } else if (this.ff6ab40b1) {
            ogXyZpLzZtELnfrB(this.fd22a0a80, new java.util.NoSuchElementException());
        } else {
            KeUxMfqXILOGMwSg(this.fd22a0a80);
        }
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            xSBJzckYnYqyTYge(th);
        } else {
            this.f6b2ded51 = true;
            QNfVfJbMkuxEwujd(this.fd22a0a80, th);
        }
    }

    public void OnNext(T t) {
        if (this.f6b2ded51) {
            return;
        }
        if (this.f2063c160 is null) {
            this.f2063c160 = t;
            return;
        }
        this.f6b2ded51 = true;
        ShvxyPccgnpfmTwB(this.fbc3b0556);
        jHoryoMMtrjCxFLU(this.fd22a0a80, new java.lang.IllegalArgumentException("Sequence contains more than one element!"));
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((3 + 28) % 28 > 0) {
        }
        if (aLHFOkjyBjcjRnyG(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            aTgfqrGvfWxaAlCZ(this.fd22a0a80, this);
            fYbinzLiorJjjRte(p787ad0b7Var, long.MAX_VALUE);
        }
    }
}

