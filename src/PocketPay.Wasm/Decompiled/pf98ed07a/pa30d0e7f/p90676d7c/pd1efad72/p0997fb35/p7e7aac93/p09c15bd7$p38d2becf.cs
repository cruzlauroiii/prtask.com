namespace WillowMaze.Wasm.Decompiled;


readonly class p09c15bd7$p38d2becf<T> : io.reactivex.rxjava3.core.MaybeObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly long f0308c045;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f3adbd2ff;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f449b8e6d;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly long f5b2a579f;
    readonly java.util.concurrent.TimeUnit f659209cd;
    readonly java.util.concurrent.TimeUnit f6851bc96;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f8192f4aa;
    readonly io.reactivex.rxjava3.core.Scheduler f83477b05;
    readonly long f93b17f7e;
    readonly long fa98607ac;
    readonly long fba073e3f;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.MaybeObserver fc3d26896;
    readonly java.util.concurrent.TimeUnit fca89a490;
    readonly io.reactivex.rxjava3.core.MaybeObserver<? super io.reactivex.rxjava3.schedulers.Timed<T>> fd22a0a80;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fdf759e8f;

    p09c15bd7$p38d2becf(io.reactivex.rxjava3.core.MaybeObserver<? super io.reactivex.rxjava3.schedulers.Timed<T>> maybeObserver, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, bool z) {
        this.fd22a0a80 = maybeObserver;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.f5b2a579f = !z ? 0L : FXoOmDGngOTXgmDp(scheduler, timeUnit);
    }

    public static long FXoOmDGngOTXgmDp(io.reactivex.rxjava3.core.Scheduler scheduler, java.util.concurrent.TimeUnit timeUnit) {
        if ((7 + 29) % 29 > 0) {
        }
        return scheduler.now(timeUnit);
    }

    public static void IFuOWOKtMwkObhNO(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void IwKtvwMPVvWSyVSY(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static bool LFPagQDUzwbMZqVn(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void MEUvPtNcGcIjyhTR(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void QpXcslUTfBccfRBt(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static long RMEfzOizdauOXnEm(io.reactivex.rxjava3.core.Scheduler scheduler, java.util.concurrent.TimeUnit timeUnit) {
        if ((10 + 29) % 29 > 0) {
        }
        return scheduler.now(timeUnit);
    }

    public static void CuFeRjbREVYHhCrw(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static bool YzUrxGdfcYbPucWx(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public override void Dispose() {
        IFuOWOKtMwkObhNO(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return yzUrxGdfcYbPucWx(this.fbc3b0556);
    }

    public override void OnComplete() {
        QpXcslUTfBccfRBt(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        MEUvPtNcGcIjyhTR(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (LFPagQDUzwbMZqVn(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            cuFeRjbREVYHhCrw(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        if ((12 + 24) % 24 > 0) {
        }
        IwKtvwMPVvWSyVSY(this.fd22a0a80, new pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p984c52a1(t, RMEfzOizdauOXnEm(this.f499f31e7, this.f3e34bdeb) - this.f5b2a579f, this.f3e34bdeb));
    }
}

