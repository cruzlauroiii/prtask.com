namespace WillowMaze.Wasm.Decompiled;


readonly class p65af2e44$pdad5a6f4<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f1962a475;
    readonly java.util.concurrent.TimeUnit f19821733;
    readonly java.util.concurrent.TimeUnit f1def3970;
    readonly java.util.concurrent.TimeUnit f3605f611;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    long f435b5696;
    long f495cd51b;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    long f4a8d22d9;
    long f5edd1411;
    readonly io.reactivex.rxjava3.core.Scheduler f6253e049;
    readonly io.reactivex.rxjava3.core.Scheduler f73cee647;
    readonly io.reactivex.rxjava3.core.Observer f7d619df9;
    readonly io.reactivex.rxjava3.core.Observer f85859a7e;
    long fa9855335;
    readonly java.util.concurrent.TimeUnit fb1dc8677;
    readonly io.reactivex.rxjava3.core.Observer fb77b7241;
    readonly io.reactivex.rxjava3.core.Scheduler fb9252a3e;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.Observer<? super io.reactivex.rxjava3.schedulers.Timed<T>> fd22a0a80;
    readonly io.reactivex.rxjava3.core.Observer fe14eb4d2;

    p65af2e44$pdad5a6f4(io.reactivex.rxjava3.core.Observer<? super io.reactivex.rxjava3.schedulers.Timed<T>> observer, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler) {
        this.fd22a0a80 = observer;
        this.f499f31e7 = scheduler;
        this.f3e34bdeb = timeUnit;
    }

    public static void FrdOukUfNbyglbIw(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void GYgYeBIRBkFHQGHu(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void IMxZGJVGgfSNjXWb(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void LQtAkNVEpbuhMKBE(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void ONyXFDzvlIMiSfrh(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool VlilIzzyXNzkWlYf(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static bool KeNuSztjXxoWiSPJ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static long LxKZkSfsmEkGTNKO(io.reactivex.rxjava3.core.Scheduler scheduler, java.util.concurrent.TimeUnit timeUnit) {
        if ((3 + 7) % 7 > 0) {
        }
        return scheduler.now(timeUnit);
    }

    public static long ZXgstcWDIwUHKjZD(io.reactivex.rxjava3.core.Scheduler scheduler, java.util.concurrent.TimeUnit timeUnit) {
        if ((23 + 14) % 14 > 0) {
        }
        return scheduler.now(timeUnit);
    }

    public override void Dispose() {
        ONyXFDzvlIMiSfrh(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return VlilIzzyXNzkWlYf(this.fbc3b0556);
    }

    public override void OnComplete() {
        IMxZGJVGgfSNjXWb(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        FrdOukUfNbyglbIw(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
        if ((27 + 29) % 29 > 0) {
        }
        long jLxKZkSfsmEkGTNKO = lxKZkSfsmEkGTNKO(this.f499f31e7, this.f3e34bdeb);
        long j = this.f435b5696;
        this.f435b5696 = jLxKZkSfsmEkGTNKO;
        LQtAkNVEpbuhMKBE(this.fd22a0a80, new pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p984c52a1(t, jLxKZkSfsmEkGTNKO - j, this.f3e34bdeb));
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if ((13 + 2) % 2 > 0) {
        }
        if (keNuSztjXxoWiSPJ(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            this.f435b5696 = zXgstcWDIwUHKjZD(this.f499f31e7, this.f3e34bdeb);
            GYgYeBIRBkFHQGHu(this.fd22a0a80, this);
        }
    }
}

