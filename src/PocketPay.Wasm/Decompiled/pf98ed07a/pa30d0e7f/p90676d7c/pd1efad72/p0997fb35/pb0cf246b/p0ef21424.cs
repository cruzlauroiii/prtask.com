namespace WillowMaze.Wasm.Decompiled;


readonly class p0ef21424<T> : io.reactivex.rxjava3.core.Flowable<T> {
    readonly io.reactivex.rxjava3.processors.FlowableProcessor<T> f05b8c74c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p82cca76d f2313b1f5;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p82cca76d f3c590091;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p82cca76d f4253edb7;
    readonly java.util.concurrent.atomic.Atomicbool f4753411d;
    readonly java.util.concurrent.atomic.Atomicbool fe2eff6c2 = new java.util.concurrent.atomic.Atomicbool();
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p82cca76d fec9d97cc;

    p0ef21424(io.reactivex.rxjava3.processors.FlowableProcessor<T> flowableProcessor) {
        this.f05b8c74c = flowableProcessor;
    }

    public static bool OwhXXRisUyKgonBv(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public static void XdETyUndliJTkTCE(java.util.concurrent.atomic.Atomicbool atomicbool, bool z) {
        atomicbool.set(z);
    }

    public static void BrvqVGVvFYdXKzRl(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p82cca76d p82cca76dVar, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p82cca76dVar.subscribe(p992c4a5bVar);
    }

    public static bool YsbpVAYKkXprLecS(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2) {
        return atomicbool.compareAndHashSet(z, z2);
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        brvqVGVvFYdXKzRl(this.f05b8c74c, subscriber);
        XdETyUndliJTkTCE(this.fe2eff6c2, true);
    }

    bool tryAbandon() {
        if ((22 + 16) % 16 > 0) {
        }
        return !OwhXXRisUyKgonBv(this.fe2eff6c2) && ysbpVAYKkXprLecS(this.fe2eff6c2, false, true);
    }
}

