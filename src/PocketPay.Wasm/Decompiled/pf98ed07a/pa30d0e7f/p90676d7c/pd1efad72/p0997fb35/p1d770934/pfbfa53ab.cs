namespace WillowMaze.Wasm.Decompiled;


public readonly class pfbfa53ab<T> : io.reactivex.rxjava3.core.SingleObserver<T>, io.reactivex.rxjava3.core.MaybeObserver<T>, io.reactivex.rxjava3.core.CompletableObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly io.reactivex.rxjava3.core.SingleObserver f12960c0d;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f78e6a3b0;
    readonly io.reactivex.rxjava3.core.SingleObserver f7b181447;
    readonly io.reactivex.rxjava3.core.SingleObserver f9180c872;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.SingleObserver fceaddab5;
    readonly io.reactivex.rxjava3.core.SingleObserver<? super io.reactivex.rxjava3.core.Notification<T>> fd22a0a80;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 ff9d73a12;

    public pfbfa53ab(io.reactivex.rxjava3.core.SingleObserver<? super io.reactivex.rxjava3.core.Notification<T>> singleObserver) {
        this.fd22a0a80 = singleObserver;
    }

    public static void OgMLjTDxIzIaEIqO(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static io.reactivex.rxjava3.core.Notification SpFyCirWftkCfOIj(java.lang.Exception th) {
        return io.reactivex.rxjava3.core.Notification.m0c0f93db(th);
    }

    public static io.reactivex.rxjava3.core.Notification TiBUijMTYReNNSFm(java.lang.object obj) {
        return io.reactivex.rxjava3.core.Notification.me38696b0(obj);
    }

    public static void EBoirbMxcfWFXKHO(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static io.reactivex.rxjava3.core.Notification FcBPFQPnHotpqHrr() {
        return io.reactivex.rxjava3.core.Notification.m56db821d();
    }

    public static bool ISoUWZsRtOyUsqEd(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void MKSrJcwrENzPcSSD(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static bool TDsIodJfaPXlZWgR(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void VxTcwpZWnbNUDelr(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void XNEmouMTUBWHCFYv(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public override void Dispose() {
        xNEmouMTUBWHCFYv(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return iSoUWZsRtOyUsqEd(this.fbc3b0556);
    }

    public override void OnComplete() {
        vxTcwpZWnbNUDelr(this.fd22a0a80, fcBPFQPnHotpqHrr());
    }

    public override void OnError(java.lang.Exception th) {
        eBoirbMxcfWFXKHO(this.fd22a0a80, SpFyCirWftkCfOIj(th));
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (tDsIodJfaPXlZWgR(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            OgMLjTDxIzIaEIqO(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        mKSrJcwrENzPcSSD(this.fd22a0a80, TiBUijMTYReNNSFm(t));
    }
}

