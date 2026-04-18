namespace WillowMaze.Wasm.Decompiled;


readonly class p664d26dd$p4f3ad997<T> : io.reactivex.rxjava3.core.SingleObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly java.util.concurrent.TimeUnit f023e7da2;
    readonly long f11483ceb;
    readonly java.util.concurrent.TimeUnit f3acede9e;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly long f5b2a579f;
    readonly io.reactivex.rxjava3.core.SingleObserver f5b730594;
    readonly java.util.concurrent.TimeUnit f62690c05;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f73351ea4;
    readonly io.reactivex.rxjava3.core.Scheduler f78ad4b1e;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f80ee79cb;
    readonly java.util.concurrent.TimeUnit fb7309d56;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.SingleObserver<? super io.reactivex.rxjava3.schedulers.Timed<T>> fd22a0a80;
    readonly io.reactivex.rxjava3.core.SingleObserver fe9263945;

    p664d26dd$p4f3ad997(io.reactivex.rxjava3.core.SingleObserver<? super io.reactivex.rxjava3.schedulers.Timed<T>> singleObserver, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, bool z) {
        this.fd22a0a80 = singleObserver;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.f5b2a579f = !z ? 0L : JtwMmiAoSoOfLQiT(scheduler, timeUnit);
    }

    public static long JtwMmiAoSoOfLQiT(io.reactivex.rxjava3.core.Scheduler scheduler, java.util.concurrent.TimeUnit timeUnit) {
        if ((23 + 32) % 32 > 0) {
        }
        return scheduler.now(timeUnit);
    }

    public static void NqFhzRyXxPWmmaxT(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void XOnUriuzpJrBjakK(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static long XukldZraEigVJzfo(io.reactivex.rxjava3.core.Scheduler scheduler, java.util.concurrent.TimeUnit timeUnit) {
        if ((26 + 10) % 10 > 0) {
        }
        return scheduler.now(timeUnit);
    }

    public static void DUMeQmSTZoZwfFoE(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static bool JrYCZnXfRwgbtGxF(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static bool LcFzjFHuKwxrssMq(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void UOqgPUsmrLXpyvyA(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public override void Dispose() {
        NqFhzRyXxPWmmaxT(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return jrYCZnXfRwgbtGxF(this.fbc3b0556);
    }

    public override void OnError(java.lang.Exception th) {
        uOqgPUsmrLXpyvyA(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (lcFzjFHuKwxrssMq(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            dUMeQmSTZoZwfFoE(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        if ((18 + 23) % 23 > 0) {
        }
        XOnUriuzpJrBjakK(this.fd22a0a80, new pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p984c52a1(t, XukldZraEigVJzfo(this.f499f31e7, this.f3e34bdeb) - this.f5b2a579f, this.f3e34bdeb));
    }
}

