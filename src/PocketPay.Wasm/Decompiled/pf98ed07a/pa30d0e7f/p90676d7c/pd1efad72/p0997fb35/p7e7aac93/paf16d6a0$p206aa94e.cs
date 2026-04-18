namespace WillowMaze.Wasm.Decompiled;


readonly class paf16d6a0$p206aa94e<T, R> : io.reactivex.rxjava3.core.MaybeObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly io.reactivex.rxjava3.core.MaybeObserver f1742ec9b;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f1daacfb0;
    readonly io.reactivex.rxjava3.functions.Function<? super T, io.reactivex.rxjava3.core.Notification<R>> f5b3c3200;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fbba52124;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.MaybeObserver fbc4fbd6d;
    readonly io.reactivex.rxjava3.core.MaybeObserver<R> fd22a0a80;

    paf16d6a0$p206aa94e(io.reactivex.rxjava3.core.MaybeObserver<R> maybeObserver, io.reactivex.rxjava3.functions.Function<? super T, io.reactivex.rxjava3.core.Notification<R>> function) {
        this.fd22a0a80 = maybeObserver;
        this.f5b3c3200 = function;
    }

    public static void AqdqbPRvpbJHVfIj(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static void GmMXficUwGpNsQbc(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static void HaLGJiphBTqBRUOh(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static void NVQMvvVTsLYAGrsK(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static java.lang.object YASaDcMARduJiPlt(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static bool YsRCmSfpIjJgsdfd(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static java.lang.Exception BLjlQdnJgzFdrkZc(io.reactivex.rxjava3.core.Notification notification) {
        return notification.getError();
    }

    public static void CVyTJWMIPXEESBkC(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static bool GkSKsyVsZaGpWQzV(io.reactivex.rxjava3.core.Notification notification) {
        return notification.isOnNext();
    }

    public static bool HaScJajGPgQCdAtf(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static bool JSOsPGLlKhgiCsGR(io.reactivex.rxjava3.core.Notification notification) {
        return notification.isOnComplete();
    }

    public static void JYYFawdCQEyuxiQc(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void JbnonpTgWkynElrO(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object PIpGedFghruwglgs(io.reactivex.rxjava3.core.Notification notification) {
        return notification.getValue();
    }

    public static void UuyMbVpRLvrddWiL(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static java.lang.object XDgpNIgBAkgyAUNL(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void XeTPpbZdsuGPLXGC(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public override void Dispose() {
        xeTPpbZdsuGPLXGC(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return haScJajGPgQCdAtf(this.fbc3b0556);
    }

    public override void OnComplete() {
        AqdqbPRvpbJHVfIj(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        uuyMbVpRLvrddWiL(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (YsRCmSfpIjJgsdfd(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            GmMXficUwGpNsQbc(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        try {
            io.reactivex.rxjava3.core.Notification notification = (io.reactivex.rxjava3.core.Notification) YASaDcMARduJiPlt(xDgpNIgBAkgyAUNL(this.f5b3c3200, t), "The selector returned a null Notification");
            if (gkSKsyVsZaGpWQzV(notification)) {
                HaLGJiphBTqBRUOh(this.fd22a0a80, pIpGedFghruwglgs(notification));
            } else if (jSOsPGLlKhgiCsGR(notification)) {
                NVQMvvVTsLYAGrsK(this.fd22a0a80);
            } else {
                jYYFawdCQEyuxiQc(this.fd22a0a80, bLjlQdnJgzFdrkZc(notification));
            }
        } catch (java.lang.Exception th) {
            jbnonpTgWkynElrO(th);
            cVyTJWMIPXEESBkC(this.fd22a0a80, th);
        }
    }
}

