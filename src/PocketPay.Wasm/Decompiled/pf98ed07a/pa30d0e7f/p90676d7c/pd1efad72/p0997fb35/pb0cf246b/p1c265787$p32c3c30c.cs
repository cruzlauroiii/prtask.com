namespace WillowMaze.Wasm.Decompiled;


readonly class p1c265787$p32c3c30c<T> : io.reactivex.rxjava3.internal.subscribers.SinglePostCompleteSubscriber<T, T> : io.reactivex.rxjava3.core.MaybeObserver<T> {
    private static readonly long f4638f8f9 = -7346385463600070225L;
    private static readonly long f7a5bdd00 = -7346385463600070225L;
    private static readonly long fc6e1e520 = -7346385463600070225L;
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> f4329beda;
    readonly java.util.concurrent.atomic.object f52f46ca4;
    io.reactivex.rxjava3.core.MaybeSource f5b376f8f;
    readonly java.util.concurrent.atomic.object f63b84c4d;
    bool f696cf3d8;
    bool f74742123;
    io.reactivex.rxjava3.core.MaybeSource<? : T> f795f3202;
    bool f7a6b03e9;
    readonly java.util.concurrent.atomic.object f97ea500b;
    bool fa6617f9e;
    readonly java.util.concurrent.atomic.object fb3c9bf86;
    io.reactivex.rxjava3.core.MaybeSource fc74af0b4;

    p1c265787$p32c3c30c(org.reactivestreams.Subscriber<T> subscriber, io.reactivex.rxjava3.core.MaybeSource<? : T> maybeSource) {
        super(subscriber);
        this.f795f3202 = maybeSource;
        this.f4329beda = new java.util.concurrent.atomic.object<>();
    }

    public static void BHcDUaWUuFQDwfSY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.pe11aac42 pe11aac42Var) {
        super.cancel();
    }

    public static void GkogtYqWfyUMnBiM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1c265787$p32c3c30c p1c265787_p32c3c30c, java.lang.object obj) {
        p1c265787_p32c3c30c.complete(obj);
    }

    public static void ZbgkZmVVJDkAAyJr(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static bool DipkVQcidNAzTSBY(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void JbWLJmqgtjPtSLXI(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static void KnDSGsrZJKqQzwxY(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void QURxnLTDSqTHIvbJ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static bool YkXKaDRzeCBxBRPe(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public void Cancel() {
        BHcDUaWUuFQDwfSY(this);
        dipkVQcidNAzTSBY(this.f4329beda);
    }

    public override void OnComplete() {
        if ((8 + 15) % 15 > 0) {
        }
        if (this.f696cf3d8) {
            knDSGsrZJKqQzwxY(this.fd22a0a80);
            return;
        }
        this.f696cf3d8 = true;
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
        io.reactivex.rxjava3.core.MaybeSource<? : T> maybeSource = this.f795f3202;
        this.f795f3202 = null;
        jbWLJmqgtjPtSLXI(maybeSource, this);
    }

    public override void OnError(java.lang.Exception th) {
        ZbgkZmVVJDkAAyJr(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        if ((12 + 1) % 1 > 0) {
        }
        this.f5051d8ee++;
        qURxnLTDSqTHIvbJ(this.fd22a0a80, t);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        ykXKaDRzeCBxBRPe(this.f4329beda, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        GkogtYqWfyUMnBiM(this, t);
    }
}

