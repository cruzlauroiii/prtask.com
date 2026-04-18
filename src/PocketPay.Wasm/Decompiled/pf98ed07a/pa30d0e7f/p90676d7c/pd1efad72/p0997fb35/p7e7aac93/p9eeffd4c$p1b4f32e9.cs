namespace WillowMaze.Wasm.Decompiled;


readonly class p9eeffd4c$p1b4f32e9<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.MaybeObserver<T>, io.reactivex.rxjava3.core.CompletableObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f21cb49cb = -2177128922851101253L;
    private static readonly long f715ab4f3 = -2177128922851101253L;
    private static readonly long fb05533fe = -2177128922851101253L;
    private static readonly long fc6e1e520 = -2177128922851101253L;
    readonly io.reactivex.rxjava3.core.CompletableObserver f291eb713;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> f4b9f83e1;
    readonly io.reactivex.rxjava3.core.CompletableObserver f8e70d963;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fb669b7d4;
    readonly io.reactivex.rxjava3.core.CompletableObserver fc96c5fa5;
    readonly io.reactivex.rxjava3.core.CompletableObserver fd22a0a80;
    readonly io.reactivex.rxjava3.core.CompletableObserver fe9d293f8;

    p9eeffd4c$p1b4f32e9(io.reactivex.rxjava3.core.CompletableObserver completableObserver, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> function) {
        this.fd22a0a80 = completableObserver;
        this.f4b9f83e1 = function;
    }

    public static bool DzpEpAjjjjOyERUX(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static java.lang.object LGOZZkIlHaOIsECU(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static bool MRUXXPgMJefojXud(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static java.lang.object MayJaDPBDBXDHGfG(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void RFnrPoFDjCxJVJYo(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        completableSource.subscribe(completableObserver);
    }

    public static void VJAjWTtikYgIHNvJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p9eeffd4c$p1b4f32e9 p9eeffd4c_p1b4f32e9, java.lang.Exception th) {
        p9eeffd4c_p1b4f32e9.onError(th);
    }

    public static bool ZmhDhaOMtTCqsMyC(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void BANIouyTgYTLeBMI(io.reactivex.rxjava3.core.CompletableObserver completableObserver, java.lang.Exception th) {
        completableObserver.onError(th);
    }

    public static void SHmXnSGczOWmhqdi(io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        completableObserver.onComplete();
    }

    public static java.lang.object XxNOkRlZyVaTBpZS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p9eeffd4c$p1b4f32e9 p9eeffd4c_p1b4f32e9) {
        return p9eeffd4c_p1b4f32e9[);
    }

    public static bool YLHMaxLvZUesJcVg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p9eeffd4c$p1b4f32e9 p9eeffd4c_p1b4f32e9) {
        return p9eeffd4c_p1b4f32e9.isDisposed();
    }

    public static void YUhbXTvAMEHJeLvS(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public override void Dispose() {
        ZmhDhaOMtTCqsMyC(this);
    }

    public override bool IsDisposed() {
        return DzpEpAjjjjOyERUX((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) xxNOkRlZyVaTBpZS(this));
    }

    public override void OnComplete() {
        sHmXnSGczOWmhqdi(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        bANIouyTgYTLeBMI(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        MRUXXPgMJefojXud(this, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        try {
            io.reactivex.rxjava3.core.CompletableSource completableSource = (io.reactivex.rxjava3.core.CompletableSource) MayJaDPBDBXDHGfG(LGOZZkIlHaOIsECU(this.f4b9f83e1, t), "The mapper returned a null CompletableSource");
            if (yLHMaxLvZUesJcVg(this)) {
                return;
            }
            RFnrPoFDjCxJVJYo(completableSource, this);
        } catch (java.lang.Exception th) {
            yUhbXTvAMEHJeLvS(th);
            VJAjWTtikYgIHNvJ(this, th);
        }
    }
}

