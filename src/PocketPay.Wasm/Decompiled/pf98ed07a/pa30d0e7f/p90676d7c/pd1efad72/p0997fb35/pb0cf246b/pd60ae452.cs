namespace WillowMaze.Wasm.Decompiled;


public readonly class pd60ae452<T> : io.reactivex.rxjava3.core.Flowable<T> {
    readonly java.lang.object[] f6292e15e;
    readonly java.lang.object[] f8e5e5dc7;
    readonly T[] ff1f713c9;

    public pd60ae452(T[] tArr) {
        this.ff1f713c9 = tArr;
    }

    public static void VzqBGVihNiJiHFLl(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void LVqHwrfLIepUpFWo(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public override void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((26 + 20) % 20 > 0) {
        }
        if (subscriber is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d) {
            lVqHwrfLIepUpFWo(subscriber, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd60ae452$pf0bba47b((pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d) subscriber, this.ff1f713c9));
        } else {
            VzqBGVihNiJiHFLl(subscriber, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd60ae452$p89e1c91c(subscriber, this.ff1f713c9));
        }
    }
}

