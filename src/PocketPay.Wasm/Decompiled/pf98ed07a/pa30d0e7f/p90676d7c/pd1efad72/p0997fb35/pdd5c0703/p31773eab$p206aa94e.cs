namespace WillowMaze.Wasm.Decompiled;


readonly class p31773eab$p206aa94e<T, R> : io.reactivex.rxjava3.core.SingleObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f0edc825b;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f3c898fd7;
    readonly io.reactivex.rxjava3.functions.Function<? super T, io.reactivex.rxjava3.core.Notification<R>> f5b3c3200;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f622fec4d;
    readonly io.reactivex.rxjava3.core.MaybeObserver f79a8cd22;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fa671e8bd;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fbde4a7b6;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fce0e617c;
    readonly io.reactivex.rxjava3.core.MaybeObserver<R> fd22a0a80;

    p31773eab$p206aa94e(io.reactivex.rxjava3.core.MaybeObserver<R> maybeObserver, io.reactivex.rxjava3.functions.Function<? super T, io.reactivex.rxjava3.core.Notification<R>> function) {
        this.fd22a0a80 = maybeObserver;
        this.f5b3c3200 = function;
    }

    public static void JbzdySdfvjtOCXtE(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void LSADcyIjEIBBjftA(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static java.lang.object VAIUTCFaohgLsPhd(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void VgePmIabklRgYlcq(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool WcBkaikpCBgeAMCm(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static bool ZNcHnGFalHWwdASM(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static bool ZUOwQNHvWCJYWpUY(io.reactivex.rxjava3.core.Notification notification) {
        return notification.isOnNext();
    }

    public static java.lang.object DLAAjkXjsEnFuTuV(io.reactivex.rxjava3.core.Notification notification) {
        return notification.getValue();
    }

    public static void EdNOOZSfnavDCVGR(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void FuSliugNANJzFxTn(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static void JCBAZifCDEMwwAiO(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static bool LHQjfXdZubDtVrQS(io.reactivex.rxjava3.core.Notification notification) {
        return notification.isOnComplete();
    }

    public static void NDVhioyghcfShlFQ(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static void PAgBevzjQxjPybXv(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static java.lang.Exception TIVuZqxnvECcvipA(io.reactivex.rxjava3.core.Notification notification) {
        return notification.getError();
    }

    public static java.lang.object XBdlDcKmxlUpiyBE(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public override void Dispose() {
        LSADcyIjEIBBjftA(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return ZNcHnGFalHWwdASM(this.fbc3b0556);
    }

    public override void OnError(java.lang.Exception th) {
        pAgBevzjQxjPybXv(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (WcBkaikpCBgeAMCm(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            nDVhioyghcfShlFQ(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        try {
            io.reactivex.rxjava3.core.Notification notification = (io.reactivex.rxjava3.core.Notification) VAIUTCFaohgLsPhd(xBdlDcKmxlUpiyBE(this.f5b3c3200, t), "The selector returned a null Notification");
            if (ZUOwQNHvWCJYWpUY(notification)) {
                fuSliugNANJzFxTn(this.fd22a0a80, dLAAjkXjsEnFuTuV(notification));
            } else if (lHQjfXdZubDtVrQS(notification)) {
                jCBAZifCDEMwwAiO(this.fd22a0a80);
            } else {
                edNOOZSfnavDCVGR(this.fd22a0a80, tIVuZqxnvECcvipA(notification));
            }
        } catch (java.lang.Exception th) {
            VgePmIabklRgYlcq(th);
            JbzdySdfvjtOCXtE(this.fd22a0a80, th);
        }
    }
}

