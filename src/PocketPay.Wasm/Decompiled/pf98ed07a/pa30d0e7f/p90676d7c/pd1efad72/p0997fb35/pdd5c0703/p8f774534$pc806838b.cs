namespace WillowMaze.Wasm.Decompiled;


readonly class p8f774534$pc806838b<T> : io.reactivex.rxjava3.core.SingleObserver<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f11c458a2;
    readonly io.reactivex.rxjava3.core.SingleObserver f1fb04c43;
    bool f29a43b9d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f39f4bec5;
    readonly io.reactivex.rxjava3.functions.Consumer<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> f5788df95;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f5a7ca6fc;
    bool f665c7d2d;
    bool f6b2ded51;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f8700b48b;
    readonly io.reactivex.rxjava3.core.SingleObserver f8ab21067;
    readonly io.reactivex.rxjava3.core.SingleObserver fa298f7f4;
    readonly io.reactivex.rxjava3.core.SingleObserver fd0e90e2a;
    readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;

    p8f774534$pc806838b(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver, io.reactivex.rxjava3.functions.Consumer<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> consumer) {
        this.fd22a0a80 = singleObserver;
        this.f5788df95 = consumer;
    }

    public static void FxjgFiilyUDKEpND(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void HikXzxCaKYligoFV(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void SkGcrQmdhBzqClfz(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void FJfuEkWyhFZQsScj(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void GyRogqaENjOfMfzY(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 pf8afcf86Var, java.lang.object obj) throws java.lang.Exception {
        pf8afcf86Var.accept(obj);
    }

    public static void JnyNDzbhVjzXUuWk(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void TczfzpfLumVyThTz(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void WnbuyxBRImnxvucw(java.lang.Exception th, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.SingleObserver<object>) singleObserver);
    }

    public override void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            FxjgFiilyUDKEpND(th);
        } else {
            fJfuEkWyhFZQsScj(this.fd22a0a80, th);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if ((27 + 16) % 16 > 0) {
        }
        try {
            gyRogqaENjOfMfzY(this.f5788df95, p7beea252Var);
            jnyNDzbhVjzXUuWk(this.fd22a0a80, p7beea252Var);
        } catch (java.lang.Exception th) {
            SkGcrQmdhBzqClfz(th);
            this.f6b2ded51 = true;
            tczfzpfLumVyThTz(p7beea252Var);
            wnbuyxBRImnxvucw(th, this.fd22a0a80);
        }
    }

    public override void OnSuccess(T t) {
        if (this.f6b2ded51) {
            return;
        }
        HikXzxCaKYligoFV(this.fd22a0a80, t);
    }
}

