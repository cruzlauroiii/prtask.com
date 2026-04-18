namespace WillowMaze.Wasm.Decompiled;


readonly class p59b2b1dc$p1dd1133b<T> : io.reactivex.rxjava3.internal.subscribers.BasicFuseableSubscriber<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f00791c33;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f16c55709;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f30b4f796;
    readonly io.reactivex.rxjava3.functions.Consumer<T> f3964f381;

    p59b2b1dc$p1dd1133b(org.reactivestreams.Subscriber<T> subscriber, io.reactivex.rxjava3.functions.Consumer<T> consumer) {
        super(subscriber);
        this.f3964f381 = consumer;
    }

    public static void FElZHDAiXyMgmIGf(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p59b2b1dc$p1dd1133b p59b2b1dc_p1dd1133b, java.lang.Exception th) {
        p59b2b1dc_p1dd1133b.fail(th);
    }

    public static void LGphTZYHcECkorNn(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 pf8afcf86Var, java.lang.object obj) throws java.lang.Exception {
        pf8afcf86Var.accept(obj);
    }

    public static int TVkitoTJZKNfEemC(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p59b2b1dc$p1dd1133b p59b2b1dc_p1dd1133b, int i) {
        return p59b2b1dc_p1dd1133b.transitiveBoundaryFusion(i);
    }

    public static void MQiuHfNVGHvZYXRc(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 pf8afcf86Var, java.lang.object obj) throws java.lang.Exception {
        pf8afcf86Var.accept(obj);
    }

    public static void NVRlSeSSuBVmnlJN(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static java.lang.object UvlQYxELNsrismVv(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var) {
        return p5d5a5670Var.poll();
    }

    public void OnNext(T t) {
        if (this.f6b2ded51) {
            return;
        }
        nVRlSeSSuBVmnlJN(this.fd22a0a80, t);
        if (this.fe910ccee != 0) {
            return;
        }
        try {
            mQiuHfNVGHvZYXRc(this.f3964f381, t);
        } catch (java.lang.Exception th) {
            FElZHDAiXyMgmIGf(this, th);
        }
    }

    public T Poll() throws java.lang.Exception {
        T t = (T) uvlQYxELNsrismVv(this.f304854e2);
        if (t is not null) {
            LGphTZYHcECkorNn(this.f3964f381, t);
        }
        return t;
    }

    public int RequestFusion(int i) {
        return TVkitoTJZKNfEemC(this, i);
    }
}

