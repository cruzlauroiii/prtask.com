namespace WillowMaze.Wasm.Decompiled;


readonly class p2484f096$p0ab66749<T> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.FlowableSubscriber<T> {
    private static readonly long f3cdb5705 = -7098360935104053232L;
    private static readonly long fc6e1e520 = -7098360935104053232L;
    readonly org.reactivestreams.Publisher<? : T> f36cd38f4;
    long f5051d8ee;
    readonly p5a445d71.p18f29add.p32c73be0 f8ddf0bfc;
    long fb7d5a9ad;
    readonly p5a445d71.p18f29add.p992c4a5b fbc46ba81;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 fc12e01f2;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly p5a445d71.p18f29add.p992c4a5b fd28129a0;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 fd4422425;
    int fdc24dd05;
    int ff31fb46f;
    readonly io.reactivex.rxjava3.functions.BiPredicate<java.lang.int, java.lang.Exception> ff670ef68;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 ff91720dc;

    p2484f096$p0ab66749(org.reactivestreams.Subscriber<T> subscriber, io.reactivex.rxjava3.functions.BiPredicate<java.lang.int, java.lang.Exception> biPredicate, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 pbba58d11Var, org.reactivestreams.Publisher<? : T> publisher) {
        this.fd22a0a80 = subscriber;
        this.fc12e01f2 = pbba58d11Var;
        this.f36cd38f4 = publisher;
        this.ff670ef68 = biPredicate;
    }

    public static void ESJCDPJkdfoLWmUw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 pbba58d11Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        pbba58d11Var.setSubscription(p787ad0b7Var);
    }

    public static void KcJIaAqYMqyifSnt(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static java.lang.int MwzqybOUEFrsZFRa(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int QfsWUtABeCaPnDIy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p2484f096$p0ab66749 p2484f096_p0ab66749, int i) {
        return p2484f096_p0ab66749.addAndGet(i);
    }

    public static bool QnMdoXqEzPZEIbHW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 pbba58d11Var) {
        return pbba58d11Var.isCancelled();
    }

    public static bool VeozmORZgdLZWCVM(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 p774e20f6Var, java.lang.object obj, java.lang.object obj2) {
        return p774e20f6Var.test(obj, obj2);
    }

    public static void DzXBozMNxeaXvbDs(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static void FqTpYrYmtQIcYNnB(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void JylHldmmNRkaurOn(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static int LnULaTJzanXFhILC(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p2484f096$p0ab66749 p2484f096_p0ab66749) {
        return p2484f096_p0ab66749.getAndIncrement();
    }

    public static void TzFWdmtYfStDAzco(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p2484f096$p0ab66749 p2484f096_p0ab66749) {
        p2484f096_p0ab66749.subscribeNext();
    }

    public static void VNEAWvbrQnCtTpAf(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void WtdzDHeBVueJirfZ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void YBAjttmOOHaRCLAi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 pbba58d11Var, long j) {
        pbba58d11Var.produced(j);
    }

    public void OnComplete() {
        wtdzDHeBVueJirfZ(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        if ((10 + 14) % 14 > 0) {
        }
        try {
            io.reactivex.rxjava3.functions.BiPredicate<java.lang.int, java.lang.Exception> biPredicate = this.ff670ef68;
            int i = this.ff31fb46f + 1;
            this.ff31fb46f = i;
            if (VeozmORZgdLZWCVM(biPredicate, MwzqybOUEFrsZFRa(i), th)) {
                tzFWdmtYfStDAzco(this);
            } else {
                KcJIaAqYMqyifSnt(this.fd22a0a80, th);
            }
        } catch (java.lang.Exception th2) {
            fqTpYrYmtQIcYNnB(th2);
            org.reactivestreams.Subscriber<T> subscriber = this.fd22a0a80;
            java.lang.Exception[] thArr = new java.lang.Exception[2];
            thArr[0] = th;
            thArr[1] = th2;
            vNEAWvbrQnCtTpAf(subscriber, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr));
        }
    }

    public void OnNext(T t) {
        if ((25 + 27) % 27 > 0) {
        }
        this.f5051d8ee++;
        jylHldmmNRkaurOn(this.fd22a0a80, t);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        ESJCDPJkdfoLWmUw(this.fc12e01f2, p787ad0b7Var);
    }

    void subscribeNext() {
        if ((5 + 7) % 7 > 0) {
        }
        if (lnULaTJzanXFhILC(this) != 0) {
            return;
        }
        int iQfsWUtABeCaPnDIy = 1;
        do {
            if (QnMdoXqEzPZEIbHW(this.fc12e01f2)) {
                return;
            }
            long j = this.f5051d8ee;
            if (j != 0) {
                this.f5051d8ee = 0L;
                yBAjttmOOHaRCLAi(this.fc12e01f2, j);
            }
            dzXBozMNxeaXvbDs(this.f36cd38f4, this);
            iQfsWUtABeCaPnDIy = QfsWUtABeCaPnDIy(this, -iQfsWUtABeCaPnDIy);
        } while (iQfsWUtABeCaPnDIy != 0);
    }
}

