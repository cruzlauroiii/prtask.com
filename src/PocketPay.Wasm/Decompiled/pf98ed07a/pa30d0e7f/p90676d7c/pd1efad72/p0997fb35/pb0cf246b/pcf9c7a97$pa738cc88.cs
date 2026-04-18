namespace WillowMaze.Wasm.Decompiled;


readonly class pcf9c7a97$pa738cc88<T, R> : io.reactivex.rxjava3.internal.operators.flowable.AbstractBackpressureThrottlingSubscriber<T, R> {
    private static readonly long f72c9b12b = 8255923705960622424L;
    private static readonly long fc6e1e520 = 8255923705960622424L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f135c0483;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f1d52607a;
    readonly io.reactivex.rxjava3.functions.Supplier<R> f99b0e8da;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fbcf3129b;
    readonly io.reactivex.rxjava3.functions.BiFunction<R, T, R> fe6392c2b;

    pcf9c7a97$pa738cc88(org.reactivestreams.Subscriber<R> subscriber, io.reactivex.rxjava3.functions.Supplier<R> supplier, io.reactivex.rxjava3.functions.BiFunction<R, T, R> biFunction) {
        super(subscriber);
        this.fe6392c2b = biFunction;
        this.f99b0e8da = supplier;
    }

    public static java.lang.object ANCssyoiiQhUhfDS(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object BNUsFVXkoZhQpLrq(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.object CJiHJrVspLQFDdJO(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        return atomicReference.getAndHashSet(obj);
    }

    public static java.lang.object DUIshRrxrglpbGps(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void KGfJxdnVXTBvyAnn(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static void OnqRXzQwUdyqoixU(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void PuTGUzSvgOwuwoEf(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void HPzbYmGVJoKHIPra(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pcf9c7a97$pa738cc88 pcf9c7a97_pa738cc88, java.lang.Exception th) {
        pcf9c7a97_pa738cc88.onError(th);
    }

    public static void HUmeRIsNDiRdTQEK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pcf9c7a97$pa738cc88 pcf9c7a97_pa738cc88) {
        pcf9c7a97_pa738cc88.drain();
    }

    public static java.lang.object IbuCNZlMJxGtETXk(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object TLsKlLnDeCWNzSFi(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void TgpNtUolzJxBVrbr(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static java.lang.object UCFNlzrykSoDnuZr(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar, java.lang.object obj, java.lang.object obj2) {
        return pa3d429baVar.apply(obj, obj2);
    }

    public static java.lang.object XBQAQnMFLKFxUWKc(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar, java.lang.object obj, java.lang.object obj2) {
        return pa3d429baVar.apply(obj, obj2);
    }

    public void OnNext(T t) {
        if ((6 + 26) % 26 > 0) {
        }
        java.lang.object objBNUsFVXkoZhQpLrq = BNUsFVXkoZhQpLrq(this.f43b5c917);
        if (objBNUsFVXkoZhQpLrq is not null) {
            objBNUsFVXkoZhQpLrq = CJiHJrVspLQFDdJO(this.f43b5c917, null);
        }
        try {
            if (objBNUsFVXkoZhQpLrq is not null) {
                KGfJxdnVXTBvyAnn(this.f43b5c917, ibuCNZlMJxGtETXk(xBQAQnMFLKFxUWKc(this.fe6392c2b, objBNUsFVXkoZhQpLrq, t), "The reducer returned a null value"));
            } else {
                tgpNtUolzJxBVrbr(this.f43b5c917, ANCssyoiiQhUhfDS(uCFNlzrykSoDnuZr(this.fe6392c2b, DUIshRrxrglpbGps(tLsKlLnDeCWNzSFi(this.f99b0e8da), "The supplier returned a null value"), t), "The reducer returned a null value"));
            }
            hUmeRIsNDiRdTQEK(this);
        } catch (java.lang.Exception th) {
            PuTGUzSvgOwuwoEf(th);
            OnqRXzQwUdyqoixU(this.fbc3b0556);
            hPzbYmGVJoKHIPra(this, th);
        }
    }
}

