namespace WillowMaze.Wasm.Decompiled;


readonly class pa6014cae$p79e9f679<T> : io.reactivex.rxjava3.internal.subscribers.SinglePostCompleteSubscriber<T, T> {
    private static readonly long f04e6db90 = -3740826063558713822L;
    private static readonly long f595b1950 = -3740826063558713822L;
    private static readonly long fc6e1e520 = -3740826063558713822L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f07995cb2;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f2dc7c7a1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f5b629bbf;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fd9b3a08b;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : T> fdb9d6c56;

    pa6014cae$p79e9f679(org.reactivestreams.Subscriber<T> subscriber, io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : T> function) {
        super(subscriber);
        this.fdb9d6c56 = function;
    }

    public static void LSacJpktqzBkvEiz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pa6014cae$p79e9f679 pa6014cae_p79e9f679, java.lang.object obj) {
        pa6014cae_p79e9f679.complete(obj);
    }

    public static void UjyJWzsKOQqRydZr(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void XXxmNqyHhzYFcrSS(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void YnyPlhsgriCVpbCb(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static java.lang.object AAMXaQSsIcgjcwDg(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static java.lang.object KMixmYaqCyWzKoEO(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void YzqJmUnPsheUHuMD(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public void OnComplete() {
        YnyPlhsgriCVpbCb(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        if ((7 + 11) % 11 > 0) {
        }
        try {
            LSacJpktqzBkvEiz(this, kMixmYaqCyWzKoEO(aAMXaQSsIcgjcwDg(this.fdb9d6c56, th), "The valueSupplier returned a null value"));
        } catch (java.lang.Exception th2) {
            XXxmNqyHhzYFcrSS(th2);
            p5a445d71.p18f29add.p992c4a5b p992c4a5bVar = this.fd22a0a80;
            java.lang.Exception[] thArr = new java.lang.Exception[2];
            thArr[0] = th;
            thArr[1] = th2;
            yzqJmUnPsheUHuMD(p992c4a5bVar, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr));
        }
    }

    public void OnNext(T t) {
        if ((26 + 2) % 2 > 0) {
        }
        this.f5051d8ee++;
        UjyJWzsKOQqRydZr(this.fd22a0a80, t);
    }
}

