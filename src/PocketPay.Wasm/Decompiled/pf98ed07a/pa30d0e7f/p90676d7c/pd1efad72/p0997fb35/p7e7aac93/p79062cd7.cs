namespace WillowMaze.Wasm.Decompiled;


public readonly class p79062cd7<T> : io.reactivex.rxjava3.core.Flowable<T> {
    readonly io.reactivex.rxjava3.core.MaybeSource[] f1a5b30cd;
    readonly io.reactivex.rxjava3.core.MaybeSource[] f216a32af;
    readonly io.reactivex.rxjava3.core.MaybeSource[] f4a02a837;
    readonly io.reactivex.rxjava3.core.MaybeSource<? : T>[] ff2ab5fb2;

    public p79062cd7(io.reactivex.rxjava3.core.MaybeSource<? : T>[] maybeSourceArr) {
        this.ff2ab5fb2 = maybeSourceArr;
    }

    public static void IdovwDcfynkuNtXE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p79062cd7$p19f5da85 p79062cd7_p19f5da85) {
        p79062cd7_p19f5da85.drain();
    }

    public static void KOmAjAvrqHHmLaCI(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p79062cd7$p19f5da85 p79062cd7_p19f5da85 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p79062cd7$p19f5da85(subscriber, this.ff2ab5fb2);
        kOmAjAvrqHHmLaCI(subscriber, p79062cd7_p19f5da85);
        IdovwDcfynkuNtXE(p79062cd7_p19f5da85);
    }
}

