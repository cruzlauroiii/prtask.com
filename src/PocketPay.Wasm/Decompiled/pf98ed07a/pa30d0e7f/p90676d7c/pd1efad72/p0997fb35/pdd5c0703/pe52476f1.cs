namespace WillowMaze.Wasm.Decompiled;


public readonly class pe52476f1<T> : io.reactivex.rxjava3.core.Flowable<T> {
    readonly io.reactivex.rxjava3.core.SingleSource<? : T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.SingleSource f3879711a;
    readonly io.reactivex.rxjava3.core.SingleSource f7d6c243d;
    readonly io.reactivex.rxjava3.core.SingleSource f803113ee;
    readonly io.reactivex.rxjava3.core.SingleSource fb20becc9;

    public pe52476f1(io.reactivex.rxjava3.core.SingleSource<? : T> singleSource) {
        this.f36cd38f4 = singleSource;
    }

    public static void KefLquZWfSTbxixH(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public override void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        kefLquZWfSTbxixH(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pe52476f1$p61103ed0(subscriber));
    }
}

