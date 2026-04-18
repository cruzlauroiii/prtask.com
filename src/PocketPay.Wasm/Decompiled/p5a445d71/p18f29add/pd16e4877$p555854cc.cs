namespace WillowMaze.Wasm.Decompiled;


readonly class pd16e4877$p555854cc<T, U> : org.reactivestreams.Processor<T, U> {
    readonly java.util.concurrent.Flow$Processor<? super T, ? : U> fcff54971;
    readonly java.util.concurrent.Flow$Processor ff6544f5a;

    public pd16e4877$p555854cc(java.util.concurrent.Flow$Processor<? super T, ? : U> flow$Processor) {
        this.fcff54971 = flow$Processor;
    }

    public static void BosntqgtgYJBTJYH(java.util.concurrent.Flow$Processor flow$Processor, java.lang.Exception th) {
        flow$Processor.onError(th);
    }

    public static void MghHVnZkkkZcXTiw(java.util.concurrent.Flow$Processor flow$Processor, java.util.concurrent.Flow$Subscriber flow$Subscriber) {
        flow$Processor.subscribe(flow$Subscriber);
    }

    public static void QbqqJIMCHqyfKlqV(java.util.concurrent.Flow$Processor flow$Processor, java.lang.object obj) {
        flow$Processor.onNext(obj);
    }

    public static void UvbOSWtRkQNHTDKR(java.util.concurrent.Flow$Processor flow$Processor, java.util.concurrent.Flow$Subscription flow$Subscription) {
        flow$Processor.onSubscribe(flow$Subscription);
    }

    public static void PDLEtAwEJPKkErYz(java.util.concurrent.Flow$Processor flow$Processor) {
        flow$Processor.onComplete();
    }

    public void OnComplete() {
        pDLEtAwEJPKkErYz(this.fcff54971);
    }

    public void OnError(java.lang.Exception th) {
        BosntqgtgYJBTJYH(this.fcff54971, th);
    }

    public void OnNext(T t) {
        QbqqJIMCHqyfKlqV(this.fcff54971, t);
    }

    public void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        UvbOSWtRkQNHTDKR(this.fcff54971, p787ad0b7Var is not null ? new p5a445d71.p18f29add.pd16e4877$pe39d6493(p787ad0b7Var) : null);
    }

    public void Subscribe(org.reactivestreams.Subscriber<U> subscriber) {
        MghHVnZkkkZcXTiw(this.fcff54971, subscriber is not null ? new p5a445d71.p18f29add.pd16e4877$p8988a65d(subscriber) : null);
    }
}

