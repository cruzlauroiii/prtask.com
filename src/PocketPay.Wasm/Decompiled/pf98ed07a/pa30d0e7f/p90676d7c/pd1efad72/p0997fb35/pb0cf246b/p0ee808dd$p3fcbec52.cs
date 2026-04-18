namespace WillowMaze.Wasm.Decompiled;


readonly class p0ee808dd$p3fcbec52<T, R> : io.reactivex.rxjava3.internal.subscribers.SinglePostCompleteSubscriber<T, R> {
    private static readonly long fc6e1e520 = 2757120512858778108L;
    private static readonly long fd14ccfe5 = 2757120512858778108L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f16b6fce7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f1e1e3652;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f36821398;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f3731320f;
    readonly io.reactivex.rxjava3.functions.Supplier<? : R> f6c1d5d4f;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : R> f81778e72;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : R> fa1b38de8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fa93b3572;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fa9e324ac;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fb9175341;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fd351df10;

    p0ee808dd$p3fcbec52(org.reactivestreams.Subscriber<R> subscriber, io.reactivex.rxjava3.functions.Function<? super T, ? : R> function, io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : R> function2, io.reactivex.rxjava3.functions.Supplier<? : R> supplier) {
        super(subscriber);
        this.f81778e72 = function;
        this.fa1b38de8 = function2;
        this.f6c1d5d4f = supplier;
    }

    public static void GoQLcjBIpCbWunoi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0ee808dd$p3fcbec52 p0ee808dd_p3fcbec52, java.lang.object obj) {
        p0ee808dd_p3fcbec52.complete(obj);
    }

    public static void HZQCHaWbZIcTNPKP(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void NyVrBSddzgeOBTVd(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static java.lang.object QvfHFZYHiYwOXvof(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void UhZSlAWodXusBqlz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0ee808dd$p3fcbec52 p0ee808dd_p3fcbec52, java.lang.object obj) {
        p0ee808dd_p3fcbec52.complete(obj);
    }

    public static java.lang.object VLayzyCHbasRGujP(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object AVKGdKhcWvIZowTM(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static java.lang.object BXynaOitqvnPxJFC(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void HkCSxMuikjYULFmQ(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void IRRAbQlxbSDABIjN(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void IZxlsjaRuxWRjLkA(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void KNSPzLMkXoDepCvT(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object NQlRhWfBIjlDoAxW(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void NwphpMhHfCmRtymv(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static java.lang.object RxMeooyWYgoomQuF(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public void OnComplete() {
        if ((19 + 24) % 24 > 0) {
        }
        try {
            GoQLcjBIpCbWunoi(this, nQlRhWfBIjlDoAxW(aVKGdKhcWvIZowTM(this.f6c1d5d4f), "The onComplete publisher returned is null"));
        } catch (java.lang.Exception th) {
            kNSPzLMkXoDepCvT(th);
            NyVrBSddzgeOBTVd(this.fd22a0a80, th);
        }
    }

    public void OnError(java.lang.Exception th) {
        if ((11 + 24) % 24 > 0) {
        }
        try {
            UhZSlAWodXusBqlz(this, VLayzyCHbasRGujP(QvfHFZYHiYwOXvof(this.fa1b38de8, th), "The onError publisher returned is null"));
        } catch (java.lang.Exception th2) {
            HZQCHaWbZIcTNPKP(th2);
            p5a445d71.p18f29add.p992c4a5b p992c4a5bVar = this.fd22a0a80;
            java.lang.Exception[] thArr = new java.lang.Exception[2];
            thArr[0] = th;
            thArr[1] = th2;
            iZxlsjaRuxWRjLkA(p992c4a5bVar, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr));
        }
    }

    public void OnNext(T t) {
        if ((20 + 5) % 5 > 0) {
        }
        try {
            java.lang.object objRxMeooyWYgoomQuF = rxMeooyWYgoomQuF(bXynaOitqvnPxJFC(this.f81778e72, t), "The onNext publisher returned is null");
            this.f5051d8ee++;
            iRRAbQlxbSDABIjN(this.fd22a0a80, objRxMeooyWYgoomQuF);
        } catch (java.lang.Exception th) {
            hkCSxMuikjYULFmQ(th);
            nwphpMhHfCmRtymv(this.fd22a0a80, th);
        }
    }
}

