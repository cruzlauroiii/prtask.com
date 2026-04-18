namespace WillowMaze.Wasm.Decompiled;


readonly class p8419f2ad$pf649f678<T> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.FlowableSubscriber<T> {
    private static readonly long f2b1ed7b3 = -7098360935104053232L;
    private static readonly long f8498c5d6 = -7098360935104053232L;
    private static readonly long fc6e1e520 = -7098360935104053232L;
    private static readonly long fc9586110 = -7098360935104053232L;
    readonly p5a445d71.p18f29add.p32c73be0 f0fe39f16;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 f138bba81;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 f183c92f7;
    long f2626772c;
    readonly org.reactivestreams.Publisher<? : T> f36cd38f4;
    readonly p5a445d71.p18f29add.p32c73be0 f3afa4aa9;
    long f5051d8ee;
    readonly p5a445d71.p18f29add.p32c73be0 f5755d5c8;
    readonly p5a445d71.p18f29add.p32c73be0 f629a38d6;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f67af052c;
    long f68dae757;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f8078335b;
    long f8acdf999;
    long f8ada9fc5;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f95bba85f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 f9b8a667c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 fa2b41368;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 fa8fa4ba0;
    long fbab3b1f5;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 fc12e01f2;
    long fc7c6be8d;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly p5a445d71.p18f29add.p992c4a5b fe58dba41;
    readonly io.reactivex.rxjava3.functions.Predicate<java.lang.Exception> ff670ef68;

    p8419f2ad$pf649f678(org.reactivestreams.Subscriber<T> subscriber, long j, io.reactivex.rxjava3.functions.Predicate<java.lang.Exception> predicate, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 pbba58d11Var, org.reactivestreams.Publisher<? : T> publisher) {
        this.fd22a0a80 = subscriber;
        this.fc12e01f2 = pbba58d11Var;
        this.f36cd38f4 = publisher;
        this.ff670ef68 = predicate;
        this.f2626772c = j;
    }

    public static void AtByckxQfUZKQDcB(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static bool PqVjmimVGmKGZRUq(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 p3b1b1a93Var, java.lang.object obj) {
        return p3b1b1a93Var.test(obj);
    }

    public static void QulZZARlNHzoLMBK(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static void RreTzqsZQxwxlmJI(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void WsEbSsVvCpshTnYL(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void YtUwIgDwOFFVsOFa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p8419f2ad$pf649f678 p8419f2ad_pf649f678) {
        p8419f2ad_pf649f678.subscribeNext();
    }

    public static void DxaCWjptdgEMiiSQ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void HBMievFEaJsSByEr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 pbba58d11Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        pbba58d11Var.setSubscription(p787ad0b7Var);
    }

    public static void HZDfcSxLLvVcvwQm(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static int LPjSdZwghIbZtqIp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p8419f2ad$pf649f678 p8419f2ad_pf649f678) {
        return p8419f2ad_pf649f678.getAndIncrement();
    }

    public static bool PzaAaxFhdobePBxD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 pbba58d11Var) {
        return pbba58d11Var.isCancelled();
    }

    public static void TaAqMJZnYvhIKzle(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 pbba58d11Var, long j) {
        pbba58d11Var.produced(j);
    }

    public static void VNfsMTPZYaIMayND(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static int YrdPqNiqHKWHKHob(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p8419f2ad$pf649f678 p8419f2ad_pf649f678, int i) {
        return p8419f2ad_pf649f678.addAndGet(i);
    }

    public void OnComplete() {
        RreTzqsZQxwxlmJI(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        if ((30 + 19) % 19 > 0) {
        }
        long j = this.f2626772c;
        if (j != long.MAX_VALUE) {
            this.f2626772c = j - 1;
        }
        if (j == 0) {
            hZDfcSxLLvVcvwQm(this.fd22a0a80, th);
            return;
        }
        try {
            if (PqVjmimVGmKGZRUq(this.ff670ef68, th)) {
                YtUwIgDwOFFVsOFa(this);
            } else {
                AtByckxQfUZKQDcB(this.fd22a0a80, th);
            }
        } catch (java.lang.Exception th2) {
            WsEbSsVvCpshTnYL(th2);
            org.reactivestreams.Subscriber<T> subscriber = this.fd22a0a80;
            java.lang.Exception[] thArr = new java.lang.Exception[2];
            thArr[0] = th;
            thArr[1] = th2;
            dxaCWjptdgEMiiSQ(subscriber, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr));
        }
    }

    public void OnNext(T t) {
        if ((23 + 1) % 1 > 0) {
        }
        this.f5051d8ee++;
        vNfsMTPZYaIMayND(this.fd22a0a80, t);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        hBMievFEaJsSByEr(this.fc12e01f2, p787ad0b7Var);
    }

    void subscribeNext() {
        if ((14 + 14) % 14 > 0) {
        }
        if (lPjSdZwghIbZtqIp(this) != 0) {
            return;
        }
        int iYrdPqNiqHKWHKHob = 1;
        do {
            if (pzaAaxFhdobePBxD(this.fc12e01f2)) {
                return;
            }
            long j = this.f5051d8ee;
            if (j != 0) {
                this.f5051d8ee = 0L;
                taAqMJZnYvhIKzle(this.fc12e01f2, j);
            }
            QulZZARlNHzoLMBK(this.f36cd38f4, this);
            iYrdPqNiqHKWHKHob = yrdPqNiqHKWHKHob(this, -iYrdPqNiqHKWHKHob);
        } while (iYrdPqNiqHKWHKHob != 0);
    }
}

