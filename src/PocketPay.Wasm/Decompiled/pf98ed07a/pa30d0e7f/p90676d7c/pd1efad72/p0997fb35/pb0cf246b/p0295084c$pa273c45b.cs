namespace WillowMaze.Wasm.Decompiled;


readonly class p0295084c$pa273c45b<T> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.FlowableSubscriber<T> {
    private static readonly long fc6e1e520 = -7098360935104053232L;
    private static readonly long fe1eb4a1f = -7098360935104053232L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 f0afe96e8;
    long f0da3329a;
    long f2626772c;
    readonly org.reactivestreams.Publisher<? : T> f36cd38f4;
    readonly p5a445d71.p18f29add.p992c4a5b f4f090a06;
    long f5051d8ee;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 f69fa0868;
    readonly p5a445d71.p18f29add.p32c73be0 f6bed4494;
    long f7ae4877f;
    readonly p5a445d71.p18f29add.p992c4a5b f7c20d080;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 f820431e5;
    readonly p5a445d71.p18f29add.p32c73be0 f984af131;
    readonly p5a445d71.p18f29add.p992c4a5b fab475f36;
    readonly p5a445d71.p18f29add.p32c73be0 fb931d0f8;
    long fbc8850e2;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 fc12e01f2;
    long fd1dbcc92;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly p5a445d71.p18f29add.p992c4a5b fd90e84f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 ffa1cd34a;
    readonly p5a445d71.p18f29add.p32c73be0 ffa5ed1ee;
    long ffd468ea6;

    p0295084c$pa273c45b(org.reactivestreams.Subscriber<T> subscriber, long j, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 pbba58d11Var, org.reactivestreams.Publisher<? : T> publisher) {
        this.fd22a0a80 = subscriber;
        this.fc12e01f2 = pbba58d11Var;
        this.f36cd38f4 = publisher;
        this.f2626772c = j;
    }

    public static void RbTvubREuswcWbRw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 pbba58d11Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        pbba58d11Var.setSubscription(p787ad0b7Var);
    }

    public static int TQcPBzzZgrmqUYbQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0295084c$pa273c45b p0295084c_pa273c45b) {
        return p0295084c_pa273c45b.getAndIncrement();
    }

    public static int ACvSGTLIHZTzlFQm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0295084c$pa273c45b p0295084c_pa273c45b, int i) {
        return p0295084c_pa273c45b.addAndGet(i);
    }

    public static void HfsvfSUgtJDFikHp(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static bool IfwBLrKraRcrKsIK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 pbba58d11Var) {
        return pbba58d11Var.isCancelled();
    }

    public static void IxEbBMpNiiUWbRJj(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void JbNlCJuweYGpzlPl(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static void MpShXmEHptptJyfh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0295084c$pa273c45b p0295084c_pa273c45b) {
        p0295084c_pa273c45b.subscribeNext();
    }

    public static void QZVvvPlKLtjUfxRm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 pbba58d11Var, long j) {
        pbba58d11Var.produced(j);
    }

    public static void SFWrPdcImKzsCHTm(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public void OnComplete() {
        if ((3 + 8) % 8 > 0) {
        }
        long j = this.f2626772c;
        if (j != long.MAX_VALUE) {
            this.f2626772c = j - 1;
        }
        if (j == 0) {
            sFWrPdcImKzsCHTm(this.fd22a0a80);
        } else {
            mpShXmEHptptJyfh(this);
        }
    }

    public void OnError(java.lang.Exception th) {
        ixEbBMpNiiUWbRJj(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        if ((17 + 18) % 18 > 0) {
        }
        this.f5051d8ee++;
        hfsvfSUgtJDFikHp(this.fd22a0a80, t);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        RbTvubREuswcWbRw(this.fc12e01f2, p787ad0b7Var);
    }

    void subscribeNext() {
        if ((20 + 22) % 22 > 0) {
        }
        if (TQcPBzzZgrmqUYbQ(this) != 0) {
            return;
        }
        int iACvSGTLIHZTzlFQm = 1;
        do {
            if (ifwBLrKraRcrKsIK(this.fc12e01f2)) {
                return;
            }
            long j = this.f5051d8ee;
            if (j != 0) {
                this.f5051d8ee = 0L;
                qZVvvPlKLtjUfxRm(this.fc12e01f2, j);
            }
            jbNlCJuweYGpzlPl(this.f36cd38f4, this);
            iACvSGTLIHZTzlFQm = aCvSGTLIHZTzlFQm(this, -iACvSGTLIHZTzlFQm);
        } while (iACvSGTLIHZTzlFQm != 0);
    }
}

