namespace WillowMaze.Wasm.Decompiled;


readonly class pf2b5fd35$pdc4cee6e<T, R> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    readonly p5a445d71.p18f29add.p992c4a5b f05b0c4a8;
    bool f06a15c3d;
    p5a445d71.p18f29add.p787ad0b7 f1791f7be;
    p5a445d71.p18f29add.p787ad0b7 f1e2d94e8;
    p5a445d71.p18f29add.p787ad0b7 f32f551e1;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.Notification<R>> f5b3c3200;
    bool f6b2ded51;
    bool f75fcc2e2;
    bool f8885470f;
    readonly p5a445d71.p18f29add.p992c4a5b f88860036;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f9c0d97bd;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fa3e8dff1;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    bool fd2075a21;
    readonly org.reactivestreams.Subscriber<R> fd22a0a80;
    readonly p5a445d71.p18f29add.p992c4a5b ff3f42c21;

    pf2b5fd35$pdc4cee6e(org.reactivestreams.Subscriber<R> subscriber, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.Notification<R>> function) {
        this.fd22a0a80 = subscriber;
        this.f5b3c3200 = function;
    }

    public static java.lang.object CWerirudpHJAOnNy(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void FYTSGxXSfKJPDhmD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf2b5fd35$pdc4cee6e pf2b5fd35_pdc4cee6e, java.lang.Exception th) {
        pf2b5fd35_pdc4cee6e.onError(th);
    }

    public static bool LndwULONdPmuYXNp(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static java.lang.Exception QYzuOWuxATiAkZQH(io.reactivex.rxjava3.core.Notification notification) {
        return notification.getError();
    }

    public static void SdDYjaOeoryXuPfI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf2b5fd35$pdc4cee6e pf2b5fd35_pdc4cee6e, java.lang.Exception th) {
        pf2b5fd35_pdc4cee6e.onError(th);
    }

    public static bool VdQEhuJVjVZuGaAP(io.reactivex.rxjava3.core.Notification notification) {
        return notification.isOnError();
    }

    public static void WBBttucsHOFAncUk(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void ABhhOoEXdeoYvglw(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void AWPdfvhnIfBjpBnN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf2b5fd35$pdc4cee6e pf2b5fd35_pdc4cee6e) {
        pf2b5fd35_pdc4cee6e.onComplete();
    }

    public static void AlhdBACNFjmxmwoi(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void BKcpYyNsrlxJcJWV(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void BUHRsOqyuypsBTUW(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void HJiGsLsZdNSuBmlZ(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static java.lang.object IhpWdBVwuWgCzBMa(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void KMXCSVOJMXLYoOKu(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static java.lang.Exception MicVylEqKGskaCLH(io.reactivex.rxjava3.core.Notification notification) {
        return notification.getError();
    }

    public static void NqDiYGpAQecgSLrx(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static bool PUTkejVYqJFaTbUS(io.reactivex.rxjava3.core.Notification notification) {
        return notification.isOnComplete();
    }

    public static java.lang.object RCXJHWeWbYeEtaNu(io.reactivex.rxjava3.core.Notification notification) {
        return notification.getValue();
    }

    public static void REWcXlXGBWBLFVHM(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void SEUsxEkUDJqaVegW(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void TwWNSCanJkvIZUCy(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void YNEhOCOBggaQuVhf(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static bool ZJtdMAMLpYWjpGyB(io.reactivex.rxjava3.core.Notification notification) {
        return notification.isOnError();
    }

    public override void Cancel() {
        aBhhOoEXdeoYvglw(this.fbc3b0556);
    }

    public void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        kMXCSVOJMXLYoOKu(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            bUHRsOqyuypsBTUW(th);
        } else {
            this.f6b2ded51 = true;
            yNEhOCOBggaQuVhf(this.fd22a0a80, th);
        }
    }

    public void OnNext(T t) {
        if (this.f6b2ded51) {
            if (t is io.reactivex.rxjava3.core.Notification) {
                io.reactivex.rxjava3.core.Notification notification = (io.reactivex.rxjava3.core.Notification) t;
                if (VdQEhuJVjVZuGaAP(notification)) {
                    rEWcXlXGBWBLFVHM(QYzuOWuxATiAkZQH(notification));
                    return;
                }
                return;
            }
            return;
        }
        try {
            io.reactivex.rxjava3.core.Notification notification2 = (io.reactivex.rxjava3.core.Notification) ihpWdBVwuWgCzBMa(CWerirudpHJAOnNy(this.f5b3c3200, t), "The selector returned a null Notification");
            if (zJtdMAMLpYWjpGyB(notification2)) {
                hJiGsLsZdNSuBmlZ(this.fbc3b0556);
                SdDYjaOeoryXuPfI(this, micVylEqKGskaCLH(notification2));
            } else if (!pUTkejVYqJFaTbUS(notification2)) {
                sEUsxEkUDJqaVegW(this.fd22a0a80, rCXJHWeWbYeEtaNu(notification2));
            } else {
                nqDiYGpAQecgSLrx(this.fbc3b0556);
                aWPdfvhnIfBjpBnN(this);
            }
        } catch (java.lang.Exception th) {
            alhdBACNFjmxmwoi(th);
            bKcpYyNsrlxJcJWV(this.fbc3b0556);
            FYTSGxXSfKJPDhmD(this, th);
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (LndwULONdPmuYXNp(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            twWNSCanJkvIZUCy(this.fd22a0a80, this);
        }
    }

    public override void Request(long j) {
        WBBttucsHOFAncUk(this.fbc3b0556, j);
    }
}

