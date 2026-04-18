namespace WillowMaze.Wasm.Decompiled;


readonly class p29550156$p52cf00b3<T, R> : io.reactivex.rxjava3.core.SingleObserver<T> {
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : R> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f4e837f4f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f9543b9c9;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fbac54d56;
    readonly io.reactivex.rxjava3.core.SingleObserver fc5505dbb;
    readonly io.reactivex.rxjava3.core.SingleObserver fd56bb30e;
    readonly io.reactivex.rxjava3.core.SingleObserver<R> fe358efa4;
    readonly io.reactivex.rxjava3.core.SingleObserver fe607259d;
    readonly io.reactivex.rxjava3.core.SingleObserver fef88588f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 ff0c71bb4;

    p29550156$p52cf00b3(io.reactivex.rxjava3.core.SingleObserver<R> singleObserver, io.reactivex.rxjava3.functions.Function<? super T, ? : R> function) {
        this.fe358efa4 = singleObserver;
        this.f4b9f83e1 = function;
    }

    public static void IkwfIHYdRDVMTEoC(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static java.lang.object ORbPPycoYSHGEqOG(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void OlYbUxHrkTUGKeKD(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void XprWuHUpeRTgXAGC(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void ZBbFxBpHVTkMghuz(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static java.lang.object BtcCWuFQeOShNJEa(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void JnuHWtteQVuMAKJN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p29550156$p52cf00b3 p29550156_p52cf00b3, java.lang.Exception th) {
        p29550156_p52cf00b3.onError(th);
    }

    public override void OnError(java.lang.Exception th) {
        OlYbUxHrkTUGKeKD(this.fe358efa4, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        ZBbFxBpHVTkMghuz(this.fe358efa4, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        try {
            IkwfIHYdRDVMTEoC(this.fe358efa4, btcCWuFQeOShNJEa(ORbPPycoYSHGEqOG(this.f4b9f83e1, t), "The mapper function returned a null value."));
        } catch (java.lang.Exception th) {
            XprWuHUpeRTgXAGC(th);
            jnuHWtteQVuMAKJN(this, th);
        }
    }
}

