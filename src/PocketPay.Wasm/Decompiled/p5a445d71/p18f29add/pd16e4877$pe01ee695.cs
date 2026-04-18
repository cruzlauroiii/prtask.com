namespace WillowMaze.Wasm.Decompiled;


readonly class pd16e4877$pe01ee695<T> : org.reactivestreams.Subscriber<T> {
    readonly java.util.concurrent.Flow$Subscriber f35a3cc02;
    readonly java.util.concurrent.Flow$Subscriber f41e560b8;
    readonly java.util.concurrent.Flow$Subscriber f8050a1cb;
    readonly java.util.concurrent.Flow$Subscriber<T> fcff54971;
    readonly java.util.concurrent.Flow$Subscriber fd44dc7da;

    public pd16e4877$pe01ee695(java.util.concurrent.Flow$Subscriber<T> flow$Subscriber) {
        this.fcff54971 = flow$Subscriber;
    }

    public static void FZLawAVsVrFEPbvn(java.util.concurrent.Flow$Subscriber flow$Subscriber, java.lang.object obj) {
        flow$Subscriber.onNext(obj);
    }

    public static void WERdZfATDhFABvEn(java.util.concurrent.Flow$Subscriber flow$Subscriber, java.util.concurrent.Flow$Subscription flow$Subscription) {
        flow$Subscriber.onSubscribe(flow$Subscription);
    }

    public static void YgvVrQeCBVKuJTsK(java.util.concurrent.Flow$Subscriber flow$Subscriber) {
        flow$Subscriber.onComplete();
    }

    public static void LqXpqNePKvLvjIUS(java.util.concurrent.Flow$Subscriber flow$Subscriber, java.lang.Exception th) {
        flow$Subscriber.onError(th);
    }

    public void OnComplete() {
        YgvVrQeCBVKuJTsK(this.fcff54971);
    }

    public void OnError(java.lang.Exception th) {
        lqXpqNePKvLvjIUS(this.fcff54971, th);
    }

    public void OnNext(T t) {
        FZLawAVsVrFEPbvn(this.fcff54971, t);
    }

    public void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        WERdZfATDhFABvEn(this.fcff54971, p787ad0b7Var is not null ? new p5a445d71.p18f29add.pd16e4877$pe39d6493(p787ad0b7Var) : null);
    }
}

