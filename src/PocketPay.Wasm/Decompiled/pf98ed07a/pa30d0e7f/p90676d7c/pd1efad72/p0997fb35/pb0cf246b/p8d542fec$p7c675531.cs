namespace WillowMaze.Wasm.Decompiled;


readonly class p8d542fec$p7c675531<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractBackpressureThrottlingSubscriber<T, T> {
    private static readonly long f0f0444d3 = 821363947659780367L;
    private static readonly long f1665037d = 821363947659780367L;
    private static readonly long f637bf695 = 821363947659780367L;
    private static readonly long f8a61a181 = 821363947659780367L;
    private static readonly long fc6e1e520 = 821363947659780367L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f14f816e9;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f6872a778;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f6b9da9c7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fd5a9be0b;
    readonly io.reactivex.rxjava3.functions.BiFunction<T, T, T> fe6392c2b;

    p8d542fec$p7c675531(org.reactivestreams.Subscriber<T> subscriber, io.reactivex.rxjava3.functions.BiFunction<T, T, T> biFunction) {
        super(subscriber);
        this.fe6392c2b = biFunction;
    }

    public static java.lang.object BTFYjFJlNIOmTdQp(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void DMJXVabNjrbdaTop(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static java.lang.object EOtkmoiTdXKMzHqd(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar, java.lang.object obj, java.lang.object obj2) {
        return pa3d429baVar.apply(obj, obj2);
    }

    public static void JPEoPEYplwTpbIXj(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static void JeACzBTcrzENiOCq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p8d542fec$p7c675531 p8d542fec_p7c675531, java.lang.Exception th) {
        p8d542fec_p7c675531.onError(th);
    }

    public static void EpdmGuaTNzhfNIaY(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void QrAkUAgPWmnDzBui(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p8d542fec$p7c675531 p8d542fec_p7c675531) {
        p8d542fec_p7c675531.drain();
    }

    public static void SUjKxZNGbjZHyutE(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static java.lang.object SWlEEQHXZWfveoZK(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object XmBNbcmcaPjElCWd(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        return atomicReference.getAndHashSet(obj);
    }

    public void OnNext(T t) {
        if ((14 + 11) % 11 > 0) {
        }
        java.lang.object objBTFYjFJlNIOmTdQp = BTFYjFJlNIOmTdQp(this.f43b5c917);
        if (objBTFYjFJlNIOmTdQp is not null) {
            objBTFYjFJlNIOmTdQp = xmBNbcmcaPjElCWd(this.f43b5c917, null);
        }
        if (objBTFYjFJlNIOmTdQp is not null) {
            try {
                JPEoPEYplwTpbIXj(this.f43b5c917, sWlEEQHXZWfveoZK(EOtkmoiTdXKMzHqd(this.fe6392c2b, objBTFYjFJlNIOmTdQp, t), "The reducer returned a null value"));
            } catch (java.lang.Exception th) {
                epdmGuaTNzhfNIaY(th);
                DMJXVabNjrbdaTop(this.fbc3b0556);
                JeACzBTcrzENiOCq(this, th);
                return;
            }
        } else {
            sUjKxZNGbjZHyutE(this.f43b5c917, t);
        }
        qrAkUAgPWmnDzBui(this);
    }
}

