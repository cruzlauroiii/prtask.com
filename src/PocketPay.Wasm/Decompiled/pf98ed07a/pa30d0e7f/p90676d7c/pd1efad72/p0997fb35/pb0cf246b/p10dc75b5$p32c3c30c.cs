namespace WillowMaze.Wasm.Decompiled;


readonly class p10dc75b5$p32c3c30c<T> : io.reactivex.rxjava3.internal.subscribers.SinglePostCompleteSubscriber<T, T> : io.reactivex.rxjava3.core.SingleObserver<T> {
    private static readonly long f36662c18 = -7346385463600070225L;
    private static readonly long faa8d151d = -7346385463600070225L;
    private static readonly long fc6e1e520 = -7346385463600070225L;
    readonly java.util.concurrent.atomic.object f0ac32d45;
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> f4329beda;
    io.reactivex.rxjava3.core.SingleSource f4fb9c739;
    io.reactivex.rxjava3.core.SingleSource<? : T> f795f3202;
    io.reactivex.rxjava3.core.SingleSource f9e94f002;
    readonly java.util.concurrent.atomic.object fbb757a8a;
    io.reactivex.rxjava3.core.SingleSource fd9817334;
    readonly java.util.concurrent.atomic.object fe1c21b5e;
    readonly java.util.concurrent.atomic.object ff3df0c2f;

    p10dc75b5$p32c3c30c(org.reactivestreams.Subscriber<T> subscriber, io.reactivex.rxjava3.core.SingleSource<? : T> singleSource) {
        super(subscriber);
        this.f795f3202 = singleSource;
        this.f4329beda = new java.util.concurrent.atomic.object<>();
    }

    public static void MnSpBvqQjRmPalgM(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void WIWcqpbgiUPXvMXr(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static bool JfJIzePLPcUDOFfa(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void MGAmvZfzTZAvswQa(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public static void PmyUTkLlIxAUbDYq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p10dc75b5$p32c3c30c p10dc75b5_p32c3c30c, java.lang.object obj) {
        p10dc75b5_p32c3c30c.complete(obj);
    }

    public static void SAIySrvxtlQYiKBA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.pe11aac42 pe11aac42Var) {
        super.cancel();
    }

    public static bool ZaNfoFySJoIKPsxt(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public void Cancel() {
        sAIySrvxtlQYiKBA(this);
        zaNfoFySJoIKPsxt(this.f4329beda);
    }

    public void OnComplete() {
        if ((26 + 23) % 23 > 0) {
        }
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
        io.reactivex.rxjava3.core.SingleSource<? : T> singleSource = this.f795f3202;
        this.f795f3202 = null;
        mGAmvZfzTZAvswQa(singleSource, this);
    }

    public override void OnError(java.lang.Exception th) {
        WIWcqpbgiUPXvMXr(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        if ((8 + 14) % 14 > 0) {
        }
        this.f5051d8ee++;
        MnSpBvqQjRmPalgM(this.fd22a0a80, t);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        jfJIzePLPcUDOFfa(this.f4329beda, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        pmyUTkLlIxAUbDYq(this, t);
    }
}

