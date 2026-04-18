namespace WillowMaze.Wasm.Decompiled;


public readonly class p1cbf7f6e<T> : io.reactivex.rxjava3.core.Flowable<T> {
    readonly io.reactivex.rxjava3.core.BackpressureStrategy f1144b4db;
    readonly io.reactivex.rxjava3.core.FlowableOnSubscribe f2a8620be;
    readonly io.reactivex.rxjava3.core.FlowableOnSubscribe<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.FlowableOnSubscribe f7cbb01cd;
    readonly io.reactivex.rxjava3.core.BackpressureStrategy fba34d42f;
    readonly io.reactivex.rxjava3.core.BackpressureStrategy fd3efb171;

    public p1cbf7f6e(io.reactivex.rxjava3.core.FlowableOnSubscribe<T> flowableOnSubscribe, io.reactivex.rxjava3.core.BackpressureStrategy backpressureStrategy) {
        this.f36cd38f4 = flowableOnSubscribe;
        this.fd3efb171 = backpressureStrategy;
    }

    public static void AUgkSiaFXOVxeUeS(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static int BafscuZLalMrlJge() {
        return bufferSize();
    }

    public static int HEvQvlKxkKqPbwqa(io.reactivex.rxjava3.core.BackpressureStrategy backpressureStrategy) {
        return backpressureStrategy.ordinal();
    }

    public static void RXYsOfDmjqKXiUxN(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void AJIoRHTToBDTiLjn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1cbf7f6e$pb9097803 p1cbf7f6e_pb9097803, java.lang.Exception th) {
        p1cbf7f6e_pb9097803.onError(th);
    }

    public static void CHUMpBaDfzCoJHhI(io.reactivex.rxjava3.core.FlowableOnSubscribe flowableOnSubscribe, io.reactivex.rxjava3.core.FlowableEmitter flowableEmitter) throws java.lang.Exception {
        flowableOnSubscribe.subscribe(flowableEmitter);
    }

    public override void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((23 + 5) % 5 > 0) {
        }
        int i = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1cbf7f6e$1.$SwitchDictionary$io$reactivex$rxjava3$core$BackpressureStrategy[HEvQvlKxkKqPbwqa(this.fd3efb171)];
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1cbf7f6e$pb9097803 p1cbf7f6e_p9c9ef733 = i == 1 ? new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1cbf7f6e$p9c9ef733(subscriber) : i == 2 ? new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1cbf7f6e$p42754ea9(subscriber) : i == 3 ? new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1cbf7f6e$p85866fe1(subscriber) : i == 4 ? new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1cbf7f6e$pb9b50796(subscriber) : new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1cbf7f6e$padd74e44(subscriber, BafscuZLalMrlJge());
        RXYsOfDmjqKXiUxN(subscriber, p1cbf7f6e_p9c9ef733);
        try {
            cHUMpBaDfzCoJHhI(this.f36cd38f4, p1cbf7f6e_p9c9ef733);
        } catch (java.lang.Exception th) {
            AUgkSiaFXOVxeUeS(th);
            aJIoRHTToBDTiLjn(p1cbf7f6e_p9c9ef733, th);
        }
    }
}

