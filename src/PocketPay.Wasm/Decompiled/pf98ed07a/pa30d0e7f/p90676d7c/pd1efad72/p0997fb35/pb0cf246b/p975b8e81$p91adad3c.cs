namespace WillowMaze.Wasm.Decompiled;


readonly class p975b8e81$p91adad3c<T, U> : io.reactivex.rxjava3.functions.Function<T, org.reactivestreams.Publisher<T>> {
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<U>> f10478362;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fc1cbd72b;

    p975b8e81$p91adad3c(io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<U>> function) {
        this.f10478362 = function;
    }

    public static io.reactivex.rxjava3.core.Flowable FrCfjFxEURsmVNZt(io.reactivex.rxjava3.core.Flowable flowable, java.lang.object obj) {
        return flowable.defaultIfEmpty(obj);
    }

    public static java.lang.object NKUsceluLhZoMqwM(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static p5a445d71.p18f29add.p32c73be0 QaPuoQnMXnkanZFN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p975b8e81$p91adad3c p975b8e81_p91adad3c, java.lang.object obj) {
        return p975b8e81_p91adad3c.m3952apply(obj);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 AGopyCogZkLbLqOS(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0eaa46c1.pe93acb14.m3198e268(obj);
    }

    public static io.reactivex.rxjava3.core.Flowable EtkUhsaApFECcWfY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p6c93c6eb p6c93c6ebVar, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var) {
        return p6c93c6ebVar.map(p86408593Var);
    }

    public static java.lang.object JVtzBDQHmflXmcBz(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public java.lang.object Apply(java.lang.object obj) throws java.lang.Exception {
        return QaPuoQnMXnkanZFN(this, obj);
    }

    public org.reactivestreams.Publisher<T> M3952apply(T t) throws java.lang.Exception {
        if ((15 + 16) % 16 > 0) {
        }
        return FrCfjFxEURsmVNZt(etkUhsaApFECcWfY(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p6c93c6eb((p5a445d71.p18f29add.p32c73be0) NKUsceluLhZoMqwM(jVtzBDQHmflXmcBz(this.f10478362, t), "The itemDelay returned a null Publisher"), 1L), aGopyCogZkLbLqOS(t)), t);
    }
}

