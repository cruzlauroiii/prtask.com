namespace WillowMaze.Wasm.Decompiled;


readonly class p5e827690$p206aa94e<T, R> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    bool f29ee0961;
    bool f2fa95d24;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.Notification<R>> f5b3c3200;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f5ff52da0;
    bool f6b2ded51;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f79cd1e7e;
    readonly io.reactivex.rxjava3.core.Observer f8ce410f2;
    readonly io.reactivex.rxjava3.core.Observer f956c94e2;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fb01c1b04;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.Observer<R> fd22a0a80;
    bool ff29367a3;

    p5e827690$p206aa94e(io.reactivex.rxjava3.core.Observer<R> observer, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.Notification<R>> function) {
        this.fd22a0a80 = observer;
        this.f5b3c3200 = function;
    }

    public static java.lang.object DTEgDIuWNcVAczkn(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void GJNXTuRajmNdMbEf(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void HgmXNFQrGfKCtVRy(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static java.lang.Exception QBKgzuvohfshYhHn(io.reactivex.rxjava3.core.Notification notification) {
        return notification.getError();
    }

    public static void THonDTbwNMLZtMiI(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void WbowVOATNLdMZRiK(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void AhErUZzXkAYyhKOZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e827690$p206aa94e p5e827690_p206aa94e, java.lang.Exception th) {
        p5e827690_p206aa94e.onError(th);
    }

    public static bool COMDHPPydhiQmPTH(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void DtiZfwlgBmmazarg(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void HFkcLOqRMXJUTfOn(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void HWaeSZhKRuijZgXp(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool IxKoNTpLbZMHoJgm(io.reactivex.rxjava3.core.Notification notification) {
        return notification.isOnError();
    }

    public static java.lang.object JzSHqHlnciyjpwZP(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void KjjCdcTBbnJXmbdg(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static bool OkusrTlDwrTetMSp(io.reactivex.rxjava3.core.Notification notification) {
        return notification.isOnError();
    }

    public static void PREIWeusQLPhEwqL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e827690$p206aa94e p5e827690_p206aa94e) {
        p5e827690_p206aa94e.onComplete();
    }

    public static java.lang.object QNpYgmrcIXItQDmz(io.reactivex.rxjava3.core.Notification notification) {
        return notification.getValue();
    }

    public static void RClNpDsGofQCoLgP(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void RdEThBrhEMQkWPCE(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void SYOOtxIhWesacNyZ(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static java.lang.Exception XuldTvHdFceizYIv(io.reactivex.rxjava3.core.Notification notification) {
        return notification.getError();
    }

    public static void YDYiRmBbDHBNSjsg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e827690$p206aa94e p5e827690_p206aa94e, java.lang.Exception th) {
        p5e827690_p206aa94e.onError(th);
    }

    public static bool YRHAuPiPQvBhYQAX(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static bool ZXaGULiQzwFJOAIw(io.reactivex.rxjava3.core.Notification notification) {
        return notification.isOnComplete();
    }

    public override void Dispose() {
        rdEThBrhEMQkWPCE(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return yRHAuPiPQvBhYQAX(this.fbc3b0556);
    }

    public override void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        kjjCdcTBbnJXmbdg(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            THonDTbwNMLZtMiI(th);
        } else {
            this.f6b2ded51 = true;
            GJNXTuRajmNdMbEf(this.fd22a0a80, th);
        }
    }

    public override void OnNext(T t) {
        if (this.f6b2ded51) {
            if (t is io.reactivex.rxjava3.core.Notification) {
                io.reactivex.rxjava3.core.Notification notification = (io.reactivex.rxjava3.core.Notification) t;
                if (okusrTlDwrTetMSp(notification)) {
                    rClNpDsGofQCoLgP(xuldTvHdFceizYIv(notification));
                    return;
                }
                return;
            }
            return;
        }
        try {
            io.reactivex.rxjava3.core.Notification notification2 = (io.reactivex.rxjava3.core.Notification) DTEgDIuWNcVAczkn(jzSHqHlnciyjpwZP(this.f5b3c3200, t), "The selector returned a null Notification");
            if (ixKoNTpLbZMHoJgm(notification2)) {
                dtiZfwlgBmmazarg(this.fbc3b0556);
                ahErUZzXkAYyhKOZ(this, QBKgzuvohfshYhHn(notification2));
            } else if (!zXaGULiQzwFJOAIw(notification2)) {
                sYOOtxIhWesacNyZ(this.fd22a0a80, qNpYgmrcIXItQDmz(notification2));
            } else {
                HgmXNFQrGfKCtVRy(this.fbc3b0556);
                pREIWeusQLPhEwqL(this);
            }
        } catch (java.lang.Exception th) {
            hWaeSZhKRuijZgXp(th);
            WbowVOATNLdMZRiK(this.fbc3b0556);
            yDYiRmBbDHBNSjsg(this, th);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (cOMDHPPydhiQmPTH(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            hFkcLOqRMXJUTfOn(this.fd22a0a80, this);
        }
    }
}

